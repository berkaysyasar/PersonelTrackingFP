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
    public partial class PersonelMaas : Form
    {
        public PersonelMaas(string tcno)
        {
            InitializeComponent();
            personeltcno = tcno;
            yilDateTimePicker.MaxDate = DateTime.Now;
        }

        string personeltcno = "";
        string connectionString = Properties.Settings.Default.veritabaniConnectionString;

        public void SetIbanNo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT personel_ibanno, personel_maas FROM personelTbl WHERE personel_tcno = @tcno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@tcno", personeltcno);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ibanTxt.Text = reader.GetString(0);
                            maasTxt.Text = reader.GetInt32(1).ToString();
                        }
                    }
                }
            }
        }
        public void FillOdemeTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string yil = DateTime.Now.Year.ToString();
                string query = "SELECT * FROM odemeTbl WHERE personel_tcno = @tcno AND odeme_yili = @yil";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@tcno", personeltcno);
                    command.Parameters.AddWithValue("@yil", yil);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odemeDataGridView.Rows.Add(reader["odeme_ocak"], reader["odeme_subat"], reader["odeme_mart"],
                                reader["odeme_nisan"], reader["odeme_mayis"], reader["odeme_haziran"], reader["odeme_temmuz"], reader["odeme_agustos"],
                                reader["odeme_eylul"], reader["odeme_ekim"], reader["odeme_kasim"], reader["odeme_aralik"]);
                        }
                    }
                }

            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetIbanNo();
            FillOdemeTable();
        }

        private void yilDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM odemeTbl WHERE personel_tcno = @tcno AND odeme_yili = @yil";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@tcno", personeltcno);
                    command.Parameters.AddWithValue("@yil", yilDateTimePicker.Value.Year.ToString());

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odemeDataGridView.Rows.Add(reader["odeme_ocak"], reader["odeme_subat"], reader["odeme_mart"],
                                reader["odeme_nisan"], reader["odeme_mayis"], reader["odeme_haziran"], reader["odeme_temmuz"], reader["odeme_agustos"],
                                reader["odeme_eylul"], reader["odeme_ekim"], reader["odeme_kasim"], reader["odeme_aralik"]);
                        }
                    }
                }

            }
        }
    }
}
