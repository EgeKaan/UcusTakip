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
    public partial class UcusIslemleri : Form
    {
        public UcusIslemleri()
        {
            InitializeComponent();
        }

        private int perNo = 0;
        private int aracKodu = 0;
        private string aracTuru = string.Empty;
        private void UcusIslemleri_Load(object sender, EventArgs e)
        {

            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                perNo = KullaniciRol.KullaniciID;
                lblAdSoyad.Visible = false;
                btnPerSec.Visible = false;
                TumKayitleriListele();
            }
            
        }
        
          string tarih = string.Empty; string aracAdi = string.Empty; string ucustipi = string.Empty; string ucuSure = string.Empty; string ucusno=string.Empty;
        void TumKayitleriListele()
        {
            dgUcus.Columns.Clear();
            dgUcus.ColumnCount = 5;
            dgUcus.Columns[0].Name = "Uçuş No";
            dgUcus.Columns[1].Name = "Tarih";
            dgUcus.Columns[2].Name = "Aracın Adı";
            dgUcus.Columns[3].Name = "Uçuş Tipi";
            dgUcus.Columns[4].Name = "Uçuş Süresi";
   

            UcusTakipEntities vt = new UcusTakipEntities();
            var ucusList = vt.UcusBilgileris.Where(p => p.PersonelNo == perNo).ToList();
            if(ucusList!=null)
            {
                foreach (var item in ucusList)
                {
                    tarih = string.Empty;
                    ucustipi = string.Empty;
                    ucuSure = string.Empty;
                    aracAdi = string.Empty;
                    ucusno = string.Empty;

                    ucusno = item.UcusNo.ToString();
                    if (item.UcusTarihi != null) tarih = item.UcusTarihi.Value.Date.ToString();
                    if (item.UcusTipi != null) ucustipi = item.UcusTipi.ToString();
                    if (item.UcusDakikası != null) ucuSure = item.UcusDakikası.ToString();
                    int aracKod = item.HavaAraciNo;

                    var list = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciNo == aracKod);
                    aracAdi = list.HavaAraciAdi;
                    string[] satir = new string[]
                          {ucusno,tarih,aracAdi,ucustipi,ucuSure};
                    dgUcus.Rows.Add(satir);
                }
            }
        }

        private void cbAracTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbAracAdi.Items.Clear();
                string secilenTur = cbAracTuru.SelectedItem.ToString();
                UcusTakipEntities vt = new UcusTakipEntities();
                if (secilenTur == "Helikopter")
                {
                    aracTuru = "Helikopter";
                    var perYetki = vt.PersonelAracYetkis.Where(p => p.PersonelNo == perNo & p.YetkisiVar == true).ToList();

                    foreach (var item in perYetki)
                    {
                        var heli = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciTipi == "Helikopter" & p.HavaAraciNo == item.HavaAraciNo);
                        if(heli!=null) cbAracAdi.Items.Add(heli.HavaAraciAdi);
                    }
                }

                if (secilenTur == "Uçak")
                {
                    aracTuru = "Uçak";
                    var perYetki = vt.PersonelAracYetkis.Where(p => p.PersonelNo == perNo & p.YetkisiVar == true).ToList();

                    foreach (var item in perYetki)
                    {
                        var ucak = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciTipi == "Uçak" & p.HavaAraciNo == item.HavaAraciNo);
                        if (ucak != null) cbAracAdi.Items.Add(ucak.HavaAraciAdi);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen hava arac yetkilerini kontrol ediniz.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                UcusBilgileri u = new UcusBilgileri();
                u.PersonelNo = perNo;
                u.HavaAraciNo = aracKodu;
                if (dtTarih.Value != null)
                {
                    var tarih = dtTarih.Value.Date;
                    u.UcusTarihi = tarih.Date;
                }
                if (cbUcusTipi.SelectedItem != null) u.UcusTipi = cbUcusTipi.SelectedItem.ToString();
                if (txtUcusSuresi.Text != "") u.UcusDakikası = Convert.ToInt32(txtUcusSuresi.Text.Trim());

                UcusTakipEntities vt = new UcusTakipEntities();
                vt.UcusBilgileris.Add(u);

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    TumKayitleriListele();
                    printPreviewDialog1.ShowDialog();
                    AlanlariTemizle();
                }
                else MessageBox.Show("Kayıt Başarısız");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen araç türü ve araç adı seçimini kontrol ediniz.");
            }

        }

        void AlanlariTemizle()
        {
            lblUcusNo.Text = string.Empty;
            txtUcusSuresi.Text = string.Empty;
            cbAracAdi.Items.Clear();
            dtTarih.Value = DateTime.Now;
        }

        private void btnPerSec_Click(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            lblAdSoyad.Text = SecilenPersonel.PerdsonelAdSoyad;
            perNo = SecilenPersonel.PersonelNo;
            if (string.IsNullOrEmpty(lblAdSoyad.Text))
            {
                MessageBox.Show("Lütfen personel seçiniz.");
            }
            else
            {
                TumKayitleriListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                string adSoyad = string.Empty;
                if (KullaniciRol.KullaniciRolu == "Yonetici") adSoyad = lblAdSoyad.Text;
                if (KullaniciRol.KullaniciRolu == "Personel")
                {
                    UcusTakipEntities vt = new UcusTakipEntities();
                    var per = vt.Personels.FirstOrDefault(p => p.PersonelNo == perNo);
                    adSoyad = per.Ad + " " + per.Soyad;
                }

                Font myFont = new Font("Calibri", 28);
                SolidBrush sbrush = new SolidBrush(Color.Black);
                Pen myPen = new Pen(Color.Black);


                //e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
                //e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
                e.Graphics.DrawString(" Uçuş Bilgi Fişi", myFont, sbrush, 300, 120);

                e.Graphics.DrawLine(myPen, 120, 300, 750, 300);

                myFont = new Font("Calibri", 12, FontStyle.Bold);
                e.Graphics.DrawLine(myPen, 120, 220, 750, 220);
                e.Graphics.DrawString("Ad Soyad", myFont, sbrush, 140, 250);

                e.Graphics.DrawString("Tarih", myFont, sbrush, 140, 320);
                e.Graphics.DrawLine(myPen, 120, 350, 750, 350);
                e.Graphics.DrawString("Araç Tipi", myFont, sbrush, 140, 360);
                e.Graphics.DrawLine(myPen, 120, 390, 750, 390);
                e.Graphics.DrawString("Araç Adı", myFont, sbrush, 140, 400);
                e.Graphics.DrawLine(myPen, 120, 430, 750, 430);
                e.Graphics.DrawString("Uçuş Tipi", myFont, sbrush, 140, 440);
                e.Graphics.DrawLine(myPen, 120, 470, 750, 470);
                e.Graphics.DrawString("Uçuş Süresi", myFont, sbrush, 140, 480);
                e.Graphics.DrawLine(myPen, 120, 510, 750, 510);

                e.Graphics.DrawLine(myPen, 230, 220, 230, 510);

                StringFormat myStringFormat = new StringFormat();
                myStringFormat.Alignment = StringAlignment.Far;


                if (dtTarih.Value != null) e.Graphics.DrawString(dtTarih.Value.Date.ToString(), myFont, sbrush, 437, 320, myStringFormat);
                if (cbUcusTipi.SelectedItem != null) e.Graphics.DrawString(cbUcusTipi.SelectedItem.ToString(), myFont, sbrush, 250, 360);
                if (cbAracAdi.SelectedItem != null) e.Graphics.DrawString(cbAracAdi.SelectedItem.ToString(), myFont, sbrush, 250, 400);
                if (cbUcusTipi.SelectedItem != null) e.Graphics.DrawString(cbUcusTipi.SelectedItem.ToString(), myFont, sbrush, 250, 440);
                if (txtUcusSuresi.Text != null) e.Graphics.DrawString(txtUcusSuresi.Text, myFont, sbrush, 250, 480);
                if (adSoyad != null) e.Graphics.DrawString(adSoyad, myFont, sbrush, 250, 250);
                

            }
            catch (Exception)
            {

            }
        }



        private void cbAracAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cbAracAdi.SelectedItem.ToString();
            UcusTakipEntities vt = new UcusTakipEntities();
            var list = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciAdi == secilen);
            aracKodu = list.HavaAraciNo;
        }
    }
}
