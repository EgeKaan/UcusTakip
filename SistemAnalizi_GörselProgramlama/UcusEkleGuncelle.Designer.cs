namespace SistemAnalizi_GörselProgramlama
{
    partial class UcusEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcusEkleGuncelle));
            this.dgUcus = new System.Windows.Forms.DataGridView();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUcusNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.txtUcusSuresi = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblAracAdi = new System.Windows.Forms.Label();
            this.lblAracTuru = new System.Windows.Forms.Label();
            this.lblUcusTipi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUcus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUcus
            // 
            this.dgUcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUcus.Location = new System.Drawing.Point(12, 106);
            this.dgUcus.Name = "dgUcus";
            this.dgUcus.Size = new System.Drawing.Size(776, 332);
            this.dgUcus.TabIndex = 92;
            this.dgUcus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUcus_CellDoubleClick);
            this.dgUcus.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgUcus_CellMouseDown);
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtTarih.Location = new System.Drawing.Point(358, 34);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(134, 21);
            this.dtTarih.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(267, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 104;
            this.label2.Text = "Uçuş Tarihi";
            // 
            // lblUcusNo
            // 
            this.lblUcusNo.AutoSize = true;
            this.lblUcusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUcusNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUcusNo.Location = new System.Drawing.Point(121, 12);
            this.lblUcusNo.Name = "lblUcusNo";
            this.lblUcusNo.Size = new System.Drawing.Size(0, 15);
            this.lblUcusNo.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 102;
            this.label1.Text = "Uçuş No";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuncelle.Location = new System.Drawing.Point(570, 16);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 41);
            this.btnGuncelle.TabIndex = 101;
            this.btnGuncelle.Text = "Uçuş Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label32.Location = new System.Drawing.Point(239, 65);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 15);
            this.label32.TabIndex = 100;
            this.label32.Text = "Ucus Süresi (dk)";
            // 
            // txtUcusSuresi
            // 
            this.txtUcusSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUcusSuresi.Location = new System.Drawing.Point(358, 62);
            this.txtUcusSuresi.MaxLength = 1000;
            this.txtUcusSuresi.Name = "txtUcusSuresi";
            this.txtUcusSuresi.Size = new System.Drawing.Size(134, 21);
            this.txtUcusSuresi.TabIndex = 99;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label31.Location = new System.Drawing.Point(278, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 15);
            this.label31.TabIndex = 98;
            this.label31.Text = "Uçuş Tipi";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label30.Location = new System.Drawing.Point(40, 68);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 15);
            this.label30.TabIndex = 96;
            this.label30.Text = "Aracın Adı";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label29.Location = new System.Drawing.Point(32, 42);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 15);
            this.label29.TabIndex = 94;
            this.label29.Text = "Aracın Türü";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSil.Location = new System.Drawing.Point(570, 61);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 29);
            this.btnSil.TabIndex = 108;
            this.btnSil.Text = "Uçuş Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnListele.Location = new System.Drawing.Point(695, 35);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(93, 55);
            this.btnListele.TabIndex = 111;
            this.btnListele.Text = "Seçilen Personeli Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAdSoyad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdSoyad.Location = new System.Drawing.Point(692, 8);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblAdSoyad.TabIndex = 109;
            // 
            // lblAracAdi
            // 
            this.lblAracAdi.AutoSize = true;
            this.lblAracAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAracAdi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAracAdi.Location = new System.Drawing.Point(121, 70);
            this.lblAracAdi.Name = "lblAracAdi";
            this.lblAracAdi.Size = new System.Drawing.Size(0, 15);
            this.lblAracAdi.TabIndex = 112;
            // 
            // lblAracTuru
            // 
            this.lblAracTuru.AutoSize = true;
            this.lblAracTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAracTuru.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAracTuru.Location = new System.Drawing.Point(121, 44);
            this.lblAracTuru.Name = "lblAracTuru";
            this.lblAracTuru.Size = new System.Drawing.Size(0, 15);
            this.lblAracTuru.TabIndex = 113;
            // 
            // lblUcusTipi
            // 
            this.lblUcusTipi.AutoSize = true;
            this.lblUcusTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUcusTipi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUcusTipi.Location = new System.Drawing.Point(355, 11);
            this.lblUcusTipi.Name = "lblUcusTipi";
            this.lblUcusTipi.Size = new System.Drawing.Size(0, 15);
            this.lblUcusTipi.TabIndex = 114;
            // 
            // UcusEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUcusTipi);
            this.Controls.Add(this.lblAracTuru);
            this.Controls.Add(this.lblAracAdi);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUcusNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtUcusSuresi);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.dgUcus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UcusEkleGuncelle";
            this.Text = "Uçuş Güncelle";
            this.Load += new System.EventHandler(this.UsucEkleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUcus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgUcus;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUcusNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtUcusSuresi;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblAracAdi;
        private System.Windows.Forms.Label lblAracTuru;
        private System.Windows.Forms.Label lblUcusTipi;
    }
}