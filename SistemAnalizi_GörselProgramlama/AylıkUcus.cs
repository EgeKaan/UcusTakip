using Microsoft.Office.Interop.Excel;
using SistemAnalizi_GorselProgramlama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;

namespace SistemAnalizi_GörselProgramlama
{
    public partial class AylıkUcus : Form
    {
        public AylıkUcus()
        {
            InitializeComponent();
        }
        private int secilenAyKodu = 0;
        private int secilenYilKodu = 0;
        private int AyKacGun = 31;
        private int perNo = KullaniciRol.KullaniciID;
        private void AylıkUcus_Load(object sender, EventArgs e)
        {
            button1.Visible = false; lblAdSoyad.Visible = false;
            cbDonemDoldur();
            if (TıklanılanButon.butonAdi == "yillik")
            {
                label1.Visible = false; cbAylar.Visible = false;
                btnListele.Text = "Seçilen Dönemin Uçuşlarını Listele";
                button2.Text = "Dönemin Uçuşlarını İndir";
                this.Text = "Yıllık Uçuş Listesi";
            }
            if (KullaniciRol.KullaniciRolu == "Yonetici") { button1.Visible = true; lblAdSoyad.Visible = true; }
        }

        void cbDoldur()
        {
            cbAylar.Items.Clear() ;

            cbAylar.Items.Add("Ocak"); cbAylar.Items.Add("Şubat"); cbAylar.Items.Add("Mart");
            cbAylar.Items.Add("Nisan"); cbAylar.Items.Add("Mayıs"); cbAylar.Items.Add("Haziran");
            cbAylar.Items.Add("Temmuz"); cbAylar.Items.Add("Ağustos"); cbAylar.Items.Add("Eylül");
            cbAylar.Items.Add("Ekim"); cbAylar.Items.Add("Kasım"); cbAylar.Items.Add("Aralık");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {            
                if (KullaniciRol.KullaniciRolu == "Personel")
                {
                if (perNo > 0) { Sorgu(); }
                else MessageBox.Show("Lütfen personel şeçimi yapınız");
                }
                if (KullaniciRol.KullaniciRolu == "Yonetici")
                {
                if (lblAdSoyad.Text != "") { Sorgu(); }
                else MessageBox.Show("Lütfen personel şeçimi yapınız");
                }                       
        }

        private void cbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenAy = cbAylar.SelectedItem.ToString();
            switch (secilenAy)
            {
                case "Ocak": secilenAyKodu = 1; break;
                case "Şubat": secilenAyKodu = 2; AyKacGun = 28; break;
                case "Mart": secilenAyKodu = 3; break;
                case "Nisan": secilenAyKodu = 4; AyKacGun = 30; break;
                case "Mayıs": secilenAyKodu = 5; break;
                case "Haziran": secilenAyKodu = 6; AyKacGun = 30; break;
                case "Temmuz": secilenAyKodu = 7; break;
                case "Ağustos": secilenAyKodu = 8; break;
                case "Eylül": secilenAyKodu = 9; AyKacGun = 30; break;
                case "Ekim": secilenAyKodu = 10; break;
                case "Kasım": secilenAyKodu = 11; AyKacGun = 30; break;
                case "Aralık": secilenAyKodu = 12; break;
                default: secilenAyKodu = 0; break;
            }
        }

