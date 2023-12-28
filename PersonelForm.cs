using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        string connectionString = Properties.Settings.Default.veritabaniConnectionString;

        private void fotosecBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "JPG(*.JPG)|*.jpg|PNG(*.PNG)|*.png|GIF(*.GIF)|*.gif";
            of.RestoreDirectory = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                resimBox.Image = Image.FromFile(of.FileName);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateDepartman();
            UpdateArac();
            GetAllPersonel();
            
        }

        public void UpdateDepartman()
        {
            dptSilTxt.Items.Clear();
            dptUTxt.Items.Clear();
            departmanUSecTxt.Items.Clear();
            deptComboBox.Items.Clear();
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

                            dptSilTxt.Items.Add(departmentName);
                            dptUTxt.Items.Add(departmentName);
                            departmanUSecTxt.Items.Add(departmentName);
                            deptComboBox.Items.Add(departmentName);
                        }
                    }
                }
            }
        }

        public void UpdateUnvan()
        {
            unvanSilTxt.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string departmentName = departmanUSecTxt.Text;

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
                            unvanSilTxt.Items.Add(positionName);
                        }
                    }
                }
            }
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

        public bool UnvanKontrol(string unvan, string departman)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT unvan_ad FROM unvanTbl WHERE departman_id = (SELECT departman_id FROM departmanTbl WHERE departman_ad = @departman_ad) AND unvan_ad = @unvan_ad";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@unvan_ad", unvan);
                    command.Parameters.AddWithValue("@departman_ad", departman);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

        }

        public void UpdateArac()
        {
            aracSecTxt.Items.Clear();
            aracComboBox.Items.Clear();
            aracComboBox.Items.Add("Yok");
            aracComboBox.SelectedIndex = aracComboBox.FindStringExact("Yok");
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

                            aracSecTxt.Items.Add(plaka);
                            aracComboBox.Items.Add(plaka);
                        }
                    }
                }
            }
        }

        public bool TextboxKontrol()
        {
            foreach (TextBox t in tabPage1.Controls.OfType<TextBox>())
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

        private void dptEkleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dptEkleTxt.Text) || string.IsNullOrWhiteSpace(dptEkleTxt.Text))
            {
                MessageBox.Show("Lütfen bir departman adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string departmentAd = dptEkleTxt.Text;

                string query = "SELECT departman_ad FROM departmanTbl WHERE departman_ad = @departman_ad";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@departman_ad", departmentAd);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            MessageBox.Show("Bu departman zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                        }

                        else
                        {
                            
                            reader.Close();
                            query = "INSERT INTO departmanTbl (departman_ad) VALUES (@departman_ad)";

                            using (SqlCommand insertCommand = new SqlCommand(query, connection))
                            {
                                insertCommand.CommandType = CommandType.Text;
                                insertCommand.Parameters.AddWithValue("@departman_ad", departmentAd);
                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show("Departman eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateDepartman();
                                dptEkleTxt.Clear();
                            }
                            /*
                            reader.Close();
                            query = "INSERT INTO unvanTbl (unvan_ad, departman_id) VALUES (@unvan_ad, (SELECT departman_id FROM departmanTbl WHERE departman_ad = @departman_ad))";

                            using (SqlCommand insertCommand = new SqlCommand(query, connection))
                            {
                                insertCommand.CommandType = CommandType.Text;
                                insertCommand.Parameters.AddWithValue("@unvan_ad", "Yönetici");
                                insertCommand.Parameters.AddWithValue("@departman_ad", departmentAd);
                                insertCommand.ExecuteNonQuery();
                            } */
                        }
                    }
                }
            }
        }

        private void dptSilBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string departmentAd = dptSilTxt.Text;

                string query = "DELETE FROM departmanTbl WHERE departman_ad = @departman_ad";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@departman_ad", departmentAd);
                    command.ExecuteNonQuery();
                }
            }
            UpdateDepartman();
        }

        private void unvanEkleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unvanEkleTxt.Text) || string.IsNullOrWhiteSpace(unvanEkleTxt.Text))
            {
                MessageBox.Show("Lütfen bir unvan giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UnvanKontrol(unvanEkleTxt.Text, dptUTxt.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string unvanAd = unvanEkleTxt.Text;
                    string departmentAd = dptUTxt.Text;

                    string query = "INSERT INTO unvanTbl (unvan_ad, departman_id) VALUES (@unvan_ad, (SELECT departman_id FROM departmanTbl WHERE departman_ad = @departman_ad))";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@unvan_ad", unvanAd);
                        command.Parameters.AddWithValue("@departman_ad", departmentAd);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ünvan eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        unvanEkleTxt.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu ünvan zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void departmanUSecTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnvan();
        }

        private void unvanSilBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string positionName = unvanSilTxt.Text;
                string departmentName = departmanUSecTxt.Text;

                string query = "DELETE FROM unvanTbl WHERE unvan_ad = @unvan_ad AND departman_id = (SELECT departman_id FROM departmanTbl WHERE departman_ad = @departman_ad)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@unvan_ad", positionName);
                    command.Parameters.AddWithValue("@departman_ad", departmentName);
                    command.ExecuteNonQuery();
                }
            }
            UpdateUnvan();

        }

        private void aracEkleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(aracAdTxt.Text) || string.IsNullOrWhiteSpace(aracAdTxt.Text))
            {
                MessageBox.Show("Lütfen araç adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(aracPlakaTxt.Text) || string.IsNullOrWhiteSpace(aracPlakaTxt.Text))
            {
                MessageBox.Show("Lütfen araç plakası adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT arac_plaka FROM aracTbl WHERE arac_plaka = @arac_plaka";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@arac_plaka", aracPlakaTxt.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Bu araç zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            reader.Close();
                            query = "INSERT INTO aracTbl (arac_model, arac_plaka) VALUES (@arac_model, @arac_plaka)";

                            using (SqlCommand insertCommand = new SqlCommand(query, connection))
                            {
                                insertCommand.CommandType = CommandType.Text;
                                insertCommand.Parameters.AddWithValue("@arac_model", aracAdTxt.Text);
                                insertCommand.Parameters.AddWithValue("@arac_plaka", aracPlakaTxt.Text);
                                insertCommand.ExecuteNonQuery();
                                aracAdTxt.Clear();
                                aracPlakaTxt.Clear();
                                MessageBox.Show("Araç eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateArac();
                            }
                        }
                    }
                }
            }
        }

        private void aracSilBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM aracTbl WHERE arac_plaka = @arac_plaka";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@arac_plaka", aracSecTxt.Text);
                    command.ExecuteNonQuery();
                }
            }
            UpdateArac();
        }

        public string GetCinsiyet()
        {
            if (erkekCbox.Checked)
            {
                return "Erkek";
            }
            else
            {
                return "Kadın";
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        
        public void SayfayıTemizle()
        {
            adTxt.Clear();
            soyadTxt.Clear();
            tcnoTxt.Clear();
            telNoTxt.Clear();
            adresTxt.Clear();
            mailTxt.Clear();
            ibanTxt.Clear();
            maasTxt.Clear();
            resimBox.Image = (Image)Properties.Resources.bosresim;
        }

        private void personelKaydetBtn_Click(object sender, EventArgs e)
        {
            string apppw = "tuzdawidxcflfiky";
            SmtpClient send = new SmtpClient();
            send.UseDefaultCredentials = false;
            var NetworkCredentials = new NetworkCredential() { UserName = "berkayyasar0@gmail.com", Password = apppw };
            send.Port = 587;
            send.EnableSsl = true;
            send.Host = "smtp.gmail.com";
            send.Credentials = NetworkCredentials;
            if (!TextboxKontrol())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT personel_tcno FROM personelTbl WHERE personel_tcno = @personel_tcno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Bu personel zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        else
                        {
                            reader.Close();
                            var dogumtarih = dogumPicker.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                            query = "INSERT INTO personelTbl (personel_tcno, personel_ad, personel_soyad, personel_dogumtarih, personel_cinsiyet, " +
                                "personel_adres, personel_email, personel_telno, personel_departman, personel_unvan, " +
                                "personel_fotograf, personel_isebaslamatarih, personel_ibanno, personel_maas, personel_arac, kullanici_ad, kullanici_sifre) " +
                                "VALUES (@personel_tcno, @personel_ad, @personel_soyad, @personel_dogumtarih, @personel_cinsiyet, " +
                                "@personel_adres, @personel_email, @personel_telno, @personel_departman, @personel_unvan, " +
                                "@personel_fotograf, @personel_isebaslamatarih, @personel_ibanno, @personel_maas, @personel_arac, @kullanici_ad, @kullanici_sifre)";

                            using (SqlCommand insertCommand = new SqlCommand(query, connection))
                            {
                                insertCommand.CommandType = CommandType.Text;
                                insertCommand.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_ad", adTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_soyad", soyadTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_dogumtarih", dogumtarih);
                                insertCommand.Parameters.AddWithValue("@personel_cinsiyet", GetCinsiyet());
                                insertCommand.Parameters.AddWithValue("@personel_adres", adresTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_email", mailTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_telno", telNoTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_departman", deptComboBox.Text);
                                insertCommand.Parameters.AddWithValue("@personel_unvan", unvanComboBox.Text);
                                insertCommand.Parameters.AddWithValue("@personel_fotograf", ImageToByteArray(resimBox.Image));
                                insertCommand.Parameters.AddWithValue("@personel_isebaslamatarih", isTarihPicker.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                                insertCommand.Parameters.AddWithValue("@personel_ibanno", ibanTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_maas", maasTxt.Text);
                                insertCommand.Parameters.AddWithValue("@personel_arac", aracComboBox.Text);
                                insertCommand.Parameters.AddWithValue("@kullanici_ad", adTxt.Text + tcnoTxt.Text);
                                insertCommand.Parameters.AddWithValue("@kullanici_sifre", (tcnoTxt.Text + adTxt.Text).GetHashCode().ToString());
                                insertCommand.ExecuteNonQuery();

                                MailMessage msg = new MailMessage();
                                msg.From = new MailAddress("berkayyasar0@gmail.com");
                                msg.To.Add(mailTxt.Text);
                                msg.Subject = "Kullanıcı adı ve şifreniz";
                                msg.Body = "Kullanıcı adınız: " + adTxt.Text + tcnoTxt.Text + " , Şifreniz: " + (tcnoTxt.Text + adTxt.Text).GetHashCode().ToString();
                                send.Send(msg);
                                MessageBox.Show("Personel eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetAllPersonel();
                            }
                        }
                    }
                }
            }

            string query2 = "INSERT INTO odemeTbl (personel_tcno, odeme_yili) VALUES (@personel_tcno, @odeme_yili)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);
                    command.Parameters.AddWithValue("@odeme_yili", DateTime.Now.Year.ToString());
                    command.ExecuteNonQuery();
                }
            }

            string query3 = "INSERT INTO mesaiTbl (personel_tcno) VALUES (@personel_tcno)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", tcnoTxt.Text);
                    command.ExecuteNonQuery();
                }
            }
            SayfayıTemizle();
        }

        public void GetAllPersonel()
        {
            personelDataGridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();          

                string query = "SELECT * FROM personelTbl";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personelDataGridView.Rows.Add(reader["personel_ad"].ToString(), reader["personel_soyad"].ToString(),
                                reader["personel_telno"].ToString(), reader["personel_email"].ToString(), reader["personel_departman"].ToString(), reader["personel_unvan"].ToString());
                        }
                    }
                }
            }
        }

        private void tcnoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnvanForKisi();
        }

        private void personelAraBtn_Click(object sender, EventArgs e)
        {
            personelDataGridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string personelAd = personelAraTxt.Text;

                string query = "SELECT * FROM personelTbl WHERE personel_ad = @personel_ad";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_ad", personelAraTxt.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personelDataGridView.Rows.Add(reader["personel_ad"].ToString(), reader["personel_soyad"].ToString(),
                                reader["personel_telno"].ToString(), reader["personel_email"].ToString(), reader["personel_departman"].ToString(), reader["personel_unvan"].ToString());
                        }
                    }
                }
            }
        }

        private void personelSilBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string personelMail = personelDataGridView.CurrentRow.Cells["emailColumn"].Value.ToString();

                string query = "DELETE FROM personelTbl WHERE personel_email = @personel_email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_email", personelMail);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Personel silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    personelAraTxt.Text = "";
                    personelDataGridView.Rows.RemoveAt(personelDataGridView.CurrentRow.Index);
                }
            }
        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string personelAd = personelAraTxt.Text;
                string personelMail = personelDataGridView.CurrentRow.Cells["emailColumn"].Value.ToString();

                string query = "SELECT * FROM personelTbl WHERE personel_email = @personel_email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_email", personelMail);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["personel_fotograf"];
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                Image foto = Image.FromStream(stream);
                                DuzenleForm duzenleForm = new DuzenleForm(reader["personel_tcno"].ToString(),
                                                                            reader["personel_ad"].ToString(),
                                                                            reader["personel_soyad"].ToString(),
                                                                            reader["personel_dogumtarih"].ToString(),
                                                                            reader["personel_cinsiyet"].ToString(),
                                                                            reader["personel_adres"].ToString(),
                                                                            reader["personel_email"].ToString(),
                                                                            reader["personel_telno"].ToString(),
                                                                            foto,
                                                                            reader["personel_isebaslamatarih"].ToString(),
                                                                            reader["personel_ibanno"].ToString(),
                                                                            reader["personel_maas"].ToString(),
                                                                            reader["personel_departman"].ToString(),
                                                                            reader["personel_unvan"].ToString(),
                                                                            reader["personel_arac"].ToString());
                                duzenleForm.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void personelDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (personelDataGridView.SelectedRows.Count > 0)
            {
                duzenleBtn.Enabled = true;
                personelSilBtn.Enabled = true;
            }

            else
            {
                duzenleBtn.Enabled = false;
                personelSilBtn.Enabled = false;
            }
        }

        private void adminDegisBtn_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM adminTbl WHERE admin_kullaniciad = @kulAdi";
            string apppw = "tuzdawidxcflfiky";
            SmtpClient send = new SmtpClient();
            send.UseDefaultCredentials = false;
            var NetworkCredentials = new NetworkCredential() { UserName = "berkayyasar0@gmail.com", Password = apppw };
            send.Port = 587;
            send.EnableSsl = true;
            send.Host = "smtp.gmail.com";
            send.Credentials = NetworkCredentials;
            string query = "UPDATE adminTbl SET admin_kullaniciad = @admin_kullaniciad, admin_kullanicisifre = @admin_kullanicisifre, admin_email = @admin_email WHERE admin_kullaniciad = @admin_kullaniciad";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@kulAdi", adminAdTxt.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reader.Close();

                            using (SqlCommand updateCommand = new SqlCommand(query, connection))
                            {
                                updateCommand.CommandType = CommandType.Text;
                                updateCommand.Parameters.AddWithValue("@admin_kullaniciad", adminAdTxt.Text);
                                updateCommand.Parameters.AddWithValue("@admin_kullanicisifre", adminSifreTxt.Text);
                                updateCommand.Parameters.AddWithValue("@admin_email", adminMailTxt.Text);
                                updateCommand.ExecuteNonQuery();
                                MailMessage msg = new MailMessage();
                                msg.From = new MailAddress("berkayyasar0@gmail.com");
                                msg.To.Add(adminMailTxt.Text);
                                msg.Subject = "Kullanıcı adı ve şifreniz";
                                msg.Body = "Kullanıcı adınız: " + adminAdTxt.Text + " Şifreniz: " + adminSifreTxt.Text;
                                send.Send(msg);
                            }
                        }
                    }
                }
            }
        }

        private void personelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            personelSilBtn.Enabled = true;
            duzenleBtn.Enabled = true;
        }

        private void gerialBtn_Click(object sender, EventArgs e)
        {
            GetAllPersonel();
        }

    }
}
