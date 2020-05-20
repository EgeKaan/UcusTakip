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
    public partial class PersonelleriListele : Form
    {
        public PersonelleriListele()
        {
            InitializeComponent();
        }

        private int perNo = KullaniciRol.KullaniciID;
        private void PersonelleriListele_Load(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();

            if (TıklanılanButon.butonAdi_2 == "ButunPersoneller")
            {
                dataGridView1.DataSource = vt.Personels.ToList();
                dgTemizle();
                this.Text = "Personel Listesi";
            }

            if (TıklanılanButon.butonAdi_2 == "KendiBilgileri")
            {
                var list = vt.Personels.Where(p => p.PersonelNo == perNo).ToList();
                dataGridView1.DataSource = list;
                dgTemizle();
                this.Text = "Bilgilerim";
            }

            if (TıklanılanButon.butonAdi_2 == "yetkiliAracListem") YetkiliAracListesi();
            if (TıklanılanButon.butonAdi_2 == "havaAraclariListele") HavaAraclariListele();
            if (TıklanılanButon.butonAdi_2 == "kurslariListele") KurslariListele();
            if (TıklanılanButon.butonAdi_2 == "komutanlariListele") KomutanlariListele();
            if (TıklanılanButon.butonAdi_2 == "harekatSubaylariListele") HarekatSubayListele();
            if (TıklanılanButon.butonAdi_2 == "yillikToplamUcus") YillikToplamUcusLarim();
            if (TıklanılanButon.butonAdi_2 == "kullanicilariListele") KullanicilariListele();
        }

        void YetkiliAracListesi()
        {
            //dataGridView1.DataSource = vt.PersonelAracYetkis.Where(p => p.PersonelNo == perNo).ToList();
            //dataGridView1.Columns["HavaAracları"].Visible = false;
            //dataGridView1.Columns["Personel"].Visible = false;
            //dataGridView1.Columns["PersonelAracYetkiID"].Visible = false;
            //dataGridView1.Columns["Personel"].Visible = false;
            //dataGridView1.Columns["Personel"].Visible = false;

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Aracın Adı";
            dataGridView1.Columns[1].Name = "Uçuş Süresi(dk)";
            UcusTakipEntities vt = new UcusTakipEntities();
            var yetki = vt.PersonelAracYetkis.Where(p => p.PersonelNo == perNo && p.YetkisiVar == true).ToList();
            var havaAraci = vt.HavaAracları.ToList();
            foreach (var item in yetki)
            {
                string id = item.PersonelAracYetkiID.ToString();
                string ucusSuresi = item.AracToplamUcusSuresi.ToString();
                string aracAdi;
                foreach (var i in havaAraci)
                {
                    if (i.HavaAraciNo == item.HavaAraciNo)
                    {
                        aracAdi = i.HavaAraciAdi;
                        string[] satir = new string[]
                            { aracAdi,ucusSuresi};
                        dataGridView1.Rows.Add(satir);

                    }
                }
            }
            this.Text = "Yetkili Arac Listesi";
        }

        void HavaAraclariListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dataGridView1.DataSource = vt.HavaAracları.ToList();
            dataGridView1.Columns["PersonelAracYetkis"].Visible = false;
            dataGridView1.Columns["UcusBilgileris"].Visible = false;
            this.Text = "Hava Araç Listesi";
        }
        void KurslariListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dataGridView1.DataSource = vt.Kurs.ToList();
            dataGridView1.Columns["PersonelKurs"].Visible = false;
            this.Text = "Kurs Listesi";
        }

        void KomutanlariListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dataGridView1.DataSource = vt.HarekatSB_Komutan.Where(p => p.KisiUnvani == "KOMUTAN").ToList() ;
            dataGridView1.Columns["PersonelKomutanı"].Visible = false;
            this.Text = "Komutan Listesi";
        }
        void HarekatSubayListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dataGridView1.DataSource = vt.HarekatSB_Komutan.Where(p => p.KisiUnvani == "HAREKAT SUBAYI").ToList();
            dataGridView1.Columns["PersonelKomutanı"].Visible = false;
            this.Text = "Harekat Subay Listesi";
        }

        void YillikToplamUcusLarim()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            DateTime simdi = DateTime.Today;
            DateTime yearsAgo = simdi.AddYears(-1);
            dataGridView1.DataSource = vt.UcusBilgileris.Where(p => p.UcusTarihi > yearsAgo ).ToList();
            dataGridView1.Columns["HavaAracları"].Visible = false;
            dataGridView1.Columns["Personel"].Visible = false;
            this.Text = "Yıllık Toplam Uçuş Listesi";
        }

        void KullanicilariListele()
        {
            int kullaniciID, personelID, rolNo;

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Kullanıcı ID";
            dataGridView1.Columns[1].Name = "Rol";
            dataGridView1.Columns[2].Name = "Ad Soyad";
            dataGridView1.Columns[3].Name = "Kullanıcı Adı";
            dataGridView1.Columns[4].Name = "Şifre";

            string kullaniciAdi, sifre, ad, soyad;
            UcusTakipEntities vt = new UcusTakipEntities();
            var perList = vt.Personels.ToList();
            foreach (var item in perList)
            {
                personelID = item.PersonelNo;
                ad = item.Ad;
                soyad = item.Soyad;
                string kayitYok = string.Empty;
                var kullaniciList = vt.Kullanicis.FirstOrDefault(p => p.PersonelID == personelID);
                if (kullaniciList != null)
                {
                    kullaniciID = kullaniciList.KullanıcıID;
                    rolNo = kullaniciList.RolID;
                    string kulID = kullaniciID.ToString();
                    string rolID = string.Empty;
                    if (rolNo == 1) rolID = "Yönetici";
                    if (rolNo == 2) rolID = "Personel";
                    kullaniciAdi = kullaniciList.KullaniciAdi;
                    sifre = kullaniciList.Sifre;
                    string[] satir = new string[]
                           { kulID,rolID,ad+" "+soyad,kullaniciAdi,sifre};
                    dataGridView1.Rows.Add(satir);
                }
                if (kullaniciList == null)
                {
                    string[] deneme = new string[]
                        {kayitYok,kayitYok, ad + " " + soyad,kayitYok,kayitYok };
                    dataGridView1.Rows.Add(deneme);
                }
            }
            this.Text = "Kullanıcı Listesi";
        }

        void dgTemizle()
        {
            dataGridView1.Columns["Kullanicis"].Visible = false;
            dataGridView1.Columns["PersonelAracYetkis"].Visible = false;
            dataGridView1.Columns["PersonelKurs"].Visible = false;
            dataGridView1.Columns["PersonelKomutanı"].Visible = false;
            dataGridView1.Columns["Tarihs"].Visible = false;
            dataGridView1.Columns["UcusBilgileris"].Visible = false;
        }
    }

}
