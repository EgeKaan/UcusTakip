namespace SistemAnalizi_GörselProgramlama
{
    partial class UcusIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcusIslemleri));
            this.label32 = new System.Windows.Forms.Label();
            this.txtUcusSuresi = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cbUcusTipi = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cbAracAdi = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cbAracTuru = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgUcus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUcusNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnPerSec = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUcus)).BeginInit();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label32.Location = new System.Drawing.Point(302, 66);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 15);
            this.label32.TabIndex = 73;
            this.label32.Text = "Ucus Süresi (dk)";
            // 
            // txtUcusSuresi
            // 
            this.txtUcusSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUcusSuresi.Location = new System.Drawing.Point(421, 63);
            this.txtUcusSuresi.MaxLength = 1000;
            this.txtUcusSuresi.Name = "txtUcusSuresi";
            this.txtUcusSuresi.Size = new System.Drawing.Size(134, 21);
            this.txtUcusSuresi.TabIndex = 72;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label31.Location = new System.Drawing.Point(341, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 15);
            this.label31.TabIndex = 71;
            this.label31.Text = "Uçuş Tipi";
            // 
            // cbUcusTipi
            // 
            this.cbUcusTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbUcusTipi.FormattingEnabled = true;
            this.cbUcusTipi.Items.AddRange(new object[] {
            "GÖREREK UÇUŞ KURALLARI (GUK)",
            "GECE UÇUŞ KURALLARI  (GECE)",
            "GECE GÖRÜŞ GÖZLÜĞÜ (GGG)"});
            this.cbUcusTipi.Location = new System.Drawing.Point(421, 9);
            this.cbUcusTipi.Name = "cbUcusTipi";
            this.cbUcusTipi.Size = new System.Drawing.Size(134, 23);
            this.cbUcusTipi.TabIndex = 70;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label30.Location = new System.Drawing.Point(43, 62);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 15);
            this.label30.TabIndex = 69;
            this.label30.Text = "Aracın Adı";
            // 
            // cbAracAdi
            // 
            this.cbAracAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbAracAdi.FormattingEnabled = true;
            this.cbAracAdi.Location = new System.Drawing.Point(126, 59);
            this.cbAracAdi.Name = "cbAracAdi";
            this.cbAracAdi.Size = new System.Drawing.Size(134, 23);
            this.cbAracAdi.TabIndex = 68;
            this.cbAracAdi.SelectedIndexChanged += new System.EventHandler(this.cbAracAdi_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label29.Location = new System.Drawing.Point(36, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 15);
            this.label29.TabIndex = 67;
            this.label29.Text = "Aracın Türü";
            // 
            // cbAracTuru
            // 
            this.cbAracTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbAracTuru.FormattingEnabled = true;
            this.cbAracTuru.Items.AddRange(new object[] {
            "Uçak",
            "Helikopter"});
            this.cbAracTuru.Location = new System.Drawing.Point(126, 32);
            this.cbAracTuru.Name = "cbAracTuru";
            this.cbAracTuru.Size = new System.Drawing.Size(134, 23);
            this.cbAracTuru.TabIndex = 66;
            this.cbAracTuru.SelectedIndexChanged += new System.EventHandler(this.cbAracTuru_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEkle.Location = new System.Drawing.Point(582, 61);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 29);
            this.btnEkle.TabIndex = 74;
            this.btnEkle.Text = "Uçuş Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgUcus
            // 
            this.dgUcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUcus.Location = new System.Drawing.Point(12, 106);
            this.dgUcus.Name = "dgUcus";
            this.dgUcus.Size = new System.Drawing.Size(776, 332);
            this.dgUcus.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Uçuş No";
            // 
            // lblUcusNo
            // 
            this.lblUcusNo.AutoSize = true;
            this.lblUcusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUcusNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUcusNo.Location = new System.Drawing.Point(123, 8);
            this.lblUcusNo.Name = "lblUcusNo";
            this.lblUcusNo.Size = new System.Drawing.Size(0, 15);
            this.lblUcusNo.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(330, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Uçuş Tarihi";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtTarih.Location = new System.Drawing.Point(421, 35);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(134, 21);
            this.dtTarih.TabIndex = 81;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAdSoyad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdSoyad.Location = new System.Drawing.Point(692, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblAdSoyad.TabIndex = 83;
            // 
            // btnPerSec
            // 
            this.btnPerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPerSec.Location = new System.Drawing.Point(695, 27);
            this.btnPerSec.Name = "btnPerSec";
            this.btnPerSec.Size = new System.Drawing.Size(93, 73);
            this.btnPerSec.TabIndex = 84;
            this.btnPerSec.Text = "Seçilen Personelin Bilgilerini Listele";
            this.btnPerSec.UseVisualStyleBackColor = true;
            this.btnPerSec.Click += new System.EventHandler(this.btnPerSec_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "Önizleme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UcusIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPerSec);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUcusNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUcus);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtUcusSuresi);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.cbUcusTipi);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.cbAracAdi);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.cbAracTuru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UcusIslemleri";
            this.Text = "Uçuş Ekle";
            this.Load += new System.EventHandler(this.UcusIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUcus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtUcusSuresi;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cbUcusTipi;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cbAracAdi;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbAracTuru;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgUcus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUcusNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnPerSec;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button2;
    }
}