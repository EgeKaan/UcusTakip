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
    public partial class KomutanBilgileriEkle : Form
    {
        public KomutanBilgileriEkle()
        {
            InitializeComponent();
        }

        private void KomutanBilgileriEkle_Load(object sender, EventArgs e)
        {
            btnKomutanGuncelle.Visible = false;
            btnKomutanKaydet.Visible = false;
            btnKomutanSil.Visible = false;
            txtKomutanUnvani.Text = null;
            if (TıklanılanButon.butonAdi_2 == "Komutan") { txtKomutanUnvani.Text = "KOMUTAN"; this.Text = "Komutan Bilgi İşlemleri"; }
            if (TıklanılanButon.butonAdi_2 == "HarekatSubayi") { txtKomutanUnvani.Text = "HAREKAT SUBAYI"; lblKomutan_Subay.Text = "Harekat Subayı ID"; }
            if (TıklanılanButon.butonAdi == "Ekle") btnKomutanKaydet.Visible = true;
            if (TıklanılanButon.butonAdi == "Guncelle") btnKomutanGuncelle.Visible = true;
            if (TıklanılanButon.butonAdi == "Sil") btnKomutanSil.Visible = true;
            TumKayitleriListele();
        }
        private void btnKomutanKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtKomutanAdi.Text)) MessageBox.Show("Lütfen boş alanları doldurunuz.");
                else
                {
                    HarekatSB_Komutan h1 = new HarekatSB_Komutan();
                    h1.KisiAdi = txtKomutanAdi.Text;
                    h1.KisiSoyadi = txtKomutanSoyadi.Text;
                    h1.KisiUnvani = txtKomutanUnvani.Text;
                    h1.KisiRutbesi = txtKomutanRutbesi.Text;

                    UcusTakipEntities vt = new UcusTakipEntities();
                    vt.HarekatSB_Komutan.Add(h1);

                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        TumKayitleriListele();
                    }
                    else MessageBox.Show("Kayıt Başarısız");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
            }
           
            
        }

        void TumKayitleriListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            if (TıklanılanButon.butonAdi_2 == "Komutan")
                dgKomutanBilgileri.DataSource = vt.HarekatSB_Komutan.Where(p=>p.KisiUnvani=="KOMUTAN").ToList();
            if (TıklanılanButon.butonAdi_2 == "HarekatSubayi")
                dgKomutanBilgileri.DataSource = vt.HarekatSB_Komutan.Where(p => p.KisiUnvani == "HAREKAT SUBAYI").ToList();
            dgKomutanBilgileri.Columns["PersonelKomutanı"].Visible = false;
        }

        void AlanlariTemizle()
        {
            lblKomutanID.Text = string.Empty;
            txtKomutanAdi.Text = string.Empty;
            txtKomutanSoyadi.Text = string.Empty;
            txtKomutanUnvani.Text = string.Empty;
        }

        DataGridViewRow seciliSatir;
        private void dgKomutanBilgileri_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                seciliSatir = dgKomutanBilgileri.Rows[e.RowIndex];
            }
        }

        private void dgKomutanBilgileri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlanlariTemizle();
                DataGridViewRow str = dgKomutanBilgileri.Rows[e.RowIndex];
                lblKomutanID.Text = str.Cells[0].Value.ToString();
                txtKomutanAdi.Text = str.Cells[1].Value.ToString();
                txtKomutanSoyadi.Text = str.Cells[2].Value.ToString();
                txtKomutanUnvani.Text = str.Cells[3].Value.ToString();
                txtKomutanRutbesi.Text = str.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
        }

        private void btnKomutanSil_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenKisiID = Convert.ToInt32(lblKomutanID.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                HarekatSB_Komutan k1 = vt.HarekatSB_Komutan.FirstOrDefault(p => p.KisiID == secilenKisiID);
                vt.HarekatSB_Komutan.Remove(k1);

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    AlanlariTemizle();
                    TumKayitleriListele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            } 
        }

        private void btnKomutanGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenKisiID = Convert.ToInt32(lblKomutanID.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                HarekatSB_Komutan h1 = vt.HarekatSB_Komutan.FirstOrDefault(p => p.KisiID == secilenKisiID);
                h1.KisiAdi = txtKomutanAdi.Text;
                h1.KisiSoyadi = txtKomutanSoyadi.Text;
                h1.KisiRutbesi = txtKomutanRutbesi.Text;

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    TumKayitleriListele();
                }
                else MessageBox.Show("Güncelleme Başarısız");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıt seçimi yapınız.");
            }
        }


    }
}
