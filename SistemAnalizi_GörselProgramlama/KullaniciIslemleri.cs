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
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }

        private int kullaniciID, personelID, rolNo;

        private void dgKullanici_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow str = dgKullanici.Rows[e.RowIndex];
                lblKullaniciID.Text = str.Cells[0].Value.ToString();
                if (str.Cells[1].Value.ToString() == "Yönetici")
                    rbYonetici.Checked = true;
                else
                    rbPersonel.Checked = true;
                lblPerID.Text = str.Cells[2].Value.ToString();
                txtKullaniciAdi.Text = str.Cells[3].Value.ToString();
                txtSifre.Text = str.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text)) MessageBox.Show("Lütfen boş alanları doldurunuz.");
                else
                {
                    int perNo = 0;
                    string perAd = string.Empty;
                    string perSoyad = string.Empty;
                    UcusTakipEntities vt = new UcusTakipEntities();
                    if (string.IsNullOrEmpty(lblPerID.Text))
                    {
                        Personel p = new Personel();

                        perAd = txtKullaniciAdi.Text;
                        p.Ad = perAd;

                        vt.Personels.Add(p);
                        vt.SaveChanges();
                        var perList = vt.Personels.ToList();

                        foreach (var item in perList)
                        {
                            if (item.Ad == perAd) perNo = item.PersonelNo;
                        }


                        Kullanici k = new Kullanici();
                        k.KullaniciAdi = txtKullaniciAdi.Text;
                        k.PersonelID = perNo;
                        k.Sifre = txtSifre.Text;
                        k.RolID = rbYonetici.Checked ? 1 : 2;
                        vt.Kullanicis.Add(k);
                        int sonuc = vt.SaveChanges();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kayıt Başarılı");
                            TumKayitlariListele();
                        }
                    }
                    else
                    {
                        Kullanici k = new Kullanici();
                        k.KullaniciAdi = txtKullaniciAdi.Text;
                        k.PersonelID = personelID;
                        k.Sifre = txtSifre.Text;
                        k.RolID = rbYonetici.Checked ? 1 : 2;
                        vt.Kullanicis.Add(k);
                        int sonuc = vt.SaveChanges();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kayıt Başarılı");
                            TumKayitlariListele();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden veri çekmeden tekrar deneyiniz.");
            }
            finally { lblKullaniciID.Text = string.Empty;lblPerID.Text = string.Empty; } 
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = Convert.ToInt32(lblKullaniciID.Text);
                UcusTakipEntities vt = new UcusTakipEntities();
                Kullanici k = vt.Kullanicis.FirstOrDefault(p => p.KullanıcıID == secilen);
                k.KullaniciAdi = txtKullaniciAdi.Text;
                k.Sifre = txtSifre.Text;
                k.RolID = rbYonetici.Checked ? 1 : 2;
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                    TumKayitlariListele();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı bilgileri ilk defa oluşturulacak personelin kaydı için\" Kullanıcı Ekle\" panelinden işlem yapınız."); 
            }

            finally { txtKullaniciAdi.Text = string.Empty;txtSifre.Text = string.Empty; }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = Convert.ToInt32(lblKullaniciID.Text);
                DialogResult silOnaylama = new DialogResult();
                silOnaylama = MessageBox.Show(secilen + " Numaralı kullanıcı Kaydını silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                if (silOnaylama == DialogResult.Yes)
                {
                    UcusTakipEntities vt = new UcusTakipEntities();
                    Kullanici k = vt.Kullanicis.FirstOrDefault(p => p.KullanıcıID == secilen);
                    vt.Kullanicis.Remove(k);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Silme İşlemi Başarılı");
                        TumKayitlariListele();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı kaydı yoktur. \n Lütfen kayıtlı kullanıcı seçiniz. ");
            }
            
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnEkle.Visible = false;
            if (TıklanılanButon.butonAdi_2 == "Ekle") btnEkle.Visible = true;
            if (TıklanılanButon.butonAdi_2 == "Guncelle") btnGuncelle.Visible = true;
            if (TıklanılanButon.butonAdi_2 == "Sil") btnSil.Visible = true;
            TumKayitlariListele();
        }

        void TumKayitlariListele()
        {
            dgKullanici.Columns.Clear();

            dgKullanici.ColumnCount = 5;
            dgKullanici.Columns[0].Name = "Kullanıcı ID";
            dgKullanici.Columns[1].Name = "Rol";
            dgKullanici.Columns[2].Name = "Ad Soyad";
            dgKullanici.Columns[3].Name = "Kullanıcı Adı";
            dgKullanici.Columns[4].Name = "Şifre";

            string kullaniciAdi, sifre,ad,soyad;
            UcusTakipEntities vt = new UcusTakipEntities();
            var perList = vt.Personels.ToList();
            foreach (var item in perList)
            {
                personelID = item.PersonelNo;
                ad = item.Ad;
                soyad = item.Soyad;
                string kayitYok = string.Empty;
                var kullaniciList = vt.Kullanicis.FirstOrDefault(p=>p.PersonelID==personelID);
                if (kullaniciList != null)
                {
                    kullaniciID = kullaniciList.KullanıcıID;
                    rolNo = kullaniciList.RolID;
                    string kulID = kullaniciID.ToString();
                    string rolID = string.Empty;
                    if (rolNo == 1) rolID = "Yönetici";
                    if (rolNo == 2) rolID = "Personel";
                    kullaniciAdi = kullaniciList.KullaniciAdi;
                    sifre = kullaniciList.Sifre;
                    string[] satir = new string[]
                           { kulID,rolID,ad+" "+soyad,kullaniciAdi,sifre};
                    dgKullanici.Rows.Add(satir);
                }
                if (kullaniciList == null)
                {
                    string[] deneme = new string[]
                        {kayitYok,kayitYok, ad + " " + soyad,kayitYok,kayitYok };
                    dgKullanici.Rows.Add(deneme);
                }
            }

        }
    }
}
