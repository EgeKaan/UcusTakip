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
    public partial class PersonelEkleGuncelle : Form
    {
        public PersonelEkleGuncelle()
        {
            InitializeComponent();
        }
        private int perNo = KullaniciRol.KullaniciID;
        private void PersonelEkleGuncelle_Load(object sender, EventArgs e)
        {
            btnPerEkle.Visible = false;
            btnPerGuncelle.Visible = false;
            btnPerSil.Visible = false;
            if (TıklanılanButon.butonAdi == "Ekle") btnPerEkle.Visible = true;
            if (TıklanılanButon.butonAdi == "Guncelle")
            {
                btnPerGuncelle.Visible = true;
                TumKayitleriListele();
            }
            if (TıklanılanButon.butonAdi == "Sil")
            {
                btnPerSil.Visible = true;
                TumKayitleriListele();
            }
            if (KullaniciRol.KullaniciRolu == "Yonetici") TumKayitleriListele();
            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                TumKayitleriListele();
                this.Text = "Personel Kişisel Bilgi Güncelleme";
            }
        }


        void AlanlariTemizle()
        {
            txtPerNo.Text = string.Empty;
            txtPerAd.Text = string.Empty;
            txtPerSoyad.Text = string.Empty;
            txtSinifRutbesi.Text = string.Empty;
            txtSicilNo.Text = string.Empty;
            txtBroveNo.Text = string.Empty;
            dtPerDT.Value = DateTime.Now;
            txtBirlik.Text = string.Empty;
            txtUcusBirlik.Text = string.Empty;
            dtİlkUcusBas.Value = DateTime.Now;
            dtTemelKursBitis.Value = DateTime.Now;
            lblToplamUcusYılı.Text = string.Empty;
        }

        DataGridViewRow seciliSatir;
        private void dgPerEkleGun_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                seciliSatir = dgPerEkleGun.Rows[e.RowIndex];
            }
        }

        private void dgPerEkleGun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlanlariTemizle();
                DataGridViewRow str = dgPerEkleGun.Rows[e.RowIndex];
                if (str.Cells[0].Value != null) txtPerNo.Text = str.Cells[0].Value.ToString();
                if (str.Cells[1].Value != null) txtPerAd.Text = str.Cells[1].Value.ToString();
                if (str.Cells[2].Value != null) txtPerSoyad.Text = str.Cells[2].Value.ToString();
                if (str.Cells[3].Value != null) txtSinifRutbesi.Text = str.Cells[3].Value.ToString();
                if (str.Cells[4].Value != null) txtSicilNo.Text = str.Cells[4].Value.ToString();
                if (str.Cells[5].Value != null) txtBroveNo.Text = str.Cells[5].Value.ToString();
                if (str.Cells["DogumTarihi"].Value != null)
                    dtPerDT.Value = (DateTime)str.Cells["DogumTarihi"].Value;
                if (str.Cells[7].Value != null) txtBirlik.Text = str.Cells[7].Value.ToString();
                if (str.Cells[8].Value != null) txtUcusBirlik.Text = str.Cells[8].Value.ToString();
                if (str.Cells["IlkUcusTarihi"].Value != null)
                    dtİlkUcusBas.Value = (DateTime)str.Cells["IlkUcusTarihi"].Value;
                if (str.Cells["TemelKursBitirmeTarihi"].Value != null)
                    dtTemelKursBitis.Value = (DateTime)str.Cells["TemelKursBitirmeTarihi"].Value;
                if (str.Cells[11].Value != null) lblToplamUcusYılı.Text = str.Cells[11].Value.ToString();
                if (str.Cells[12].Value != null)
                {
                    if (str.Cells[12].Value.ToString() == "Kurum/Kh.")
                        rbKurum.Checked = true;
                    else
                        rbKita.Checked = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }

        }

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Personel p1 = new Personel();
                p1.Ad = txtPerAd.Text;
                p1.Soyad = txtPerSoyad.Text;
                p1.SinifRutbesi = txtSinifRutbesi.Text;
                p1.SicilNo = Convert.ToInt32(txtSicilNo.Text);
                p1.BroveNo = Convert.ToInt32(txtBroveNo.Text);
                p1.DogumTarihi = dtPerDT.Value;
                p1.Birligi = txtBirlik.Text;
                p1.UcusBirligi = txtUcusBirlik.Text;
                p1.IlkUcusTarihi = dtİlkUcusBas.Value;
                p1.TemelKursBitirmeTarihi = dtTemelKursBitis.Value;
                if (dtTemelKursBitis.Value != null)
                {
                    DateTime bitis = dtTemelKursBitis.Value;
                    p1.ToplamUcusYılı = DateTime.Now.Year - bitis.Year;
                }
                lblToplamUcusYılı.Text = p1.ToplamUcusYılı.ToString();
                if (rbKita.Checked == true) p1.GorevDurumu = "Kıt'a";
                if (rbKita.Checked == true) p1.GorevDurumu = "Kurum/Kh.";

                UcusTakipEntities vt = new UcusTakipEntities();
                vt.Personels.Add(p1);

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    TumKayitleriListele();
                    AlanlariTemizle();
                }
                else MessageBox.Show("Kayıt Başarısız");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz.");
            }



        }

        private void btnPerSil_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenKisiID = Convert.ToInt32(txtPerNo.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                Kullanici kullanici = vt.Kullanicis.FirstOrDefault(p => p.PersonelID == secilenKisiID);
                if (kullanici != null) vt.Kullanicis.Remove(kullanici);
                PersonelKur perKurs = vt.PersonelKurs.FirstOrDefault(p => p.PersonelNo == secilenKisiID);
                if (perKurs != null) vt.PersonelKurs.Remove(perKurs);
                PersonelAracYetki perYet = vt.PersonelAracYetkis.FirstOrDefault(p => p.PersonelNo == secilenKisiID);
                if (perYet != null) vt.PersonelAracYetkis.Remove(perYet);
                PersonelKomutanı perKom = vt.PersonelKomutanı.FirstOrDefault(p => p.PersonelNo == secilenKisiID);
                if (perKom != null) vt.PersonelKomutanı.Remove(perKom);
                Tarih t = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == secilenKisiID);
                if (t != null) vt.Tarihs.Remove(t);
                UcusBilgileri ucus = vt.UcusBilgileris.FirstOrDefault(p => p.PersonelNo == secilenKisiID);
                if (ucus != null) vt.UcusBilgileris.Remove(ucus);
                Personel k = vt.Personels.FirstOrDefault(p => p.PersonelNo == secilenKisiID);
                vt.Personels.Remove(k);

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem Başarlı");
                    AlanlariTemizle();
                    TumKayitleriListele();
                }
            }

            catch (Exception)
            {
                TumKayitleriListele();
            }
        }
    



        void TumKayitleriListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            if (KullaniciRol.KullaniciRolu == "Yonetici")
            {
                dgPerEkleGun.DataSource = vt.Personels.ToList();
                dgGizle();
            }
            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                dgPerEkleGun.DataSource = vt.Personels.Where(p => p.PersonelNo == perNo).ToList();
                dgGizle();
            }
        }

        private void btnPerGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenKisiID = Convert.ToInt32(txtPerNo.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                Personel p1 = vt.Personels.FirstOrDefault(p => p.PersonelNo == secilenKisiID);
                p1.Ad = txtPerAd.Text;
                p1.Soyad = txtPerSoyad.Text;
                p1.SinifRutbesi = txtSinifRutbesi.Text;
                if (txtSicilNo.Text != "") p1.SicilNo = Convert.ToInt32(txtSicilNo.Text);
                if (txtBroveNo.Text != "") p1.BroveNo = Convert.ToInt32(txtBroveNo.Text);
                p1.DogumTarihi = dtPerDT.Value;
                p1.Birligi = txtBirlik.Text;
                p1.UcusBirligi = txtUcusBirlik.Text;
                p1.IlkUcusTarihi = dtİlkUcusBas.Value;
                p1.TemelKursBitirmeTarihi = dtTemelKursBitis.Value;
                if (dtTemelKursBitis.Value != null)
                {
                    DateTime baslangicYil = dtTemelKursBitis.Value;
                    p1.ToplamUcusYılı = DateTime.Now.Year - baslangicYil.Year;
                }
                lblToplamUcusYılı.Text = p1.ToplamUcusYılı.ToString();
                if (rbKita.Checked == true) p1.GorevDurumu = "Kıt'a";
                if (rbKita.Checked == true) p1.GorevDurumu = "Kurum/Kh.";

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem Başarlı");
                    TumKayitleriListele();
                    AlanlariTemizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıt seçiniz.");
            }
        }

        void dgGizle()
        {
            dgPerEkleGun.Columns["Kullanicis"].Visible = false;
            dgPerEkleGun.Columns["PersonelAracYetkis"].Visible = false;
            dgPerEkleGun.Columns["PersonelKurs"].Visible = false;
            dgPerEkleGun.Columns["PersonelKomutanı"].Visible = false;
            dgPerEkleGun.Columns["Tarihs"].Visible = false;
            dgPerEkleGun.Columns["UcusBilgileris"].Visible = false;
        }
    }
}
