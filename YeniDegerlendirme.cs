using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class YeniDegerlendirme : Form
    {
        public YeniDegerlendirme(string tcno, string ad, string soyad)
        {
            InitializeComponent();
            meslekDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            meslekDataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            davranisDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            davranisDataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            bireyselDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            bireyselDataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            tcnoLbl.Text = tcno;
            personelad = ad;
            personelsoyad = soyad;
            adsoyadLbl.Text = ad + " " + soyad;
        }

        string connectionString = Properties.Settings.Default.veritabaniConnectionString;
        string personelad = "";
        string personelsoyad = "";




        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            meslekDataGridView.Rows.Add("İş Bilgisi (Yaptığı işe ilişkin teorik ve pratik bilgi düzeyi)");
            meslekDataGridView.Rows.Add("Verimlilik (Görevini kurallara uygun istenilen zamanda ve miktarda yapabilmesi)");
            meslekDataGridView.Rows.Add("İş Kalitesi (İşini Standartlara Uygun Olarak Yapabilme)");
            meslekDataGridView.Rows.Add("Sorumluluk (Görev sorumluluğuyla araç ve gereçleri doğru kullanma ve sonuçları üstlenme)");
            meslekDataGridView.Rows.Add("Problem Çözme ve Üretkenlik (Karşılaştığı problemleri hızlı ve doğru biçimde çözme; fikir geliştirme; araştırma; farklı düşünceler ortaya koyma becerisi)");
            davranisDataGridView.Rows.Add("İnsan İlişkileri (Üstleri; astları; çalışma arkadaşları ve çevresiyle uyumlu ilişkiler ve sağlıklı iletişim kurma)");
            davranisDataGridView.Rows.Add("Organizasyon Becerisi (Verilen görevi organize edebilme ve sonuçlarını takip edebilme becerisi)");
            davranisDataGridView.Rows.Add("Öğrenmeye Yatkın Olma (Hizmet içi eğitimlerde ve görev aldığı çalışmalarda başarılı ile performans gösterebilme becerisi)");
            davranisDataGridView.Rows.Add("Girişimcilik ve Yeniliklere Yatkın Olma (Yaptığı işlerle ilgili olarak güncel olayları takip edebilme; yönetime işlerin işleyişiyle ilgili yeni öneriler sunabilme becerisi)");
            davranisDataGridView.Rows.Add("Takım Çalışması (Takım üyeleri ile işbirliği ve dayanışma içinde çalışma; bilgiyi paylaşma)");
            davranisDataGridView.Rows.Add("Hizmete Odaklık (Görevini diğer birimlerdeki çalışanlarımız ile toplumun arzu ve beklentileri doğrultusunda yerine getirebilme becerisi)");
            bireyselDataGridView.Rows.Add("Karar Alma (Kendisini ilgilendiren konularda karar alabilme; insiyatif kullanabilme)");
            bireyselDataGridView.Rows.Add("Programlı Çalışma (Çalışmalarını önem ve aciliyetine göre sırayla koyarak bitirebilme becerisi)");
            bireyselDataGridView.Rows.Add("İşe Bağlılığı (Yaptığı işi benimseyerek yapabilme becerisi; işe ve kuruma bağlılık derecesi))");
            bireyselDataGridView.Rows.Add("Esneklik (Yöneticisinin bilgi ve izni doğrultusunda kendisine verilen diğer görevleri yerine getirebilme becerisi)");
        }

        private void meslekDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {

            List<string> degerlendirmeList = new List<string>();

            for (int i = 0; i < meslekDataGridView.Rows.Count; i++)
            {
                degerlendirmeList.Add(meslekDataGridView.Rows[i].Cells[1].Value.ToString());
            }

            for (int i = 0; i < davranisDataGridView.Rows.Count; i++)
            {
                degerlendirmeList.Add(davranisDataGridView.Rows[i].Cells[1].Value.ToString());
            }

            for (int i = 0; i < bireyselDataGridView.Rows.Count; i++)
            {
                degerlendirmeList.Add(bireyselDataGridView.Rows[i].Cells[1].Value.ToString());
            }

            string degerlendirmeJson = Newtonsoft.Json.JsonConvert.SerializeObject(degerlendirmeList);

            string query = "INSERT INTO degerlendirmeTbl (personel_tcno, degerlendirme_yil, degerlendirme_sonuc) VALUES (@personel_tcno, @degerlendirme_yil, @degerlendirme_sonuc)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query2 = "SELECT personel_tcno FROM degerlendirmeTbl WHERE personel_tcno = @personel_tcno";

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", tcnoLbl.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Bu personelin değerlendirmesi zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        else
                        {
                            reader.Close();
                            using (SqlCommand insertCommand = new SqlCommand(query, connection))
                            {
                                insertCommand.CommandType = CommandType.Text;
                                insertCommand.Parameters.AddWithValue("@personel_tcno", tcnoLbl.Text);
                                insertCommand.Parameters.AddWithValue("@degerlendirme_yil", DateTime.Now.Year.ToString());
                                insertCommand.Parameters.AddWithValue("@degerlendirme_sonuc", degerlendirmeJson);
                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show("Değerlendirmeler kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
    }
}
