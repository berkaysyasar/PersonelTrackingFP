namespace personeltakip
{
    partial class YeniDegerlendirme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.meslekDataGridView = new System.Windows.Forms.DataGridView();
            this.meslekiyeterlilikColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degerlendirmeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.davranisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bireyselDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoLbl = new System.Windows.Forms.Label();
            this.adsoyadLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kaydetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meslekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.davranisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bireyselDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // meslekDataGridView
            // 
            this.meslekDataGridView.AllowUserToAddRows = false;
            this.meslekDataGridView.AllowUserToDeleteRows = false;
            this.meslekDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.meslekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meslekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meslekiyeterlilikColumn,
            this.degerlendirmeColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.meslekDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.meslekDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.meslekDataGridView.Location = new System.Drawing.Point(13, 59);
            this.meslekDataGridView.MultiSelect = false;
            this.meslekDataGridView.Name = "meslekDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.meslekDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.meslekDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meslekDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.meslekDataGridView.Size = new System.Drawing.Size(868, 133);
            this.meslekDataGridView.TabIndex = 0;
            this.meslekDataGridView.SelectionChanged += new System.EventHandler(this.meslekDataGridView_SelectionChanged);
            // 
            // meslekiyeterlilikColumn
            // 
            this.meslekiyeterlilikColumn.FillWeight = 187.8788F;
            this.meslekiyeterlilikColumn.HeaderText = "Mesleki Yeterlilik";
            this.meslekiyeterlilikColumn.Name = "meslekiyeterlilikColumn";
            this.meslekiyeterlilikColumn.ReadOnly = true;
            // 
            // degerlendirmeColumn
            // 
            this.degerlendirmeColumn.FillWeight = 12.12121F;
            this.degerlendirmeColumn.HeaderText = "Not";
            this.degerlendirmeColumn.Name = "degerlendirmeColumn";
            // 
            // davranisDataGridView
            // 
            this.davranisDataGridView.AllowUserToAddRows = false;
            this.davranisDataGridView.AllowUserToDeleteRows = false;
            this.davranisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.davranisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.davranisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.davranisDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.davranisDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.davranisDataGridView.Location = new System.Drawing.Point(13, 210);
            this.davranisDataGridView.MultiSelect = false;
            this.davranisDataGridView.Name = "davranisDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.davranisDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.davranisDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.davranisDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.davranisDataGridView.Size = new System.Drawing.Size(868, 154);
            this.davranisDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 187.8788F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Davranışsal Yeterlilik";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 12.12121F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Not";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bireyselDataGridView
            // 
            this.bireyselDataGridView.AllowUserToAddRows = false;
            this.bireyselDataGridView.AllowUserToDeleteRows = false;
            this.bireyselDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bireyselDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bireyselDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bireyselDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.bireyselDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.bireyselDataGridView.Location = new System.Drawing.Point(13, 384);
            this.bireyselDataGridView.MultiSelect = false;
            this.bireyselDataGridView.Name = "bireyselDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bireyselDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bireyselDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bireyselDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bireyselDataGridView.Size = new System.Drawing.Size(868, 110);
            this.bireyselDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 187.8788F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Bireysel Yeterlilik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 12.12121F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Not";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tcnoLbl
            // 
            this.tcnoLbl.AutoSize = true;
            this.tcnoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcnoLbl.Location = new System.Drawing.Point(29, 22);
            this.tcnoLbl.Name = "tcnoLbl";
            this.tcnoLbl.Size = new System.Drawing.Size(44, 16);
            this.tcnoLbl.TabIndex = 4;
            this.tcnoLbl.Text = "label1";
            // 
            // adsoyadLbl
            // 
            this.adsoyadLbl.AutoSize = true;
            this.adsoyadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsoyadLbl.Location = new System.Drawing.Point(245, 22);
            this.adsoyadLbl.Name = "adsoyadLbl";
            this.adsoyadLbl.Size = new System.Drawing.Size(44, 16);
            this.adsoyadLbl.TabIndex = 5;
            this.adsoyadLbl.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Değerlendirme Aralığı : 1 (Çok Kötü) - 5 (Mükemmel)";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydetBtn.Location = new System.Drawing.Point(302, 508);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(279, 98);
            this.kaydetBtn.TabIndex = 7;
            this.kaydetBtn.Text = "Değerlendirmeyi Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // YeniDegerlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 618);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adsoyadLbl);
            this.Controls.Add(this.tcnoLbl);
            this.Controls.Add(this.bireyselDataGridView);
            this.Controls.Add(this.davranisDataGridView);
            this.Controls.Add(this.meslekDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YeniDegerlendirme";
            this.Text = "Yeni Değerlendirme";
            ((System.ComponentModel.ISupportInitialize)(this.meslekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.davranisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bireyselDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView meslekDataGridView;
        private System.Windows.Forms.DataGridView davranisDataGridView;
        private System.Windows.Forms.DataGridView bireyselDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslekiyeterlilikColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degerlendirmeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label tcnoLbl;
        private System.Windows.Forms.Label adsoyadLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kaydetBtn;
    }
}