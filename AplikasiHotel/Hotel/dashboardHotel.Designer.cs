namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAryaHotel = new System.Windows.Forms.TabControl();
            this.informasiTab = new System.Windows.Forms.TabPage();
            this.pesanKmrTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.floorComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hariNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noKmrTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cekKmrTab = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabAryaHotel.SuspendLayout();
            this.pesanKmrTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hariNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cekKmrTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAryaHotel
            // 
            this.tabAryaHotel.Controls.Add(this.informasiTab);
            this.tabAryaHotel.Controls.Add(this.pesanKmrTab);
            this.tabAryaHotel.Controls.Add(this.cekKmrTab);
            this.tabAryaHotel.Controls.Add(this.tabPage1);
            this.tabAryaHotel.Controls.Add(this.tabPage2);
            this.tabAryaHotel.Controls.Add(this.tabPage3);
            this.tabAryaHotel.Controls.Add(this.tabPage4);
            this.tabAryaHotel.Location = new System.Drawing.Point(172, 136);
            this.tabAryaHotel.Name = "tabAryaHotel";
            this.tabAryaHotel.SelectedIndex = 0;
            this.tabAryaHotel.Size = new System.Drawing.Size(1026, 547);
            this.tabAryaHotel.TabIndex = 24;
            // 
            // informasiTab
            // 
            this.informasiTab.Location = new System.Drawing.Point(4, 29);
            this.informasiTab.Name = "informasiTab";
            this.informasiTab.Padding = new System.Windows.Forms.Padding(3);
            this.informasiTab.Size = new System.Drawing.Size(1018, 514);
            this.informasiTab.TabIndex = 1;
            this.informasiTab.Text = "Informasi Hotel";
            this.informasiTab.UseVisualStyleBackColor = true;
            // 
            // pesanKmrTab
            // 
            this.pesanKmrTab.Controls.Add(this.label8);
            this.pesanKmrTab.Controls.Add(this.floorComboBox);
            this.pesanKmrTab.Controls.Add(this.comboBox2);
            this.pesanKmrTab.Controls.Add(this.nextButton);
            this.pesanKmrTab.Controls.Add(this.totalTextBox);
            this.pesanKmrTab.Controls.Add(this.label7);
            this.pesanKmrTab.Controls.Add(this.label5);
            this.pesanKmrTab.Controls.Add(this.hariNumericUpDown);
            this.pesanKmrTab.Controls.Add(this.noKmrTextBox);
            this.pesanKmrTab.Controls.Add(this.label6);
            this.pesanKmrTab.Controls.Add(this.label4);
            this.pesanKmrTab.Controls.Add(this.label3);
            this.pesanKmrTab.Controls.Add(this.label2);
            this.pesanKmrTab.Controls.Add(this.label1);
            this.pesanKmrTab.Controls.Add(this.namaTextBox);
            this.pesanKmrTab.Controls.Add(this.panel1);
            this.pesanKmrTab.Controls.Add(this.panel2);
            this.pesanKmrTab.Location = new System.Drawing.Point(4, 29);
            this.pesanKmrTab.Name = "pesanKmrTab";
            this.pesanKmrTab.Padding = new System.Windows.Forms.Padding(3);
            this.pesanKmrTab.Size = new System.Drawing.Size(1018, 514);
            this.pesanKmrTab.TabIndex = 0;
            this.pesanKmrTab.Text = "Pesan Kamar";
            this.pesanKmrTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Lantai";
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.floorComboBox.Location = new System.Drawing.Point(515, 138);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.Size = new System.Drawing.Size(63, 28);
            this.floorComboBox.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.comboBox2.Location = new System.Drawing.Point(644, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 28);
            this.comboBox2.TabIndex = 38;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(723, 401);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(118, 39);
            this.nextButton.TabIndex = 37;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.Location = new System.Drawing.Point(711, 325);
            this.totalTextBox.Multiline = true;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(130, 47);
            this.totalTextBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "/hari";
            // 
            // hariNumericUpDown
            // 
            this.hariNumericUpDown.Location = new System.Drawing.Point(679, 249);
            this.hariNumericUpDown.Name = "hariNumericUpDown";
            this.hariNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.hariNumericUpDown.TabIndex = 34;
            // 
            // noKmrTextBox
            // 
            this.noKmrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noKmrTextBox.Location = new System.Drawing.Point(515, 244);
            this.noKmrTextBox.Multiline = true;
            this.noKmrTextBox.Name = "noKmrTextBox";
            this.noKmrTextBox.Size = new System.Drawing.Size(60, 31);
            this.noKmrTextBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Jenis Kamar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "No kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lama menginap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nama";
            // 
            // namaTextBox
            // 
            this.namaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namaTextBox.Location = new System.Drawing.Point(159, 141);
            this.namaTextBox.Multiline = true;
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(245, 47);
            this.namaTextBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Location = new System.Drawing.Point(112, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 411);
            this.panel1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Data Diri";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Location = new System.Drawing.Point(47, 188);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(245, 47);
            this.emailTextBox.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(461, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 411);
            this.panel2.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Reservasi";
            // 
            // cekKmrTab
            // 
            this.cekKmrTab.Controls.Add(this.listBox1);
            this.cekKmrTab.Location = new System.Drawing.Point(4, 29);
            this.cekKmrTab.Name = "cekKmrTab";
            this.cekKmrTab.Padding = new System.Windows.Forms.Padding(3);
            this.cekKmrTab.Size = new System.Drawing.Size(1018, 514);
            this.cekKmrTab.TabIndex = 2;
            this.cekKmrTab.Text = "Cek Kamar";
            this.cekKmrTab.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Kamar 101",
            "Kamar 102",
            "Kamar 103",
            "Kamar 104",
            "Kamar 105",
            "Kamar 106",
            "Kamar 107",
            "Kamar 108",
            "Kamar 109",
            "Kamar 110",
            ""});
            this.listBox1.Location = new System.Drawing.Point(321, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 224);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 514);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Pesan Makan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 514);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Pelayanan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1018, 514);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Riwayat Reservasi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1018, 514);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "CheckOut";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Welcome, Baim";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1157, 57);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(118, 39);
            this.logOutButton.TabIndex = 43;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(481, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 44);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "ARYA HOTEL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1366, 707);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabAryaHotel);
            this.Name = "Form1";
            this.Text = "Dashboard Hotel";
            this.tabAryaHotel.ResumeLayout(false);
            this.pesanKmrTab.ResumeLayout(false);
            this.pesanKmrTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hariNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cekKmrTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAryaHotel;
        private System.Windows.Forms.TabPage informasiTab;
        private System.Windows.Forms.TabPage pesanKmrTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox floorComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown hariNumericUpDown;
        private System.Windows.Forms.TextBox noKmrTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage cekKmrTab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

