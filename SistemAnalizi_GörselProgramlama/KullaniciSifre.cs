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
    public partial class KullaniciSifre : Form
    {
        public KullaniciSifre()
        {
            InitializeComponent();
        }
        private int perNo = KullaniciRol.KullaniciID;
        private string sifre = string.Empty;
        private string kullaniciAdi = string.Empty;
        private int kullaniciID = 0;
        private void KullaniciSifre_Load(object sender, EventArgs e)
        {
            
            if (TıklanılanButon.butonAdi_2 == "Kullanici")
            {
                lblEski.Text = "Eski Kullanıcı Adı";
                lblYeni.Text = "Yeni Kullanıcı Adı";
                lblYeniTekrar.Text = "Tekrar Kullanıcı Adı";
                button1.Text = "Kullanıcı Adımı Değiştir";
                this.Text = "Kullanici Adı Değiştirme";
            }
            if (TıklanılanButon.butonAdi_2 == "sifre")
            {
                lblEski.Text = "    Eski Şifre";
                lblYeni.Text = "    Yeni Şifre";
                lblYeniTekrar.Text = "    Tekrar Şifre";
                button1.Text = "Şifremi Değiştir";
                this.Text = "Şifre Değiştirme";
            }

        }

        void AlanlariTemizle()
        {
            txtEski.Text = string.Empty;
            txtYeni.Text = string.Empty;
            txtYeniKontrol.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            var kullaniciBilgileri = vt.Kullanicis.FirstOrDefault(p => p.PersonelID == perNo);

            sifre = kullaniciBilgileri.Sifre.Trim();
            kullaniciID = kullaniciBilgileri.KullanıcıID;
            kullaniciAdi = kullaniciBilgileri.KullaniciAdi.Trim();

            if (TıklanılanButon.butonAdi_2 == "Kullanici") KullaniciAdiGuncelle();
            else SifreGuncelleme();
        }

        void SifreGuncelleme()
        {
            if (string.IsNullOrEmpty(txtEski.Text) || string.IsNullOrEmpty(txtYeni.Text)
               || string.IsNullOrEmpty(txtYeniKontrol.Text))
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz.");
            }
            else if (txtEski.Text == sifre)
            {
                if (txtYeni.Text == txtYeniKontrol.Text)
                {
                    UcusTakipEntities vt = new UcusTakipEntities();
                    Kullanici k = vt.Kullanicis.FirstOrDefault(p => p.KullanıcıID == kullaniciID);
                    k.Sifre = txtYeni.Text.Trim();
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Şifreniz Başarılıyla Değitirilmiştir.");
                        AlanlariTemizle();
                    }
                }
                else MessageBox.Show("Girdiğiniz Şifreler Eşleşmiyor.\n Lütfen Kontrol Ediniz.");
            }
            else
            {
                txtEski.Text = string.Empty;
                MessageBox.Show("Eski Şifreniz Yanlıştır. \n Lütfen Tekrar Giriniz.");
            }
        }

        void KullaniciAdiGuncelle()
        {
            if (string.IsNullOrEmpty(txtEski.Text) || string.IsNullOrEmpty(txtYeni.Text)
               || string.IsNullOrEmpty(txtYeniKontrol.Text))
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz.");
            }
            else if (txtEski.Text == kullaniciAdi)
            {
                if (txtYeni.Text == txtYeniKontrol.Text)
                {
                    UcusTakipEntities vt = new UcusTakipEntities();
                    Kullanici k = vt.Kullanicis.FirstOrDefault(p => p.KullanıcıID == kullaniciID);
                    k.KullaniciAdi = txtYeni.Text.Trim();
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kullanıcı Adınız Başarılıyla Değitirilmiştir.");
                        AlanlariTemizle();
                    }
                }
                else MessageBox.Show("Girdiğiniz kullanıcı adları eşleşmiyor.\n Lütfen kontrol ediniz.");
            }
            else
            {
                txtEski.Text = string.Empty;
                MessageBox.Show("Eski kullanıcı Adınız yanlıştır. \n Lütfen tekrar giriniz.");
            }
        }
    }
}
