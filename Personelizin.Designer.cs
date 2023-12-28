namespace personeltakip
{
    partial class Personelizin
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
            this.izinDataGridView = new System.Windows.Forms.DataGridView();
            this.izinBaslangicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinBitisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicPicker = new System.Windows.Forms.DateTimePicker();
            this.bitisPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.izinTalepBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.izinDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izinDataGridView
            // 
            this.izinDataGridView.AllowUserToAddRows = false;
            this.izinDataGridView.AllowUserToDeleteRows = false;
            this.izinDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.izinBaslangicColumn,
            this.izinBitisColumn,
            this.izinDurum});
            this.izinDataGridView.Location = new System.Drawing.Point(6, 19);
            this.izinDataGridView.Name = "izinDataGridView";
            this.izinDataGridView.ReadOnly = true;
            this.izinDataGridView.Size = new System.Drawing.Size(720, 203);
            this.izinDataGridView.TabIndex = 0;
            // 
            // izinBaslangicColumn
            // 
            this.izinBaslangicColumn.HeaderText = "İzin Başlangıç Tarihi";
            this.izinBaslangicColumn.Name = "izinBaslangicColumn";
            this.izinBaslangicColumn.ReadOnly = true;
            // 
            // izinBitisColumn
            // 
            this.izinBitisColumn.HeaderText = "İzin Bitiş Tarihi";
            this.izinBitisColumn.Name = "izinBitisColumn";
            this.izinBitisColumn.ReadOnly = true;
            // 
            // izinDurum
            // 
            this.izinDurum.HeaderText = "Talep Durumu";
            this.izinDurum.Name = "izinDurum";
            this.izinDurum.ReadOnly = true;
            // 
            // baslangicPicker
            // 
            this.baslangicPicker.CustomFormat = "dd/MM/yyyy";
            this.baslangicPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.baslangicPicker.Location = new System.Drawing.Point(183, 20);
            this.baslangicPicker.Name = "baslangicPicker";
            this.baslangicPicker.Size = new System.Drawing.Size(200, 20);
            this.baslangicPicker.TabIndex = 1;
            // 
            // bitisPicker
            // 
            this.bitisPicker.CustomFormat = "dd/MM/yyyy";
            this.bitisPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bitisPicker.Location = new System.Drawing.Point(535, 20);
            this.bitisPicker.Name = "bitisPicker";
            this.bitisPicker.Size = new System.Drawing.Size(200, 20);
            this.bitisPicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "İzin Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "İzin Bitiş Tarihi :";
            // 
            // izinTalepBtn
            // 
            this.izinTalepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izinTalepBtn.Location = new System.Drawing.Point(240, 52);
            this.izinTalepBtn.Name = "izinTalepBtn";
            this.izinTalepBtn.Size = new System.Drawing.Size(289, 42);
            this.izinTalepBtn.TabIndex = 5;
            this.izinTalepBtn.Text = "İzin Talep Et";
            this.izinTalepBtn.UseVisualStyleBackColor = true;
            this.izinTalepBtn.Click += new System.EventHandler(this.izinTalepBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.izinDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 232);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şimdiki ve Önceki Talep İsteklerim";
            // 
            // Personelizin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.izinTalepBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitisPicker);
            this.Controls.Add(this.baslangicPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Personelizin";
            this.Text = "İzin Talep İşlemi";
            ((System.ComponentModel.ISupportInitialize)(this.izinDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView izinDataGridView;
        private System.Windows.Forms.DateTimePicker baslangicPicker;
        private System.Windows.Forms.DateTimePicker bitisPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button izinTalepBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinBaslangicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinBitisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinDurum;
    }
}