namespace personeltakip
{
    partial class GirisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kulAdTxt = new System.Windows.Forms.TextBox();
            this.kulSifreTxt = new System.Windows.Forms.TextBox();
            this.hatirlaCBox = new System.Windows.Forms.CheckBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // kulAdTxt
            // 
            this.kulAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulAdTxt.Location = new System.Drawing.Point(112, 12);
            this.kulAdTxt.Name = "kulAdTxt";
            this.kulAdTxt.Size = new System.Drawing.Size(167, 24);
            this.kulAdTxt.TabIndex = 2;
            // 
            // kulSifreTxt
            // 
            this.kulSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulSifreTxt.Location = new System.Drawing.Point(112, 42);
            this.kulSifreTxt.Name = "kulSifreTxt";
            this.kulSifreTxt.Size = new System.Drawing.Size(167, 24);
            this.kulSifreTxt.TabIndex = 3;
            this.kulSifreTxt.UseSystemPasswordChar = true;
            // 
            // hatirlaCBox
            // 
            this.hatirlaCBox.AutoSize = true;
            this.hatirlaCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatirlaCBox.Location = new System.Drawing.Point(177, 72);
            this.hatirlaCBox.Name = "hatirlaCBox";
            this.hatirlaCBox.Size = new System.Drawing.Size(102, 22);
            this.hatirlaCBox.TabIndex = 4;
            this.hatirlaCBox.Text = "Beni Hatırla";
            this.hatirlaCBox.UseVisualStyleBackColor = true;
            // 
            // girisBtn
            // 
            this.girisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisBtn.Location = new System.Drawing.Point(285, 12);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(92, 54);
            this.girisBtn.TabIndex = 5;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 105);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.hatirlaCBox);
            this.Controls.Add(this.kulSifreTxt);
            this.Controls.Add(this.kulAdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GirisForm";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kulAdTxt;
        private System.Windows.Forms.TextBox kulSifreTxt;
        private System.Windows.Forms.CheckBox hatirlaCBox;
        private System.Windows.Forms.Button girisBtn;
    }
}

