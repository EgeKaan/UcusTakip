namespace SistemAnalizi_GörselProgramlama
{
    partial class KomutanBilgileriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KomutanBilgileriEkle));
            this.lblKomutanID = new System.Windows.Forms.Label();
            this.lblKomutan_Subay = new System.Windows.Forms.Label();
            this.dgKomutanBilgileri = new System.Windows.Forms.DataGridView();
            this.btnKomutanSil = new System.Windows.Forms.Button();
            this.btnKomutanGuncelle = new System.Windows.Forms.Button();
            this.btnKomutanKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKomutanUnvani = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKomutanRutbesi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKomutanSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKomutanAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgKomutanBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKomutanID
            // 
            this.lblKomutanID.AutoSize = true;
            this.lblKomutanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKomutanID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKomutanID.Location = new System.Drawing.Point(130, 40);
            this.lblKomutanID.Name = "lblKomutanID";
            this.lblKomutanID.Size = new System.Drawing.Size(0, 15);
            this.lblKomutanID.TabIndex = 30;
            // 
            // lblKomutan_Subay
            // 
            this.lblKomutan_Subay.AutoSize = true;
            this.lblKomutan_Subay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKomutan_Subay.Location = new System.Drawing.Point(43, 40);
            this.lblKomutan_Subay.Name = "lblKomutan_Subay";
            this.lblKomutan_Subay.Size = new System.Drawing.Size(72, 15);
            this.lblKomutan_Subay.TabIndex = 29;
            this.lblKomutan_Subay.Text = "Komutan ID";
            // 
            // dgKomutanBilgileri
            // 
            this.dgKomutanBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKomutanBilgileri.Location = new System.Drawing.Point(12, 203);
            this.dgKomutanBilgileri.Name = "dgKomutanBilgileri";
            this.dgKomutanBilgileri.Size = new System.Drawing.Size(416, 235);
            this.dgKomutanBilgileri.TabIndex = 27;
            this.dgKomutanBilgileri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKomutanBilgileri_CellDoubleClick);
            this.dgKomutanBilgileri.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKomutanBilgileri_CellMouseDown);
            // 
            // btnKomutanSil
            // 
            this.btnKomutanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnKomutanSil.Location = new System.Drawing.Point(294, 143);
            this.btnKomutanSil.Name = "btnKomutanSil";
            this.btnKomutanSil.Size = new System.Drawing.Size(75, 27);
            this.btnKomutanSil.TabIndex = 26;
            this.btnKomutanSil.Text = "Sil";
            this.btnKomutanSil.UseVisualStyleBackColor = true;
            this.btnKomutanSil.Click += new System.EventHandler(this.btnKomutanSil_Click);
            // 
            // btnKomutanGuncelle
            // 
            this.btnKomutanGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnKomutanGuncelle.Location = new System.Drawing.Point(294, 103);
            this.btnKomutanGuncelle.Name = "btnKomutanGuncelle";
            this.btnKomutanGuncelle.Size = new System.Drawing.Size(75, 27);
            this.btnKomutanGuncelle.TabIndex = 25;
            this.btnKomutanGuncelle.Text = "Güncelle";
            this.btnKomutanGuncelle.UseVisualStyleBackColor = true;
            this.btnKomutanGuncelle.Click += new System.EventHandler(this.btnKomutanGuncelle_Click);
            // 
            // btnKomutanKaydet
            // 
            this.btnKomutanKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnKomutanKaydet.Location = new System.Drawing.Point(294, 60);
            this.btnKomutanKaydet.Name = "btnKomutanKaydet";
            this.btnKomutanKaydet.Size = new System.Drawing.Size(75, 27);
            this.btnKomutanKaydet.TabIndex = 24;
            this.btnKomutanKaydet.Text = "Kaydet";
            this.btnKomutanKaydet.UseVisualStyleBackColor = true;
            this.btnKomutanKaydet.Click += new System.EventHandler(this.btnKomutanKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(63, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rütbesi ";
            // 
            // txtKomutanUnvani
            // 
            this.txtKomutanUnvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKomutanUnvani.Location = new System.Drawing.Point(133, 143);
            this.txtKomutanUnvani.Name = "txtKomutanUnvani";
            this.txtKomutanUnvani.ReadOnly = true;
            this.txtKomutanUnvani.Size = new System.Drawing.Size(128, 21);
            this.txtKomutanUnvani.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(67, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ünvanı ";
            // 
            // txtKomutanRutbesi
            // 
            this.txtKomutanRutbesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKomutanRutbesi.Location = new System.Drawing.Point(133, 116);
            this.txtKomutanRutbesi.Name = "txtKomutanRutbesi";
            this.txtKomutanRutbesi.Size = new System.Drawing.Size(128, 21);
            this.txtKomutanRutbesi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(71, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Soyadı";
            // 
            // txtKomutanSoyadi
            // 
            this.txtKomutanSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKomutanSoyadi.Location = new System.Drawing.Point(133, 89);
            this.txtKomutanSoyadi.Name = "txtKomutanSoyadi";
            this.txtKomutanSoyadi.Size = new System.Drawing.Size(128, 21);
            this.txtKomutanSoyadi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(91, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adı";
            // 
            // txtKomutanAdi
            // 
            this.txtKomutanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKomutanAdi.Location = new System.Drawing.Point(133, 63);
            this.txtKomutanAdi.Name = "txtKomutanAdi";
            this.txtKomutanAdi.Size = new System.Drawing.Size(128, 21);
            this.txtKomutanAdi.TabIndex = 0;
            // 
            // KomutanBilgileriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.dgKomutanBilgileri);
            this.Controls.Add(this.lblKomutanID);
            this.Controls.Add(this.lblKomutan_Subay);
            this.Controls.Add(this.txtKomutanAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKomutanSil);
            this.Controls.Add(this.txtKomutanSoyadi);
            this.Controls.Add(this.btnKomutanGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKomutanKaydet);
            this.Controls.Add(this.txtKomutanRutbesi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKomutanUnvani);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KomutanBilgileriEkle";
            this.Text = "Harekat Subayı Bilgi İşlemleri";
            this.Load += new System.EventHandler(this.KomutanBilgileriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKomutanBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKomutanID;
        private System.Windows.Forms.Label lblKomutan_Subay;
        private System.Windows.Forms.DataGridView dgKomutanBilgileri;
        private System.Windows.Forms.Button btnKomutanSil;
        private System.Windows.Forms.Button btnKomutanGuncelle;
        private System.Windows.Forms.Button btnKomutanKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKomutanUnvani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKomutanRutbesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKomutanSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKomutanAdi;
    }
}