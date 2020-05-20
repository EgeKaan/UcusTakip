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
    public partial class HavaAraciIslemleriYetkilendirme : Form
    {
        public HavaAraciIslemleriYetkilendirme()
        {
            InitializeComponent();
        }
        private int perNo = KullaniciRol.KullaniciID;

        private void HavaAraciIslemleri_Load(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();

            if (KullaniciRol.KullaniciRolu == "Personel")
            {
                perNo = KullaniciRol.KullaniciID;
                lblPerSecim.Text = "PersonelNo";
                var perList = vt.Personels.FirstOrDefault(p => p.PersonelNo == perNo);
                lblAdSoyad.Text = perList.Ad + " " + perList.Soyad;
                cbListele();
                YetkiListele();
                button1.Visible = false;
            }

            if (KullaniciRol.KullaniciRolu == "Yonetici")
            {
                btnHavaAracKaydet.Visible = true;
                btnSil.Visible = true;
            }
            if (TıklanılanButon.butonAdi == "Sil")  btnHavaAracKaydet.Visible = false;
            if (TıklanılanButon.butonAdi == "Ekle")  btnSil.Visible = false;
        }
        void YetkiListele()
        {
            dgYetki.Columns.Clear();
            dgYetki.ColumnCount = 3;
            dgYetki.Columns[0].Name = "Personel Yetki No.";
            dgYetki.Columns[1].Name = "Aracın Adı";
            dgYetki.Columns[2].Name = "Uçuş Süresi(dk)";
            UcusTakipEntities vt = new UcusTakipEntities();
            var yetki = vt.PersonelAracYetkis.Where(p => p.PersonelNo == perNo && p.YetkisiVar == true).ToList();
            var havaAraci = vt.HavaAracları.ToList();
            foreach (var item in yetki)
            {
                string id = string.Empty; string ucusSuresi = string.Empty; string aracAdi = string.Empty;
                 id = item.PersonelAracYetkiID.ToString();
                 ucusSuresi = item.AracToplamUcusSuresi.ToString();
                foreach (var i in havaAraci)
                {
                    if (i.HavaAraciNo==item.HavaAraciNo)
                    {
                        aracAdi = i.HavaAraciAdi;
                        string[] satir = new string[]
                            { id,aracAdi,ucusSuresi};
                        dgYetki.Rows.Add(satir);

                    }
                }
            }
        }

        void cbListele()
        {
            cbAracTipi.Items.Clear();
            cbHavaAraci.Items.Clear();
            cbAracTipi.Items.Add("Uçak");
            cbAracTipi.Items.Add("Helikopter");
        }
        private string secilenAracNo=null;
        private int YetkiNo = 0;
        private int secilenAracınNumarası = 0;

        private void btnHavaAracKaydet_Click(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            int yeniKayit = 0;

            var list = vt.PersonelAracYetkis.Where(p => p.PersonelNo == perNo).ToList();
            foreach (var i in list)
            {
                if (i.HavaAraciNo == Convert.ToInt32(secilenAracNo) & i.YetkisiVar == false)
                {
                    PersonelAracYetki a = vt.PersonelAracYetkis.FirstOrDefault(p => p.PersonelAracYetkiID == i.PersonelAracYetkiID);
                    a.YetkisiVar = true;
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Araç Yetkisi Tekrar verilmiştir");
                        txtToplamUcus.Text = null;
                        lblSecilenArac.Text = string.Empty;
                    }
                    yeniKayit = 1;
                }
            }


            if (secilenAracNo != null & yeniKayit == 0)
            {
                PersonelAracYetki y = new PersonelAracYetki();
                y.HavaAraciNo = Convert.ToInt32(secilenAracNo);
                y.PersonelNo = perNo;
                y.YetkisiVar = true;
                if (txtToplamUcus.Text != "")
                {
                    y.AracToplamUcusSuresi = Convert.ToInt32(txtToplamUcus.Text);
                    vt.PersonelAracYetkis.Add(y);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt İşlemi Başarılı");
                        txtToplamUcus.Text = null;
                        lblSecilenArac.Text = string.Empty;
                    }
                    
                }
                else MessageBox.Show("Toplam Uçuş Süresini Girmediniz");
            }
            else MessageBox.Show("Lütfen Bir Araç Seçiniz");

            YetkiListele();
        }

        private void cbHavaAraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtToplamUcus.Text = null;
            UcusTakipEntities vt = new UcusTakipEntities();
            lblSecilenArac.Text = string.Empty;
            lblSecilenArac.Text = cbHavaAraci.SelectedItem.ToString();
            var list2 = vt.HavaAracları.FirstOrDefault(p => p.HavaAraciAdi == lblSecilenArac.Text);
            secilenAracNo = list2.HavaAraciNo.ToString();
            secilenAracınNumarası = Convert.ToInt32(secilenAracNo);
            var list = vt.PersonelAracYetkis.FirstOrDefault(p => p.HavaAraciNo == secilenAracınNumarası & p.PersonelNo==perNo);
            if (list != null)
            {
                YetkiNo = list.PersonelAracYetkiID;
                txtToplamUcus.Text = null;
                if(list.AracToplamUcusSuresi!=null) txtToplamUcus.Text = list.AracToplamUcusSuresi.ToString();
            }
        }
       private int silinecekAracNo = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSecilenArac.Text) ) MessageBox.Show("Lütfen kayıt seçimi yapınız.");
            else
            {
                UcusTakipEntities vt = new UcusTakipEntities();
                string silinecekAracAdi = lblSecilenArac.Text;
                var list = vt.HavaAracları.ToList();
                foreach (var i in list)
                {
                    if (i.HavaAraciAdi == silinecekAracAdi) silinecekAracNo = i.HavaAraciNo;
                }
                DialogResult silOnaylama = new DialogResult();
                silOnaylama = MessageBox.Show(silinecekAracAdi + " Adlı araç kaydını silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                if (silOnaylama == DialogResult.Yes)
                {
                    PersonelAracYetki y = vt.PersonelAracYetkis.FirstOrDefault(p => p.PersonelNo == perNo);
                    y.YetkisiVar = false;
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Silme İşlemi Başarılı");
                        txtToplamUcus.Text = null;
                        lblSecilenArac.Text = string.Empty;
                    }
                }
                if (silOnaylama == DialogResult.No) MessageBox.Show(silinecekAracAdi + " Adlı araç kaydı silinmedi.");

            }
        }

        private void cbAracTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHavaAraci.Items.Clear();
            UcusTakipEntities vt = new UcusTakipEntities();
            if (cbAracTipi.SelectedIndex==0)
            {
                string tip = "Uçak";
                var list2 = vt.HavaAracları.Where(p => p.HavaAraciTipi == tip).ToList();
                foreach (var i in list2)
                {
                    cbHavaAraci.Items.Add(i.HavaAraciAdi);
                }
            }

            if (cbAracTipi.SelectedIndex == 1)
            {
                string tip = "Helikopter";
                var list2 = vt.HavaAracları.Where(p => p.HavaAraciTipi == tip).ToList();
                foreach (var i in list2)
                {
                    cbHavaAraci.Items.Add(i.HavaAraciAdi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                YetkiListele();
                cbListele();
            }
        }

        private void dgYetki_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow str = dgYetki.Rows[e.RowIndex];
                lblSecilenArac.Text = str.Cells[1].Value.ToString();
                txtToplamUcus.Text = str.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
        }
    }
}
