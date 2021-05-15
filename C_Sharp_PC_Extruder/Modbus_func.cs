using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Modbus.Device;


namespace C_Sharp_PC_Extruder
{
	public partial class Form1
    {		
		
		
		public void connect_modbus()
		{									
					
			serialPort.PortName 	= post_buf;									// СОМ порт для каждого канала
			serialPort.BaudRate 	= Convert.ToInt32(speed_net_buf);			// скорость передачи по выбранному каналу модбас
			serialPort.DataBits 	= Convert.ToInt32(quantity_bit_buf);		// кол-во бит в посылке

			
			switch (parity_net_buf)												// проверка на чётность
			{
				case "Even": serialPort.Parity 		= 	Parity.Even;	break;
				case "Mark": serialPort.Parity 		= 	Parity.Mark;	break;
				case "None": serialPort.Parity 		= 	Parity.None;	break;
				case "Odd": serialPort.Parity 		= 	Parity.Odd;		break;
				case "Space": serialPort.Parity 	= 	Parity.Space;	break;			
			}
			
			
			
			switch (stop_bit_net_buf)											// кол-во стоп бит
			{
				case "None":  serialPort.StopBits				=	StopBits.None;	break;
				case "One":  serialPort.StopBits				=	StopBits.One;	break;
				case "OnePointFive":  serialPort.StopBits		=	StopBits.OnePointFive;	break;
				case "Two":  serialPort.StopBits				=	StopBits.Two;	break;								
										
			}

            try
            {
                serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.Retries = 0;       // don't have to do retries
                master.Transport.ReadTimeout = 50; // milliseconds

                toolStripStatusLabel2.Text = DateTime.Now.ToString() + " " + serialPort.PortName + " Открыт ";              // выводим сообщение в строку состояния
                
        

            }

            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                toolStripStatusLabel2.Text = DateTime.Now.ToString() + " " + serialPort.PortName + " Не удалось открыть ";  // выводим сообщение в строку состояния
            }


            try
            {
            	Thread_Modbus.Start(modBus_var);                                 // запуск процесса обработки ком порта
                toolStripStatusLabel4.Text = " Поток запущен ";                  // выводим сообщение в строку состояния

            }
            catch (Exception)
            {
                toolStripStatusLabel4.Text = " Поток не запущен ";               // выводим сообщение в строку состояния
            }
            
		}
		
		
		
		
		
		
		public static void Modbus_func(object obj)                                     // метод потока. для работы с ком портом
		{

			ModBus_var modBus_var = (ModBus_var)obj;
			
			bool enable_loop = true;
						

			
            while (enable_loop)														// не забываем за бесконечный цикл в потоках =)
            {    

            	if(enable_loop == false)
            	{
            		break;
            	}
            	
    	        try
                {
					
                    ushort[] register;

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 0, 2);           //  телеметрия состояния контроллера
					modBus_var.mb_mass[0] = register[0];

					// 15	-	1 если включился и ждёт команды от пользователя.
					// 14	-	
					// 13	-	
					// 12	-	
					// 11	-	
					// 10	-	
					// 9	-	
					// 8	-	

					// 7	-	
					// 6	-	
					// 5	-	
					// 4	-	
					// 3	-	
					// 2	-	
					// 1	-	
					// 0	-	


					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 8, 2);           // счётчик для проверки связи
                    modBus_var.mb_mass[8] = register[0];




					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 13, 2);          // GPIOA.0		Isens значение АЦП без пересчёта
					modBus_var.mb_mass[13] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 14, 2);          // GPIOA.4		Uzpt значение АЦП без пересчёта
					modBus_var.mb_mass[14] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 15, 2);          // GPIOA.5		Un значение АЦП без пересчёта
					modBus_var.mb_mass[15] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 16, 2);          // GPIOA.6		Ibreak значение АЦП без пересчёта
					modBus_var.mb_mass[16] = register[0];



					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 20, 2);          // 
					modBus_var.mb_mass[20] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 21, 2);          // 
					modBus_var.mb_mass[21] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 22, 2);          // 
					modBus_var.mb_mass[22] = register[0];

					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 23, 2);          // 
					modBus_var.mb_mass[23] = register[0];


					/*
					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 21, 2);          // Нижнее пороговое значение напряжения ЗПТ. Порог срабатывания реле ЗПТ. Телеметрия, мастер не меняет это значение
					modBus_var.mb_mass[21] = register[0];

					master.WriteSingleRegister(modBus_var.adrr_dev_in, 22, modBus_var.mb_mass[22]); // Нижнее пороговое значение напряжения ЗПТ. Порог срабатывания реле ЗПТ. Задание мастером, слейв не менят это значение
					*/



					master.WriteSingleRegister(modBus_var.adrr_dev_in, 1, modBus_var.mb_mass[1]);   //  запись управляющего слова
					master.WriteSingleRegister(modBus_var.adrr_dev_in, 2, modBus_var.mb_mass[2]);


					register = master.ReadHoldingRegisters(modBus_var.adrr_dev_in, 3, 2);           // слейв пишет в этот адрес код команды слейву
					modBus_var.mb_mass[3] = register[0];

					if (modBus_var.mb_mass[3] == 1)
					{
						modBus_var.mb_mass[2] = 0;
					}

				}

				catch 
				{

				}
            	               	
            }
			
        }
		
	}
	
}