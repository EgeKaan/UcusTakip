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
    public partial class PersonelSecimi : Form
    {
        public PersonelSecimi()
        {
            InitializeComponent();
        }

        private void PersonelSecimi_Load(object sender, EventArgs e)
        {
            TumKayitleriListele();
        }

        void TumKayitleriListele()
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dgPersonelSecimi.DataSource = vt.Personels.ToList();
            string columnName;
            for (int i = 7; i < 19; i++)
            {
                columnName = dgPersonelSecimi.Columns[i].HeaderCell.Value.ToString();
                dgPersonelSecimi.Columns[columnName].Visible = false;
            }
        }

        DataGridViewRow seciliSatir;
        private void dgPersonelSecimi_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                seciliSatir = dgPersonelSecimi.Rows[e.RowIndex];
            }
        }

        private void dgPersonelSecimi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlanlariTemizle();
                UcusTakipEntities vt = new UcusTakipEntities();
                DataGridViewRow str = dgPersonelSecimi.Rows[e.RowIndex];
                if (str.Cells[1].Value != null & str.Cells[2].Value != null) lblAdSoyad.Text = (str.Cells[1].Value.ToString()) + " " + (str.Cells[2].Value.ToString());
                else if (str.Cells[1].Value != null) lblAdSoyad.Text = (str.Cells[1].Value.ToString());
                lblPerNo.Text = str.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.");
            }
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            UcusTakipEntities vt = new UcusTakipEntities();
            dgPersonelSecimi.DataSource = vt.Personels.Where(p => p.Ad.Contains(txtSorgu.Text)).ToList();
        }

        void AlanlariTemizle()
        {
            lblAdSoyad.Text = string.Empty;
            lblPerNo.Text = string.Empty;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secOnaylama = new DialogResult();
                secOnaylama = MessageBox.Show(lblAdSoyad.Text + " Adlı personeli seçtiğinizi onaylıyor musunuz?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo);
                if (secOnaylama == DialogResult.Yes)
                {
                    SecilenPersonel.PersonelNo = 0;
                    SecilenPersonel.PersonelNo = Convert.ToInt32(lblPerNo.Text);
                    SecilenPersonel.PerdsonelAdSoyad = string.Empty;
                    SecilenPersonel.PerdsonelAdSoyad = lblAdSoyad.Text;
                    MessageBox.Show(" Seçim işlemi başarılı.");
                }
                if (secOnaylama == DialogResult.No) MessageBox.Show(" Seçim onaylanmadı. \n Lütfen tekrar seçim yapınız!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen seçim yaparken çift tıklayınız.");
            }

        }
    }
}
