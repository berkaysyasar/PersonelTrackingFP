using Newtonsoft.Json;
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
    public partial class PersonelDegerlendirme : Form
    {
        public PersonelDegerlendirme(string tcno, string ad, string soyad, bool _isadmin)
        {
            InitializeComponent();
            meslekDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            meslekDataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            davranisDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            davranisDataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            bireyselDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            bireyselDataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            personeltcno = tcno;
            personelad = ad;
            personelsoyad = soyad;
            isadmin = _isadmin;
        }

        string personeltcno = "";
        string personelad = "";
        string personelsoyad = "";
        bool isadmin = false;

        string connectionString = Properties.Settings.Default.veritabaniConnectionString;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (isadmin)
            {
                tcnoLbl.Text = personeltcno;
                adsoyadLbl.Text = personelad + " " + personelsoyad;
                tcnoLbl.Visible = true;
                adsoyadLbl.Visible = true;
            }
            UpdateDegerlendirme(DateTime.Now.Year.ToString());
        }
        public void UpdateDegerlendirme(string yil)
        {
            meslekDataGridView.Rows.Clear();
            davranisDataGridView.Rows.Clear();
            bireyselDataGridView.Rows.Clear();
            if (yil == "")
            {
                yil = DateTime.Now.Year.ToString();
            }

            List<string> degerlendirmeList = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query2 = "SELECT * FROM degerlendirmeTbl WHERE personel_tcno = @personel_tcno AND degerlendirme_yil = @degerlendirme_yil";

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@personel_tcno", personeltcno);
                    command.Parameters.AddWithValue("@degerlendirme_yil", yil);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            degerlendirmeList = JsonConvert.DeserializeObject<List<string>>(reader.GetString(3));
                            meslekDataGridView.Rows.Add("İş Bilgisi (Yaptığı işe ilişkin teorik ve pratik bilgi düzeyi)", degerlendirmeList[0]);
                            meslekDataGridView.Rows.Add("Verimlilik (Görevini kurallara uygun istenilen zamanda ve miktarda yapabilmesi)", degerlendirmeList[1]);
                            meslekDataGridView.Rows.Add("İş Kalitesi (İşini Standartlara Uygun Olarak Yapabilme)", degerlendirmeList[2]);
                            meslekDataGridView.Rows.Add("Sorumluluk (Görev sorumluluğuyla araç ve gereçleri doğru kullanma ve sonuçları üstlenme)", degerlendirmeList[3]);
                            meslekDataGridView.Rows.Add("Problem Çözme ve Üretkenlik (Karşılaştığı problemleri hızlı ve doğru biçimde çözme; fikir geliştirme; araştırma; farklı düşünceler ortaya koyma becerisi)", degerlendirmeList[4]);
                            davranisDataGridView.Rows.Add("İnsan İlişkileri (Üstleri; astları; çalışma arkadaşları ve çevresiyle uyumlu ilişkiler ve sağlıklı iletişim kurma)", degerlendirmeList[4]);
                            davranisDataGridView.Rows.Add("Organizasyon Becerisi (Verilen görevi organize edebilme ve sonuçlarını takip edebilme becerisi)", degerlendirmeList[5]);
                            davranisDataGridView.Rows.Add("Öğrenmeye Yatkın Olma (Hizmet içi eğitimlerde ve görev aldığı çalışmalarda başarılı ile performans gösterebilme becerisi)", degerlendirmeList[6]);
                            davranisDataGridView.Rows.Add("Girişimcilik ve Yeniliklere Yatkın Olma (Yaptığı işlerle ilgili olarak güncel olayları takip edebilme; yönetime işlerin işleyişiyle ilgili yeni öneriler sunabilme becerisi)", degerlendirmeList[7]);
                            davranisDataGridView.Rows.Add("Takım Çalışması (Takım üyeleri ile işbirliği ve dayanışma içinde çalışma; bilgiyi paylaşma)", degerlendirmeList[8]);
                            davranisDataGridView.Rows.Add("Hizmete Odaklık (Görevini diğer birimlerdeki çalışanlarımız ile toplumun arzu ve beklentileri doğrultusunda yerine getirebilme becerisi)", degerlendirmeList[9]);
                            bireyselDataGridView.Rows.Add("Karar Alma (Kendisini ilgilendiren konularda karar alabilme; insiyatif kullanabilme)", degerlendirmeList[10]);
                            bireyselDataGridView.Rows.Add("Programlı Çalışma (Çalışmalarını önem ve aciliyetine göre sırayla koyarak bitirebilme becerisi)", degerlendirmeList[11]);
                            bireyselDataGridView.Rows.Add("İşe Bağlılığı (Yaptığı işi benimseyerek yapabilme becerisi; işe ve kuruma bağlılık derecesi))", degerlendirmeList[12]);
                            bireyselDataGridView.Rows.Add("Esneklik (Yöneticisinin bilgi ve izni doğrultusunda kendisine verilen diğer görevleri yerine getirebilme becerisi)", degerlendirmeList[13]);
                            return;
                        }
                    }
                }
            }
        }

        private void yilDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDegerlendirme(yilDateTimePicker.Value.Year.ToString());
           
        }
    }
}