        void Sorgu()
        {
            try
            {
            UcusTakipEntities vt = new UcusTakipEntities();
                
            
            dgAylikUcus.Columns.Clear();
            dgAylikUcus.ColumnCount = 4;
            dgAylikUcus.Columns[0].Name = "Tarih";
            dgAylikUcus.Columns[1].Name = "Aracın Adı";
            dgAylikUcus.Columns[2].Name = "Uçuş Tipi";
            dgAylikUcus.Columns[3].Name = "Uçuş Süresi";


                if (TıklanılanButon.butonAdi == "aylik")
                {
                    if (secilenAyKodu == 0) MessageBox.Show("Lütfen ay seçimini kontrol ediniz.");
                    else if (secilenAyKodu > 0)
                    {
                        DateTime baslangıc = new DateTime(secilenYilKodu, secilenAyKodu, 1);
                        DateTime bitis = new DateTime(secilenYilKodu, secilenAyKodu, AyKacGun);
                        var ucusList = vt.UcusBilgileris.Where(p => p.PersonelNo == perNo & p.UcusTarihi <= bitis & p.UcusTarihi >= baslangıc).ToList();

                        if (ucusList.Count > 0)
                        {
                            foreach (var item in ucusList)
                            {
                                string tarih = string.Empty; string aracAdi = string.Empty; string ucusTip = string.Empty; string ucuSure = string.Empty;

                                if (item.UcusTarihi != null) tarih = item.UcusTarihi.Value.Date.ToString();
                                if (item.UcusDakikası != null) ucuSure = item.UcusDakikası.Value.ToString();
                                if (item.UcusTipi != null) ucusTip = item.UcusTipi.ToString();
                                int aracKoduu = item.HavaAraciNo;
                                var arac = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciNo == aracKoduu);
                                aracAdi = arac.HavaAraciAdi;

                                string[] satir = new string[]
                              {tarih,aracAdi,ucusTip,ucuSure};
                                dgAylikUcus.Rows.Add(satir);
                            }

                        }
                        else { dgAylikUcus.Columns.Clear(); MessageBox.Show(cbAylar.SelectedItem.ToString() + " ayında uçuş olmamıştır."); }
                    }
                    else MessageBox.Show("Lütfen ay seçimini kontrol ediniz.");
                }


            if (TıklanılanButon.butonAdi == "yillik")
            {
                int bas = secilenYilKodu - 1;
                DateTime baslangıc = new DateTime(bas, 9, 1);
                DateTime bitis = new DateTime(secilenYilKodu, 8, 31);
                var ucusList = vt.UcusBilgileris.Where(p => p.UcusTarihi <= bitis & p.UcusTarihi >= baslangıc & p.PersonelNo == perNo).ToList();

                if (ucusList.Count > 0)
                {
                    foreach (var item in ucusList)
                    {
                        string tarih = string.Empty; string aracAdi = string.Empty; string ucusTip = string.Empty; string ucuSure = string.Empty;
                        if (item.UcusTarihi != null) tarih = item.UcusTarihi.Value.Date.ToString();
                        if (item.UcusDakikası != null) ucuSure = item.UcusDakikası.Value.ToString();
                        if (item.UcusTipi != null) ucusTip = item.UcusTipi.ToString();
                        int aracKoduu = item.HavaAraciNo;
                        var arac = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciNo == aracKoduu);
                        aracAdi = arac.HavaAraciAdi;

                        string[] satir = new string[]
                      {tarih,aracAdi,ucusTip,ucuSure};
                        dgAylikUcus.Rows.Add(satir);
                    }
                }
                else { dgAylikUcus.Columns.Clear(); MessageBox.Show("Bu dönemde uçuş olmamıştır."); }
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Bulunamamıştır!");
            }
        }

