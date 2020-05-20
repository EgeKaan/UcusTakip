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
    public partial class HavaAraciIslemleriEkle : Form
    {
        public HavaAraciIslemleriEkle()
        {
            InitializeComponent();
        }

        private void HavaAraciIslemleriEkle_Load(object sender, EventArgs e)
        {
            TumKayitleriListele();
            btnEkle.Visible = false;
            btnGuncelle.Visible = false;
            btnSil.Visible = false;
            if (TıklanılanButon.butonAdi == "Ekle") btnEkle.Visible = true;
            if (TıklanılanButon.butonAdi == "Guncelle")
            {
                btnGuncelle.Visible = true;
            }
            if (TıklanılanButon.butonAdi == "Sil")
            {
                btnSil.Visible = true;
            }
        }

        void TumKayitleriListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dgHavaAraclari.DataSource = vt.HavaAracları.ToList();
            dgHavaAraclari.Columns["PersonelAracYetkis"].Visible = false;
            dgHavaAraclari.Columns["UcusBilgileris"].Visible = false;
        }

        void AlanlariTemizle()
        {
            lblAracKodu.Text = string.Empty;
            txtHavaAracAdi.Text = string.Empty;
        }

        DataGridViewRow seciliSatir;
        private void dgPerEkleGun_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                seciliSatir = dgHavaAraclari.Rows[e.RowIndex];
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtHavaAracAdi.Text == "") { MessageBox.Show("Lütfen araç adı giriniz.");}
            else if(rbHelikopter.Checked==false || rbUcak.Checked==false) MessageBox.Show("Lütfen araç türünü seçiniz.");
                else
                    {
                    HavaAracları h = new HavaAracları();
                    h.HavaAraciTipi = rbUcak.Checked ? "Uçak" : "Helikopter";
                    h.HavaAraciAdi = txtHavaAracAdi.Text;
                    UcusTakipEntities vt = new UcusTakipEntities();
                    vt.HavaAracları.Add(h);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        TumKayitleriListele();
                    }
                    else MessageBox.Show("Kayıt Başarısız");
                }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenAracID = Convert.ToInt32(lblAracKodu.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                HavaAracları h = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciNo == secilenAracID);
                vt.HavaAracları.Remove(h);
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
                MessageBox.Show("Lütfen kayıt seçin.");
            }
            
        }

        private void dgHavaAraclari_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                AlanlariTemizle();
                DataGridViewRow str = dgHavaAraclari.Rows[e.RowIndex];
                lblAracKodu.Text = str.Cells[0].Value.ToString();
                if (str.Cells[1].Value.ToString() == "Uçak      ")
                    rbUcak.Checked = true;
                if (str.Cells[1].Value.ToString() == "Helikopter")
                    rbHelikopter.Checked = true;
                txtHavaAracAdi.Text = str.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçimi yapınız.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenAracID = Convert.ToInt32(lblAracKodu.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                HavaAracları h = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciNo == secilenAracID);
                h.HavaAraciAdi = txtHavaAracAdi.Text.Trim();
                h.HavaAraciTipi = rbUcak.Checked ? "Uçak" : "Helikopter";
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem Başarlı");
                    TumKayitleriListele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıt seçimi yapınız.");
            }
            
        }
        
    }
}
