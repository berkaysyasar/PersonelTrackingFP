namespace personeltakip
{
    partial class YoneticiMaas
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
            this.listeleBtn = new System.Windows.Forms.Button();
            this.unvanComboBox = new System.Windows.Forms.ComboBox();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.personelDataGridView = new System.Windows.Forms.DataGridView();
            this.adColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayComboBox = new System.Windows.Forms.ComboBox();
            this.odemeDataGridView = new System.Windows.Forms.DataGridView();
            this.ocakColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nisanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haziranColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temmuzColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agustosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eylulColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekimColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasimColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aralikColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ibanLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maasLbl = new System.Windows.Forms.Label();
            this.odendiBtn = new System.Windows.Forms.Button();
            this.odenmediBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeleBtn.Location = new System.Drawing.Point(12, 77);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(260, 36);
            this.listeleBtn.TabIndex = 5;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // unvanComboBox
            // 
            this.unvanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unvanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unvanComboBox.FormattingEnabled = true;
            this.unvanComboBox.Location = new System.Drawing.Point(12, 44);
            this.unvanComboBox.Name = "unvanComboBox";
            this.unvanComboBox.Size = new System.Drawing.Size(260, 26);
            this.unvanComboBox.TabIndex = 4;
            // 
            // deptComboBox
            // 
            this.deptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(12, 12);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(260, 26);
            this.deptComboBox.TabIndex = 3;
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
            this.personelDataGridView.Location = new System.Drawing.Point(278, 12);
            this.personelDataGridView.Name = "personelDataGridView";
            this.personelDataGridView.ReadOnly = true;
            this.personelDataGridView.Size = new System.Drawing.Size(711, 269);
            this.personelDataGridView.TabIndex = 6;
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
            // ayComboBox
            // 
            this.ayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayComboBox.FormattingEnabled = true;
            this.ayComboBox.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.ayComboBox.Location = new System.Drawing.Point(12, 194);
            this.ayComboBox.Name = "ayComboBox";
            this.ayComboBox.Size = new System.Drawing.Size(260, 24);
            this.ayComboBox.TabIndex = 7;
            this.ayComboBox.Visible = false;
            // 
            // odemeDataGridView
            // 
            this.odemeDataGridView.AllowUserToAddRows = false;
            this.odemeDataGridView.AllowUserToDeleteRows = false;
            this.odemeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.odemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odemeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ocakColumn,
            this.subatColumn,
            this.martColumn,
            this.nisanColumn,
            this.mayisColumn,
            this.haziranColumn,
            this.temmuzColumn,
            this.agustosColumn,
            this.eylulColumn,
            this.ekimColumn,
            this.kasimColumn,
            this.aralikColumn});
            this.odemeDataGridView.Location = new System.Drawing.Point(12, 287);
            this.odemeDataGridView.Name = "odemeDataGridView";
            this.odemeDataGridView.ReadOnly = true;
            this.odemeDataGridView.Size = new System.Drawing.Size(977, 55);
            this.odemeDataGridView.TabIndex = 9;
            // 
            // ocakColumn
            // 
            this.ocakColumn.HeaderText = "Ocak";
            this.ocakColumn.Name = "ocakColumn";
            this.ocakColumn.ReadOnly = true;
            // 
            // subatColumn
            // 
            this.subatColumn.HeaderText = "Şubat";
            this.subatColumn.Name = "subatColumn";
            this.subatColumn.ReadOnly = true;
            // 
            // martColumn
            // 
            this.martColumn.HeaderText = "Mart";
            this.martColumn.Name = "martColumn";
            this.martColumn.ReadOnly = true;
            // 
            // nisanColumn
            // 
            this.nisanColumn.HeaderText = "Nisan";
            this.nisanColumn.Name = "nisanColumn";
            this.nisanColumn.ReadOnly = true;
            // 
            // mayisColumn
            // 
            this.mayisColumn.HeaderText = "Mayıs";
            this.mayisColumn.Name = "mayisColumn";
            this.mayisColumn.ReadOnly = true;
            // 
            // haziranColumn
            // 
            this.haziranColumn.HeaderText = "Haziran";
            this.haziranColumn.Name = "haziranColumn";
            this.haziranColumn.ReadOnly = true;
            // 
            // temmuzColumn
            // 
            this.temmuzColumn.HeaderText = "Temmuz";
            this.temmuzColumn.Name = "temmuzColumn";
            this.temmuzColumn.ReadOnly = true;
            // 
            // agustosColumn
            // 
            this.agustosColumn.HeaderText = "Ağustos";
            this.agustosColumn.Name = "agustosColumn";
            this.agustosColumn.ReadOnly = true;
            // 
            // eylulColumn
            // 
            this.eylulColumn.HeaderText = "Eylül";
            this.eylulColumn.Name = "eylulColumn";
            this.eylulColumn.ReadOnly = true;
            // 
            // ekimColumn
            // 
            this.ekimColumn.HeaderText = "Ekim";
            this.ekimColumn.Name = "ekimColumn";
            this.ekimColumn.ReadOnly = true;
            // 
            // kasimColumn
            // 
            this.kasimColumn.HeaderText = "Kasım";
            this.kasimColumn.Name = "kasimColumn";
            this.kasimColumn.ReadOnly = true;
            // 
            // aralikColumn
            // 
            this.aralikColumn.HeaderText = "Aralık";
            this.aralikColumn.Name = "aralikColumn";
            this.aralikColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IBAN NO:";
            this.label1.Visible = false;
            // 
            // ibanLbl
            // 
            this.ibanLbl.AutoSize = true;
            this.ibanLbl.Location = new System.Drawing.Point(66, 138);
            this.ibanLbl.Name = "ibanLbl";
            this.ibanLbl.Size = new System.Drawing.Size(0, 13);
            this.ibanLbl.TabIndex = 11;
            this.ibanLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maaş :";
            this.label2.Visible = false;
            // 
            // maasLbl
            // 
            this.maasLbl.AutoSize = true;
            this.maasLbl.Location = new System.Drawing.Point(52, 162);
            this.maasLbl.Name = "maasLbl";
            this.maasLbl.Size = new System.Drawing.Size(0, 13);
            this.maasLbl.TabIndex = 13;
            this.maasLbl.Visible = false;
            // 
            // odendiBtn
            // 
            this.odendiBtn.Location = new System.Drawing.Point(12, 224);
            this.odendiBtn.Name = "odendiBtn";
            this.odendiBtn.Size = new System.Drawing.Size(116, 23);
            this.odendiBtn.TabIndex = 14;
            this.odendiBtn.Text = "Ödendi";
            this.odendiBtn.UseVisualStyleBackColor = true;
            this.odendiBtn.Visible = false;
            this.odendiBtn.Click += new System.EventHandler(this.odendiBtn_Click);
            // 
            // odenmediBtn
            // 
            this.odenmediBtn.Location = new System.Drawing.Point(156, 224);
            this.odenmediBtn.Name = "odenmediBtn";
            this.odenmediBtn.Size = new System.Drawing.Size(116, 23);
            this.odenmediBtn.TabIndex = 15;
            this.odenmediBtn.Text = "Ödenmedi";
            this.odenmediBtn.UseVisualStyleBackColor = true;
            this.odenmediBtn.Visible = false;
            this.odenmediBtn.Click += new System.EventHandler(this.odenmediBtn_Click);
            // 
            // YoneticiMaas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 350);
            this.Controls.Add(this.odenmediBtn);
            this.Controls.Add(this.odendiBtn);
            this.Controls.Add(this.maasLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ibanLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odemeDataGridView);
            this.Controls.Add(this.ayComboBox);
            this.Controls.Add(this.personelDataGridView);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.unvanComboBox);
            this.Controls.Add(this.deptComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YoneticiMaas";
            this.Text = "YoneticiMaas";
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.ComboBox unvanComboBox;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.DataGridView personelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoColumn;
        private System.Windows.Forms.ComboBox ayComboBox;
        private System.Windows.Forms.DataGridView odemeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocakColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn martColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haziranColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temmuzColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agustosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eylulColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekimColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasimColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aralikColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ibanLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maasLbl;
        private System.Windows.Forms.Button odendiBtn;
        private System.Windows.Forms.Button odenmediBtn;
    }
}