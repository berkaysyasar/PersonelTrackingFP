namespace personeltakip
{
    partial class Degerlendirme
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
            this.personelDataGridView = new System.Windows.Forms.DataGridView();
            this.tcColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanComboBox = new System.Windows.Forms.ComboBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.yeniBtn = new System.Windows.Forms.Button();
            this.oncekiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personelDataGridView
            // 
            this.personelDataGridView.AllowUserToAddRows = false;
            this.personelDataGridView.AllowUserToDeleteRows = false;
            this.personelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcColumn,
            this.adColumn,
            this.soyadColumn});
            this.personelDataGridView.Location = new System.Drawing.Point(9, 184);
            this.personelDataGridView.Name = "personelDataGridView";
            this.personelDataGridView.ReadOnly = true;
            this.personelDataGridView.Size = new System.Drawing.Size(475, 150);
            this.personelDataGridView.TabIndex = 2;
            this.personelDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelDataGridView_CellClick);
            // 
            // tcColumn
            // 
            this.tcColumn.HeaderText = "TC No";
            this.tcColumn.Name = "tcColumn";
            this.tcColumn.ReadOnly = true;
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
            // unvanComboBox
            // 
            this.unvanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unvanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unvanComboBox.FormattingEnabled = true;
            this.unvanComboBox.Location = new System.Drawing.Point(113, 70);
            this.unvanComboBox.Name = "unvanComboBox";
            this.unvanComboBox.Size = new System.Drawing.Size(260, 26);
            this.unvanComboBox.TabIndex = 9;
            // 
            // deptComboBox
            // 
            this.deptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(113, 38);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(260, 26);
            this.deptComboBox.TabIndex = 8;
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.deptComboBox_SelectedIndexChanged);
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeleBtn.Location = new System.Drawing.Point(113, 118);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(260, 36);
            this.listeleBtn.TabIndex = 10;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // yeniBtn
            // 
            this.yeniBtn.Location = new System.Drawing.Point(79, 352);
            this.yeniBtn.Name = "yeniBtn";
            this.yeniBtn.Size = new System.Drawing.Size(163, 35);
            this.yeniBtn.TabIndex = 11;
            this.yeniBtn.Text = "Yeni Değerlendirme";
            this.yeniBtn.UseVisualStyleBackColor = true;
            this.yeniBtn.Click += new System.EventHandler(this.yeniBtn_Click);
            // 
            // oncekiBtn
            // 
            this.oncekiBtn.Location = new System.Drawing.Point(248, 352);
            this.oncekiBtn.Name = "oncekiBtn";
            this.oncekiBtn.Size = new System.Drawing.Size(163, 35);
            this.oncekiBtn.TabIndex = 12;
            this.oncekiBtn.Text = "Önceki Değerlendirme";
            this.oncekiBtn.UseVisualStyleBackColor = true;
            this.oncekiBtn.Click += new System.EventHandler(this.oncekiBtn_Click);
            // 
            // Degerlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 399);
            this.Controls.Add(this.oncekiBtn);
            this.Controls.Add(this.yeniBtn);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.unvanComboBox);
            this.Controls.Add(this.deptComboBox);
            this.Controls.Add(this.personelDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Degerlendirme";
            this.Text = "Değerlendirme";
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView personelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadColumn;
        private System.Windows.Forms.ComboBox unvanComboBox;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.Button yeniBtn;
        private System.Windows.Forms.Button oncekiBtn;
    }
}