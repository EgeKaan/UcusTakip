using System;
using SistemAnalizi_GorselProgramlama;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAnalizi_GörselProgramlama
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(txtKullaniciAd.Text))
                MessageBox.Show("Lütfen alanları doldur");

            else
            {
                UcusTakipEntities vt = new UcusTakipEntities();
                string KullaniciAd = txtKullaniciAd.Text.Trim();
                string Sifre = txtSifre.Text.Trim();
                Kullanici kullanici = vt.Kullanicis.FirstOrDefault(p => p.KullaniciAdi == KullaniciAd && p.Sifre == Sifre);
                if (kullanici == null)
                    MessageBox.Show("Böyle bir kullanıcı yok");
                else
                {
                    string a = kullanici.Rol.RolKod.Trim();
                    KullaniciRol.KullaniciRolu = string.Empty;
                    KullaniciRol.KullaniciRolu = a;
                    int b = kullanici.PersonelID;
                    KullaniciRol.KullaniciID = 0;
                    KullaniciRol.KullaniciID = b;

                    MainForm f = new MainForm(kullanici.Rol.RolKod.Trim());
                    f.Show();
                    this.Hide();

                }
            }
        }
    }
}