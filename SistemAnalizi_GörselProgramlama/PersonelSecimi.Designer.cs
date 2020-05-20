namespace SistemAnalizi_GörselProgramlama
{
    partial class PersonelSecimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSecimi));
            this.dgPersonelSecimi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPerNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtSorgu = new System.Windows.Forms.TextBox();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonelSecimi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPersonelSecimi
            // 
            this.dgPersonelSecimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonelSecimi.Location = new System.Drawing.Point(0, 67);
            this.dgPersonelSecimi.Name = "dgPersonelSecimi";
            this.dgPersonelSecimi.Size = new System.Drawing.Size(800, 383);
            this.dgPersonelSecimi.TabIndex = 0;
            this.dgPersonelSecimi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonelSecimi_CellDoubleClick);
            this.dgPersonelSecimi.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPersonelSecimi_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel No: ";
            // 
            // lblPerNo
            // 
            this.lblPerNo.AutoSize = true;
            this.lblPerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPerNo.Location = new System.Drawing.Point(83, 24);
            this.lblPerNo.Name = "lblPerNo";
            this.lblPerNo.Size = new System.Drawing.Size(0, 15);
            this.lblPerNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(170, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad: ";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAdSoyad.Location = new System.Drawing.Point(229, 24);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblAdSoyad.TabIndex = 4;
            // 
            // txtSorgu
            // 
            this.txtSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSorgu.Location = new System.Drawing.Point(547, 21);
            this.txtSorgu.Name = "txtSorgu";
            this.txtSorgu.Size = new System.Drawing.Size(149, 21);
            this.txtSorgu.TabIndex = 5;
            // 
            // btnSorgu
            // 
            this.btnSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSorgu.Location = new System.Drawing.Point(713, 12);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(75, 49);
            this.btnSorgu.TabIndex = 6;
            this.btnSorgu.Text = "Ada Göre Sorgu";
            this.btnSorgu.UseVisualStyleBackColor = true;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSec.Location = new System.Drawing.Point(407, 12);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 49);
            this.btnSec.TabIndex = 7;
            this.btnSec.Text = "Personeli Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // PersonelSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.txtSorgu);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPerNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPersonelSecimi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelSecimi";
            this.Text = "Personel Seçim Ekranı";
            this.Load += new System.EventHandler(this.PersonelSecimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonelSecimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPersonelSecimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPerNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtSorgu;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.Button btnSec;
    }
}