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
    public partial class YoneticiMaas : Form
    {
        public YoneticiMaas()
        {
            InitializeComponent();
            ayComboBox.SelectedIndex = 0;
        }

        string connectionString = Properties.Settings.Default.veritabaniConnectionString;
        public void UpdateDepartman()
        {
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
                            reader.GetString(0);
                            deptComboBox.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        public void UpdateUnvan()
        {
            unvanComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string departman = deptComboBox.SelectedItem.ToString();

                string query = "SELECT unvan_ad FROM unvanTbl INNER JOIN departmanTbl ON unvanTbl.departman_id = departmanTbl.departman_id WHERE departman_ad = @departman_ad";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@departman_ad", departman);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unvanComboBox.Items.Add(reader["unvan_ad"].ToString());
                        }
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateDepartman();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            personelDataGridView.Rows.Clear();
            if (deptComboBox.Text != "" || unvanComboBox.Text != "")
            {
                string query = "SELECT * from personelTbl WHERE personel_departman = @personel_departman AND personel_unvan = @personel_unvan";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@personel_departman", deptComboBox.Text);
                        command.Parameters.AddWithValue("@personel_unvan", unvanComboBox.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               personelDataGridView.Rows.Add(reader["personel_ad"].ToString(), reader["personel_soyad"].ToString(), reader["personel_tcno"].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnvan();
        }

        private void personelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            odemeDataGridView.Rows.Clear();
            string personeltcno = personelDataGridView.CurrentRow.Cells[2].Value.ToString();
            string yil = DateTime.Now.Year.ToString();
            string query = "SELECT * from odemeTbl WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
            string query2 = "SELECT personel_maas, personel_ibanno FROM personelTbl WHERE personel_tcno = @tcno";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                    command.Parameters.AddWithValue("@odeme_yili", yil);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odemeDataGridView.Rows.Add(reader["odeme_ocak"].ToString(), reader["odeme_subat"].ToString(), reader["odeme_mart"].ToString(), reader["odeme_nisan"].ToString(), reader["odeme_mayis"].ToString(), reader["odeme_haziran"].ToString(), reader["odeme_temmuz"].ToString(), reader["odeme_agustos"].ToString(), reader["odeme_eylul"].ToString(), reader["odeme_ekim"].ToString(), reader["odeme_kasim"].ToString(), reader["odeme_aralik"].ToString());
                            
                        }
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@tcno", personeltcno);
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            maasLbl.Text = reader.GetInt32(0).ToString();
                            ibanLbl.Text = reader.GetString(1).ToString();
                        }
                    }
                }
            }

            label1.Visible = true;
            label2.Visible = true;
            maasLbl.Visible = true;
            ibanLbl.Visible = true;
            ayComboBox.Visible = true;
            odendiBtn.Visible = true;
            odenmediBtn.Visible = true;
        }

        private void odendiBtn_Click(object sender, EventArgs e)
        {
            string personeltcno = personelDataGridView.CurrentRow.Cells[2].Value.ToString();
            string yil = DateTime.Now.Year.ToString();
            string ay = ayComboBox.SelectedItem.ToString();

            if (ay == "Ocak")
            {
                string query = "UPDATE odemeTbl SET odeme_ocak = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Şubat")
            {
                string query = "UPDATE odemeTbl SET odeme_subat = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Mart")
            {
                string query = "UPDATE odemeTbl SET odeme_mart = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Nisan")
            {
                string query = "UPDATE odemeTbl SET odeme_nisan = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Mayıs")
            {
                string query = "UPDATE odemeTbl SET odeme_mayis = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Haziran")
            {
                string query = "UPDATE odemeTbl SET odeme_haziran = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Temmuz")
            {
                string query = "UPDATE odemeTbl SET odeme_temmuz = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Ağustos")
            {
                string query = "UPDATE odemeTbl SET odeme_agustos = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Eylül")
            {
                string query = "UPDATE odemeTbl SET odeme_eylul = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Ekim")
            {
                string query = "UPDATE odemeTbl SET odeme_ekim = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Kasım")
            {
                string query = "UPDATE odemeTbl SET odeme_kasim = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Aralık")
            {
                string query = "UPDATE odemeTbl SET odeme_aralik = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", maasLbl.Text);
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }

            string query2 = "SELECT * from odemeTbl WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
            odemeDataGridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                    command.Parameters.AddWithValue("@odeme_yili", yil);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odemeDataGridView.Rows.Add(reader["odeme_ocak"].ToString(), reader["odeme_subat"].ToString(), reader["odeme_mart"].ToString(), reader["odeme_nisan"].ToString(), reader["odeme_mayis"].ToString(), reader["odeme_haziran"].ToString(), reader["odeme_temmuz"].ToString(), reader["odeme_agustos"].ToString(), reader["odeme_eylul"].ToString(), reader["odeme_ekim"].ToString(), reader["odeme_kasim"].ToString(), reader["odeme_aralik"].ToString());

                        }
                    }
                }
            }
        }

        private void odenmediBtn_Click(object sender, EventArgs e)
        {
            string personeltcno = personelDataGridView.CurrentRow.Cells[2].Value.ToString();
            string yil = DateTime.Now.Year.ToString();
            string ay = ayComboBox.SelectedItem.ToString();

            if (ay == "Ocak")
            {
                string query = "UPDATE odemeTbl SET odeme_ocak = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Şubat")
            {
                string query = "UPDATE odemeTbl SET odeme_subat = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Mart")
            {
                string query = "UPDATE odemeTbl SET odeme_mart = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Nisan")
            {
                string query = "UPDATE odemeTbl SET odeme_nisan = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Mayıs")
            {
                string query = "UPDATE odemeTbl SET odeme_mayis = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Haziran")
            {
                string query = "UPDATE odemeTbl SET odeme_haziran = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Temmuz")
            {
                string query = "UPDATE odemeTbl SET odeme_temmuz = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Ağustos")
            {
                string query = "UPDATE odemeTbl SET odeme_agustos = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Eylül")
            {
                string query = "UPDATE odemeTbl SET odeme_eylul = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Ekim")
            {
                string query = "UPDATE odemeTbl SET odeme_ekim = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Kasım")
            {
                string query = "UPDATE odemeTbl SET odeme_kasim = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }
            if (ay == "Aralık")
            {
                string query = "UPDATE odemeTbl SET odeme_aralik = @odeme WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@odeme", "Ödenmedi");
                        command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                        command.Parameters.AddWithValue("@odeme_yili", yil);
                        command.ExecuteNonQuery();
                    }
                }
            }

            string query2 = "SELECT * from odemeTbl WHERE personel_tcno = @personel_tcno AND odeme_yili = @odeme_yili";
            odemeDataGridView.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                    command.Parameters.AddWithValue("@odeme_yili", yil);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odemeDataGridView.Rows.Add(reader["odeme_ocak"].ToString(), reader["odeme_subat"].ToString(), reader["odeme_mart"].ToString(), reader["odeme_nisan"].ToString(), reader["odeme_mayis"].ToString(), reader["odeme_haziran"].ToString(), reader["odeme_temmuz"].ToString(), reader["odeme_agustos"].ToString(), reader["odeme_eylul"].ToString(), reader["odeme_ekim"].ToString(), reader["odeme_kasim"].ToString(), reader["odeme_aralik"].ToString());

                        }
                    }
                }
            }
        }
    }
}
