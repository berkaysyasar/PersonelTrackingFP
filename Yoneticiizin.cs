using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Globalization;

namespace personeltakip
{
    public partial class Yoneticiizin : Form
    {
        public Yoneticiizin()
        {
            InitializeComponent();
        }

        string connectionString = Properties.Settings.Default.veritabaniConnectionString;
        
        public void UpdateIzinList()
        {
            taleplerDataGridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                  SELECT e.*, r.izin_baslangictarih, r.izin_bitistarih
                  FROM personelTbl e
                  INNER JOIN izinTbl r
                  ON e.personel_tcno = r.personel_tcno
                  WHERE r.izin_talepdurumu = 'Beklemede'
               ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taleplerDataGridView.Rows.Add(reader["personel_tcno"], reader["personel_ad"], reader["personel_soyad"], reader["izin_baslangictarih"], reader["izin_bitistarih"]);
                        }
                    }
                }
            }
        }

        public void UpdateAlreadyOnIzinList()
        {
            izindeDataGridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();

                string query = @"
                  SELECT e.*, r.izin_baslangictarih, r.izin_bitistarih
                  FROM personelTbl e
                  INNER JOIN izinTbl r
                  ON e.personel_tcno = r.personel_tcno
                  WHERE r.izin_talepdurumu = 'ONAYLANDI'
               ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime bitisTarih = DateTime.ParseExact(reader["izin_bitistarih"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            DateTime baslangicTarih = DateTime.ParseExact(reader["izin_baslangictarih"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            DateTime now = DateTime.Now;
                            if (now >= baslangicTarih && now <= bitisTarih)
                            {
                                izindeDataGridView.Rows.Add(reader["personel_tcno"], reader["personel_ad"], reader["personel_soyad"], reader["izin_baslangictarih"], reader["izin_bitistarih"]);
                            }
                        }
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateIzinList();
            UpdateAlreadyOnIzinList();
        }
        
        public void MailYolla()
        {
            string query = "SELECT personel_email FROM personelTbl WHERE personel_tcno = @tcno";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tcno", taleplerDataGridView.CurrentRow.Cells[0].Value.ToString());
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string apppw = "tuzdawidxcflfiky";
                            SmtpClient send = new SmtpClient();
                            send.UseDefaultCredentials = false;
                            var NetworkCredentials = new NetworkCredential() { UserName = "berkayyasar0@gmail.com", Password = apppw };
                            send.Port = 587;
                            send.EnableSsl = true;
                            send.Host = "smtp.gmail.com";
                            send.Credentials = NetworkCredentials;
                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress("berkayyasar0@gmail.com");
                            msg.To.Add(reader["personel_email"].ToString());
                            msg.Subject = "İzin Talebiniz Onaylandı";
                            msg.Body = $"{taleplerDataGridView.CurrentRow.Cells[3].Value.ToString()} başlangıçlı, {taleplerDataGridView.CurrentRow.Cells[4].Value.ToString()} bitişli izin talebiniz onaylanmıştır.";
                            send.Send(msg);
                        }
                    }
                }
            }
        }

        public void MailReddet()
        {
            string query = "SELECT personel_email FROM personelTbl WHERE personel_tcno = @tcno";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tcno", taleplerDataGridView.CurrentRow.Cells[0].Value.ToString());
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string apppw = "tuzdawidxcflfiky";
                            SmtpClient send = new SmtpClient();
                            send.UseDefaultCredentials = false;
                            var NetworkCredentials = new NetworkCredential() { UserName = "berkayyasar0@gmail.com", Password = apppw };
                            send.Port = 587;
                            send.EnableSsl = true;
                            send.Host = "smtp.gmail.com";
                            send.Credentials = NetworkCredentials;
                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress("berkayyasar0@gmail.com");
                            msg.To.Add(reader["personel_email"].ToString());
                            msg.Subject = "İzin Talebiniz Reddedildi";
                            msg.Body = $"{taleplerDataGridView.CurrentRow.Cells[3].Value.ToString()} başlangıçlı, {taleplerDataGridView.CurrentRow.Cells[4].Value.ToString()} bitişli izin talebiniz reddedilmiştir.";
                            send.Send(msg);
                        }
                    }
                }
            }
        }

        private void onayBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE izinTbl SET izin_talepdurumu = 'ONAYLANDI' WHERE personel_tcno = @personel_tcno AND izin_baslangictarih = @izin_baslangictarih AND izin_bitistarih = @izin_bitistarih";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", taleplerDataGridView.CurrentRow.Cells[0].Value.ToString());
                    command.Parameters.AddWithValue("@izin_baslangictarih", taleplerDataGridView.CurrentRow.Cells[3].Value.ToString());
                    command.Parameters.AddWithValue("@izin_bitistarih", taleplerDataGridView.CurrentRow.Cells[4].Value.ToString());
                    command.ExecuteNonQuery();
                }
            }
            MailYolla();
            UpdateIzinList();
            UpdateAlreadyOnIzinList();
            MessageBox.Show("İzin talebi onaylandı.", "ONAYLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE izinTbl SET izin_talepdurumu = 'Reddedildi' WHERE personel_tcno = @personel_tcno AND izin_baslangictarih = @izin_baslangictarih AND izin_bitistarih = @izin_bitistarih";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", taleplerDataGridView.CurrentRow.Cells[0].Value.ToString());
                    command.Parameters.AddWithValue("@izin_baslangictarih", taleplerDataGridView.CurrentRow.Cells[3].Value.ToString());
                    command.Parameters.AddWithValue("@izin_bitistarih", taleplerDataGridView.CurrentRow.Cells[4].Value.ToString());
                    command.ExecuteNonQuery();
                }
            }
            MailReddet();
            UpdateIzinList();
            MessageBox.Show("İzin talebi reddedildi.", "Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void izindeDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                var row = dataGrid.Rows[e.RowIndex];
                dataGrid.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
                row.Selected = true;
                dataGrid.Focus();

                izinsilBtn.Show(dataGrid, e.Location);

            }
        }

        private void izinsilBtn_Click(object sender, EventArgs e)
        {
        }

        private void izinSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE izinTbl SET izin_talepdurumu = 'Reddedildi' WHERE personel_tcno = @personel_tcno AND izin_baslangictarih = @izin_baslangictarih AND izin_bitistarih = @izin_bitistarih";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", izindeDataGridView.CurrentRow.Cells[0].Value.ToString());
                    command.Parameters.AddWithValue("@izin_baslangictarih", izindeDataGridView.CurrentRow.Cells[3].Value.ToString());
                    command.Parameters.AddWithValue("@izin_bitistarih", izindeDataGridView.CurrentRow.Cells[4].Value.ToString());
                    command.ExecuteNonQuery();
                }
            }
            UpdateIzinList();
            MessageBox.Show("İzin onayı geri alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void izinsilBtn_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
