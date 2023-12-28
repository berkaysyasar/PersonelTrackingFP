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
    public partial class IzinAnalizi : Form
    {
        public IzinAnalizi(string tcno)
        {
            InitializeComponent();
            personeltcno = tcno;
        }

        string personeltcno = "";
        string connectionString = Properties.Settings.Default.veritabaniConnectionString;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string query = "SELECT * FROM izinTbl WHERE personel_tcno = @personel_tcno AND izin_talepdurumu = @izin_talepdurumu";
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
                            izinDataGridView.Rows.Add(reader["izin_baslangictarih"], reader["izin_bitistarih"]);
                        }
                    }
                }
            }
        }
    }
}
