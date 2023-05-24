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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BilgiPaneli.SuspendLayout();
            this.GirisPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisButonu
            // 
            this.GirisButonu.BackColor = System.Drawing.Color.Chocolate;
            this.GirisButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisButonu.Location = new System.Drawing.Point(383, 299);
            this.GirisButonu.Margin = new System.Windows.Forms.Padding(4);
            this.GirisButonu.Name = "GirisButonu";
            this.GirisButonu.Size = new System.Drawing.Size(100, 80);
            this.GirisButonu.TabIndex = 0;
            this.GirisButonu.Text = "Giriş Yap";
            this.GirisButonu.UseVisualStyleBackColor = false;
            this.GirisButonu.Click += new System.EventHandler(this.GirisButonu_Click);
            // 
            // BilgiPaneli
            // 
            this.BilgiPaneli.Controls.Add(this.GeriButonu);
            this.BilgiPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BilgiPaneli.Location = new System.Drawing.Point(0, 0);
            this.BilgiPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.BilgiPaneli.Name = "BilgiPaneli";
            this.BilgiPaneli.Size = new System.Drawing.Size(879, 490);
            this.BilgiPaneli.TabIndex = 1;
            // 
            // GeriButonu
            // 
            this.GeriButonu.BackColor = System.Drawing.Color.Chocolate;
            this.GeriButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeriButonu.BackgroundImage")));
            this.GeriButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriButonu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GeriButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeriButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriButonu.Location = new System.Drawing.Point(4, 4);
            this.GeriButonu.Margin = new System.Windows.Forms.Padding(4);
            this.GeriButonu.Name = "GeriButonu";
            this.GeriButonu.Size = new System.Drawing.Size(67, 62);
            this.GeriButonu.TabIndex = 0;
            this.GeriButonu.UseVisualStyleBackColor = false;
            this.GeriButonu.Click += new System.EventHandler(this.GeriButonu_Click);
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.BackColor = System.Drawing.Color.Gainsboro;
            this.KullaniciAdiTB.Location = new System.Drawing.Point(327, 133);
            this.KullaniciAdiTB.Margin = new System.Windows.Forms.Padding(4);
            this.KullaniciAdiTB.MaxLength = 20;
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(208, 22);
            this.KullaniciAdiTB.TabIndex = 0;
            // 
            // SifreTB
            // 
            this.SifreTB.BackColor = System.Drawing.Color.Gainsboro;
            this.SifreTB.Location = new System.Drawing.Point(327, 225);
            this.SifreTB.Margin = new System.Windows.Forms.Padding(4);
            this.SifreTB.MaxLength = 20;
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(208, 22);
            this.SifreTB.TabIndex = 1;
            this.SifreTB.UseSystemPasswordChar = true;
            // 
            // KullaniciAdiLB
            // 
            this.KullaniciAdiLB.AutoSize = true;
            this.KullaniciAdiLB.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciAdiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiLB.ForeColor = System.Drawing.Color.Khaki;
            this.KullaniciAdiLB.Location = new System.Drawing.Point(190, 133);
            this.KullaniciAdiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KullaniciAdiLB.Name = "KullaniciAdiLB";
            this.KullaniciAdiLB.Size = new System.Drawing.Size(120, 20);
            this.KullaniciAdiLB.TabIndex = 2;
            this.KullaniciAdiLB.Text = "Kullanıcı Adı:";
            // 
            // SifreLB
            // 
            this.SifreLB.AutoSize = true;
            this.SifreLB.BackColor = System.Drawing.Color.Transparent;
            this.SifreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreLB.ForeColor = System.Drawing.Color.Khaki;
            this.SifreLB.Location = new System.Drawing.Point(255, 228);
            this.SifreLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SifreLB.Name = "SifreLB";
            this.SifreLB.Size = new System.Drawing.Size(55, 20);
            this.SifreLB.TabIndex = 3;
            this.SifreLB.Text = "Şifre:";
            // 
            // KayıtAcmaLLB
            // 
            this.KayıtAcmaLLB.ActiveLinkColor = System.Drawing.Color.Khaki;
            this.KayıtAcmaLLB.AutoSize = true;
            this.KayıtAcmaLLB.BackColor = System.Drawing.Color.Transparent;
            this.KayıtAcmaLLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KayıtAcmaLLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtAcmaLLB.ForeColor = System.Drawing.Color.Khaki;
            this.KayıtAcmaLLB.LinkColor = System.Drawing.Color.Gold;
            this.KayıtAcmaLLB.Location = new System.Drawing.Point(400, 397);
            this.KayıtAcmaLLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KayıtAcmaLLB.Name = "KayıtAcmaLLB";
            this.KayıtAcmaLLB.Size = new System.Drawing.Size(67, 18);
            this.KayıtAcmaLLB.TabIndex = 4;
            this.KayıtAcmaLLB.TabStop = true;
            this.KayıtAcmaLLB.Text = "Kayıt Ol";
            this.KayıtAcmaLLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KayıtAcmaLLB_LinkClicked);
            // 
            // GirisPaneli
            // 
            this.GirisPaneli.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GirisPaneli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GirisPaneli.BackgroundImage")));
            this.GirisPaneli.Controls.Add(this.pictureBox2);
            this.GirisPaneli.Controls.Add(this.pictureBox1);
            this.GirisPaneli.Controls.Add(this.KayıtAcmaLLB);
            this.GirisPaneli.Controls.Add(this.KullaniciAdiTB);
            this.GirisPaneli.Controls.Add(this.SifreLB);
            this.GirisPaneli.Controls.Add(this.KullaniciAdiLB);
            this.GirisPaneli.Controls.Add(this.SifreTB);
            this.GirisPaneli.Controls.Add(this.GirisButonu);
            this.GirisPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GirisPaneli.Location = new System.Drawing.Point(0, 0);
            this.GirisPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.GirisPaneli.Name = "GirisPaneli";
            this.GirisPaneli.Size = new System.Drawing.Size(879, 490);
            this.GirisPaneli.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(879, 490);
            this.Controls.Add(this.GirisPaneli);
            this.Controls.Add(this.BilgiPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.BilgiPaneli.ResumeLayout(false);
            this.GirisPaneli.ResumeLayout(false);
            this.GirisPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}