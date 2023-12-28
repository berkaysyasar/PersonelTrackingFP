namespace personeltakip
{
    partial class Yoneticiizin
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
            this.components = new System.ComponentModel.Container();
            this.taleplerDataGridView = new System.Windows.Forms.DataGridView();
            this.tcnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onayBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.izindeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.izinsilBtn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izinSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.taleplerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izindeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.izinsilBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // taleplerDataGridView
            // 
            this.taleplerDataGridView.AllowUserToAddRows = false;
            this.taleplerDataGridView.AllowUserToDeleteRows = false;
            this.taleplerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taleplerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taleplerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcnoColumn,
            this.adColumn,
            this.soyadColumn,
            this.baslangicColumn,
            this.bitisColumn});
            this.taleplerDataGridView.Location = new System.Drawing.Point(6, 22);
            this.taleplerDataGridView.Name = "taleplerDataGridView";
            this.taleplerDataGridView.ReadOnly = true;
            this.taleplerDataGridView.Size = new System.Drawing.Size(775, 326);
            this.taleplerDataGridView.TabIndex = 0;
            // 
            // tcnoColumn
            // 
            this.tcnoColumn.HeaderText = "Tc No";
            this.tcnoColumn.Name = "tcnoColumn";
            this.tcnoColumn.ReadOnly = true;
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
            // onayBtn
            // 
            this.onayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onayBtn.Location = new System.Drawing.Point(202, 381);
            this.onayBtn.Name = "onayBtn";
            this.onayBtn.Size = new System.Drawing.Size(181, 59);
            this.onayBtn.TabIndex = 1;
            this.onayBtn.Text = "Onayla";
            this.onayBtn.UseVisualStyleBackColor = true;
            this.onayBtn.Click += new System.EventHandler(this.onayBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redBtn.Location = new System.Drawing.Point(433, 381);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(181, 59);
            this.redBtn.TabIndex = 2;
            this.redBtn.Text = "Reddet";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // izindeDataGridView
            // 
            this.izindeDataGridView.AllowUserToAddRows = false;
            this.izindeDataGridView.AllowUserToDeleteRows = false;
            this.izindeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izindeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izindeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.izindeDataGridView.Location = new System.Drawing.Point(6, 19);
            this.izindeDataGridView.Name = "izindeDataGridView";
            this.izindeDataGridView.ReadOnly = true;
            this.izindeDataGridView.Size = new System.Drawing.Size(775, 326);
            this.izindeDataGridView.TabIndex = 3;
            this.izindeDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.izindeDataGridView_CellMouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tc No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "İzin Başlangıç Tarihi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "İzin Bitiş Tarihi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.izindeDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(9, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 355);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzindeki Personeller";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.taleplerDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 354);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İzin Talepleri";
            // 
            // izinsilBtn
            // 
            this.izinsilBtn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izinSilToolStripMenuItem});
            this.izinsilBtn.Name = "izinsilBtn";
            this.izinsilBtn.Size = new System.Drawing.Size(181, 48);
            this.izinsilBtn.Opening += new System.ComponentModel.CancelEventHandler(this.izinsilBtn_Opening);
            this.izinsilBtn.Click += new System.EventHandler(this.izinsilBtn_Click);
            // 
            // izinSilToolStripMenuItem
            // 
            this.izinSilToolStripMenuItem.Name = "izinSilToolStripMenuItem";
            this.izinSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izinSilToolStripMenuItem.Text = "İzini Geri Al";
            this.izinSilToolStripMenuItem.Click += new System.EventHandler(this.izinSilToolStripMenuItem_Click);
            // 
            // Yoneticiizin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 807);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.onayBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Yoneticiizin";
            this.Text = "Personel İzin Talepleri";
            ((System.ComponentModel.ISupportInitialize)(this.taleplerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izindeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.izinsilBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView taleplerDataGridView;
        private System.Windows.Forms.Button onayBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisColumn;
        private System.Windows.Forms.DataGridView izindeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip izinsilBtn;
        private System.Windows.Forms.ToolStripMenuItem izinSilToolStripMenuItem;
    }
}