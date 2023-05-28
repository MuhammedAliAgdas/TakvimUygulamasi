namespace TakvimUygulamasi
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.GirisButonu = new System.Windows.Forms.Button();
            this.BilgiPaneli = new System.Windows.Forms.Panel();
            this.GeriButonu = new System.Windows.Forms.Button();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.KullaniciAdiLB = new System.Windows.Forms.Label();
            this.SifreLB = new System.Windows.Forms.Label();
            this.KayıtAcmaLLB = new System.Windows.Forms.LinkLabel();
            this.GirisPaneli = new System.Windows.Forms.Panel();
            this.Başlık = new System.Windows.Forms.Label();
            this.sifreLogosu = new System.Windows.Forms.PictureBox();
            this.kullaniciLogosu = new System.Windows.Forms.PictureBox();
            this.BilgiPaneli.SuspendLayout();
            this.GirisPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifreLogosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciLogosu)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisButonu
            // 
            this.GirisButonu.BackColor = System.Drawing.Color.LavenderBlush;
            this.GirisButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisButonu.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.GirisButonu.FlatAppearance.BorderSize = 2;
            this.GirisButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.GirisButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.GirisButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisButonu.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButonu.Location = new System.Drawing.Point(275, 255);
            this.GirisButonu.Name = "GirisButonu";
            this.GirisButonu.Size = new System.Drawing.Size(100, 70);
            this.GirisButonu.TabIndex = 0;
            this.GirisButonu.Text = "Giriş Yap";
            this.GirisButonu.UseVisualStyleBackColor = false;
            this.GirisButonu.Click += new System.EventHandler(this.GirisButonu_Click);
            // 
            // BilgiPaneli
            // 
            this.BilgiPaneli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BilgiPaneli.BackgroundImage")));
            this.BilgiPaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BilgiPaneli.Controls.Add(this.GeriButonu);
            this.BilgiPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BilgiPaneli.Location = new System.Drawing.Point(0, 0);
            this.BilgiPaneli.Name = "BilgiPaneli";
            this.BilgiPaneli.Size = new System.Drawing.Size(659, 389);
            this.BilgiPaneli.TabIndex = 1;
            // 
            // GeriButonu
            // 
            this.GeriButonu.BackColor = System.Drawing.Color.Transparent;
            this.GeriButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeriButonu.BackgroundImage")));
            this.GeriButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriButonu.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.GeriButonu.FlatAppearance.BorderSize = 0;
            this.GeriButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.GeriButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GeriButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeriButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriButonu.Location = new System.Drawing.Point(3, 3);
            this.GeriButonu.Name = "GeriButonu";
            this.GeriButonu.Size = new System.Drawing.Size(45, 48);
            this.GeriButonu.TabIndex = 0;
            this.GeriButonu.UseVisualStyleBackColor = false;
            this.GeriButonu.Click += new System.EventHandler(this.GeriButonu_Click);
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KullaniciAdiTB.Location = new System.Drawing.Point(245, 129);
            this.KullaniciAdiTB.MaxLength = 20;
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(157, 22);
            this.KullaniciAdiTB.TabIndex = 0;
            // 
            // SifreTB
            // 
            this.SifreTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SifreTB.Location = new System.Drawing.Point(245, 197);
            this.SifreTB.MaxLength = 20;
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(157, 22);
            this.SifreTB.TabIndex = 1;
            this.SifreTB.UseSystemPasswordChar = true;
            // 
            // KullaniciAdiLB
            // 
            this.KullaniciAdiLB.AutoSize = true;
            this.KullaniciAdiLB.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciAdiLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiLB.ForeColor = System.Drawing.Color.Thistle;
            this.KullaniciAdiLB.Location = new System.Drawing.Point(131, 129);
            this.KullaniciAdiLB.Name = "KullaniciAdiLB";
            this.KullaniciAdiLB.Size = new System.Drawing.Size(108, 22);
            this.KullaniciAdiLB.TabIndex = 2;
            this.KullaniciAdiLB.Text = "Kullanıcı Adı:";
            // 
            // SifreLB
            // 
            this.SifreLB.AutoSize = true;
            this.SifreLB.BackColor = System.Drawing.Color.Transparent;
            this.SifreLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreLB.ForeColor = System.Drawing.Color.Thistle;
            this.SifreLB.Location = new System.Drawing.Point(190, 197);
            this.SifreLB.Name = "SifreLB";
            this.SifreLB.Size = new System.Drawing.Size(49, 22);
            this.SifreLB.TabIndex = 3;
            this.SifreLB.Text = "Şifre:";
            // 
            // KayıtAcmaLLB
            // 
            this.KayıtAcmaLLB.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.KayıtAcmaLLB.AutoSize = true;
            this.KayıtAcmaLLB.BackColor = System.Drawing.Color.Transparent;
            this.KayıtAcmaLLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KayıtAcmaLLB.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtAcmaLLB.ForeColor = System.Drawing.Color.Purple;
            this.KayıtAcmaLLB.LinkColor = System.Drawing.Color.Purple;
            this.KayıtAcmaLLB.Location = new System.Drawing.Point(289, 340);
            this.KayıtAcmaLLB.Name = "KayıtAcmaLLB";
            this.KayıtAcmaLLB.Size = new System.Drawing.Size(62, 19);
            this.KayıtAcmaLLB.TabIndex = 4;
            this.KayıtAcmaLLB.TabStop = true;
            this.KayıtAcmaLLB.Text = "Kayıt Ol";
            this.KayıtAcmaLLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KayıtAcmaLLB_LinkClicked);
            // 
            // GirisPaneli
            // 
            this.GirisPaneli.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GirisPaneli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GirisPaneli.BackgroundImage")));
            this.GirisPaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GirisPaneli.Controls.Add(this.Başlık);
            this.GirisPaneli.Controls.Add(this.sifreLogosu);
            this.GirisPaneli.Controls.Add(this.kullaniciLogosu);
            this.GirisPaneli.Controls.Add(this.KayıtAcmaLLB);
            this.GirisPaneli.Controls.Add(this.KullaniciAdiTB);
            this.GirisPaneli.Controls.Add(this.SifreLB);
            this.GirisPaneli.Controls.Add(this.KullaniciAdiLB);
            this.GirisPaneli.Controls.Add(this.SifreTB);
            this.GirisPaneli.Controls.Add(this.GirisButonu);
            this.GirisPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GirisPaneli.Location = new System.Drawing.Point(0, 0);
            this.GirisPaneli.Name = "GirisPaneli";
            this.GirisPaneli.Size = new System.Drawing.Size(659, 389);
            this.GirisPaneli.TabIndex = 6;
            // 
            // Başlık
            // 
            this.Başlık.AutoSize = true;
            this.Başlık.BackColor = System.Drawing.Color.Transparent;
            this.Başlık.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Başlık.ForeColor = System.Drawing.Color.Thistle;
            this.Başlık.Location = new System.Drawing.Point(101, 36);
            this.Başlık.Name = "Başlık";
            this.Başlık.Size = new System.Drawing.Size(476, 33);
            this.Başlık.TabIndex = 7;
            this.Başlık.Text = "Kişisel Takvim Uygulamanıza Hoşgeldiniz";
            // 
            // sifreLogosu
            // 
            this.sifreLogosu.Image = ((System.Drawing.Image)(resources.GetObject("sifreLogosu.Image")));
            this.sifreLogosu.Location = new System.Drawing.Point(401, 197);
            this.sifreLogosu.Margin = new System.Windows.Forms.Padding(2);
            this.sifreLogosu.Name = "sifreLogosu";
            this.sifreLogosu.Size = new System.Drawing.Size(17, 22);
            this.sifreLogosu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sifreLogosu.TabIndex = 6;
            this.sifreLogosu.TabStop = false;
            // 
            // kullaniciLogosu
            // 
            this.kullaniciLogosu.Image = ((System.Drawing.Image)(resources.GetObject("kullaniciLogosu.Image")));
            this.kullaniciLogosu.Location = new System.Drawing.Point(401, 129);
            this.kullaniciLogosu.Margin = new System.Windows.Forms.Padding(2);
            this.kullaniciLogosu.Name = "kullaniciLogosu";
            this.kullaniciLogosu.Size = new System.Drawing.Size(17, 22);
            this.kullaniciLogosu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kullaniciLogosu.TabIndex = 5;
            this.kullaniciLogosu.TabStop = false;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(659, 389);
            this.Controls.Add(this.GirisPaneli);
            this.Controls.Add(this.BilgiPaneli);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.BilgiPaneli.ResumeLayout(false);
            this.GirisPaneli.ResumeLayout(false);
            this.GirisPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifreLogosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciLogosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GirisButonu;
        private System.Windows.Forms.Panel BilgiPaneli;
        private System.Windows.Forms.Label SifreLB;
        private System.Windows.Forms.Label KullaniciAdiLB;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.LinkLabel KayıtAcmaLLB;
        private System.Windows.Forms.Panel GirisPaneli;
        private System.Windows.Forms.Button GeriButonu;
        private System.Windows.Forms.PictureBox kullaniciLogosu;
        private System.Windows.Forms.PictureBox sifreLogosu;
        private System.Windows.Forms.Label Başlık;
    }
}