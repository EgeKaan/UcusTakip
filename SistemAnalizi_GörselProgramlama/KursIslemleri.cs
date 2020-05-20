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
    public partial class KursIslemleri : Form
    {
        public KursIslemleri()
        {
            InitializeComponent();
        }
        private string kursAd;
        private int perKurs;
        private int perNo = 0;
        private void KursIslemleri_Load(object sender, EventArgs e)
        {
            btnEkle.Visible = false;btnGuncelle.Visible = false;btnSil.Visible = false;
            if (TıklanılanButon.butonAdi == "Ekle") btnEkle.Visible = true;
            if (TıklanılanButon.butonAdi == "Sil") { btnSil.Visible = true; cbKurslar.Visible = false; label1.Visible = false; }
            if (TıklanılanButon.butonAdi == "Guncelle") { btnGuncelle.Visible = true; cbKurslar.Visible = false; label1.Visible = false; }

            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                btnPerSecim.Visible = false;
                TumKayitlariListele();
                perNo = KullaniciRol.KullaniciID;
                UcusTakipEntities vt = new UcusTakipEntities();
                var per = vt.Personels.FirstOrDefault(p => p.PersonelNo == perNo);
                lblPerAdSoyad.Text = per.Ad.Trim() + " " + per.Soyad.Trim();
                TumKayitlariListele();
            }
            
            KurslariListele();
        }

        void alanlariTemizle()
        {
            lblKursAdi.Text = string.Empty;
            lblKursNo.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        void KurslariListele()
        {
            cbKurslar.Items.Clear();
            UcusTakipEntities vt = new UcusTakipEntities();
            var kurslar = vt.Kurs.ToList();
            foreach (var item in kurslar)
            {
                cbKurslar.Items.Add(item.KursAdi);
            }
        }

        
        private void btnAdaGoreArama_Click(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            lblPerAdSoyad.Text = SecilenPersonel.PerdsonelAdSoyad;
            perNo = SecilenPersonel.PersonelNo;
            if (string.IsNullOrEmpty(lblPerAdSoyad.Text))
            {
                MessageBox.Show("Lütfen personel seçiniz.");
            }
            else
            {
                TumKayitlariListele();
            }
        }

        void TumKayitlariListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dgPerKurs.DataSource = vt.PersonelKurs.Where(p=>p.PersonelNo==perNo).ToList();
            dgPerKurs.Columns["Kur"].Visible = false;
            dgPerKurs.Columns["Personel"].Visible = false;
        }

        private void dgPerKurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                perKurs = 0;
                lblKursNo.Text = string.Empty;
                kursAd = string.Empty;

                DataGridViewRow str = dgPerKurs.Rows[e.RowIndex];
                perKurs = Convert.ToInt32(str.Cells[0].Value);
                lblKursNo.Text = str.Cells[2].Value.ToString();
                dateTimePicker1.Value = (DateTime)str.Cells[3].Value;
                int kursNo = Convert.ToInt32(lblKursNo.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                var kurs = vt.Kurs.FirstOrDefault(p => p.KursNo == kursNo);
                kursAd = kurs.KursAdi;
                lblKursAdi.Text = kursAd;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }  
        }

        private void cbKurslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKursAdi.Text = string.Empty;
            lblKursNo.Text = string.Empty;
            perKurs = 0;

            lblKursAdi.Text = cbKurslar.SelectedItem.ToString();
            UcusTakipEntities vt = new UcusTakipEntities();
            var kurs = vt.Kurs.FirstOrDefault(p => p.KursAdi == lblKursAdi.Text);
            lblKursNo.Text = kurs.KursNo.ToString();
            int kNo = Convert.ToInt32(lblKursNo.Text.Trim());
            var pk = vt.Kurs.FirstOrDefault(p => p.KursNo == kNo);
            perKurs = pk.KursNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int yeniKayit = 1;
                UcusTakipEntities vt = new UcusTakipEntities();
                var kursList = vt.PersonelKurs.Where(p => p.PersonelNo == perNo).ToList();
                foreach (var item in kursList)
                {
                    if (item.KursNo == Convert.ToInt32(lblKursNo.Text)) yeniKayit = 0;
                }

                if (string.IsNullOrEmpty(lblKursAdi.Text))
                {
                    MessageBox.Show("Lütfen Kurs Seçimi Yapınız.");
                }
                else if (yeniKayit == 0)
                {
                    MessageBox.Show(lblKursAdi.Text + " adlı kursun kaydı bulunmaktadır. \n İsterseniz başka kurs ekleyebilirsiniz.");
                }
                else
                {
                    PersonelKur pk = new PersonelKur();
                    pk.KursNo = Convert.ToInt32(lblKursNo.Text);
                    pk.KursTarihi = dateTimePicker1.Value;
                    pk.PersonelNo = perNo;

                    vt.PersonelKurs.Add(pk);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Yeni Kayıt İşlemi Başarlı");
                        alanlariTemizle();
                        TumKayitlariListele();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen seçiminizi kontrol ediniz.");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblKursAdi.Text))
            {
                MessageBox.Show("Lütfen Kurs Seçimi Yapınız.");
            }
            else
            {
                UcusTakipEntities vt = new UcusTakipEntities();
                PersonelKur pk = vt.PersonelKurs.FirstOrDefault(p => p.PersonelKursID == perKurs);
                pk.KursNo = Convert.ToInt32(lblKursNo.Text);
                pk.KursTarihi = dateTimePicker1.Value;
                pk.PersonelNo = perNo;

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarlı");
                    alanlariTemizle();
                    TumKayitlariListele();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblKursAdi.Text))
            {
                MessageBox.Show("Lütfen Kurs Seçimi Yapınız.");
            }
            else
            {

                DialogResult silOnaylama = new DialogResult();
                silOnaylama = MessageBox.Show(lblKursAdi.Text + " Adlı kurs kaydını silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                if (silOnaylama == DialogResult.Yes)
                {
                    UcusTakipEntities vt = new UcusTakipEntities();
                    PersonelKur pk = vt.PersonelKurs.FirstOrDefault(p => p.PersonelKursID == perKurs);
                    vt.PersonelKurs.Remove(pk);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Silme İşlemi Başarlı");
                        alanlariTemizle();
                        TumKayitlariListele();
                    }
                }
            }
        }
    }
}
