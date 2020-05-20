namespace SistemAnalizi_GörselProgramlama
{
    partial class HavaAraciIslemleriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HavaAraciIslemleriEkle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHavaAracAdi = new System.Windows.Forms.TextBox();
            this.dgHavaAraclari = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAracKodu = new System.Windows.Forms.Label();
            this.rbUcak = new System.Windows.Forms.RadioButton();
            this.rbHelikopter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgHavaAraclari)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(162, 136);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Araç Tipi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(224, 107);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(92, 107);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Araç Adı";
            // 
            // txtHavaAracAdi
            // 
            this.txtHavaAracAdi.Location = new System.Drawing.Point(166, 45);
            this.txtHavaAracAdi.Name = "txtHavaAracAdi";
            this.txtHavaAracAdi.Size = new System.Drawing.Size(133, 20);
            this.txtHavaAracAdi.TabIndex = 0;
            // 
            // dgHavaAraclari
            // 
            this.dgHavaAraclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHavaAraclari.Location = new System.Drawing.Point(12, 176);
            this.dgHavaAraclari.Name = "dgHavaAraclari";
            this.dgHavaAraclari.Size = new System.Drawing.Size(389, 262);
            this.dgHavaAraclari.TabIndex = 23;
            this.dgHavaAraclari.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHavaAraclari_CellMouseDoubleClick);
            this.dgHavaAraclari.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPerEkleGun_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Aracın Kodu";
            // 
            // lblAracKodu
            // 
            this.lblAracKodu.AutoSize = true;
            this.lblAracKodu.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAracKodu.Location = new System.Drawing.Point(163, 19);
            this.lblAracKodu.Name = "lblAracKodu";
            this.lblAracKodu.Size = new System.Drawing.Size(0, 13);
            this.lblAracKodu.TabIndex = 25;
            // 
            // rbUcak
            // 
            this.rbUcak.AutoSize = true;
            this.rbUcak.Location = new System.Drawing.Point(166, 80);
            this.rbUcak.Name = "rbUcak";
            this.rbUcak.Size = new System.Drawing.Size(51, 17);
            this.rbUcak.TabIndex = 26;
            this.rbUcak.TabStop = true;
            this.rbUcak.Text = "Uçak";
            this.rbUcak.UseVisualStyleBackColor = true;
            // 
            // rbHelikopter
            // 
            this.rbHelikopter.AutoSize = true;
            this.rbHelikopter.Location = new System.Drawing.Point(224, 80);
            this.rbHelikopter.Name = "rbHelikopter";
            this.rbHelikopter.Size = new System.Drawing.Size(73, 17);
            this.rbHelikopter.TabIndex = 27;
            this.rbHelikopter.TabStop = true;
            this.rbHelikopter.Text = "Helikopter";
            this.rbHelikopter.UseVisualStyleBackColor = true;
            // 
            // HavaAraciIslemleriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.rbHelikopter);
            this.Controls.Add(this.rbUcak);
            this.Controls.Add(this.lblAracKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgHavaAraclari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtHavaAracAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HavaAraciIslemleriEkle";
            this.Text = "Hava Aracı İşlemleri";
            this.Load += new System.EventHandler(this.HavaAraciIslemleriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHavaAraclari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHavaAracAdi;
        private System.Windows.Forms.DataGridView dgHavaAraclari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAracKodu;
        private System.Windows.Forms.RadioButton rbUcak;
        private System.Windows.Forms.RadioButton rbHelikopter;
    }
}