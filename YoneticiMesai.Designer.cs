namespace personeltakip
{
    partial class YoneticiMesai
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
            this.unvanComboBox = new System.Windows.Forms.ComboBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.personelDataGridView = new System.Windows.Forms.DataGridView();
            this.adColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.pazartesiBasTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.saliBasTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.carsambaBasTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.persembeBasTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.cumaBasTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.cumartesiBasTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.pazarBasTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.pazarBitTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.cumartesiBitTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.cumaBitTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.persembeBitTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.carsambaBitTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.saliBitTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.pazartesiBitTimePicker = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // unvanComboBox
            // 
            this.unvanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unvanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unvanComboBox.FormattingEnabled = true;
            this.unvanComboBox.Location = new System.Drawing.Point(12, 41);
            this.unvanComboBox.Name = "unvanComboBox";
            this.unvanComboBox.Size = new System.Drawing.Size(260, 26);
            this.unvanComboBox.TabIndex = 7;
            this.unvanComboBox.SelectedIndexChanged += new System.EventHandler(this.unvanComboBox_SelectedIndexChanged);
            // 
            // deptComboBox
            // 
            this.deptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(12, 9);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(260, 26);
            this.deptComboBox.TabIndex = 6;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // personelDataGridView
            // 
            this.personelDataGridView.AllowUserToAddRows = false;
            this.personelDataGridView.AllowUserToDeleteRows = false;
            this.personelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adColumn,
            this.soyadColumn,
            this.tcnoColumn});
            this.personelDataGridView.Location = new System.Drawing.Point(282, 9);
            this.personelDataGridView.Name = "personelDataGridView";
            this.personelDataGridView.ReadOnly = true;
            this.personelDataGridView.Size = new System.Drawing.Size(507, 269);
            this.personelDataGridView.TabIndex = 9;
            this.personelDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelDataGridView_CellClick);
            this.personelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelDataGridView_CellContentClick);
            // 
            // adColumn
            // 
            this.adColumn.HeaderText = "Ad";
            this.adColumn.Name = "adColumn";
            this.adColumn.ReadOnly = true;
            // 
            // soyadColumn
            // 
            this.soyadColumn.HeaderText = "Soyad";
            this.soyadColumn.Name = "soyadColumn";
            this.soyadColumn.ReadOnly = true;
            // 
            // tcnoColumn
            // 
            this.tcnoColumn.HeaderText = "TC No";
            this.tcnoColumn.Name = "tcnoColumn";
            this.tcnoColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pazartesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Çarşamba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Perşembe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cuma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cumartesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pazar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(461, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Giriş Saati";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(611, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Çıkış Saati";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(576, 310);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1, 210);
            this.label22.TabIndex = 33;
            this.label22.Text = "label22";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydetBtn.Location = new System.Drawing.Point(441, 531);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(275, 72);
            this.kaydetBtn.TabIndex = 34;
            this.kaydetBtn.Text = "Çalışma Saatlerini Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // pazartesiBasTimePicker
            // 
            this.pazartesiBasTimePicker.Location = new System.Drawing.Point(484, 337);
            this.pazartesiBasTimePicker.Mask = "00:00";
            this.pazartesiBasTimePicker.Name = "pazartesiBasTimePicker";
            this.pazartesiBasTimePicker.Size = new System.Drawing.Size(34, 20);
            this.pazartesiBasTimePicker.TabIndex = 35;
            this.pazartesiBasTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.pazartesiBasTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // saliBasTimePicker
            // 
            this.saliBasTimePicker.Location = new System.Drawing.Point(484, 361);
            this.saliBasTimePicker.Mask = "00:00";
            this.saliBasTimePicker.Name = "saliBasTimePicker";
            this.saliBasTimePicker.Size = new System.Drawing.Size(34, 20);
            this.saliBasTimePicker.TabIndex = 36;
            this.saliBasTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.saliBasTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // carsambaBasTimePicker
            // 
            this.carsambaBasTimePicker.Location = new System.Drawing.Point(484, 387);
            this.carsambaBasTimePicker.Mask = "00:00";
            this.carsambaBasTimePicker.Name = "carsambaBasTimePicker";
            this.carsambaBasTimePicker.Size = new System.Drawing.Size(34, 20);
            this.carsambaBasTimePicker.TabIndex = 37;
            this.carsambaBasTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.carsambaBasTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // persembeBasTimePicker
            // 
            this.persembeBasTimePicker.Location = new System.Drawing.Point(484, 415);
            this.persembeBasTimePicker.Mask = "00:00";
            this.persembeBasTimePicker.Name = "persembeBasTimePicker";
            this.persembeBasTimePicker.Size = new System.Drawing.Size(34, 20);
            this.persembeBasTimePicker.TabIndex = 38;
            this.persembeBasTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.persembeBasTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // cumaBasTimePicker
            // 
            this.cumaBasTimePicker.Location = new System.Drawing.Point(484, 442);
            this.cumaBasTimePicker.Mask = "00:00";
            this.cumaBasTimePicker.Name = "cumaBasTimePicker";
            this.cumaBasTimePicker.Size = new System.Drawing.Size(34, 20);
            this.cumaBasTimePicker.TabIndex = 39;
            this.cumaBasTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cumaBasTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // cumartesiBasTimePicker
            // 
            this.cumartesiBasTimePicker.Location = new System.Drawing.Point(484, 467);
            this.cumartesiBasTimePicker.Mask = "00:00";
            this.cumartesiBasTimePicker.Name = "cumartesiBasTimePicker";
            this.cumartesiBasTimePicker.Size = new System.Drawing.Size(34, 20);
            this.cumartesiBasTimePicker.TabIndex = 40;
            this.cumartesiBasTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cumartesiBasTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // pazarBasTimePicker
            // 
            this.pazarBasTimePicker.Location = new System.Drawing.Point(484, 491);
            this.pazarBasTimePicker.Mask = "00:00";
            this.pazarBasTimePicker.Name = "pazarBasTimePicker";
            this.pazarBasTimePicker.Size = new System.Drawing.Size(34, 20);
            this.pazarBasTimePicker.TabIndex = 41;
            this.pazarBasTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.pazarBasTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // pazarBitTimePicker
            // 
            this.pazarBitTimePicker.Location = new System.Drawing.Point(632, 491);
            this.pazarBitTimePicker.Mask = "00:00";
            this.pazarBitTimePicker.Name = "pazarBitTimePicker";
            this.pazarBitTimePicker.Size = new System.Drawing.Size(34, 20);
            this.pazarBitTimePicker.TabIndex = 48;
            this.pazarBitTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.pazarBitTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // cumartesiBitTimePicker
            // 
            this.cumartesiBitTimePicker.Location = new System.Drawing.Point(632, 467);
            this.cumartesiBitTimePicker.Mask = "00:00";
            this.cumartesiBitTimePicker.Name = "cumartesiBitTimePicker";
            this.cumartesiBitTimePicker.Size = new System.Drawing.Size(34, 20);
            this.cumartesiBitTimePicker.TabIndex = 47;
            this.cumartesiBitTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cumartesiBitTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // cumaBitTimePicker
            // 
            this.cumaBitTimePicker.Location = new System.Drawing.Point(632, 442);
            this.cumaBitTimePicker.Mask = "00:00";
            this.cumaBitTimePicker.Name = "cumaBitTimePicker";
            this.cumaBitTimePicker.Size = new System.Drawing.Size(34, 20);
            this.cumaBitTimePicker.TabIndex = 46;
            this.cumaBitTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cumaBitTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // persembeBitTimePicker
            // 
            this.persembeBitTimePicker.Location = new System.Drawing.Point(632, 415);
            this.persembeBitTimePicker.Mask = "00:00";
            this.persembeBitTimePicker.Name = "persembeBitTimePicker";
            this.persembeBitTimePicker.Size = new System.Drawing.Size(34, 20);
            this.persembeBitTimePicker.TabIndex = 45;
            this.persembeBitTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.persembeBitTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // carsambaBitTimePicker
            // 
            this.carsambaBitTimePicker.Location = new System.Drawing.Point(632, 387);
            this.carsambaBitTimePicker.Mask = "00:00";
            this.carsambaBitTimePicker.Name = "carsambaBitTimePicker";
            this.carsambaBitTimePicker.Size = new System.Drawing.Size(34, 20);
            this.carsambaBitTimePicker.TabIndex = 44;
            this.carsambaBitTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.carsambaBitTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // saliBitTimePicker
            // 
            this.saliBitTimePicker.Location = new System.Drawing.Point(632, 361);
            this.saliBitTimePicker.Mask = "00:00";
            this.saliBitTimePicker.Name = "saliBitTimePicker";
            this.saliBitTimePicker.Size = new System.Drawing.Size(34, 20);
            this.saliBitTimePicker.TabIndex = 43;
            this.saliBitTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.saliBitTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // pazartesiBitTimePicker
            // 
            this.pazartesiBitTimePicker.Location = new System.Drawing.Point(632, 337);
            this.pazartesiBitTimePicker.Mask = "00:00";
            this.pazartesiBitTimePicker.Name = "pazartesiBitTimePicker";
            this.pazartesiBitTimePicker.Size = new System.Drawing.Size(34, 20);
            this.pazartesiBitTimePicker.TabIndex = 42;
            this.pazartesiBitTimePicker.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.pazartesiBitTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // YoneticiMesai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 630);
            this.Controls.Add(this.pazarBitTimePicker);
            this.Controls.Add(this.cumartesiBitTimePicker);
            this.Controls.Add(this.cumaBitTimePicker);
            this.Controls.Add(this.persembeBitTimePicker);
            this.Controls.Add(this.carsambaBitTimePicker);
            this.Controls.Add(this.saliBitTimePicker);
            this.Controls.Add(this.pazartesiBitTimePicker);
            this.Controls.Add(this.pazarBasTimePicker);
            this.Controls.Add(this.cumartesiBasTimePicker);
            this.Controls.Add(this.cumaBasTimePicker);
            this.Controls.Add(this.persembeBasTimePicker);
            this.Controls.Add(this.carsambaBasTimePicker);
            this.Controls.Add(this.saliBasTimePicker);
            this.Controls.Add(this.pazartesiBasTimePicker);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelDataGridView);
            this.Controls.Add(this.unvanComboBox);
            this.Controls.Add(this.deptComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YoneticiMesai";
            this.Text = "Çalışma Saatleri";
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox unvanComboBox;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.DataGridView personelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.MaskedTextBox pazartesiBasTimePicker;
        private System.Windows.Forms.MaskedTextBox saliBasTimePicker;
        private System.Windows.Forms.MaskedTextBox carsambaBasTimePicker;
        private System.Windows.Forms.MaskedTextBox persembeBasTimePicker;
        private System.Windows.Forms.MaskedTextBox cumaBasTimePicker;
        private System.Windows.Forms.MaskedTextBox cumartesiBasTimePicker;
        private System.Windows.Forms.MaskedTextBox pazarBasTimePicker;
        private System.Windows.Forms.MaskedTextBox pazarBitTimePicker;
        private System.Windows.Forms.MaskedTextBox cumartesiBitTimePicker;
        private System.Windows.Forms.MaskedTextBox cumaBitTimePicker;
        private System.Windows.Forms.MaskedTextBox persembeBitTimePicker;
        private System.Windows.Forms.MaskedTextBox carsambaBitTimePicker;
        private System.Windows.Forms.MaskedTextBox saliBitTimePicker;
        private System.Windows.Forms.MaskedTextBox pazartesiBitTimePicker;
    }
}