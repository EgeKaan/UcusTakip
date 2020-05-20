namespace SistemAnalizi_GörselProgramlama
{
    partial class AylıkUcus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AylıkUcus));
            this.cbAylar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgAylikUcus = new System.Windows.Forms.DataGridView();
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgAylikUcus)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAylar
            // 
            this.cbAylar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbAylar.FormattingEnabled = true;
            this.cbAylar.Location = new System.Drawing.Point(259, 36);
            this.cbAylar.Name = "cbAylar";
            this.cbAylar.Size = new System.Drawing.Size(124, 23);
            this.cbAylar.TabIndex = 0;
            this.cbAylar.SelectedIndexChanged += new System.EventHandler(this.cbAylar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(220, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ay";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnListele.Location = new System.Drawing.Point(408, 24);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(119, 41);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Seçilen Ayın Uçuşlarını Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgAylikUcus
            // 
            this.dgAylikUcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAylikUcus.Location = new System.Drawing.Point(12, 86);
            this.dgAylikUcus.Name = "dgAylikUcus";
            this.dgAylikUcus.Size = new System.Drawing.Size(776, 352);
            this.dgAylikUcus.TabIndex = 3;
            // 
            // cbDonem
            // 
            this.cbDonem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Location = new System.Drawing.Point(78, 36);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(124, 23);
            this.cbDonem.TabIndex = 5;
            this.cbDonem.SelectedIndexChanged += new System.EventHandler(this.cbDonem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dönem";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAdSoyad.Location = new System.Drawing.Point(688, 6);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblAdSoyad.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(663, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "İşlem Yapılacak Personeli Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(533, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Seçilen Ayın Uçuş Bilgilerini İndir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // AylıkUcus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDonem);
            this.Controls.Add(this.dgAylikUcus);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAylar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AylıkUcus";
            this.Text = "Aylık Uçuş Listesi";
            this.Load += new System.EventHandler(this.AylıkUcus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAylikUcus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAylar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgAylikUcus;
        private System.Windows.Forms.ComboBox cbDonem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}