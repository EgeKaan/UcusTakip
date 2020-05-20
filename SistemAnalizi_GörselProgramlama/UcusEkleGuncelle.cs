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
    public partial class UcusEkleGuncelle : Form
    {
        public UcusEkleGuncelle()
        {
            InitializeComponent();
        }

        private int perNo = 0;
        private int aracKodu = 0;

        private void UsucEkleGuncelle_Load(object sender, EventArgs e)
        {
            if (TıklanılanButon.butonAdi == "Guncelle") { btnSil.Visible = false; this.Text = "Uçuş Güncelle"; }
            if (TıklanılanButon.butonAdi == "Sil")
            {
                btnGuncelle.Visible = false;
                this.Text = "Uçuş Sil ";
            }
            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                perNo = KullaniciRol.KullaniciID;
                lblAdSoyad.Visible = false;
                btnListele.Visible = false;
                TumKayitleriListele();
            }
        }

       
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
            if (ucusList != null)
            {
                foreach (var item in ucusList)
                {
                    string tarih = string.Empty; string aracAdi = string.Empty; string ucustipi = string.Empty; string ucuSure = string.Empty; string ucusno = string.Empty;

                    ucusno = item.UcusNo.ToString();
                    if(item.UcusTarihi !=null) tarih = item.UcusTarihi.Value.Date.ToString();
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

        void AlanlariTemizle()
        {
            lblAracAdi.Text = string.Empty;
            lblAracTuru.Text = string.Empty;
            lblUcusNo.Text = string.Empty;
            lblUcusTipi.Text = string.Empty;
            dtTarih.Value = DateTime.Now;
            txtUcusSuresi.Text = string.Empty;
        }

        private void dgUcus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlanlariTemizle();

                DataGridViewRow str = dgUcus.Rows[e.RowIndex];
                lblUcusNo.Text = str.Cells[0].Value.ToString();
                if (str.Cells[2].Value != null) lblAracAdi.Text = str.Cells[2].Value.ToString();
                if (str.Cells[1].Value != null) dtTarih.Value = Convert.ToDateTime(str.Cells[1].Value.ToString());
                if (str.Cells[3].Value != null) lblUcusTipi.Text = str.Cells[3].Value.ToString();
                if (str.Cells[4].Value != null) txtUcusSuresi.Text = str.Cells[4].Value.ToString();

                UcusTakipEntities vt = new UcusTakipEntities();
                var arac = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciAdi == lblAracAdi.Text);
                aracKodu = arac.HavaAraciNo;
                lblAracTuru.Text = arac.HavaAraciTipi.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }

        }

        DataGridViewRow seciliSatir;
        private void dgUcus_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                seciliSatir = dgUcus.Rows[e.RowIndex];
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekUcusNo = Convert.ToInt32(lblUcusNo.Text);
            DialogResult silOnaylama = new DialogResult();
            silOnaylama = MessageBox.Show(silinecekUcusNo + " Numaralı uçuş kaydını silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (silOnaylama == DialogResult.Yes)
            {
                UcusTakipEntities vt = new UcusTakipEntities();
                UcusBilgileri u = vt.UcusBilgileris.FirstOrDefault(p => p.UcusNo == silinecekUcusNo);
                vt.UcusBilgileris.Remove(u);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Silme İşlemi Başarlı");
                    AlanlariTemizle();
                    TumKayitleriListele();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenkUcusNo = Convert.ToInt32(lblUcusNo.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                UcusBilgileri u = vt.UcusBilgileris.FirstOrDefault(p => p.UcusNo == secilenkUcusNo);
                u.UcusDakikası = Convert.ToInt32(txtUcusSuresi.Text);
                u.UcusTarihi = dtTarih.Value;

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarlı");
                    AlanlariTemizle();
                    TumKayitleriListele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayt seçimi yapınız.");
            }
            
        }

        private void btnListele_Click(object sender, EventArgs e)
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


    }
}
