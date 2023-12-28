namespace personeltakip
{
    partial class IzinAnalizi
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
            this.baslangicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.izinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // izinDataGridView
            // 
            this.izinDataGridView.AllowUserToAddRows = false;
            this.izinDataGridView.AllowUserToDeleteRows = false;
            this.izinDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baslangicColumn,
            this.bitisColumn});
            this.izinDataGridView.Location = new System.Drawing.Point(13, 13);
            this.izinDataGridView.Name = "izinDataGridView";
            this.izinDataGridView.ReadOnly = true;
            this.izinDataGridView.Size = new System.Drawing.Size(528, 336);
            this.izinDataGridView.TabIndex = 0;
            // 
            // baslangicColumn
            // 
            this.baslangicColumn.HeaderText = "İzin Başlangıç Tarihi";
            this.baslangicColumn.Name = "baslangicColumn";
            this.baslangicColumn.ReadOnly = true;
            // 
            // bitisColumn
            // 
            this.bitisColumn.HeaderText = "İzin Bitiş Tarihi";
            this.bitisColumn.Name = "bitisColumn";
            this.bitisColumn.ReadOnly = true;
            // 
            // IzinAnalizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 358);
            this.Controls.Add(this.izinDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IzinAnalizi";
            this.Text = "İzin Analizi";
            ((System.ComponentModel.ISupportInitialize)(this.izinDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView izinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisColumn;
    }
}