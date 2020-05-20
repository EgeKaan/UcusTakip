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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string rolKod)
        {
            InitializeComponent();
            menuYonetici.Visible = false;
            menuPersonel.Visible = false;
            switch (rolKod)
            {
                case "Yonetici":
                    menuYonetici.Visible = true;
                    break;
                case "Personel":
                    menuPersonel.Visible = true;
                    this.Text = "Kişisel Uçuş Takip Uygulaması";
                    int perno = KullaniciRol.KullaniciID;
                    DateTime simdi = DateTime.Now;
                    UcusTakipEntities vt = new UcusTakipEntities();
                    var list = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == perno);
                    if (simdi > list.YillikSaglikSon || simdi > list.BesYillikSaglikSon)
                    {
                        MessageBox.Show("Lütfen sağlık muayene tarihlerinizi kontrol ediniz.");
                    }
                    break;
            }
        }

        private void personelleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = "ButunPersoneller";

            PersonelleriListele personelListele = new PersonelleriListele();
            personelListele.MdiParent = this;
            personelListele.Show();
        }

        private void personelBilgileriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string personel = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = personel;

            PersonelEkleGuncelle personelEkle = new PersonelEkleGuncelle();
            personelEkle.MdiParent = this;
            personelEkle.Show();
    
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "SaglikEkle";

            SaglıkTarihiEkleGuncelle personelEkle = new SaglıkTarihiEkleGuncelle();
            personelEkle.MdiParent = this;
            personelEkle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void personelBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string personel = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = personel;

            PersonelEkleGuncelle personelGuncelle = new PersonelEkleGuncelle();
            personelGuncelle.MdiParent = this;
            personelGuncelle.Show();
        }

        private void sağlıkMuayeneBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "SaglikGuncelle";

            SaglıkTarihiEkleGuncelle personelGuncelle = new SaglıkTarihiEkleGuncelle();
            personelGuncelle.MdiParent = this;
            personelGuncelle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void uçuşlarıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "Guncelle";

            UcusEkleGuncelle ucusGuncelle = new UcusEkleGuncelle();
            ucusGuncelle.MdiParent = this;
            ucusGuncelle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void uçuşEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcusIslemleri ucusEkle = new UcusIslemleri();
            ucusEkle.MdiParent = this;
            ucusEkle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void havaAracıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string havaAraci = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = havaAraci;

            HavaAraciIslemleriEkle havaAraciIslemi = new HavaAraciIslemleriEkle();
            havaAraciIslemi.MdiParent = this;
            havaAraciIslemi.Show();
        }

        private void personelBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string personel = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = personel;

            PersonelEkleGuncelle personelSil = new PersonelEkleGuncelle();
            personelSil.MdiParent = this;
            personelSil.Show();

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "SaglikSil";

            SaglıkTarihiEkleGuncelle personelGuncelle = new SaglıkTarihiEkleGuncelle();
            personelGuncelle.MdiParent = this;
            personelGuncelle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void bilgilerimiListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string personel = "KendiBilgileri";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = personel;

            PersonelleriListele personelListele = new PersonelleriListele();
            personelListele.MdiParent = this;
            personelListele.Show();
        }

        private void personelBilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string personel = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = personel;

            string giris = "Personel";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = giris;

            PersonelEkleGuncelle personelGuncelle = new PersonelEkleGuncelle();
            personelGuncelle.MdiParent = this;
            personelGuncelle.Show();
        }

        private void sağlıkMuayeneBilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaglıkTarihiEkleGuncelle personelSaglıkGuncelle = new SaglıkTarihiEkleGuncelle();
            personelSaglıkGuncelle.MdiParent = this;
            personelSaglıkGuncelle.Show();

        }

        private void yetkimOlanAraçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string yetki = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = yetki;

            HavaAraciIslemleriYetkilendirme yetkilendir = new HavaAraciIslemleriYetkilendirme();
            yetkilendir.MdiParent = this;
            yetkilendir.Show();
        }

        private void yetkiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string yetki = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = yetki;

            HavaAraciIslemleriYetkilendirme yetkilendir = new HavaAraciIslemleriYetkilendirme();
            yetkilendir.MdiParent = this;
            yetkilendir.Show();
        }

        private void havaAracıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string havaAraci = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = havaAraci;

            HavaAraciIslemleriEkle havaAraciIslemi = new HavaAraciIslemleriEkle();
            havaAraciIslemi.MdiParent = this;
            havaAraciIslemi.Show();
        }

        private void havaAraçlarınıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string havaAraci = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = havaAraci;

            HavaAraciIslemleriEkle havaAraciIslemi = new HavaAraciIslemleriEkle();
            havaAraciIslemi.MdiParent = this;
            havaAraciIslemi.Show();
        }

        private void havaAracıYetkileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HavaAraciIslemleriYetkilendirme yetkilendir = new HavaAraciIslemleriYetkilendirme();
            yetkilendir.MdiParent = this;
            yetkilendir.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void komutanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buton = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = buton;
            TıklanılanButon.butonAdi_2 = string.Empty;
            string komutan = "Komutan";
            TıklanılanButon.butonAdi_2 = komutan;

            KomutanBilgileriEkle komutanEkle = new KomutanBilgileriEkle();
            komutanEkle.MdiParent = this;
            komutanEkle.Show();
        }

        private void komutanGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buton = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = buton;
            TıklanılanButon.butonAdi_2 = string.Empty;
            string komutan = "Komutan";
            TıklanılanButon.butonAdi_2 = komutan;

            KomutanBilgileriEkle KomutanGuncelle = new KomutanBilgileriEkle();
            KomutanGuncelle.MdiParent = this;
            KomutanGuncelle.Show();
        }

        private void komutanSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buton = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = buton;
            TıklanılanButon.butonAdi_2 = string.Empty;
            string komutan = "Komutan";
            TıklanılanButon.butonAdi_2 = komutan;

            KomutanBilgileriEkle KomutanSil = new KomutanBilgileriEkle();
            KomutanSil.MdiParent = this;
            KomutanSil.Show();
        }

        private void harekatSubayıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buton = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = buton;
            string harekatSubayi = "HarekatSubayi";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = harekatSubayi;

            KomutanBilgileriEkle HarekatSubayiEkle = new KomutanBilgileriEkle();
            HarekatSubayiEkle.MdiParent = this;
            HarekatSubayiEkle.Show();
        }

        private void harekatSubayıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buton = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = buton;
            string harekatSubayi = "HarekatSubayi";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = harekatSubayi;

            KomutanBilgileriEkle HarekatSubayiGuncelle = new KomutanBilgileriEkle();
            HarekatSubayiGuncelle.MdiParent = this;
            HarekatSubayiGuncelle.Show();
        }

        private void harekatSubayıGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string buton = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = buton;
            string harekatSubayi = "HarekatSubayi";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = harekatSubayi;

            KomutanBilgileriEkle HarekatSubayiSil = new KomutanBilgileriEkle();
            HarekatSubayiSil.MdiParent = this;
            HarekatSubayiSil.Show();
        }

        private void komutanSeçimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi_2 = string.Empty;
            string komutan = "Komutan";
            TıklanılanButon.butonAdi_2 = komutan;

            KomutanIslemleri komutanSecimi = new KomutanIslemleri();
            komutanSecimi.MdiParent = this;
            komutanSecimi.Show();
        }

        private void harekatSubayıSeçimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string harekatSubayi = "HarekatSubayi";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = harekatSubayi;

            KomutanIslemleri harekatSubayiSecimi = new KomutanIslemleri();
            harekatSubayiSecimi.MdiParent = this;
            harekatSubayiSecimi.Show();
        }

        private void komutanSeçimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi_2 = string.Empty;
            string komutan = "Komutan";
            TıklanılanButon.butonAdi_2 = komutan;

            KomutanIslemleri komutanSecimi = new KomutanIslemleri();
            komutanSecimi.MdiParent = this;
            komutanSecimi.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void harekatSubayıSeçimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string harekatSubayi = "HarekatSubayi";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = harekatSubayi;

            KomutanIslemleri harekatSubayiSecimi = new KomutanIslemleri();
            harekatSubayiSecimi.MdiParent = this;
            harekatSubayiSecimi.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void uçuşEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string ucusislemi = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = ucusislemi;

            UcusIslemleri ucusEkle = new UcusIslemleri();
            ucusEkle.MdiParent = this;
            ucusEkle.Show();
        }

        private void uçuşSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ucusislemi = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = ucusislemi;

            UcusEkleGuncelle ucusSil = new UcusEkleGuncelle();
            ucusSil.MdiParent = this;
            ucusSil.Show();
        }

        private void uçuşlarımıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ucusislemi = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = ucusislemi;

            UcusEkleGuncelle ucusGuncelle = new UcusEkleGuncelle();
            ucusGuncelle.MdiParent = this;
            ucusGuncelle.Show();
        }


        private void uçuşSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string ucusislemi = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = ucusislemi;

            UcusEkleGuncelle ucusSil = new UcusEkleGuncelle();
            ucusSil.MdiParent = this;
            ucusSil.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void kursEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursBilgileriEkleGuncelle kursEkle = new KursBilgileriEkleGuncelle();
            kursEkle.MdiParent = this;
            kursEkle.Show();
            
        }

        private void kurslarıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursBilgileriEkleGuncelle kursGuncelle = new KursBilgileriEkleGuncelle();
            kursGuncelle.MdiParent = this;
            kursGuncelle.Show();
        }

        private void kursSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursBilgileriEkleGuncelle kursSil = new KursBilgileriEkleGuncelle();
            kursSil.MdiParent = this;
            kursSil.Show();
        }

        private void yetkiliOlduğumAraçlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listele = "yetkiliAracListem";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = listele;

            PersonelleriListele perlist = new PersonelleriListele();
            perlist.MdiParent = this;
            perlist.Show();
        }

        private void yıllıkToplamUçuşlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listele = "yillik";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = listele;

            AylıkUcus aylikUcus = new AylıkUcus();
            aylikUcus.MdiParent = this;
            aylikUcus.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void havaAraçlarınıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listele = "havaAraclariListele";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = listele;

            PersonelleriListele perlist = new PersonelleriListele();
            perlist.MdiParent = this;
            perlist.Show();
        }

        private void kurslarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listele = "kurslariListele";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = listele;

            PersonelleriListele perlist = new PersonelleriListele();
            perlist.MdiParent = this;
            perlist.Show();
        }

        private void komutanlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listele = "komutanlariListele";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = listele;

            PersonelleriListele perlist = new PersonelleriListele();
            perlist.MdiParent = this;
            perlist.Show();
        }

        private void harekatSubaylarınıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listele = "harekatSubaylariListele";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = listele;

            PersonelleriListele perlist = new PersonelleriListele();
            perlist.MdiParent = this;
            perlist.Show();
        }

        private void kuslarımıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listele = "kurslarimiListele";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = listele;

            PersonelleriListele perlist = new PersonelleriListele();
            perlist.MdiParent = this;
            perlist.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            string listele = "yillik";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = listele;

            AylıkUcus aylikUcus = new AylıkUcus();
            aylikUcus.MdiParent = this;
            aylikUcus.Show();
        }

        private void kullanıcılarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string islem = "kullanicilariListele";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = islem;

            PersonelleriListele kullanicilariListele = new PersonelleriListele();
            kullanicilariListele.MdiParent = this;
            kullanicilariListele.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string islem = "Ekle";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = islem;

            KullaniciIslemleri kullaniciEkle = new KullaniciIslemleri();
            kullaniciEkle.MdiParent = this;
            kullaniciEkle.Show();
        }

        private void kullanıcıŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string islem = "Sil";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = islem;

            KullaniciIslemleri kullaniciSil = new KullaniciIslemleri();
            kullaniciSil.MdiParent = this;
            kullaniciSil.Show();
        }

        private void kullanıcılarıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string islem = "Guncelle";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = islem;

            KullaniciIslemleri kullaniciGuncelle = new KullaniciIslemleri();
            kullaniciGuncelle.MdiParent = this;
            kullaniciGuncelle.Show();
        }

        private void şifreGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string islem = "sifre";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = islem;

            KullaniciSifre sifreIslemi = new KullaniciSifre();
            sifreIslemi.MdiParent = this;
            sifreIslemi.Show();
        }

        private void kullanıcıAdıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string islem = "Kullanici";
            TıklanılanButon.butonAdi_2 = string.Empty;
            TıklanılanButon.butonAdi_2 = islem;

            KullaniciSifre kullaniciAdi = new KullaniciSifre();
            kullaniciAdi.MdiParent = this;
            kullaniciAdi.Show();
        }

        private void sağlıkMuayeneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "SaglikEkle";

            SaglıkTarihiEkleGuncelle personelEkle = new SaglıkTarihiEkleGuncelle();
            personelEkle.MdiParent = this;
            personelEkle.Show();
        }

        private void sağlıkMuayeneSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "SaglikSil";

            SaglıkTarihiEkleGuncelle personelEkle = new SaglıkTarihiEkleGuncelle();
            personelEkle.MdiParent = this;
            personelEkle.Show();
        }

        private void sağlıkMuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "SaglikGuncelle";

            SaglıkTarihiEkleGuncelle personelEkle = new SaglıkTarihiEkleGuncelle();
            personelEkle.MdiParent = this;
            personelEkle.Show();
        }

        private void aylıkUçuşlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "aylik";

            AylıkUcus aylikUcus = new AylıkUcus();
            aylikUcus.MdiParent = this;
            aylikUcus.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = "aylik";

            AylıkUcus aylikUcus = new AylıkUcus();
            aylikUcus.MdiParent = this;
            aylikUcus.Show();
        }

        private void personelKursİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kursEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursIslemleri kursEkle = new KursIslemleri();
            kursEkle.MdiParent = this;
            kursEkle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void kursSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursIslemleri kursEkle = new KursIslemleri();
            kursEkle.MdiParent = this;
            kursEkle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void kursGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursIslemleri kursEkle = new KursIslemleri();
            kursEkle.MdiParent = this;
            kursEkle.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void kursKayıtTarihiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Guncelle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursIslemleri kursGuncelle = new KursIslemleri();
            kursGuncelle.MdiParent = this;
            kursGuncelle.Show();
        }

        private void kursKayıtSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Sil";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursIslemleri kursGuncelle = new KursIslemleri();
            kursGuncelle.MdiParent = this;
            kursGuncelle.Show();
        }

        private void kursKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kursİslemi = "Ekle";
            TıklanılanButon.butonAdi = string.Empty;
            TıklanılanButon.butonAdi = kursİslemi;

            KursIslemleri kursGuncelle = new KursIslemleri();
            kursGuncelle.MdiParent = this;
            kursGuncelle.Show();
        }

        private void yıllıkUçuçGrafiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafik yillikGrafik = new Grafik();
            yillikGrafik.MdiParent = this;
            yillikGrafik.Show();

            PersonelSecimi sec = new PersonelSecimi();
            sec.Name = "perSec";
            if (Application.OpenForms["perSec"] == null)
            {
                sec.MdiParent = this;
                sec.Show();
            }
            else sec.Focus();
        }

        private void yıllıkUçuşGrafiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafik yillikGrafik = new Grafik();
            yillikGrafik.MdiParent = this;
            yillikGrafik.Show();
        }
    }
    
      
}
