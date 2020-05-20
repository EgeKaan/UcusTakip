namespace SistemAnalizi_GörselProgramlama
{
    partial class KomutanIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KomutanIslemleri));
            this.lblPerSecim = new System.Windows.Forms.Label();
            this.lblKomutan_Subay = new System.Windows.Forms.Label();
            this.lblPer_Komutan_Subay = new System.Windows.Forms.Label();
            this.rbKomutan = new System.Windows.Forms.RadioButton();
            this.rbHarekatSubayi = new System.Windows.Forms.RadioButton();
            this.dgKomutan_Subay = new System.Windows.Forms.DataGridView();
            this.dgPer_Komutan_subay = new System.Windows.Forms.DataGridView();
            this.btnSecilenPerGoster = new System.Windows.Forms.Button();
            this.lblKomutanSubay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGuncellemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblKomutanAdSoyad = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblPerKomID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKomutan_Subay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPer_Komutan_subay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerSecim
            // 
            this.lblPerSecim.AutoSize = true;
            this.lblPerSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPerSecim.Location = new System.Drawing.Point(40, 18);
            this.lblPerSecim.Name = "lblPerSecim";
            this.lblPerSecim.Size = new System.Drawing.Size(126, 15);
            this.lblPerSecim.TabIndex = 13;
            this.lblPerSecim.Text = "Personelin Adı Soyadı";
            // 
            // lblKomutan_Subay
            // 
            this.lblKomutan_Subay.AutoSize = true;
            this.lblKomutan_Subay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKomutan_Subay.Location = new System.Drawing.Point(532, 197);
            this.lblKomutan_Subay.Name = "lblKomutan_Subay";
            this.lblKomutan_Subay.Size = new System.Drawing.Size(99, 15);
            this.lblKomutan_Subay.TabIndex = 12;
            this.lblKomutan_Subay.Text = "Tüm Komutanlar";
            // 
            // lblPer_Komutan_Subay
            // 
            this.lblPer_Komutan_Subay.AutoSize = true;
            this.lblPer_Komutan_Subay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPer_Komutan_Subay.Location = new System.Drawing.Point(126, 197);
            this.lblPer_Komutan_Subay.Name = "lblPer_Komutan_Subay";
            this.lblPer_Komutan_Subay.Size = new System.Drawing.Size(122, 15);
            this.lblPer_Komutan_Subay.TabIndex = 11;
            this.lblPer_Komutan_Subay.Text = "Personelin Komutanı";
            // 
            // rbKomutan
            // 
            this.rbKomutan.AutoSize = true;
            this.rbKomutan.Enabled = false;
            this.rbKomutan.Location = new System.Drawing.Point(146, 55);
            this.rbKomutan.Name = "rbKomutan";
            this.rbKomutan.Size = new System.Drawing.Size(67, 17);
            this.rbKomutan.TabIndex = 16;
            this.rbKomutan.TabStop = true;
            this.rbKomutan.Text = "Komutan";
            this.rbKomutan.UseVisualStyleBackColor = true;
            // 
            // rbHarekatSubayi
            // 
            this.rbHarekatSubayi.AutoSize = true;
            this.rbHarekatSubayi.Enabled = false;
            this.rbHarekatSubayi.Location = new System.Drawing.Point(219, 55);
            this.rbHarekatSubayi.Name = "rbHarekatSubayi";
            this.rbHarekatSubayi.Size = new System.Drawing.Size(98, 17);
            this.rbHarekatSubayi.TabIndex = 17;
            this.rbHarekatSubayi.TabStop = true;
            this.rbHarekatSubayi.Text = "Harekat Subayı";
            this.rbHarekatSubayi.UseVisualStyleBackColor = true;
            // 
            // dgKomutan_Subay
            // 
            this.dgKomutan_Subay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKomutan_Subay.Location = new System.Drawing.Point(400, 215);
            this.dgKomutan_Subay.Name = "dgKomutan_Subay";
            this.dgKomutan_Subay.Size = new System.Drawing.Size(346, 178);
            this.dgKomutan_Subay.TabIndex = 19;
            this.dgKomutan_Subay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKomutan_Subay_CellDoubleClick);
            // 
            // dgPer_Komutan_subay
            // 
            this.dgPer_Komutan_subay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPer_Komutan_subay.Location = new System.Drawing.Point(12, 215);
            this.dgPer_Komutan_subay.Name = "dgPer_Komutan_subay";
            this.dgPer_Komutan_subay.Size = new System.Drawing.Size(382, 178);
            this.dgPer_Komutan_subay.TabIndex = 20;
            this.dgPer_Komutan_subay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPer_Komutan_subay_CellDoubleClick);
            // 
            // btnSecilenPerGoster
            // 
            this.btnSecilenPerGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSecilenPerGoster.Location = new System.Drawing.Point(343, 3);
            this.btnSecilenPerGoster.Name = "btnSecilenPerGoster";
            this.btnSecilenPerGoster.Size = new System.Drawing.Size(113, 44);
            this.btnSecilenPerGoster.TabIndex = 23;
            this.btnSecilenPerGoster.Text = "Seçilen Personel Bilgilerini Listele";
            this.btnSecilenPerGoster.UseVisualStyleBackColor = true;
            this.btnSecilenPerGoster.Click += new System.EventHandler(this.btnSecilenPerGoster_Click);
            // 
            // lblKomutanSubay
            // 
            this.lblKomutanSubay.AutoSize = true;
            this.lblKomutanSubay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKomutanSubay.Location = new System.Drawing.Point(164, 89);
            this.lblKomutanSubay.Name = "lblKomutanSubay";
            this.lblKomutanSubay.Size = new System.Drawing.Size(72, 15);
            this.lblKomutanSubay.TabIndex = 24;
            this.lblKomutanSubay.Text = "Komutan ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Güncelleme Tarihi";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ID.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_ID.Location = new System.Drawing.Point(288, 89);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 15);
            this.lbl_ID.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(363, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Açıklama";
            // 
            // dtGuncellemeTarihi
            // 
            this.dtGuncellemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtGuncellemeTarihi.Location = new System.Drawing.Point(146, 128);
            this.dtGuncellemeTarihi.Name = "dtGuncellemeTarihi";
            this.dtGuncellemeTarihi.Size = new System.Drawing.Size(140, 21);
            this.dtGuncellemeTarihi.TabIndex = 28;
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAcıklama.Location = new System.Drawing.Point(426, 114);
            this.txtAcıklama.Multiline = true;
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(153, 51);
            this.txtAcıklama.TabIndex = 29;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEkle.Location = new System.Drawing.Point(632, 85);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuncelle.Location = new System.Drawing.Point(632, 114);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 31;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSil.Location = new System.Drawing.Point(632, 143);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(197, 20);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblAdSoyad.TabIndex = 33;
            // 
            // lblKomutanAdSoyad
            // 
            this.lblKomutanAdSoyad.AutoSize = true;
            this.lblKomutanAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKomutanAdSoyad.Location = new System.Drawing.Point(308, 89);
            this.lblKomutanAdSoyad.Name = "lblKomutanAdSoyad";
            this.lblKomutanAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblKomutanAdSoyad.TabIndex = 34;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label.Location = new System.Drawing.Point(27, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(19, 15);
            this.label.TabIndex = 35;
            this.label.Text = "ID";
            // 
            // lblPerKomID
            // 
            this.lblPerKomID.AutoSize = true;
            this.lblPerKomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPerKomID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPerKomID.Location = new System.Drawing.Point(52, 90);
            this.lblPerKomID.Name = "lblPerKomID";
            this.lblPerKomID.Size = new System.Drawing.Size(0, 15);
            this.lblPerKomID.TabIndex = 36;
            // 
            // KomutanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.lblPerKomID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblKomutanAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAcıklama);
            this.Controls.Add(this.dtGuncellemeTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKomutanSubay);
            this.Controls.Add(this.btnSecilenPerGoster);
            this.Controls.Add(this.dgPer_Komutan_subay);
            this.Controls.Add(this.dgKomutan_Subay);
            this.Controls.Add(this.rbHarekatSubayi);
            this.Controls.Add(this.rbKomutan);
            this.Controls.Add(this.lblPerSecim);
            this.Controls.Add(this.lblKomutan_Subay);
            this.Controls.Add(this.lblPer_Komutan_Subay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KomutanIslemleri";
            this.Text = "Komutan Islemleri";
            this.Load += new System.EventHandler(this.KomutanIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKomutan_Subay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPer_Komutan_subay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerSecim;
        private System.Windows.Forms.Label lblKomutan_Subay;
        private System.Windows.Forms.Label lblPer_Komutan_Subay;
        private System.Windows.Forms.RadioButton rbKomutan;
        private System.Windows.Forms.RadioButton rbHarekatSubayi;
        private System.Windows.Forms.DataGridView dgKomutan_Subay;
        private System.Windows.Forms.DataGridView dgPer_Komutan_subay;
        private System.Windows.Forms.Button btnSecilenPerGoster;
        private System.Windows.Forms.Label lblKomutanSubay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtGuncellemeTarihi;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblKomutanAdSoyad;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblPerKomID;
    }
}