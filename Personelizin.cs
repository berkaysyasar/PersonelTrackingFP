using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class Personelizin : Form
    {
        public Personelizin(string tcno)
        {
            InitializeComponent();
            baslangicPicker.MinDate = DateTime.Now;
            bitisPicker.MinDate = DateTime.Now;
            currentPersonelTcNo = tcno;
        }

        private string currentPersonelTcNo = "";
        string connectionString = Properties.Settings.Default.veritabaniConnectionString;

        public void UpdateIzin()
        {
            izinDataGridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM izinTbl WHERE personel_tcno = @personel_tcno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", currentPersonelTcNo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            izinDataGridView.Rows.Add(reader["izin_baslangictarih"], reader["izin_bitistarih"], reader["izin_talepdurumu"]);
                        }
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateIzin();
        }

        private void izinTalepBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO izinTbl (personel_tcno, izin_baslangictarih, izin_bitistarih, izin_talepdurumu) " +
                    "VALUES (@personel_tcno, @izin_baslangictarih, @izin_bitistarih, @izin_talepdurumu)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", currentPersonelTcNo);
                    command.Parameters.AddWithValue("@izin_baslangictarih", baslangicPicker.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    command.Parameters.AddWithValue("@izin_bitistarih", bitisPicker.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    command.Parameters.AddWithValue("@izin_talepdurumu", "Beklemede");
                    command.ExecuteNonQuery();
                    UpdateIzin();
                }
            }
        }
    }
}
