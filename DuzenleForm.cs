using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class DuzenleForm : Form
    {
        public DuzenleForm(string tcno, string ad, string soyad, string dogum, string cinsiyet, string adres, string mail, string tel, Image foto, string isebaslamatarih, string ibanno, string maas, string dpt, string unv, string arac)
        {
            InitializeComponent();
            resimBox.Image = foto;
            tcnoTxt.Text = tcno;
            adTxt.Text = ad;
            soyadTxt.Text = soyad;
            dogumPicker.Value = DateTime.ParseExact(dogum, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (cinsiyet == "Erkek")
            {
                erkekCbox.Checked = true;
            }
            else
            {
                kadinCbox.Checked = true;
            }
            adresTxt.Text = adres;
            mailTxt.Text = mail;
            telNoTxt.Text = tel;
            isTarihPicker.Value = DateTime.ParseExact(isebaslamatarih, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ibanTxt.Text = ibanno;
            maasTxt.Text = maas;
            UpdateDepartman();
            deptComboBox.SelectedIndex = deptComboBox.FindStringExact(dpt);
            unvanComboBox.SelectedIndex = unvanComboBox.FindStringExact(unv);
            UpdateArac();
            aracComboBox.SelectedIndex = aracComboBox.FindStringExact(arac);
            uniqueTCno = tcno;
        }

        string uniqueTCno = "";
        string connectionString = Properties.Settings.Default.veritabaniConnectionString;

        

        public void UpdateDepartman()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT departman_ad FROM departmanTbl";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string departmentName = reader.GetString(0);
                            deptComboBox.Items.Add(departmentName);
                        }
                    }
                }
            }
        }

        public void UpdateArac()
        {
            aracComboBox.Items.Clear();
            aracComboBox.Items.Add("Yok");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT arac_plaka FROM aracTbl";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string plaka = reader.GetString(0);
                            aracComboBox.Items.Add(plaka);
                        }
                    }
                }
            }
        }

        public bool TextboxKontrol()
        {
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                if (t.Text == "")
                {
                    return false;
                }
            }

            if (telNoTxt.Text == "")
            {
                return false;
            }

            if (deptComboBox.Text == "" || unvanComboBox.Text == "")
            {
                return false;
            }
            return true;
        }

        public void UpdateUnvanForKisi()
        {
            unvanComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string departmentName = deptComboBox.Text;

                string query = "SELECT unvan_ad FROM unvanTbl INNER JOIN departmanTbl ON unvanTbl.departman_id = departmanTbl.departman_id WHERE departman_ad = @departman_ad";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@departman_ad", departmentName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string positionName = reader["unvan_ad"].ToString();
                            unvanComboBox.Items.Add(positionName);
                        }
                    }
                }
            }
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void duzenleKaydetBtn_Click(object sender, EventArgs e)
        {
            if (!TextboxKontrol())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE personelTbl SET personel_tcno = @personel_tcno, personel_ad = @personel_ad, personel_soyad = @personel_soyad, " +
                "personel_dogumtarih = @personel_dogumtarih, personel_cinsiyet = @personel_cinsiyet, personel_adres = @personel_adres, " +
                "personel_email = @personel_email, personel_telno = @personel_telno, personel_departman = @personel_departman, personel_unvan = @personel_unvan, " +
                "personel_fotograf = @personel_fotograf, personel_isebaslamatarih = @personel_isebaslamatarih, personel_ibanno = @personel_ibanno, " +
                "personel_maas = @personel_maas, personel_arac = @personel_arac WHERE personel_tcno = @uniqueTCno";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@uniqueTCno", uniqueTCno);
                    command.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);
                    command.Parameters.AddWithValue("@personel_ad", adTxt.Text);
                    command.Parameters.AddWithValue("@personel_soyad", soyadTxt.Text);
                    command.Parameters.AddWithValue("@personel_dogumtarih", dogumPicker.Value.ToString("dd/MM/yyyy"));
                    if (erkekCbox.Checked)
                    {
                        command.Parameters.AddWithValue("@personel_cinsiyet", "Erkek");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@personel_cinsiyet", "Kadın");
                    }
                    command.Parameters.AddWithValue("@personel_adres", adresTxt.Text);
                    command.Parameters.AddWithValue("@personel_email", mailTxt.Text);
                    command.Parameters.AddWithValue("@personel_telno", telNoTxt.Text);
                    command.Parameters.AddWithValue("@personel_departman", deptComboBox.Text);
                    command.Parameters.AddWithValue("@personel_unvan", unvanComboBox.Text);
                    command.Parameters.AddWithValue("@personel_fotograf", ImageToByteArray(resimBox.Image));
                    command.Parameters.AddWithValue("@personel_isebaslamatarih", isTarihPicker.Value.ToString("dd/MM/yyyy"));
                    command.Parameters.AddWithValue("@personel_ibanno", ibanTxt.Text);
                    command.Parameters.AddWithValue("@personel_maas", maasTxt.Text);
                    command.Parameters.AddWithValue("@personel_arac", aracComboBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (uniqueTCno != tcnoTxt.Text)
            {
                string query2 = "UPDATE izinTbl SET personel_tcno = @personel_tcno WHERE personel_tcno = @uniqueTCno";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@uniqueTCno", uniqueTCno);
                        command.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);
                        command.ExecuteNonQuery();
                    }
                }

                string query3 = "UPDATE odemeTbl SET personel_tcno = @personel_tcno WHERE personel_tcno = @uniqueTCno";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@uniqueTCno", uniqueTCno);
                        command.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);
                        command.ExecuteNonQuery();
                    }
                }

                string query4 = "UPDATE mesaiTbl SET personel_tcno = @personel_tcno WHERE personel_tcno = @uniqueTCno";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query4, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@uniqueTCno", uniqueTCno);
                        command.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnvanForKisi();
        }
    }
}
