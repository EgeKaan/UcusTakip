namespace SistemAnalizi_GörselProgramlama
{
    partial class KullaniciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciIslemleri));
            this.dgKullanici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblPerID = new System.Windows.Forms.Label();
            this.lblKullaniciID = new System.Windows.Forms.Label();
            this.rbYonetici = new System.Windows.Forms.RadioButton();
            this.rbPersonel = new System.Windows.Forms.RadioButton();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKullanici
            // 
            this.dgKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKullanici.Location = new System.Drawing.Point(12, 112);
            this.dgKullanici.Name = "dgKullanici";
            this.dgKullanici.Size = new System.Drawing.Size(543, 326);
            this.dgKullanici.TabIndex = 0;
            this.dgKullanici.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKullanici_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(231, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(231, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEkle.Location = new System.Drawing.Point(467, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuncelle.Location = new System.Drawing.Point(467, 38);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSil.Location = new System.Drawing.Point(467, 66);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblPerID
            // 
            this.lblPerID.AutoSize = true;
            this.lblPerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPerID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPerID.Location = new System.Drawing.Point(88, 13);
            this.lblPerID.Name = "lblPerID";
            this.lblPerID.Size = new System.Drawing.Size(0, 15);
            this.lblPerID.TabIndex = 9;
            // 
            // lblKullaniciID
            // 
            this.lblKullaniciID.AutoSize = true;
            this.lblKullaniciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKullaniciID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKullaniciID.Location = new System.Drawing.Point(88, 41);
            this.lblKullaniciID.Name = "lblKullaniciID";
            this.lblKullaniciID.Size = new System.Drawing.Size(0, 15);
            this.lblKullaniciID.TabIndex = 10;
            // 
            // rbYonetici
            // 
            this.rbYonetici.AutoSize = true;
            this.rbYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbYonetici.Location = new System.Drawing.Point(91, 67);
            this.rbYonetici.Name = "rbYonetici";
            this.rbYonetici.Size = new System.Drawing.Size(68, 19);
            this.rbYonetici.TabIndex = 11;
            this.rbYonetici.TabStop = true;
            this.rbYonetici.Text = "Yönetici";
            this.rbYonetici.UseVisualStyleBackColor = true;
            // 
            // rbPersonel
            // 
            this.rbPersonel.AutoSize = true;
            this.rbPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPersonel.Location = new System.Drawing.Point(160, 67);
            this.rbPersonel.Name = "rbPersonel";
            this.rbPersonel.Size = new System.Drawing.Size(74, 19);
            this.rbPersonel.TabIndex = 12;
            this.rbPersonel.TabStop = true;
            this.rbPersonel.Text = "Personel";
            this.rbPersonel.UseVisualStyleBackColor = true;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(311, 9);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(132, 21);
            this.txtKullaniciAdi.TabIndex = 13;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSifre.Location = new System.Drawing.Point(311, 38);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(132, 21);
            this.txtSifre.TabIndex = 14;
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.rbPersonel);
            this.Controls.Add(this.rbYonetici);
            this.Controls.Add(this.lblKullaniciID);
            this.Controls.Add(this.lblPerID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgKullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciIslemleri";
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblPerID;
        private System.Windows.Forms.Label lblKullaniciID;
        private System.Windows.Forms.RadioButton rbYonetici;
        private System.Windows.Forms.RadioButton rbPersonel;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
    }
}