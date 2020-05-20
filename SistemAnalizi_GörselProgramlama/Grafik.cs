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

namespace SistemAnalizi_GörselProgramlama
{
    public partial class Grafik : Form
    {
        private int perNo,ocak,subat,mart,nisan,mayis,haziran,temmuz,agustos,eylul,ekim,kasim,aralik, secilenYilKodu;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string secilenYil = comboBox1.SelectedItem.ToString();
                if (string.IsNullOrEmpty(secilenYil)) { MessageBox.Show("Lütfen Dönem Seçiniz."); }
                else GrafikOlustur();
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {
                
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenYil = comboBox1.SelectedItem.ToString();
            switch (secilenYil)
            {
                case "2020": secilenYilKodu = 2020; break;
                case "2019": secilenYilKodu = 2019; break;
                default: secilenYilKodu = 1; break;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string adSoyad = string.Empty;
                UcusTakipEntities vt = new UcusTakipEntities();
                var per = vt.Personels.FirstOrDefault(p => p.PersonelNo == perNo);
                adSoyad = per.Ad + " " + per.Soyad;

                var ucusbilgisi = vt.UcusBilgileris.Where(p => p.PersonelNo == perNo).ToList();
                TarihIslemleri();
                var kurs = vt.PersonelKurs.Where(p => p.PersonelNo == perNo).ToList();

                var perKomutan = vt.PersonelKomutanı.Where(p => p.PersonelNo == perNo).ToList();
                string komutan = string.Empty; string kunvan = string.Empty; string hunvan = string.Empty; string harekatSB = string.Empty;
                string hrutbe = string.Empty; string krutbe = string.Empty;
                if (perKomutan.Count > 0)
                {
                    foreach (var item in perKomutan)
                    {
                        var komutans = vt.HarekatSB_Komutan.FirstOrDefault(p => p.KisiID == item.KisiID);
                        if (komutans.KisiUnvani == "KOMUTAN")
                        {
                            komutan = komutans.KisiAdi + " " + komutans.KisiSoyadi;
                            kunvan = komutans.KisiUnvani;
                            krutbe = komutans.KisiRutbesi;
                        }

                        if (komutans.KisiUnvani == "HAREKAT SUBAYI")
                        {
                            harekatSB = komutans.KisiAdi + " " + komutans.KisiSoyadi;
                            hunvan = komutans.KisiUnvani;
                            hrutbe = komutans.KisiRutbesi;
                        }
                    }
                }

                Font myFont = new Font("Calibri", 28);
                Font ince = new Font("Calibri", 11, FontStyle.Bold);
                SolidBrush sbrush = new SolidBrush(Color.Black);
                Pen myPen = new Pen(Color.Black);


                e.Graphics.DrawString(" Kişisel Uçuş Takip Belgesi", myFont, sbrush, 200, 35);

                e.Graphics.DrawLine(myPen, 40, 100, 800, 100);

                myFont = new Font("Calibri", 12, FontStyle.Bold);
                e.Graphics.DrawString("ADI SOYADI", myFont, sbrush, 50, 110);

                e.Graphics.DrawLine(myPen, 200, 100, 200, 300);

                e.Graphics.DrawString("SİCİL NUMARASI", myFont, sbrush, 250, 110);

                e.Graphics.DrawLine(myPen, 450, 100, 450, 300);

                e.Graphics.DrawString("RÜTBESİ", myFont, sbrush, 500, 110);

                e.Graphics.DrawLine(myPen, 650, 100, 650, 300);

                e.Graphics.DrawString("YIL", myFont, sbrush, 700, 110);

                e.Graphics.DrawLine(myPen, 40, 140, 800, 140);

                e.Graphics.DrawString(adSoyad, myFont, sbrush, 50, 150);
                e.Graphics.DrawString(per.SicilNo.ToString(), myFont, sbrush, 260, 150);
                e.Graphics.DrawString(per.SinifRutbesi, myFont, sbrush, 500, 150);
                e.Graphics.DrawString(secilenYilKodu.ToString(), myFont, sbrush, 700, 150);

                e.Graphics.DrawLine(myPen, 40, 180, 800, 180);

                e.Graphics.DrawString("GÖREV DURUMU", myFont, sbrush, 50, 190);
                e.Graphics.DrawString("STAND KONTROL TARİHİ", myFont, sbrush, 245, 190);
                e.Graphics.DrawString("SAĞ.MUA. TARİHİ", myFont, sbrush, 495, 190);
                e.Graphics.DrawString("UZMANLIK KURSU", myFont, sbrush, 660, 190);

                e.Graphics.DrawLine(myPen, 40, 220, 800, 220);

                e.Graphics.DrawString("Kıt'a", myFont, sbrush, 50, 230);
                e.Graphics.DrawString("Kurum/Kh.", myFont, sbrush, 110, 230);
                e.Graphics.DrawString("UÇAK", myFont, sbrush, 250, 230);
                e.Graphics.DrawString("HELİKOPTER", myFont, sbrush, 320, 230);
                e.Graphics.DrawString("Yıllık", myFont, sbrush, 495, 230);
                e.Graphics.DrawString("Beş Yıllık", myFont, sbrush, 560, 230);

                e.Graphics.DrawLine(myPen, 40, 260, 800, 260);


                e.Graphics.DrawString("MOTOR", ince, sbrush, 700, 230);
                if (per.GorevDurumu == "Kıt'a") e.Graphics.DrawString("X", ince, sbrush, 55, 270);
                if (per.GorevDurumu == "Kurum/Kh.") e.Graphics.DrawString("X", ince, sbrush, 110, 270);
                e.Graphics.DrawString(ucak, ince, sbrush, 235, 270);
                e.Graphics.DrawString(heli, ince, sbrush, 320, 270);
                e.Graphics.DrawString(yillik, ince, sbrush, 485, 270);
                e.Graphics.DrawString(besyillik, ince, sbrush, 560, 270);

                e.Graphics.DrawLine(myPen, 40, 300, 800, 300);

                e.Graphics.DrawString("TARİH", myFont, sbrush, 50, 310);
                e.Graphics.DrawString("ARACIN TÜRÜ", myFont, sbrush, 150, 310);
                e.Graphics.DrawString("ARACIN ADI", myFont, sbrush, 300, 310);
                e.Graphics.DrawString("UÇUŞ TİPİ", myFont, sbrush, 500, 310);
                e.Graphics.DrawString("UÇUŞ SÜRESİ", myFont, sbrush, 685, 310);

                e.Graphics.DrawLine(myPen, 40, 340, 800, 340);

                

                int y_yazi = 350;
                int y_cizgi = 380;

                foreach (var item in ucusbilgisi)
                {
                    string tarih = string.Empty; string aracAdi = string.Empty; string ucusTip = string.Empty; string ucuSure = string.Empty; string aracinTipi = string.Empty;
                    if (item.UcusTarihi != null)
                    {
                        DateTime ucustarihi = item.UcusTarihi.Value;
                        DateTime tarih1 = ucustarihi.Date;
                        tarih = tarih1.ToString("d");
                    }
                    if (item.UcusDakikası != null) ucuSure = item.UcusDakikası.Value.ToString();
                    if (item.UcusTipi != null) ucusTip = item.UcusTipi.ToString();
                    int aracKoduu = item.HavaAraciNo;
                    var arac = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciNo == aracKoduu);
                    aracAdi = arac.HavaAraciAdi;
                    aracinTipi = arac.HavaAraciTipi;

                    e.Graphics.DrawString(tarih, ince, sbrush, 50, y_yazi);
                    e.Graphics.DrawString(aracinTipi, ince, sbrush, 160, y_yazi);
                    e.Graphics.DrawString(aracAdi, ince, sbrush, 320, y_yazi);
                    e.Graphics.DrawString(ucusTip, ince, sbrush, 430, y_yazi);
                    e.Graphics.DrawString(ucuSure, ince, sbrush, 715, y_yazi);

                    e.Graphics.DrawLine(myPen, 40, y_cizgi, 800, y_cizgi);

                    y_yazi = y_yazi + 40;
                    y_cizgi = y_cizgi + 40;

                    if (y_cizgi == 1000)
                    {
                        ucusbilgisi.Clear();
                    }

                }

                e.Graphics.DrawLine(myPen, 140, 300, 140, y_cizgi - 40);
                e.Graphics.DrawLine(myPen, 260, 300, 260, y_cizgi - 40);
                e.Graphics.DrawLine(myPen, 410, 300, 410, y_cizgi - 40);
                e.Graphics.DrawLine(myPen, 670, 300, 670, y_cizgi - 40);


                e.Graphics.DrawLine(myPen, 40, 1000, 800, 1000);

                e.Graphics.DrawString("PERSONEL", myFont, sbrush, 110, 1010);
                e.Graphics.DrawString("KOMUTAN", myFont, sbrush, 350, 1010);
                e.Graphics.DrawString("HAREKAT SUBAYI", myFont, sbrush, 540, 1010);


                e.Graphics.DrawLine(myPen, 40, 1040, 800, 1040);

                e.Graphics.DrawString(adSoyad, myFont, sbrush, 100, 1050);
                e.Graphics.DrawString(per.SinifRutbesi, myFont, sbrush, 120, 1080);

                if (string.IsNullOrEmpty(komutan)) { }
                else
                {
                    e.Graphics.DrawString(komutan, myFont, sbrush, 340, 1050);
                    e.Graphics.DrawString(krutbe, myFont, sbrush, 320, 1080);
                    e.Graphics.DrawString(kunvan, myFont, sbrush, 400, 1080);
                }

                if (string.IsNullOrEmpty(harekatSB)) { }
                else
                {
                    e.Graphics.DrawString(harekatSB, myFont, sbrush, 540, 1050);
                    e.Graphics.DrawString(hrutbe, myFont, sbrush, 500, 1080);
                    e.Graphics.DrawString(hunvan, myFont, sbrush, 650, 1080);
                }

                e.Graphics.DrawLine(myPen, 40, 1120, 800, 1120);



                StringFormat myStringFormat = new StringFormat();
                myStringFormat.Alignment = StringAlignment.Far;


            }
            catch (Exception)
            {

            }
        }

