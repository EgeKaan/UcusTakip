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
    public partial class KursBilgileriEkleGuncelle : Form
    {
        public KursBilgileriEkleGuncelle()
        {
            InitializeComponent();
        }

        private void KursBilgileriEkleGuncelle_Load(object sender, EventArgs e)
        {
            btnGuncelle.Visible = false;
            btnKaydet.Visible = false;
            btnSil.Visible = false;
            if (TıklanılanButon.butonAdi == "Ekle") btnKaydet.Visible = true;
            if (TıklanılanButon.butonAdi == "Guncelle") btnGuncelle.Visible = true;
            if (TıklanılanButon.butonAdi == "Sil") btnSil.Visible = true;
            TumKayitleriListele();
        }
        void TumKayitleriListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dgKusBilgileri.DataSource = vt.Kurs.ToList();
            dgKusBilgileri.Columns["PersonelKurs"].Visible = false;
        }

        void AlanlariTemizle()
        {
            lblKursNo.Text = string.Empty;
            txtKursAdi.Text = string.Empty;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtKursAdi.Text)) MessageBox.Show("Lütfen boş alanları doldurunuz.");
            
            else
            {
                Kur k = new Kur();
                k.KursAdi = txtKursAdi.Text;
                UcusTakipEntities vt = new UcusTakipEntities();
                vt.Kurs.Add(k);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    TumKayitleriListele();
                }
                else MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenKursNo = Convert.ToInt32(lblKursNo.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                Kur k = vt.Kurs.FirstOrDefault(p => p.KursNo == secilenKursNo);
                k.KursAdi = txtKursAdi.Text;
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarlı");
                    TumKayitleriListele();
                    AlanlariTemizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıt seçimi.");
            }

           


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenKursNo = Convert.ToInt32(lblKursNo.Text);
                string kursAd = txtKursAdi.Text;
                DialogResult silOnaylama = new DialogResult();
                silOnaylama = MessageBox.Show(kursAd + " Adlı kurs kaydını silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                if (silOnaylama == DialogResult.Yes)
                {
                    UcusTakipEntities vt = new UcusTakipEntities();
                    Kur k = vt.Kurs.FirstOrDefault(p => p.KursNo == secilenKursNo);
                    vt.Kurs.Remove(k);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Silme İşlemi Başarlı");
                        TumKayitleriListele();
                        AlanlariTemizle();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıt seçimi.");
            }
        }

        private void dgKusBilgileri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlanlariTemizle();
                DataGridViewRow str = dgKusBilgileri.Rows[e.RowIndex];
                lblKursNo.Text = str.Cells[0].Value.ToString();
                txtKursAdi.Text = str.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
        }
        
    }
}
