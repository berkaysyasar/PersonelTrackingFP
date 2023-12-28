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
    public partial class YoneticiIzinAnalizi : Form
    {
        public YoneticiIzinAnalizi()
        {
            InitializeComponent();
            personelDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnvan();
        }
        
        private void listeleBtn_Click(object sender, EventArgs e)
        {
            personelDataGridView.Rows.Clear();
            if (deptComboBox.Text != "" || unvanComboBox.Text != "")
            {
                string query = @"
                  SELECT e.*, r.izin_baslangictarih, r.izin_bitistarih
                  FROM personelTbl e
                  INNER JOIN izinTbl r
                  ON e.personel_tcno = r.personel_tcno
                  WHERE e.personel_departman = @departman AND e.personel_unvan = @unvan AND r.izin_talepdurumu = @talepdurumu
               ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@departman", deptComboBox.Text);
                        command.Parameters.AddWithValue("@unvan", unvanComboBox.Text);
                        command.Parameters.AddWithValue("@talepdurumu", "ONAYLANDI");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (personelDataGridView.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[2].Value.ToString() == reader["personel_tcno"].ToString()))
                                {
                                    continue;
                                }
                                personelDataGridView.Rows.Add(reader["personel_ad"].ToString(), reader["personel_soyad"].ToString(), reader["personel_tcno"].ToString(), reader["personel_isebaslamatarih"]);
                            }
                        }
                    }
                }
            }
        }

        private void personelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string personeltcno = personelDataGridView.CurrentRow.Cells[2].Value.ToString();
            kisiListBox.Items.Clear();
            string query = @"
                  SELECT e.*, r.izin_baslangictarih, r.izin_bitistarih, r.personel_tcno
                  FROM personelTbl e
                  INNER JOIN izinTbl r
                  ON e.personel_tcno = @personel_tcno
                  WHERE r.personel_tcno = @personel_tcno AND r.izin_talepdurumu = @izin_talepdurumu
               ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                    command.Parameters.AddWithValue("@izin_talepdurumu", "ONAYLANDI");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kisiListBox.Items.Add(reader["personel_ad"].ToString() + " " + reader["personel_soyad"].ToString() + " / İzin Başlangıç Tarihi: " + reader["izin_baslangictarih"].ToString() + " / İzin Bitiş Tarihi : " + reader["izin_bitistarih"].ToString());
                        }
                    }
                }
            }
        }
    }
}