        UcusTakipEntities vt = new UcusTakipEntities();
        public Grafik()
        {
            InitializeComponent();
        }

        private void btnPerSecim_Click(object sender, EventArgs e)
        {
          
            lblpersonel.Text = SecilenPersonel.PerdsonelAdSoyad;
            perNo = SecilenPersonel.PersonelNo;
            if (string.IsNullOrEmpty(lblpersonel.Text))
            {
                MessageBox.Show("Lütfen personel seçiniz.");
            }
            else
            {
                GrafikOlustur();
            }
            
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); comboBox1.Items.Add("2020"); comboBox1.Items.Add("2019");

            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                perNo = KullaniciRol.KullaniciID;
                lblpersonel.Visible = true;
                btnPerSecim.Visible = true;
                var per = vt.Personels.FirstOrDefault(p => p.PersonelNo == perNo);
                lblpersonel.Text = per.Ad.Trim() + " " + per.Soyad.Trim();
                
            }

        }

        void ToplamUcus()
        {
            var ucuslar = vt.UcusBilgileris.Where(p => p.PersonelNo == perNo && p.UcusTarihi.Value.Year == secilenYilKodu).ToList();

            foreach (var ucus in ucuslar)
            {
                DateTime tarih = ucus.UcusTarihi.Value;
                int ay = tarih.Month;
                switch (ay)
                {
                    case 1: ocak = ocak + ucus.UcusDakikası.Value; break;
                    case 2: subat = subat + ucus.UcusDakikası.Value; break;
                    case 3: mart = mart + ucus.UcusDakikası.Value; break;
                    case 4: nisan = nisan + ucus.UcusDakikası.Value; break;
                    case 5: mayis = mayis + ucus.UcusDakikası.Value; break;
                    case 6: haziran = haziran + ucus.UcusDakikası.Value; break;
                    case 7: temmuz = temmuz + ucus.UcusDakikası.Value; break;
                    case 8: agustos = agustos + ucus.UcusDakikası.Value; break;
                    case 9: eylul = eylul + ucus.UcusDakikası.Value; break;
                    case 10: ekim = ekim + ucus.UcusDakikası.Value; break;
                    case 11: kasim = kasim + ucus.UcusDakikası.Value; break;
                    case 12: aralik = aralik + ucus.UcusDakikası.Value; break;
                    default: break;
                }
            }
        }

        void GrafikOlustur()
        {
            Temizle();
            ToplamUcus();

            chart1.Series["Uçuş Dakikası"].Points.Add(ocak);
            chart1.Series["Uçuş Dakikası"].Points.Add(subat);
            chart1.Series["Uçuş Dakikası"].Points.Add(mart);
            chart1.Series["Uçuş Dakikası"].Points.Add(nisan);
            chart1.Series["Uçuş Dakikası"].Points.Add(mayis);
            chart1.Series["Uçuş Dakikası"].Points.Add(haziran);
            chart1.Series["Uçuş Dakikası"].Points.Add(temmuz);
            chart1.Series["Uçuş Dakikası"].Points.Add(agustos);
            chart1.Series["Uçuş Dakikası"].Points.Add(eylul);
            chart1.Series["Uçuş Dakikası"].Points.Add(ekim);
            chart1.Series["Uçuş Dakikası"].Points.Add(kasim);
            chart1.Series["Uçuş Dakikası"].Points.Add(aralik);


            chart1.Series["Uçuş Dakikası"].Points[0].AxisLabel = "Ocak";
            chart1.Series["Uçuş Dakikası"].Points[1].AxisLabel = "Şubat";
            chart1.Series["Uçuş Dakikası"].Points[2].AxisLabel = "Mart";
            chart1.Series["Uçuş Dakikası"].Points[3].AxisLabel = "Nisan";
            chart1.Series["Uçuş Dakikası"].Points[4].AxisLabel = "Mayıs";
            chart1.Series["Uçuş Dakikası"].Points[5].AxisLabel = "Haziran";
            chart1.Series["Uçuş Dakikası"].Points[6].AxisLabel = "Ağustos";
            chart1.Series["Uçuş Dakikası"].Points[7].AxisLabel = "Temmuz";
            chart1.Series["Uçuş Dakikası"].Points[8].AxisLabel = "Eylül";
            chart1.Series["Uçuş Dakikası"].Points[9].AxisLabel = "Ekim";
            chart1.Series["Uçuş Dakikası"].Points[10].AxisLabel = "Kasım";
            chart1.Series["Uçuş Dakikası"].Points[11].AxisLabel = "Aralık";

            for (int i = 0; i < 12; i++)
            {
                chart1.Series["Uçuş Dakikası"].Points[i].Color = Color.RoyalBlue;
            }

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
        }

        public void Temizle()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            ocak = 0;subat = 0;mart = 0;nisan = 0; mayis = 0; haziran = 0;
            temmuz = 0; agustos = 0; eylul = 0; ekim = 0; kasim = 0; aralik = 0;
        }


        string gorev = string.Empty; string ucak = string.Empty; string heli = string.Empty; string yillik = string.Empty; string besyillik = string.Empty;
        void TarihIslemleri()
        {
            try
            {
                var tarihbilgisi = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == perNo);


                DateTime heli1 = tarihbilgisi.HeliStanSonTarih.Value;
                DateTime heli2 = heli1.Date;
                heli = heli2.ToString("d");

                DateTime ucak1 = tarihbilgisi.UcakStanSonTarihi.Value;
                DateTime ucak2 = ucak1.Date;
                ucak = ucak2.ToString("d");

                DateTime yillik1 = tarihbilgisi.YillikSaglikSon.Value;
                DateTime yillik2 = yillik1.Date;
                yillik = yillik2.ToString("d");

                DateTime besyillik1 = tarihbilgisi.BesYillikSaglikSon.Value;
                DateTime besyillik2 = besyillik1.Date;
                besyillik = besyillik2.ToString("d");
            }
            catch (Exception)
            {

            }

        }
    }
}
