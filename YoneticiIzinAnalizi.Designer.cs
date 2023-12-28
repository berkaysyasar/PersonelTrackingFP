namespace personeltakip
{
    partial class YoneticiIzinAnalizi
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
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.unvanComboBox = new System.Windows.Forms.ComboBox();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.personelDataGridView = new System.Windows.Forms.DataGridView();
            this.adColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isebaslamaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deptComboBox
            // 
            this.deptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(13, 13);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(190, 26);
            this.deptComboBox.TabIndex = 0;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // unvanComboBox
            // 
            this.unvanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unvanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unvanComboBox.FormattingEnabled = true;
            this.unvanComboBox.Location = new System.Drawing.Point(13, 45);
            this.unvanComboBox.Name = "unvanComboBox";
            this.unvanComboBox.Size = new System.Drawing.Size(190, 26);
            this.unvanComboBox.TabIndex = 1;
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeleBtn.Location = new System.Drawing.Point(13, 78);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(190, 36);
            this.listeleBtn.TabIndex = 2;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
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
            this.tcnoColumn,
            this.isebaslamaColumn});
            this.personelDataGridView.Location = new System.Drawing.Point(209, 13);
            this.personelDataGridView.Name = "personelDataGridView";
            this.personelDataGridView.ReadOnly = true;
            this.personelDataGridView.Size = new System.Drawing.Size(799, 269);
            this.personelDataGridView.TabIndex = 3;
            this.personelDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelDataGridView_CellClick);
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
            // isebaslamaColumn
            // 
            this.isebaslamaColumn.HeaderText = "İşe Başlama Tarihi";
            this.isebaslamaColumn.Name = "isebaslamaColumn";
            this.isebaslamaColumn.ReadOnly = true;
            // 
            // kisiListBox
            // 
            this.kisiListBox.FormattingEnabled = true;
            this.kisiListBox.Location = new System.Drawing.Point(12, 19);
            this.kisiListBox.Name = "kisiListBox";
            this.kisiListBox.Size = new System.Drawing.Size(461, 212);
            this.kisiListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hizmet süresi bir yıldan beş yıla kadar (beş yıl dahil) olanlar  :  14 Gün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hizmet süresi beş yıldan fazla onbeş yıldan az olanlar  :  20 Gün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hizmet süresi onbeş yıl (dahil) ve daha fazla olanlar  :  26 Gün";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yıllık İzin Süreleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kisiListBox);
            this.groupBox2.Location = new System.Drawing.Point(526, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 242);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yapılan İzinler";
            // 
            // YoneticiIzinAnalizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.personelDataGridView);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.unvanComboBox);
            this.Controls.Add(this.deptComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YoneticiIzinAnalizi";
            this.Text = "Personel İzin Analizi";
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.ComboBox unvanComboBox;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.DataGridView personelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoColumn;
        private System.Windows.Forms.ListBox kisiListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn isebaslamaColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}