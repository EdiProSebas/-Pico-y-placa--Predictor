
namespace license_plate_number_Pico_y_Placa_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AMcheck = new System.Windows.Forms.CheckBox();
            this.PMcheck = new System.Windows.Forms.CheckBox();
            this.cmbxH_AM = new System.Windows.Forms.ComboBox();
            this.cmbxH_PM = new System.Windows.Forms.ComboBox();
            this.cmbxM_AM = new System.Windows.Forms.ComboBox();
            this.cmbxM_PM = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.lblday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "License Plate Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox1.Location = new System.Drawing.Point(205, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AMcheck
            // 
            this.AMcheck.AutoSize = true;
            this.AMcheck.Location = new System.Drawing.Point(91, 67);
            this.AMcheck.Name = "AMcheck";
            this.AMcheck.Size = new System.Drawing.Size(42, 17);
            this.AMcheck.TabIndex = 4;
            this.AMcheck.Text = "AM";
            this.AMcheck.UseVisualStyleBackColor = true;
            this.AMcheck.CheckedChanged += new System.EventHandler(this.AMcheck_CheckedChanged);
            // 
            // PMcheck
            // 
            this.PMcheck.AutoSize = true;
            this.PMcheck.Location = new System.Drawing.Point(91, 90);
            this.PMcheck.Name = "PMcheck";
            this.PMcheck.Size = new System.Drawing.Size(42, 17);
            this.PMcheck.TabIndex = 5;
            this.PMcheck.Text = "PM";
            this.PMcheck.UseVisualStyleBackColor = true;
            this.PMcheck.CheckedChanged += new System.EventHandler(this.PMcheck_CheckedChanged);
            // 
            // cmbxH_AM
            // 
            this.cmbxH_AM.FormattingEnabled = true;
            this.cmbxH_AM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "07",
            "08",
            "09",
            "10",
            "11"});
            this.cmbxH_AM.Location = new System.Drawing.Point(170, 67);
            this.cmbxH_AM.Name = "cmbxH_AM";
            this.cmbxH_AM.Size = new System.Drawing.Size(45, 21);
            this.cmbxH_AM.TabIndex = 6;
            // 
            // cmbxH_PM
            // 
            this.cmbxH_PM.FormattingEnabled = true;
            this.cmbxH_PM.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbxH_PM.Location = new System.Drawing.Point(170, 94);
            this.cmbxH_PM.Name = "cmbxH_PM";
            this.cmbxH_PM.Size = new System.Drawing.Size(45, 21);
            this.cmbxH_PM.TabIndex = 7;
            // 
            // cmbxM_AM
            // 
            this.cmbxM_AM.FormattingEnabled = true;
            this.cmbxM_AM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbxM_AM.Location = new System.Drawing.Point(227, 67);
            this.cmbxM_AM.Name = "cmbxM_AM";
            this.cmbxM_AM.Size = new System.Drawing.Size(45, 21);
            this.cmbxM_AM.TabIndex = 8;
            // 
            // cmbxM_PM
            // 
            this.cmbxM_PM.FormattingEnabled = true;
            this.cmbxM_PM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbxM_PM.Location = new System.Drawing.Point(227, 94);
            this.cmbxM_PM.Name = "cmbxM_PM";
            this.cmbxM_PM.Size = new System.Drawing.Size(45, 21);
            this.cmbxM_PM.TabIndex = 9;
            this.cmbxM_PM.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("DejaVu Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFecha.Location = new System.Drawing.Point(150, 7);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(98, 31);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "label2";
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("DejaVu Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblHora.Location = new System.Drawing.Point(150, 53);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(98, 31);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "hh(hours)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "mm(minutes)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current Date and Time: ";
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.Peru;
            this.Calendar.Location = new System.Drawing.Point(15, 174);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 15;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(152, 23);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(0, 13);
            this.lblday.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Day Selected :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(15, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 99);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbxM_PM);
            this.panel2.Controls.Add(this.cmbxM_AM);
            this.panel2.Controls.Add(this.cmbxH_PM);
            this.panel2.Controls.Add(this.cmbxH_AM);
            this.panel2.Controls.Add(this.PMcheck);
            this.panel2.Controls.Add(this.AMcheck);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(219, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 190);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblday);
            this.panel3.Location = new System.Drawing.Point(271, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 60);
            this.panel3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Insert Required Data";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(22, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Choose a Date From the Calendar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "PICO Y PLACA PREDICTOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 457);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Calendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox AMcheck;
        private System.Windows.Forms.CheckBox PMcheck;
        private System.Windows.Forms.ComboBox cmbxH_AM;
        private System.Windows.Forms.ComboBox cmbxH_PM;
        private System.Windows.Forms.ComboBox cmbxM_AM;
        private System.Windows.Forms.ComboBox cmbxM_PM;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer FechaHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

