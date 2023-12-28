namespace personeltakip
{
    partial class DuzenleForm
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
            this.kisiGroupBox = new System.Windows.Forms.GroupBox();
            this.telNoTxt = new System.Windows.Forms.MaskedTextBox();
            this.kadinCbox = new System.Windows.Forms.RadioButton();
            this.erkekCbox = new System.Windows.Forms.RadioButton();
            this.resimBox = new System.Windows.Forms.PictureBox();
            this.fotosecBtn = new System.Windows.Forms.Button();
            this.unvanComboBox = new System.Windows.Forms.ComboBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.dogumPicker = new System.Windows.Forms.DateTimePicker();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.tcnoTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucretGroupBox = new System.Windows.Forms.GroupBox();
            this.maasTxt = new System.Windows.Forms.TextBox();
            this.ibanTxt = new System.Windows.Forms.TextBox();
            this.isTarihPicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.duzenleKaydetBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aracComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.kisiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimBox)).BeginInit();
            this.ucretGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kisiGroupBox
            // 
            this.kisiGroupBox.Controls.Add(this.telNoTxt);
            this.kisiGroupBox.Controls.Add(this.kadinCbox);
            this.kisiGroupBox.Controls.Add(this.erkekCbox);
            this.kisiGroupBox.Controls.Add(this.resimBox);
            this.kisiGroupBox.Controls.Add(this.fotosecBtn);
            this.kisiGroupBox.Controls.Add(this.unvanComboBox);
            this.kisiGroupBox.Controls.Add(this.deptComboBox);
            this.kisiGroupBox.Controls.Add(this.dogumPicker);
            this.kisiGroupBox.Controls.Add(this.mailTxt);
            this.kisiGroupBox.Controls.Add(this.adresTxt);
            this.kisiGroupBox.Controls.Add(this.soyadTxt);
            this.kisiGroupBox.Controls.Add(this.adTxt);
            this.kisiGroupBox.Controls.Add(this.tcnoTxt);
            this.kisiGroupBox.Controls.Add(this.label11);
            this.kisiGroupBox.Controls.Add(this.label10);
            this.kisiGroupBox.Controls.Add(this.label9);
            this.kisiGroupBox.Controls.Add(this.label8);
            this.kisiGroupBox.Controls.Add(this.label7);
            this.kisiGroupBox.Controls.Add(this.label6);
            this.kisiGroupBox.Controls.Add(this.label5);
            this.kisiGroupBox.Controls.Add(this.label4);
            this.kisiGroupBox.Controls.Add(this.label3);
            this.kisiGroupBox.Controls.Add(this.label2);
            this.kisiGroupBox.Controls.Add(this.label1);
            this.kisiGroupBox.Location = new System.Drawing.Point(174, 12);
            this.kisiGroupBox.Name = "kisiGroupBox";
            this.kisiGroupBox.Size = new System.Drawing.Size(349, 558);
            this.kisiGroupBox.TabIndex = 1;
            this.kisiGroupBox.TabStop = false;
            this.kisiGroupBox.Text = "Kişi Bilgileri";
            // 
            // telNoTxt
            // 
            this.telNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telNoTxt.Location = new System.Drawing.Point(109, 283);
            this.telNoTxt.Mask = "(999) 000-0000";
            this.telNoTxt.Name = "telNoTxt";
            this.telNoTxt.Size = new System.Drawing.Size(200, 21);
            this.telNoTxt.TabIndex = 4;
            this.telNoTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // kadinCbox
            // 
            this.kadinCbox.AutoSize = true;
            this.kadinCbox.Location = new System.Drawing.Point(215, 175);
            this.kadinCbox.Name = "kadinCbox";
            this.kadinCbox.Size = new System.Drawing.Size(52, 17);
            this.kadinCbox.TabIndex = 25;
            this.kadinCbox.Text = "Kadın";
            this.kadinCbox.UseVisualStyleBackColor = true;
            // 
            // erkekCbox
            // 
            this.erkekCbox.AutoSize = true;
            this.erkekCbox.Checked = true;
            this.erkekCbox.Location = new System.Drawing.Point(125, 175);
            this.erkekCbox.Name = "erkekCbox";
            this.erkekCbox.Size = new System.Drawing.Size(53, 17);
            this.erkekCbox.TabIndex = 24;
            this.erkekCbox.TabStop = true;
            this.erkekCbox.Text = "Erkek";
            this.erkekCbox.UseVisualStyleBackColor = true;
            // 
            // resimBox
            // 
            this.resimBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resimBox.Image = global::personeltakip.Properties.Resources.bosresim;
            this.resimBox.Location = new System.Drawing.Point(139, 423);
            this.resimBox.Name = "resimBox";
            this.resimBox.Size = new System.Drawing.Size(137, 129);
            this.resimBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimBox.TabIndex = 23;
            this.resimBox.TabStop = false;
            // 
            // fotosecBtn
            // 
            this.fotosecBtn.Location = new System.Drawing.Point(109, 394);
            this.fotosecBtn.Name = "fotosecBtn";
            this.fotosecBtn.Size = new System.Drawing.Size(200, 23);
            this.fotosecBtn.TabIndex = 22;
            this.fotosecBtn.Text = "Fotoğraf Seç";
            this.fotosecBtn.UseVisualStyleBackColor = true;
            // 
            // unvanComboBox
            // 
            this.unvanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unvanComboBox.FormattingEnabled = true;
            this.unvanComboBox.Location = new System.Drawing.Point(109, 359);
            this.unvanComboBox.Name = "unvanComboBox";
            this.unvanComboBox.Size = new System.Drawing.Size(200, 21);
            this.unvanComboBox.TabIndex = 21;
            // 
            // deptComboBox
            // 
            this.deptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(109, 323);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(200, 21);
            this.deptComboBox.TabIndex = 20;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // dogumPicker
            // 
            this.dogumPicker.CustomFormat = "dd/MM/yyyy";
            this.dogumPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumPicker.Location = new System.Drawing.Point(109, 138);
            this.dogumPicker.Name = "dogumPicker";
            this.dogumPicker.Size = new System.Drawing.Size(200, 20);
            this.dogumPicker.TabIndex = 17;
            // 
            // mailTxt
            // 
            this.mailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTxt.Location = new System.Drawing.Point(109, 247);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(200, 21);
            this.mailTxt.TabIndex = 15;
            // 
            // adresTxt
            // 
            this.adresTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresTxt.Location = new System.Drawing.Point(109, 212);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(200, 21);
            this.adresTxt.TabIndex = 14;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadTxt.Location = new System.Drawing.Point(109, 97);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(200, 21);
            this.soyadTxt.TabIndex = 13;
            // 
            // adTxt
            // 
            this.adTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adTxt.Location = new System.Drawing.Point(109, 62);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(200, 21);
            this.adTxt.TabIndex = 12;
            // 
            // tcnoTxt
            // 
            this.tcnoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcnoTxt.Location = new System.Drawing.Point(109, 27);
            this.tcnoTxt.MaxLength = 11;
            this.tcnoTxt.Name = "tcnoTxt";
            this.tcnoTxt.Size = new System.Drawing.Size(200, 21);
            this.tcnoTxt.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fotoğraf :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ünvan :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Departman :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefon No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // ucretGroupBox
            // 
            this.ucretGroupBox.Controls.Add(this.maasTxt);
            this.ucretGroupBox.Controls.Add(this.ibanTxt);
            this.ucretGroupBox.Controls.Add(this.isTarihPicker);
            this.ucretGroupBox.Controls.Add(this.label14);
            this.ucretGroupBox.Controls.Add(this.label13);
            this.ucretGroupBox.Controls.Add(this.label12);
            this.ucretGroupBox.Location = new System.Drawing.Point(529, 12);
            this.ucretGroupBox.Name = "ucretGroupBox";
            this.ucretGroupBox.Size = new System.Drawing.Size(350, 130);
            this.ucretGroupBox.TabIndex = 2;
            this.ucretGroupBox.TabStop = false;
            this.ucretGroupBox.Text = "Ücret Bilgileri";
            // 
            // maasTxt
            // 
            this.maasTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maasTxt.Location = new System.Drawing.Point(134, 86);
            this.maasTxt.Name = "maasTxt";
            this.maasTxt.Size = new System.Drawing.Size(200, 21);
            this.maasTxt.TabIndex = 5;
            // 
            // ibanTxt
            // 
            this.ibanTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibanTxt.Location = new System.Drawing.Point(134, 55);
            this.ibanTxt.MaxLength = 26;
            this.ibanTxt.Name = "ibanTxt";
            this.ibanTxt.Size = new System.Drawing.Size(200, 21);
            this.ibanTxt.TabIndex = 4;
            // 
            // isTarihPicker
            // 
            this.isTarihPicker.CustomFormat = "dd/MM/yyyy";
            this.isTarihPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.isTarihPicker.Location = new System.Drawing.Point(133, 26);
            this.isTarihPicker.Name = "isTarihPicker";
            this.isTarihPicker.Size = new System.Drawing.Size(200, 20);
            this.isTarihPicker.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(83, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Maaş :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(68, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "IBAN No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "İşe Başlama Tarihi :";
            // 
            // duzenleKaydetBtn
            // 
            this.duzenleKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duzenleKaydetBtn.Location = new System.Drawing.Point(528, 218);
            this.duzenleKaydetBtn.Name = "duzenleKaydetBtn";
            this.duzenleKaydetBtn.Size = new System.Drawing.Size(351, 102);
            this.duzenleKaydetBtn.TabIndex = 5;
            this.duzenleKaydetBtn.Text = "Düzenlemeleri Kaydet";
            this.duzenleKaydetBtn.UseVisualStyleBackColor = true;
            this.duzenleKaydetBtn.Click += new System.EventHandler(this.duzenleKaydetBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aracComboBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(529, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Araç Tahsisi";
            // 
            // aracComboBox
            // 
            this.aracComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aracComboBox.FormattingEnabled = true;
            this.aracComboBox.Location = new System.Drawing.Point(68, 24);
            this.aracComboBox.Name = "aracComboBox";
            this.aracComboBox.Size = new System.Drawing.Size(265, 23);
            this.aracComboBox.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Araçlar :";
            // 
            // DuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 581);
            this.Controls.Add(this.duzenleKaydetBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ucretGroupBox);
            this.Controls.Add(this.kisiGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DuzenleForm";
            this.Text = "Personel Bilgileri Düzenleme";
            this.kisiGroupBox.ResumeLayout(false);
            this.kisiGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimBox)).EndInit();
            this.ucretGroupBox.ResumeLayout(false);
            this.ucretGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox kisiGroupBox;
        private System.Windows.Forms.MaskedTextBox telNoTxt;
        private System.Windows.Forms.RadioButton kadinCbox;
        private System.Windows.Forms.RadioButton erkekCbox;
        private System.Windows.Forms.PictureBox resimBox;
        private System.Windows.Forms.Button fotosecBtn;
        private System.Windows.Forms.ComboBox unvanComboBox;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.DateTimePicker dogumPicker;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox tcnoTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ucretGroupBox;
        private System.Windows.Forms.TextBox maasTxt;
        private System.Windows.Forms.TextBox ibanTxt;
        private System.Windows.Forms.DateTimePicker isTarihPicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button duzenleKaydetBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox aracComboBox;
        private System.Windows.Forms.Label label15;
    }
}