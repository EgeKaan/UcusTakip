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
    public partial class KomutanIslemleri : Form
    {
        public KomutanIslemleri()
        {
            InitializeComponent();
        }
        private int perNo = KullaniciRol.KullaniciID;
        private int PerKurID;
        public string PersonelAdSoyad { get; set; }
        private void KomutanIslemleri_Load(object sender, EventArgs e)
        {

            UcusTakipEntities vt = new UcusTakipEntities();
            if (KullaniciRol.KullaniciRolu == "Yonetici")
            {
                if (string.IsNullOrEmpty(SecilenPersonel.PerdsonelAdSoyad))
                {
                    PersonelAdSoyad = string.Empty;
                    lblAdSoyad.Text = string.Empty;
                }
                else
                {
                    PersonelAdSoyad = string.Empty;
                    lblAdSoyad.Text = string.Empty;
                    PersonelAdSoyad = SecilenPersonel.PerdsonelAdSoyad;
                    perNo = SecilenPersonel.PersonelNo;
                    TumKayitleriListele();
                }
            }


            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                btnSecilenPerGoster.Visible = false;
                lblAdSoyad.Text = string.Empty;
                var personel = vt.Personels.FirstOrDefault(p => p.PersonelNo == perNo);
                lblAdSoyad.Text = personel.Ad + " " + personel.Soyad;
                TumKayitleriListele();
            }

            if (TıklanılanButon.butonAdi_2 == "HarekatSubayi")
            {
                rbHarekatSubayi.Checked = true;
                rbKomutan.Visible = false;
                lblKomutanSubay.Text = "Harekat Subayı ID";
                this.Text = "Harekat Subay İşlemleri";
            }

            if (TıklanılanButon.butonAdi_2 == "Komutan")
            {
                rbHarekatSubayi.Checked = true;
                rbHarekatSubayi.Visible = false;
                this.Text = "Komutan İşlemleri";
            }

            if (TıklanılanButon.butonAdi == "Ekle") { btnEkle.Visible = true; }
            if (TıklanılanButon.butonAdi == "Guncelle") { btnGuncelle.Visible = true; }
            if (TıklanılanButon.butonAdi == "Sil") { btnSil.Visible = true; }

        }

        void TumKayitleriListele()
        {

            UcusTakipEntities vt = new UcusTakipEntities();


            dgPer_Komutan_subay.Columns.Clear();
            dgPer_Komutan_subay.ColumnCount = 5;
            dgPer_Komutan_subay.Columns[0].Name = "Personel Komutan ID";
            dgPer_Komutan_subay.Columns[1].Name = "Personel No";
            dgPer_Komutan_subay.Columns[2].Name = "Kisi ID";
            dgPer_Komutan_subay.Columns[3].Name = "Tarih";
            dgPer_Komutan_subay.Columns[4].Name = "Açıklama";
            

            if (TıklanılanButon.butonAdi_2 == "Komutan")
            {
                var komutanlar = vt.HarekatSB_Komutan.Where(p => p.KisiUnvani == "KOMUTAN").ToList();
                dgKomutan_Subay.DataSource = komutanlar;
                var perKomutani = vt.PersonelKomutanı.Where(p=>p.PersonelNo==perNo).ToList();
                foreach (var i in perKomutani)
                {
                    foreach (var s in komutanlar)
                    {
                        if (i.KisiID == s.KisiID)
                        {
                            string tarih = string.Empty; string perKomID = string.Empty; string aciklama = string.Empty;
                            perKomID = i.PersonelKomutanıID.ToString();
                            if (i.PKTarih != null) tarih = i.PKTarih.Value.Date.ToString();
                            if (txtAcıklama.Text != null) aciklama = i.KisiAciklamasi;

                            string[] satir = new string[]
                                  {perKomID,perNo.ToString(),s.KisiID.ToString(),tarih,aciklama};
                            dgPer_Komutan_subay.Rows.Add(satir);
                        }
                    }
                }
            }

            if (TıklanılanButon.butonAdi_2 == "HarekatSubayi")
            {
                lblKomutan_Subay.Text = "Tüm Harekat Subayları";
                lblPer_Komutan_Subay.Text = "Personelin Harekat Subayı";
                var harekatSubaylari = vt.HarekatSB_Komutan.Where(p => p.KisiUnvani == "HAREKAT SUBAYI").ToList();
                dgKomutan_Subay.DataSource = harekatSubaylari;
                var perSubayi = vt.PersonelKomutanı.Where(p => p.PersonelNo == perNo).ToList();
                if (perSubayi.Count > 0)
                {
                    foreach (var i in perSubayi)
                    {
                        foreach (var s in harekatSubaylari)
                        {
                            if (i.KisiID == s.KisiID)
                            {
                                string tarih = string.Empty; string perKomID = string.Empty; string aciklama = string.Empty;
                                perKomID = i.PersonelKomutanıID.ToString();
                                if (i.PKTarih != null) tarih = i.PKTarih.Value.Date.ToString();
                                if (txtAcıklama.Text != null) aciklama = i.KisiAciklamasi;

                                string[] satir = new string[]
                                      {perKomID,perNo.ToString(),s.KisiID.ToString(),tarih,aciklama};
                                dgPer_Komutan_subay.Rows.Add(satir);
                            }
                        }
                    }
                }
            }
        }


        private void btnSecilenPerGoster_Click(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            lblAdSoyad.Text = string.Empty;
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
        string ad, soyad;
        private void dgKomutan_Subay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string adSoyad = lblAdSoyad.Text;
                AlanlariTemizle();
                lblAdSoyad.Text = adSoyad;
                DataGridViewRow str = dgKomutan_Subay.Rows[e.RowIndex];

                if(str.Cells[0].Value !=null) lbl_ID.Text = str.Cells[0].Value.ToString();
                if (str.Cells[1].Value != null) ad = str.Cells[1].Value.ToString();
                if (str.Cells[2].Value != null) soyad = str.Cells[2].Value.ToString();
                lblKomutanAdSoyad.Text = ad + " " + soyad;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
        }

        void AlanlariTemizle()
        {
            lblPerKomID.Text = string.Empty;
            lblAdSoyad.Text = string.Empty;
            lbl_ID.Text = string.Empty;
            txtAcıklama.Text = string.Empty;
            dtGuncellemeTarihi.Value = DateTime.Now;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblPerKomID.Text != null)
                {
                    PerKurID = Convert.ToInt32(lblPerKomID.Text);
                    DialogResult silOnaylama = new DialogResult();
                    silOnaylama = MessageBox.Show(PerKurID + " Numaralı kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (silOnaylama == DialogResult.Yes)
                    {
                        UcusTakipEntities vt = new UcusTakipEntities();
                        PersonelKomutanı pk = vt.PersonelKomutanı.FirstOrDefault(p => p.PersonelKomutanıID == PerKurID);
                        vt.PersonelKomutanı.Remove(pk);
                        int sonuc = vt.SaveChanges();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Silme İşlemi Başarlı");
                            TumKayitleriListele();
                            AlanlariTemizle();
                        }
                    }
                }
                else MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
            }
            catch (Exception)
            {
                if (TıklanılanButon.butonAdi_2 == "HarekatSubayi") MessageBox.Show("Lütfen Harekat Subayı seçimini yapınız.");
                if (TıklanılanButon.butonAdi_2 == "Komutan") MessageBox.Show("Lütfen Komutan seçimini yapınız.");
                if (KullaniciRol.KullaniciRolu == "Yonetici") MessageBox.Show("Lütfen personel seçimini kontrol ediniz.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            UcusTakipEntities vt = new UcusTakipEntities();

            try
            {
                if (lblKomutanAdSoyad.Text != null)
                {
                    int secilenID=Convert.ToInt32(lbl_ID.Text);
                    var komList = vt.PersonelKomutanı.Where(p => p.KisiID ==secilenID & p.PersonelNo==perNo).ToList();
                    if (komList.Count > 0)
                    {
                        MessageBox.Show("Aynı kişiyi birden fazla kez kayıt edemezsiniz.");
                    }
                    else if (komList.Count==0)
                    {
                        PersonelKomutanı pk = new PersonelKomutanı();
                        pk.KisiID = Convert.ToInt32(lbl_ID.Text);
                        pk.PersonelNo = perNo;
                        pk.PKTarih = dtGuncellemeTarihi.Value;
                        pk.KisiAciklamasi = txtAcıklama.Text;

                        vt.PersonelKomutanı.Add(pk);
                        int sonuc = vt.SaveChanges();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kayıt İşlemi Başarlı");
                            AlanlariTemizle();
                            TumKayitleriListele();
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                if (TıklanılanButon.butonAdi_2 == "HarekatSubayi") MessageBox.Show("Lütfen Harekat Subayı seçimini yapınız.");
                if (TıklanılanButon.butonAdi_2 == "Komutan") MessageBox.Show("Lütfen Komutan seçimini yapınız.");
                if (KullaniciRol.KullaniciRolu == "Yonetici") MessageBox.Show("Lütfen personel seçimini kontrol ediniz.");
            }
           
        }

        private void dgPer_Komutan_subay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlanlariTemizle();
                DataGridViewRow str = dgPer_Komutan_subay.Rows[e.RowIndex];

                if (str.Cells[0].Value != null)  lblPerKomID.Text = str.Cells[0].Value.ToString();
                if (str.Cells[2].Value != null)  lbl_ID.Text = str.Cells[2].Value.ToString();
                if (str.Cells[3].Value != null) dtGuncellemeTarihi.Value = Convert.ToDateTime(str.Cells[3].Value.ToString());
                if (str.Cells[4].Value != null) txtAcıklama.Text = str.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblPerKomID.Text != null)
                {
                    PerKurID = Convert.ToInt32(lblPerKomID.Text);
                    UcusTakipEntities vt = new UcusTakipEntities();
                    PersonelKomutanı pk = vt.PersonelKomutanı.FirstOrDefault(p => p.PersonelKomutanıID == PerKurID);
                    pk.KisiID = Convert.ToInt32(lbl_ID.Text);
                    pk.PersonelNo = perNo;
                    pk.PKTarih = dtGuncellemeTarihi.Value;
                    pk.KisiAciklamasi = txtAcıklama.Text;

                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Güncelleme İşlemi Başarlı");
                        AlanlariTemizle();
                        TumKayitleriListele();
                    }
                }
                else MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz.");
            }
            catch (Exception)
            {
                if (TıklanılanButon.butonAdi_2 == "HarekatSubayi") MessageBox.Show("Lütfen Harekat Subayı seçimini yapınız.");
                if (TıklanılanButon.butonAdi_2 == "Komutan") MessageBox.Show("Lütfen Komutan seçimini yapınız.");
                if (KullaniciRol.KullaniciRolu == "Yonetici") MessageBox.Show("Lütfen personel seçimini kontrol ediniz.");
            }
            
        }
        
    }
}
