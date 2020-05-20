namespace SistemAnalizi_GörselProgramlama
{
    partial class HavaAraciIslemleriYetkilendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HavaAraciIslemleriYetkilendirme));
            this.lblPerSecim = new System.Windows.Forms.Label();
            this.btnHavaAracKaydet = new System.Windows.Forms.Button();
            this.cbAracTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHavaAraci = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamUcus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSecilenArac = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.dgYetki = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgYetki)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerSecim
            // 
            this.lblPerSecim.AutoSize = true;
            this.lblPerSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPerSecim.Location = new System.Drawing.Point(17, 23);
            this.lblPerSecim.Name = "lblPerSecim";
            this.lblPerSecim.Size = new System.Drawing.Size(110, 15);
            this.lblPerSecim.TabIndex = 20;
            this.lblPerSecim.Text = "Personel Ad Soyad";
            // 
            // btnHavaAracKaydet
            // 
            this.btnHavaAracKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHavaAracKaydet.Location = new System.Drawing.Point(352, 112);
            this.btnHavaAracKaydet.Name = "btnHavaAracKaydet";
            this.btnHavaAracKaydet.Size = new System.Drawing.Size(75, 33);
            this.btnHavaAracKaydet.TabIndex = 19;
            this.btnHavaAracKaydet.Text = "Yetki Ver";
            this.btnHavaAracKaydet.UseVisualStyleBackColor = true;
            this.btnHavaAracKaydet.Click += new System.EventHandler(this.btnHavaAracKaydet_Click);
            // 
            // cbAracTipi
            // 
            this.cbAracTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbAracTipi.FormattingEnabled = true;
            this.cbAracTipi.Location = new System.Drawing.Point(117, 60);
            this.cbAracTipi.Name = "cbAracTipi";
            this.cbAracTipi.Size = new System.Drawing.Size(160, 23);
            this.cbAracTipi.TabIndex = 22;
            this.cbAracTipi.SelectedIndexChanged += new System.EventHandler(this.cbAracTipi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hava Aracı Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(295, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Hava Aracı ";
            // 
            // cbHavaAraci
            // 
            this.cbHavaAraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbHavaAraci.FormattingEnabled = true;
            this.cbHavaAraci.Location = new System.Drawing.Point(364, 60);
            this.cbHavaAraci.Name = "cbHavaAraci";
            this.cbHavaAraci.Size = new System.Drawing.Size(160, 23);
            this.cbHavaAraci.TabIndex = 24;
            this.cbHavaAraci.SelectedIndexChanged += new System.EventHandler(this.cbHavaAraci_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSil.Location = new System.Drawing.Point(444, 112);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 32);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Yetkiyi Al";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Toplam Uçuş Süresi";
            // 
            // txtToplamUcus
            // 
            this.txtToplamUcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtToplamUcus.Location = new System.Drawing.Point(139, 118);
            this.txtToplamUcus.Name = "txtToplamUcus";
            this.txtToplamUcus.Size = new System.Drawing.Size(114, 21);
            this.txtToplamUcus.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Seçilen Hava Aracı";
            // 
            // lblSecilenArac
            // 
            this.lblSecilenArac.AutoSize = true;
            this.lblSecilenArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSecilenArac.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSecilenArac.Location = new System.Drawing.Point(140, 96);
            this.lblSecilenArac.Name = "lblSecilenArac";
            this.lblSecilenArac.Size = new System.Drawing.Size(0, 15);
            this.lblSecilenArac.TabIndex = 33;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(140, 25);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblAdSoyad.TabIndex = 34;
            // 
            // dgYetki
            // 
            this.dgYetki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgYetki.Location = new System.Drawing.Point(12, 172);
            this.dgYetki.Name = "dgYetki";
            this.dgYetki.Size = new System.Drawing.Size(520, 266);
            this.dgYetki.TabIndex = 35;
            this.dgYetki.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgYetki_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(364, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
            this.button1.TabIndex = 36;
            this.button1.Text = "Seçili Personel Bilgilerini Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HavaAraciIslemleriYetkilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgYetki);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblSecilenArac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToplamUcus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHavaAraci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAracTipi);
            this.Controls.Add(this.lblPerSecim);
            this.Controls.Add(this.btnHavaAracKaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HavaAraciIslemleriYetkilendirme";
            this.Text = "Hava Aracı Yetki İşlemleri";
            this.Load += new System.EventHandler(this.HavaAraciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgYetki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPerSecim;
        private System.Windows.Forms.Button btnHavaAracKaydet;
        private System.Windows.Forms.ComboBox cbAracTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHavaAraci;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamUcus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSecilenArac;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.DataGridView dgYetki;
        private System.Windows.Forms.Button button1;
    }
}