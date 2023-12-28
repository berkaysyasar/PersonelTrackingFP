using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class AnaForm : Form
    {
        public AnaForm(string _personeltc, bool _isAdmin)
        {
            InitializeComponent();
            tcno = _personeltc;
            isAdmin = _isAdmin;
        }

        
        private string tcno = string.Empty;
        bool isAdmin = false;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (isAdmin == false)
            {
                personelBtn.Enabled = false;
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izinBtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                Yoneticiizin yoneticiizin = new Yoneticiizin();
                yoneticiizin.ShowDialog();
            }
            else
            {
                Personelizin personelizin = new Personelizin(tcno);
                personelizin.ShowDialog();
            }
        }

        private void izinAnalizBtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                YoneticiIzinAnalizi izinAnaliz = new YoneticiIzinAnalizi();
                izinAnaliz.ShowDialog();
            }
            else
            {
                IzinAnalizi izinAnaliz = new IzinAnalizi(tcno);
                izinAnaliz.ShowDialog();
            }
        }
        
        private void personelBtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                PersonelForm yoneticiPersonel = new PersonelForm();
                yoneticiPersonel.ShowDialog();
            }
            
            else
            {
                MessageBox.Show("Buna yetkiniz yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maasBtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                YoneticiMaas maasForm = new YoneticiMaas();
                maasForm.ShowDialog();
            }
            else
            {
                PersonelMaas maasForm = new PersonelMaas(tcno);
                maasForm.ShowDialog();
            }
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mesaiBtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                YoneticiMesai mesaiForm = new YoneticiMesai();
                mesaiForm.ShowDialog();
            }
            else
            {
                PersonelMesai mesaiForm = new PersonelMesai(tcno);
                mesaiForm.ShowDialog();
            }
        }

        private void degerlendirmeBtn_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                Degerlendirme degerForm = new Degerlendirme();
                degerForm.ShowDialog();
            }
            
            else
            {
                PersonelDegerlendirme degerlendirmeForm = new PersonelDegerlendirme(tcno, "", "", false);
                degerlendirmeForm.ShowDialog();
            }
        }
    }
}
