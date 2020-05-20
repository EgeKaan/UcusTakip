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
    public partial class SaglıkTarihiEkleGuncelle : Form
    {
        public SaglıkTarihiEkleGuncelle()
        {
            InitializeComponent();
        }

        int kullaniciID = KullaniciRol.KullaniciID;
        private int perNo ;
        private void SaglıkTarihiEkleGuncelle_Load(object sender, EventArgs e)
        {
            btnSil.Visible = false;
            btnTarihGuncelle.Visible = false;
            btnEkle.Visible = false;
            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                btnPerSec.Visible = false;
                TumKayitleriListele();
                perNo = kullaniciID;
            }
            if (TıklanılanButon.butonAdi == "SaglikSil")
            {
                btnSil.Visible = true;
                TumKayitleriListele();
            }

            if (TıklanılanButon.butonAdi == "SaglikGuncelle")
            {
                btnTarihGuncelle.Visible = true;
                TumKayitleriListele();
            }

            if (TıklanılanButon.butonAdi == "SaglikEkle")
            {
                UcusTakipEntities vt = new UcusTakipEntities();
                var list = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == perNo);
                if (list != null)
                { MessageBox.Show("Sistemde bulunan kayıttan başka kayıt açamazsınız. " +
                    " Guncelleme ekranına yönlendirildiniz. ");
                    btnTarihGuncelle.Visible = true;
                }
                else  btnEkle.Visible = true; 

            }
            
        }

        void AlanlariTemizle()
        {
            dtUcak.Value = DateTime.Now;
            dtHeli.Value = DateTime.Now;
            dtYillik.Value = DateTime.Now;
            dt5Yillik.Value = DateTime.Now;
            lblSağlık.Text = string.Empty;
            lblSağlık5.Text = string.Empty;
        }

        void TumKayitleriListele()
        {
            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                UcusTakipEntities vt = new UcusTakipEntities();
                var tarihList = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == perNo);
                dgSaglıkTarih.DataSource = vt.Tarihs.Where(p => p.PersonelNo == perNo).ToList();
                if (tarihList!=null) dgSaglıkTarih.Columns["Personel"].Visible = false;
                dgSaglıkTarih.Columns["TarihID"].Visible = false;
                var list = vt.Personels.FirstOrDefault(p => p.PersonelNo == kullaniciID);
                string ad = list.Ad;
                if (list.Ad != null & list.Soyad != null) lblPerAdSoyad.Text = list.Ad + " " + list.Soyad;
                else if (list.Ad != null) lblPerAdSoyad.Text = list.Ad;

                try
                {
                    if (tarihList.BesYillikSaglikSon != null) lblSağlık5.Text = tarihList.BesYillikSaglikSon.Value.ToShortDateString();
                    if (tarihList.YillikSaglikSon != null) lblSağlık.Text = tarihList.YillikSaglikSon.Value.ToShortDateString();
                }
                catch (Exception)
                {

                }
            }

            if (KullaniciRol.KullaniciRolu == "Yonetici")
            {
                UcusTakipEntities vt = new UcusTakipEntities();
                dgSaglıkTarih.DataSource = vt.Tarihs.Where(p => p.PersonelNo == perNo).ToList();
                dgSaglıkTarih.Columns["Personel"].Visible = false;
                dgSaglıkTarih.Columns["TarihID"].Visible = true;

                var tarihList = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == perNo);
                try
                {
                    if (tarihList.BesYillikSaglikSon != null) lblSağlık5.Text = tarihList.BesYillikSaglikSon.Value.ToString();
                    if (tarihList.YillikSaglikSon != null) lblSağlık.Text = tarihList.YillikSaglikSon.Value.ToString();
                }
                catch (Exception)
                {

                }
            }
            
        }
        

        private void btnTarihGuncelle_Click(object sender, EventArgs e)
        {
            if (lblTarihID.Text == "") MessageBox.Show("Lütfen kayıt seçinz");
            else
            {
                int tID = Convert.ToInt32(lblTarihID.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                DateTime simdi = DateTime.Now.Date;
                Tarih t1 = vt.Tarihs.FirstOrDefault(p => p.TarihID == tID);
                t1.UcakStanSonTarihi = (DateTime)dtUcak.Value.Date;
                t1.HeliStanSonTarih = dtHeli.Value.Date;
                t1.YillikSaglikSon = dtYillik.Value.Date;
                t1.BesYillikSaglikSon = dt5Yillik.Value.Date;
                if (dtYillik.Value != null)
                {
                    lblSağlık.Text = (dtYillik.Value.Date.AddYears(1)).ToString();

                }
                if (dt5Yillik.Value != null)
                {
                    lblSağlık5.Text = (dt5Yillik.Value.Date.AddYears(5)).ToString();
                }
                
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem Başarlı");
                    TumKayitleriListele();
                }
            }
        }

      

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblTarihID.Text == "") MessageBox.Show("Lütfen kayıt seçinz");
            else
            {
                int tID = Convert.ToInt32(lblTarihID.Text);
                int silinecekKisiID = perNo;
                UcusTakipEntities vt = new UcusTakipEntities();
                var list = vt.Tarihs.Where(p => p.TarihID == tID).FirstOrDefault();

                list.UcakStanSonTarihi = null;
                list.HeliStanSonTarih = null;
                list.YillikSaglik = null;
                list.BesYillikSaglik = null;
                list.YillikSaglikSon = null;
                list.BesYillikSaglikSon = null;
                lblSağlık.Text = string.Empty;
                lblSağlık5.Text = string.Empty;

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem Başarlı");
                    TumKayitleriListele();
                    AlanlariTemizle();
                }
            }
        }

        private void btnPerSec_Click(object sender, EventArgs e)
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
                dgSaglıkTarih.DataSource = vt.Tarihs.Where(p => p.PersonelNo == perNo).ToList();
                dgSaglıkTarih.Columns["Personel"].Visible = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
             try
             {
                UcusTakipEntities vt = new UcusTakipEntities();
                var list = vt.Tarihs.FirstOrDefault(p => p.PersonelNo == perNo);
                if (list != null)
                {
                    MessageBox.Show("Sistemde bulunan kayıttan başka kayıt açamazsınız. ");
                    this.Close();
                }
                else
                {

                    DateTime simdi = DateTime.Now;
                    Tarih t1 = new Tarih();
                    t1.PersonelNo = perNo;
                    t1.UcakStanSonTarihi = dtUcak.Value;
                    t1.HeliStanSonTarih = dtHeli.Value;
                    t1.YillikSaglikSon = dtYillik.Value;
                    t1.BesYillikSaglikSon = dt5Yillik.Value;
                    if (dtYillik.Value != null)
                    {
                        lblSağlık.Text = (dtYillik.Value - simdi).ToString();
                    }
                    if (dt5Yillik.Value != null)
                    {
                        lblSağlık5.Text = (dt5Yillik.Value - simdi).ToString();
                    }
                    vt.Tarihs.Add(t1);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("İşlem Başarılı");
                        TumKayitleriListele();
                        AlanlariTemizle();
                    }
                }
            }
             catch (Exception)
             {
                
             }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlanlariTemizle();
                DataGridViewRow str = dgSaglıkTarih.Rows[e.RowIndex];
                lblTarihID.Text = str.Cells[0].Value.ToString();
                perNo = Convert.ToInt32(str.Cells[1].Value);
                if (str.Cells[2].Value != null) dtUcak.Value = (DateTime)str.Cells[2].Value;
                if (str.Cells[3].Value != null) dtHeli.Value = (DateTime)str.Cells[3].Value;
                if (str.Cells[5].Value != null) dtYillik.Value = (DateTime)str.Cells[5].Value;
                if (str.Cells[7].Value != null) dt5Yillik.Value = (DateTime)str.Cells[7].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
        }
    }
}
