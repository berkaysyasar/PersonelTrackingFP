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
    public partial class Degerlendirme : Form
    {
        public Degerlendirme()
        {
            InitializeComponent();
        }

        string connectionString = Properties.Settings.Default.veritabaniConnectionString;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateDepartman();
        }

        string ad = "";
        string soyad = "";
        string pertcno = "";

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

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnvan();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            personelDataGridView.Rows.Clear();
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
                            personelDataGridView.Rows.Add(reader["personel_tcno"].ToString(), reader["personel_ad"].ToString(), reader["personel_soyad"].ToString());
                            ad = reader["personel_ad"].ToString();
                            soyad = reader["personel_soyad"].ToString();
                        }
                    }
                }
            }
        }
        
        private void oncekiBtn_Click(object sender, EventArgs e)
        {
            PersonelDegerlendirme yeniDegerlendirme = new PersonelDegerlendirme(pertcno, ad, soyad, true);
            yeniDegerlendirme.ShowDialog();
        }

        private void yeniBtn_Click(object sender, EventArgs e)
        {
            YeniDegerlendirme yeniDegerlendirme = new YeniDegerlendirme(pertcno, ad, soyad);
            yeniDegerlendirme.ShowDialog();
        }

        private void personelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pertcno = personelDataGridView.CurrentRow.Cells[0].Value.ToString();
            ad = personelDataGridView.CurrentRow.Cells[1].Value.ToString();
            soyad = personelDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
