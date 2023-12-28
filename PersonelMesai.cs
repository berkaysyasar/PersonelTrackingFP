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
    public partial class PersonelMesai : Form
    {
        public PersonelMesai(string _tcno)
        {
            InitializeComponent();
            tcno = _tcno;
        }

        string connectionString = Properties.Settings.Default.veritabaniConnectionString;
        string tcno = "";

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM mesaiTbl WHERE personel_tcno = @personel_tcno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", tcno);

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
    }
}
