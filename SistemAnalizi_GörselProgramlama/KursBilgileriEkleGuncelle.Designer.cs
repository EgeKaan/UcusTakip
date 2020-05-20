namespace SistemAnalizi_GörselProgramlama
{
    partial class KursBilgileriEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursBilgileriEkleGuncelle));
            this.dgKusBilgileri = new System.Windows.Forms.DataGridView();
            this.lblKursNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKursAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKusBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKusBilgileri
            // 
            this.dgKusBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKusBilgileri.Location = new System.Drawing.Point(12, 110);
            this.dgKusBilgileri.Name = "dgKusBilgileri";
            this.dgKusBilgileri.Size = new System.Drawing.Size(416, 314);
            this.dgKusBilgileri.TabIndex = 42;
            this.dgKusBilgileri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKusBilgileri_CellDoubleClick);
            // 
            // lblKursNo
            // 
            this.lblKursNo.AutoSize = true;
            this.lblKursNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKursNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKursNo.Location = new System.Drawing.Point(134, 24);
            this.lblKursNo.Name = "lblKursNo";
            this.lblKursNo.Size = new System.Drawing.Size(0, 15);
            this.lblKursNo.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Kurs No";
            // 
            // txtKursAdi
            // 
            this.txtKursAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKursAdi.Location = new System.Drawing.Point(137, 47);
            this.txtKursAdi.Name = "txtKursAdi";
            this.txtKursAdi.Size = new System.Drawing.Size(128, 21);
            this.txtKursAdi.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(68, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kurs Adı";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSil.Location = new System.Drawing.Point(286, 77);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 27);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnGuncelle.Location = new System.Drawing.Point(286, 44);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 27);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnKaydet.Location = new System.Drawing.Point(286, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 27);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // KursBilgileriEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.dgKusBilgileri);
            this.Controls.Add(this.lblKursNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKursAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KursBilgileriEkleGuncelle";
            this.Text = "Kurs Bilgi İşlemleri";
            this.Load += new System.EventHandler(this.KursBilgileriEkleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKusBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKusBilgileri;
        private System.Windows.Forms.Label lblKursNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKursAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
    }
}