        private void cbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilenYil = cbDonem.SelectedItem.ToString();
            switch (secilenYil)
            {
                case "2020": secilenYilKodu = 2020;  break;
                case "2019": secilenYilKodu = 2019; break;
                default: secilenYilKodu = 1; break;
            }
            if (TıklanılanButon.butonAdi == "aylik")
            {
                if (secilenYilKodu > 1) { cbDoldur(); }
                else MessageBox.Show("Lütfen dönem seçimini kontrol ediniz.");
            }

        }

        void cbDonemDoldur() { cbDonem.Items.Clear(); cbDonem.Items.Add("2020"); cbDonem.Items.Add("2019"); }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            lblAdSoyad.Text = SecilenPersonel.PerdsonelAdSoyad;
            perNo = SecilenPersonel.PersonelNo;
            if (string.IsNullOrEmpty(lblAdSoyad.Text))
            {
                MessageBox.Show("Lütfen personel seçiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelDosyasıHazirla();
        }


        //string gorev = string.Empty; string ucak = string.Empty; string heli = string.Empty; string yillik = string.Empty; string besyillik = string.Empty;
        //void TarihIslemleri()
        //{
        //    try
        //    {
        //        UcusTakipEntities vt = new UcusTakipEntities();
        //        var tarihbilgisi = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == perNo);


        //        DateTime heli1 = tarihbilgisi.HeliStanSonTarih.Value;
        //        DateTime heli2 = heli1.Date;
        //        heli = heli2.ToString("d");

        //        DateTime ucak1 = tarihbilgisi.UcakStanSonTarihi.Value;
        //        DateTime ucak2 = ucak1.Date;
        //        ucak = ucak2.ToString("d");

        //        DateTime yillik1 = tarihbilgisi.YillikSaglikSon.Value;
        //        DateTime yillik2 = yillik1.Date;
        //        yillik = yillik2.ToString("d");

        //        DateTime besyillik1 = tarihbilgisi.BesYillikSaglikSon.Value;
        //        DateTime besyillik2 = besyillik1.Date;
        //        besyillik = besyillik2.ToString("d");
        //    }
        //    catch (Exception)
        //    {
              
        //    }
            
        //}

        void ExcelDosyasıHazirla()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application exceldosya = new Excel.Application();
                exceldosya.Visible = true;
                object Missing = Type.Missing;
                Workbook wb = exceldosya.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)wb.Sheets[1];

                int sutun = 1;
                int satir = 1;

                for (int i = 0; i < dgAylikUcus.Columns.Count; i++)
                {
                    try
                    {
                        Range myrange = (Range)sheet1.Cells[satir, sutun + i];
                        myrange.Value2 = dgAylikUcus.Columns[i].HeaderText;
                    }
                    catch {; }
                }
                satir++;
                for (int i = 0; i < dgAylikUcus.Rows.Count; i++)
                {
                    for (int j = 0; j < dgAylikUcus.Columns.Count; j++)
                    {
                        try
                        {
                            Range myrange = (Range)sheet1.Cells[satir + i, sutun + j];
                            myrange.Value2 = dgAylikUcus[j, i].Value == null ? "" : dgAylikUcus[j, i].Value;
                            myrange.Select();
                        }
                        catch {; }

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //try
            //{
            //    string adSoyad = string.Empty;
            //    UcusTakipEntities vt = new UcusTakipEntities();
            //    var per = vt.Personels.FirstOrDefault(p => p.PersonelNo == perNo);
            //    adSoyad = per.Ad + " " + per.Soyad;
                
            //    var ucusbilgisi = vt.UcusBilgileris.Where(p => p.PersonelNo == perNo).ToList();
            //    TarihIslemleri();
            //    var kurs = vt.PersonelKurs.Where(p => p.PersonelNo == perNo).ToList();

            //    var perKomutan = vt.PersonelKomutanı.Where(p => p.PersonelNo == perNo).ToList();
            //    string komutan = string.Empty;  string kunvan = string.Empty; string hunvan = string.Empty; string harekatSB = string.Empty;
            //    string hrutbe = string.Empty; string krutbe = string.Empty;
            //    if (perKomutan.Count > 0)
            //    {
            //        foreach (var item in perKomutan)
            //        {
            //            var komutans = vt.HarekatSB_Komutan.FirstOrDefault(p => p.KisiID == item.KisiID);
            //            if (komutans.KisiUnvani == "KOMUTAN")
            //            {
            //                komutan = komutans.KisiAdi + " " + komutans.KisiSoyadi;
            //                kunvan = komutans.KisiUnvani;
            //                krutbe = komutans.KisiRutbesi;
            //            }

            //            if (komutans.KisiUnvani == "HAREKAT SUBAYI")
            //            {
            //                harekatSB = komutans.KisiAdi + " " + komutans.KisiSoyadi;
            //                hunvan = komutans.KisiUnvani;
            //                hrutbe = komutans.KisiRutbesi;
            //            }
            //        }
            //    }

            //    Font myFont = new Font("Calibri", 28);
            //    Font ince = new Font("Calibri", 11, FontStyle.Bold);
            //    SolidBrush sbrush = new SolidBrush(Color.Black);
            //    Pen myPen = new Pen(Color.Black);

                
            //    e.Graphics.DrawString(" Kişisel Uçuş Takip Belgesi", myFont, sbrush, 200, 35);

            //    e.Graphics.DrawLine(myPen, 40, 100, 800, 100);

            //    myFont = new Font("Calibri", 12, FontStyle.Bold);
            //    e.Graphics.DrawString("ADI SOYADI", myFont, sbrush, 50 , 110);

            //    e.Graphics.DrawLine(myPen, 200, 100, 200, 300);

            //    e.Graphics.DrawString("SİCİL NUMARASI", myFont, sbrush, 250 , 110);

            //    e.Graphics.DrawLine(myPen, 450, 100, 450, 300);

            //    e.Graphics.DrawString("RÜTBESİ", myFont, sbrush, 500, 110);

            //    e.Graphics.DrawLine(myPen, 650, 100, 650, 300);

            //    e.Graphics.DrawString("YIL", myFont, sbrush, 700, 110);

            //    e.Graphics.DrawLine(myPen, 40, 140, 800, 140);

            //    e.Graphics.DrawString(adSoyad, myFont, sbrush, 50, 150);
            //    e.Graphics.DrawString(per.SicilNo.ToString(), myFont, sbrush, 260, 150);
            //    e.Graphics.DrawString(per.SinifRutbesi, myFont, sbrush, 500, 150);
            //    e.Graphics.DrawString(secilenYilKodu.ToString(), myFont, sbrush, 700, 150);

            //    e.Graphics.DrawLine(myPen, 40, 180, 800, 180);

            //    e.Graphics.DrawString("GÖREV DURUMU", myFont, sbrush, 50, 190);
            //    e.Graphics.DrawString("STAND KONTROL TARİHİ", myFont, sbrush, 245, 190);
            //    e.Graphics.DrawString("SAĞ.MUA. TARİHİ", myFont, sbrush, 495, 190);
            //    e.Graphics.DrawString("UZMANLIK KURSU", myFont, sbrush, 660, 190);

            //    e.Graphics.DrawLine(myPen, 40, 220, 800, 220);

            //    e.Graphics.DrawString("Kıt'a", myFont, sbrush, 50, 230);
            //    e.Graphics.DrawString("Kurum/Kh.", myFont, sbrush, 110, 230);
            //    e.Graphics.DrawString("UÇAK", myFont, sbrush, 250, 230);
            //    e.Graphics.DrawString("HELİKOPTER", myFont, sbrush, 320, 230);
            //    e.Graphics.DrawString("Yıllık", myFont, sbrush, 495, 230);
            //    e.Graphics.DrawString("Beş Yıllık", myFont, sbrush, 560, 230);

            //    e.Graphics.DrawLine(myPen, 40, 260, 800, 260);

                
            //    e.Graphics.DrawString("MOTOR", ince, sbrush, 700, 230);
            //    if (per.GorevDurumu == "Kıt'a") e.Graphics.DrawString("X", ince, sbrush, 55, 270);
            //    if (per.GorevDurumu == "Kurum/Kh.") e.Graphics.DrawString("X", ince, sbrush, 110, 270);
            //    e.Graphics.DrawString(ucak, ince, sbrush, 235, 270);
            //    e.Graphics.DrawString(heli, ince, sbrush, 320, 270);
            //    e.Graphics.DrawString(yillik, ince, sbrush, 485, 270);
            //    e.Graphics.DrawString(besyillik, ince, sbrush, 560, 270);

            //    e.Graphics.DrawLine(myPen, 40, 300, 800, 300);

            //    e.Graphics.DrawString("TARİH", myFont, sbrush, 50, 310);
            //    e.Graphics.DrawString("ARACIN TÜRÜ", myFont, sbrush, 150, 310);
            //    e.Graphics.DrawString("ARACIN ADI", myFont, sbrush, 300, 310);
            //    e.Graphics.DrawString("UÇUŞ TİPİ", myFont, sbrush, 500, 310);
            //    e.Graphics.DrawString("UÇUŞ SÜRESİ", myFont, sbrush, 685, 310);

            //    e.Graphics.DrawLine(myPen, 40, 340, 800, 340);






            //    int y_yazi = 350;
            //    int y_cizgi = 380;

            //    foreach (var item in ucusbilgisi)
            //    {
            //        string tarih = string.Empty; string aracAdi = string.Empty; string ucusTip = string.Empty; string ucuSure = string.Empty; string aracinTipi = string.Empty;
            //        if (item.UcusTarihi != null)
            //        {
            //            DateTime ucustarihi = item.UcusTarihi.Value;
            //            DateTime tarih1 = ucustarihi.Date;
            //            tarih = tarih1.ToString("d");
            //        }
            //        if (item.UcusDakikası != null) ucuSure = item.UcusDakikası.Value.ToString();
            //        if (item.UcusTipi != null) ucusTip = item.UcusTipi.ToString();
            //        int aracKoduu = item.HavaAraciNo;
            //        var arac = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciNo == aracKoduu);
            //        aracAdi = arac.HavaAraciAdi;
            //        aracinTipi = arac.HavaAraciTipi;

            //        e.Graphics.DrawString(tarih, ince, sbrush, 50, y_yazi);
            //        e.Graphics.DrawString(aracinTipi, ince, sbrush, 160, y_yazi);
            //        e.Graphics.DrawString(aracAdi, ince, sbrush, 320, y_yazi);
            //        e.Graphics.DrawString(ucusTip, ince, sbrush, 430, y_yazi);
            //        e.Graphics.DrawString(ucuSure, ince, sbrush, 715, y_yazi);

            //        e.Graphics.DrawLine(myPen, 40, y_cizgi, 800, y_cizgi);

            //        y_yazi = y_yazi + 40;
            //        y_cizgi = y_cizgi + 40;

            //        if (y_cizgi == 1000)
            //        {
            //            ucusbilgisi.Clear();
            //        }

            //    }
                
            //    e.Graphics.DrawLine(myPen, 140, 300, 140, y_cizgi - 40);
            //    e.Graphics.DrawLine(myPen, 260, 300, 260, y_cizgi - 40);
            //    e.Graphics.DrawLine(myPen, 410, 300, 410, y_cizgi - 40);
            //    e.Graphics.DrawLine(myPen, 670, 300, 670, y_cizgi - 40);


            //    e.Graphics.DrawLine(myPen, 40, 1000, 800, 1000);

            //    e.Graphics.DrawString("PERSONEL", myFont, sbrush, 110, 1010);
            //    e.Graphics.DrawString("KOMUTAN", myFont, sbrush, 350, 1010);
            //    e.Graphics.DrawString("HAREKAT SUBAYI", myFont, sbrush, 540, 1010);


            //    e.Graphics.DrawLine(myPen, 40, 1040, 800, 1040);

            //    e.Graphics.DrawString(adSoyad, myFont, sbrush, 100, 1050);
            //    e.Graphics.DrawString(per.SinifRutbesi, myFont, sbrush, 120, 1080);

            //    if (string.IsNullOrEmpty(komutan)) { }
            //    else
            //    {
            //        e.Graphics.DrawString(komutan, myFont, sbrush, 340, 1050);
            //        e.Graphics.DrawString(krutbe, myFont, sbrush, 320, 1080);
            //        e.Graphics.DrawString(kunvan, myFont, sbrush, 400, 1080);       
            //    }

            //    if (string.IsNullOrEmpty(harekatSB)) { }
            //    else
            //    {
            //        e.Graphics.DrawString(harekatSB, myFont, sbrush, 540, 1050);
            //        e.Graphics.DrawString(hrutbe, myFont, sbrush, 500, 1080);
            //        e.Graphics.DrawString(hunvan, myFont, sbrush, 650, 1080);
            //    }

            //    e.Graphics.DrawLine(myPen, 40, 1120, 800, 1120);



            //    StringFormat myStringFormat = new StringFormat();
            //    myStringFormat.Alignment = StringAlignment.Far;
   

            //}
            //catch (Exception)
            //{

            //}
        }
    }
}
