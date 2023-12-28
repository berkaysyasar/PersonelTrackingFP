using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Properties.Settings.Default.adHatirla != "")
            {
                kulAdTxt.Text = Properties.Settings.Default.adHatirla;
                hatirlaCBox.Checked = true;
            }
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM adminTbl WHERE admin_kullaniciad = @kulAdi AND admin_kullanicisifre = @sifre";

            SqlConnection bag = new SqlConnection(Properties.Settings.Default.veritabaniConnectionString);
            SqlCommand sorgu = new SqlCommand(query2);
            sorgu.Connection = bag;
            sorgu.Parameters.AddWithValue("@kulAdi", kulAdTxt.Text);
            sorgu.Parameters.AddWithValue("@sifre", kulSifreTxt.Text);
            bag.Open();
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                AnaForm anaForm = new AnaForm("admin", true);
                anaForm.Show();
                this.Hide();
                MessageBox.Show("Admin girişi yapıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (hatirlaCBox.Checked)
                {
                    Properties.Settings.Default.adHatirla = kulAdTxt.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.adHatirla = "";
                    Properties.Settings.Default.Save();
                }
                bag.Close();
                bag.Dispose();
                sorgu.Dispose();
                oku.Dispose();
                return;
            }

            bag = new SqlConnection(Properties.Settings.Default.veritabaniConnectionString);
            sorgu = new SqlCommand("SELECT * FROM personelTbl WHERE kullanici_ad = @kullanici_ad AND kullanici_sifre = @kullanici_sifre");
            sorgu.Connection = bag;
            sorgu.Parameters.AddWithValue("@kullanici_ad", kulAdTxt.Text);
            sorgu.Parameters.AddWithValue("@kullanici_sifre", kulSifreTxt.Text);
            bag.Open();
            oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                AnaForm anaForm = new AnaForm(oku["personel_tcno"].ToString(), false);
                anaForm.Show();
                this.Hide();
                MessageBox.Show("Giriş yapıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (hatirlaCBox.Checked)
                {
                    Properties.Settings.Default.adHatirla = kulAdTxt.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.adHatirla = "";
                    Properties.Settings.Default.Save();
                }
            }

            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bag.Close();
            bag.Dispose();
            sorgu.Dispose();
            oku.Dispose();
        }
    }
}
