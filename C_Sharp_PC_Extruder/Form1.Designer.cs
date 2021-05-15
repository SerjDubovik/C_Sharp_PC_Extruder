namespace C_Sharp_PC_Extruder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Main_menu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Property = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_transport_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.EEPROM_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_help_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_for_Displ = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.Label();
            this.A5 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.Label();
            this.A0 = new System.Windows.Forms.Label();
            this.button_set_ZPT_threshold = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_milisec = new System.Windows.Forms.Label();
            this.label_second = new System.Windows.Forms.Label();
            this.label_minut = new System.Windows.Forms.Label();
            this.label_hour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Main_menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_menu
            // 
            this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Property,
            this.ToolStripMenuItem_Help});
            this.Main_menu.Location = new System.Drawing.Point(0, 0);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(800, 24);
            this.Main_menu.TabIndex = 7;
            this.Main_menu.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(109, 22);
            this.ToolStripMenuItem_exit.Text = "Выход";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // ToolStripMenuItem_Property
            // 
            this.ToolStripMenuItem_Property.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_transport_btn,
            this.EEPROM_ToolStripMenuItem});
            this.ToolStripMenuItem_Property.Name = "ToolStripMenuItem_Property";
            this.ToolStripMenuItem_Property.Size = new System.Drawing.Size(79, 20);
            this.ToolStripMenuItem_Property.Text = "Настройки";
            // 
            // ToolStripMenuItem_transport_btn
            // 
            this.ToolStripMenuItem_transport_btn.Name = "ToolStripMenuItem_transport_btn";
            this.ToolStripMenuItem_transport_btn.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_transport_btn.Text = "Передача данных";
            this.ToolStripMenuItem_transport_btn.Click += new System.EventHandler(this.ToolStripMenuItem_transport_btn_Click);
            // 
            // EEPROM_ToolStripMenuItem
            // 
            this.EEPROM_ToolStripMenuItem.Name = "EEPROM_ToolStripMenuItem";
            this.EEPROM_ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.EEPROM_ToolStripMenuItem.Text = "EEPROM контроллера";
            this.EEPROM_ToolStripMenuItem.Click += new System.EventHandler(this.EEPROM_ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_help_btn,
            this.ToolStripMenuItem_about});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItem_Help.Text = "Помощь";
            // 
            // ToolStripMenuItem_help_btn
            // 
            this.ToolStripMenuItem_help_btn.Name = "ToolStripMenuItem_help_btn";
            this.ToolStripMenuItem_help_btn.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItem_help_btn.Text = "Справка";
            this.ToolStripMenuItem_help_btn.Click += new System.EventHandler(this.ToolStripMenuItem_help_btn_Click);
            // 
            // ToolStripMenuItem_about
            // 
            this.ToolStripMenuItem_about.Name = "ToolStripMenuItem_about";
            this.ToolStripMenuItem_about.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItem_about.Text = "О программе";
            this.ToolStripMenuItem_about.Click += new System.EventHandler(this.ToolStripMenuItem_about_Click);
            // 
            // timer_for_Displ
            // 
            this.timer_for_Displ.Enabled = true;
            this.timer_for_Displ.Interval = 300;
            this.timer_for_Displ.Tick += new System.EventHandler(this.timer_for_Displ_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel1.Text = "    ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel2.Text = "    ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel3.Text = "    ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel4.Text = "    ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel5.Text = "    ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel6.Text = "Ответ платы:   ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel7.Text = "     ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "ацп";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "ацп";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "ацп";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "ацп";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "GPIOA.6 Ibreak Скорость двигателя";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "GPIOA.5 Un";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "GPIOA.4 Uzpt";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "GPIOA.0 Isens Температура нагревателя";
            // 
            // A6
            // 
            this.A6.AutoSize = true;
            this.A6.Location = new System.Drawing.Point(249, 120);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(29, 13);
            this.A6.TabIndex = 54;
            this.A6.Text = "NuN";
            // 
            // A5
            // 
            this.A5.AutoSize = true;
            this.A5.Location = new System.Drawing.Point(249, 97);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(29, 13);
            this.A5.TabIndex = 53;
            this.A5.Text = "NuN";
            // 
            // A4
            // 
            this.A4.AutoSize = true;
            this.A4.Location = new System.Drawing.Point(249, 72);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(29, 13);
            this.A4.TabIndex = 52;
            this.A4.Text = "NuN";
            // 
            // A0
            // 
            this.A0.AutoSize = true;
            this.A0.Location = new System.Drawing.Point(249, 49);
            this.A0.Name = "A0";
            this.A0.Size = new System.Drawing.Size(29, 13);
            this.A0.TabIndex = 51;
            this.A0.Text = "NuN";
            // 
            // button_set_ZPT_threshold
            // 
            this.button_set_ZPT_threshold.Location = new System.Drawing.Point(696, 49);
            this.button_set_ZPT_threshold.Name = "button_set_ZPT_threshold";
            this.button_set_ZPT_threshold.Size = new System.Drawing.Size(55, 21);
            this.button_set_ZPT_threshold.TabIndex = 65;
            this.button_set_ZPT_threshold.Text = "Задать";
            this.button_set_ZPT_threshold.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(635, 49);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Скорость вращения подачи:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = ":";
            // 
            // label_milisec
            // 
            this.label_milisec.AutoSize = true;
            this.label_milisec.Location = new System.Drawing.Point(381, 288);
            this.label_milisec.Name = "label_milisec";
            this.label_milisec.Size = new System.Drawing.Size(29, 13);
            this.label_milisec.TabIndex = 69;
            this.label_milisec.Text = "NuN";
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Location = new System.Drawing.Point(315, 288);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(29, 13);
            this.label_second.TabIndex = 68;
            this.label_second.Text = "NuN";
            // 
            // label_minut
            // 
            this.label_minut.AutoSize = true;
            this.label_minut.Location = new System.Drawing.Point(249, 288);
            this.label_minut.Name = "label_minut";
            this.label_minut.Size = new System.Drawing.Size(29, 13);
            this.label_minut.TabIndex = 67;
            this.label_minut.Text = "NuN";
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Location = new System.Drawing.Point(167, 288);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(29, 13);
            this.label_hour.TabIndex = 66;
            this.label_hour.Text = "NuN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_milisec);
            this.Controls.Add(this.label_second);
            this.Controls.Add(this.label_minut);
            this.Controls.Add(this.label_hour);
            this.Controls.Add(this.button_set_ZPT_threshold);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A0);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Main_menu);
            this.Name = "Form1";
            this.Text = "Экструдер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Main_menu.ResumeLayout(false);
            this.Main_menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Property;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_transport_btn;
        private System.Windows.Forms.ToolStripMenuItem EEPROM_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help_btn;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_about;
        private System.Windows.Forms.Timer timer_for_Displ;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label A6;
        private System.Windows.Forms.Label A5;
        private System.Windows.Forms.Label A4;
        private System.Windows.Forms.Label A0;
        private System.Windows.Forms.Button button_set_ZPT_threshold;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_milisec;
        private System.Windows.Forms.Label label_second;
        private System.Windows.Forms.Label label_minut;
        private System.Windows.Forms.Label label_hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

