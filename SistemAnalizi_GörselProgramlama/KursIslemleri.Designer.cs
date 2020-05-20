namespace SistemAnalizi_GörselProgramlama
{
    partial class KursIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursIslemleri));
            this.label2 = new System.Windows.Forms.Label();
            this.btnPerSecim = new System.Windows.Forms.Button();
            this.lblPerAdSoyad = new System.Windows.Forms.Label();
            this.dgPerKurs = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblKursNo = new System.Windows.Forms.Label();
            this.lblKursAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKurslar = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personel Adı Soyadı";
            // 
            // btnPerSecim
            // 
            this.btnPerSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPerSecim.Location = new System.Drawing.Point(369, 5);
            this.btnPerSecim.Name = "btnPerSecim";
            this.btnPerSecim.Size = new System.Drawing.Size(141, 44);
            this.btnPerSecim.TabIndex = 17;
            this.btnPerSecim.Text = "Seçilen Personelin Bilgilerini Listele";
            this.btnPerSecim.UseVisualStyleBackColor = true;
            this.btnPerSecim.Click += new System.EventHandler(this.btnAdaGoreArama_Click);
            // 
            // lblPerAdSoyad
            // 
            this.lblPerAdSoyad.AutoSize = true;
            this.lblPerAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPerAdSoyad.Location = new System.Drawing.Point(146, 20);
            this.lblPerAdSoyad.Name = "lblPerAdSoyad";
            this.lblPerAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblPerAdSoyad.TabIndex = 18;
            // 
            // dgPerKurs
            // 
            this.dgPerKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerKurs.Location = new System.Drawing.Point(12, 165);
            this.dgPerKurs.Name = "dgPerKurs";
            this.dgPerKurs.Size = new System.Drawing.Size(515, 177);
            this.dgPerKurs.TabIndex = 19;
            this.dgPerKurs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPerKurs_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seçilen Kurs ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lblKursNo
            // 
            this.lblKursNo.AutoSize = true;
            this.lblKursNo.Location = new System.Drawing.Point(146, 87);
            this.lblKursNo.Name = "lblKursNo";
            this.lblKursNo.Size = new System.Drawing.Size(0, 13);
            this.lblKursNo.TabIndex = 23;
            // 
            // lblKursAdi
            // 
            this.lblKursAdi.AutoSize = true;
            this.lblKursAdi.Location = new System.Drawing.Point(205, 87);
            this.lblKursAdi.Name = "lblKursAdi";
            this.lblKursAdi.Size = new System.Drawing.Size(0, 13);
            this.lblKursAdi.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kurslar";
            // 
            // cbKurslar
            // 
            this.cbKurslar.FormattingEnabled = true;
            this.cbKurslar.Location = new System.Drawing.Point(149, 49);
            this.cbKurslar.Name = "cbKurslar";
            this.cbKurslar.Size = new System.Drawing.Size(175, 21);
            this.cbKurslar.TabIndex = 26;
            this.cbKurslar.SelectedIndexChanged += new System.EventHandler(this.cbKurslar_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(398, 59);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(398, 94);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(398, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // KursIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 354);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbKurslar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKursAdi);
            this.Controls.Add(this.lblKursNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgPerKurs);
            this.Controls.Add(this.lblPerAdSoyad);
            this.Controls.Add(this.btnPerSecim);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KursIslemleri";
            this.Text = "Kurs İşlemleri";
            this.Load += new System.EventHandler(this.KursIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPerKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPerSecim;
        private System.Windows.Forms.Label lblPerAdSoyad;
        private System.Windows.Forms.DataGridView dgPerKurs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblKursNo;
        private System.Windows.Forms.Label lblKursAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKurslar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}