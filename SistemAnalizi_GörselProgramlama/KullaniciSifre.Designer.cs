namespace SistemAnalizi_GörselProgramlama
{
    partial class KullaniciSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciSifre));
            this.txtEski = new System.Windows.Forms.TextBox();
            this.txtYeni = new System.Windows.Forms.TextBox();
            this.txtYeniKontrol = new System.Windows.Forms.TextBox();
            this.lblEski = new System.Windows.Forms.Label();
            this.lblYeni = new System.Windows.Forms.Label();
            this.lblYeniTekrar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEski
            // 
            this.txtEski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEski.Location = new System.Drawing.Point(144, 21);
            this.txtEski.Name = "txtEski";
            this.txtEski.Size = new System.Drawing.Size(139, 21);
            this.txtEski.TabIndex = 0;
            // 
            // txtYeni
            // 
            this.txtYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtYeni.Location = new System.Drawing.Point(144, 57);
            this.txtYeni.Name = "txtYeni";
            this.txtYeni.Size = new System.Drawing.Size(139, 21);
            this.txtYeni.TabIndex = 1;
            // 
            // txtYeniKontrol
            // 
            this.txtYeniKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtYeniKontrol.Location = new System.Drawing.Point(144, 93);
            this.txtYeniKontrol.Name = "txtYeniKontrol";
            this.txtYeniKontrol.Size = new System.Drawing.Size(139, 21);
            this.txtYeniKontrol.TabIndex = 2;
            // 
            // lblEski
            // 
            this.lblEski.AutoSize = true;
            this.lblEski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEski.Location = new System.Drawing.Point(43, 24);
            this.lblEski.Name = "lblEski";
            this.lblEski.Size = new System.Drawing.Size(58, 15);
            this.lblEski.TabIndex = 3;
            this.lblEski.Text = "Eski Şifre";
            // 
            // lblYeni
            // 
            this.lblYeni.AutoSize = true;
            this.lblYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblYeni.Location = new System.Drawing.Point(43, 60);
            this.lblYeni.Name = "lblYeni";
            this.lblYeni.Size = new System.Drawing.Size(59, 15);
            this.lblYeni.TabIndex = 4;
            this.lblYeni.Text = "Yeni Şifre";
            // 
            // lblYeniTekrar
            // 
            this.lblYeniTekrar.AutoSize = true;
            this.lblYeniTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblYeniTekrar.Location = new System.Drawing.Point(27, 96);
            this.lblYeniTekrar.Name = "lblYeniTekrar";
            this.lblYeniTekrar.Size = new System.Drawing.Size(100, 15);
            this.lblYeniTekrar.TabIndex = 5;
            this.lblYeniTekrar.Text = "Tekrar  Yeni Şifre";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(120, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Şifremi Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullaniciSifre
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblYeniTekrar);
            this.Controls.Add(this.lblYeni);
            this.Controls.Add(this.lblEski);
            this.Controls.Add(this.txtYeniKontrol);
            this.Controls.Add(this.txtYeni);
            this.Controls.Add(this.txtEski);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciSifre";
            this.Text = "KullaniciSifre";
            this.Load += new System.EventHandler(this.KullaniciSifre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEski;
        private System.Windows.Forms.TextBox txtYeni;
        private System.Windows.Forms.TextBox txtYeniKontrol;
        private System.Windows.Forms.Label lblEski;
        private System.Windows.Forms.Label lblYeni;
        private System.Windows.Forms.Label lblYeniTekrar;
        private System.Windows.Forms.Button button1;
    }
}