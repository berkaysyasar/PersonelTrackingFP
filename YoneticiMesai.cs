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
    public partial class YoneticiMesai : Form
    {
        public YoneticiMesai()
        {
            InitializeComponent();
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
        private void unvanComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                            personelDataGridView.Rows.Add(reader["personel_ad"].ToString(), reader["personel_soyad"].ToString(), reader["personel_tcno"].ToString());
                        }
                    }
                }
            }
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUnvan();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            string personeltcno = personelDataGridView.CurrentRow.Cells[2].Value.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE mesaiTbl SET mesai_pazartesibaslangic = @mesai_pazartesibaslangic, mesai_pazartesibitis = @mesai_pazartesibitis, " +
                               "mesai_salibaslangic = @mesai_salibaslangic, mesai_salibitis = @mesai_salibitis, " +
                               "mesai_carsambabaslangic = @mesai_carsambabaslangic, mesai_carsambabitis = @mesai_carsambabitis, " +
                               "mesai_persembebaslangic = @mesai_persembebaslangic, mesai_persembebitis = @mesai_persembebitis, " +
                               "mesai_cumabaslangic = @mesai_cumabaslangic, mesai_cumabitis = @mesai_cumabitis, " +
                               "mesai_cumartesibaslangic = @mesai_cumartesibaslangic, mesai_cumartesibitis = @mesai_cumartesibitis, " +
                               "mesai_pazarbaslangic = @mesai_pazarbaslangic, mesai_pazarbitis = @mesai_pazarbitis WHERE personel_tcno = @personel_tcno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                    command.Parameters.AddWithValue("@mesai_pazartesibaslangic", pazartesiBasTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_pazartesibitis", pazartesiBitTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_salibaslangic", saliBasTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_salibitis", saliBitTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_carsambabaslangic", carsambaBasTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_carsambabitis", carsambaBitTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_persembebaslangic", persembeBasTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_persembebitis", persembeBitTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_cumabaslangic", cumaBasTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_cumabitis", cumaBitTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_cumartesibaslangic", cumartesiBasTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_cumartesibitis", cumartesiBitTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_pazarbaslangic", pazarBasTimePicker.Text);
                    command.Parameters.AddWithValue("@mesai_pazarbitis", pazarBitTimePicker.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Mesai saatleri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void personelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string personeltcno = personelDataGridView.CurrentRow.Cells[2].Value.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM mesaiTbl WHERE personel_tcno = @personel_tcno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", personeltcno);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pazartesiBasTimePicker.Text = reader["mesai_pazartesibaslangic"].ToString();
                            pazartesiBitTimePicker.Text = reader["mesai_pazartesibitis"].ToString();
                            saliBasTimePicker.Text = reader["mesai_salibaslangic"].ToString();
                            saliBitTimePicker.Text = reader["mesai_salibitis"].ToString();
                            carsambaBasTimePicker.Text = reader["mesai_carsambabaslangic"].ToString();
                            carsambaBitTimePicker.Text = reader["mesai_carsambabitis"].ToString();
                            persembeBasTimePicker.Text = reader["mesai_persembebaslangic"].ToString();
                            persembeBitTimePicker.Text = reader["mesai_persembebitis"].ToString();
                            cumaBasTimePicker.Text = reader["mesai_cumabaslangic"].ToString();
                            cumaBitTimePicker.Text = reader["mesai_cumabitis"].ToString();
                            cumartesiBasTimePicker.Text = reader["mesai_cumartesibaslangic"].ToString();
                            cumartesiBitTimePicker.Text = reader["mesai_cumartesibitis"].ToString();
                            pazarBasTimePicker.Text = reader["mesai_pazarbaslangic"].ToString();
                            pazarBitTimePicker.Text = reader["mesai_pazarbitis"].ToString();
                        }
                    }
                }
            }
            
        }

        private void personelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
