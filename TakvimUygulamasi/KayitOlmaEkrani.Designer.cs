namespace TakvimUygulamasi
{
    partial class KayitOlmaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOlmaEkrani));
            this.AdTB = new System.Windows.Forms.TextBox();
            this.SoyadTB = new System.Windows.Forms.TextBox();
            this.KullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.TcNoTB = new System.Windows.Forms.TextBox();
            this.TelNoTB = new System.Windows.Forms.MaskedTextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.adresRTB = new System.Windows.Forms.RichTextBox();
            this.adminSifreTB = new System.Windows.Forms.TextBox();
            this.adminMisinCB = new System.Windows.Forms.CheckBox();
            this.adLB = new System.Windows.Forms.Label();
            this.soyadLB = new System.Windows.Forms.Label();
            this.kullaniciAdiLB = new System.Windows.Forms.Label();
            this.sifreLB = new System.Windows.Forms.Label();
            this.TcNoLB = new System.Windows.Forms.Label();
            this.telNoLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.AdresLB = new System.Windows.Forms.Label();
            this.adminSifreLB = new System.Windows.Forms.Label();
            this.KaydolButonu = new System.Windows.Forms.Button();
            this.adHataLB = new System.Windows.Forms.Label();
            this.sifreHataLB = new System.Windows.Forms.Label();
            this.kullaniciadiHataLB = new System.Windows.Forms.Label();
            this.soyadHataLB = new System.Windows.Forms.Label();
            this.tcnoHataLB = new System.Windows.Forms.Label();
            this.telnoHataLB = new System.Windows.Forms.Label();
            this.emailHataLB = new System.Windows.Forms.Label();
            this.adresHataLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdTB
            // 
            this.AdTB.Location = new System.Drawing.Point(145, 31);
            this.AdTB.MaxLength = 20;
            this.AdTB.Name = "AdTB";
            this.AdTB.Size = new System.Drawing.Size(156, 20);
            this.AdTB.TabIndex = 0;
            // 
            // SoyadTB
            // 
            this.SoyadTB.Location = new System.Drawing.Point(145, 80);
            this.SoyadTB.MaxLength = 20;
            this.SoyadTB.Name = "SoyadTB";
            this.SoyadTB.Size = new System.Drawing.Size(156, 20);
            this.SoyadTB.TabIndex = 1;
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(145, 127);
            this.KullaniciAdiTB.MaxLength = 20;
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(156, 20);
            this.KullaniciAdiTB.TabIndex = 2;
            this.KullaniciAdiTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KullaniciAdiTB_KeyPress);
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(145, 174);
            this.SifreTB.MaxLength = 20;
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(156, 20);
            this.SifreTB.TabIndex = 3;
            this.SifreTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SifreTB_KeyPress);
            // 
            // TcNoTB
            // 
            this.TcNoTB.Location = new System.Drawing.Point(145, 225);
            this.TcNoTB.MaxLength = 11;
            this.TcNoTB.Name = "TcNoTB";
            this.TcNoTB.Size = new System.Drawing.Size(156, 20);
            this.TcNoTB.TabIndex = 4;
            this.TcNoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TcNoTB_KeyPress);
            // 
            // TelNoTB
            // 
            this.TelNoTB.Location = new System.Drawing.Point(145, 277);
            this.TelNoTB.Mask = "0 000 000 00 00";
            this.TelNoTB.Name = "TelNoTB";
            this.TelNoTB.PromptChar = ' ';
            this.TelNoTB.Size = new System.Drawing.Size(156, 20);
            this.TelNoTB.TabIndex = 5;
            this.TelNoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelNoTB_KeyPress);
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(145, 325);
            this.EmailTB.MaxLength = 30;
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(156, 20);
            this.EmailTB.TabIndex = 6;
            this.EmailTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTB_KeyPress);
            // 
            // adresRTB
            // 
            this.adresRTB.Location = new System.Drawing.Point(389, 31);
            this.adresRTB.MaxLength = 250;
            this.adresRTB.Name = "adresRTB";
            this.adresRTB.Size = new System.Drawing.Size(227, 116);
            this.adresRTB.TabIndex = 7;
            this.adresRTB.Text = "";
            // 
            // adminSifreTB
            // 
            this.adminSifreTB.Location = new System.Drawing.Point(419, 174);
            this.adminSifreTB.MaxLength = 50;
            this.adminSifreTB.Name = "adminSifreTB";
            this.adminSifreTB.Size = new System.Drawing.Size(197, 20);
            this.adminSifreTB.TabIndex = 8;
            this.adminSifreTB.UseSystemPasswordChar = true;
            this.adminSifreTB.TextChanged += new System.EventHandler(this.adminSifreTB_TextChanged);
            // 
            // adminMisinCB
            // 
            this.adminMisinCB.AutoSize = true;
            this.adminMisinCB.Enabled = false;
            this.adminMisinCB.Location = new System.Drawing.Point(419, 224);
            this.adminMisinCB.Name = "adminMisinCB";
            this.adminMisinCB.Size = new System.Drawing.Size(88, 17);
            this.adminMisinCB.TabIndex = 9;
            this.adminMisinCB.Text = "Admin Misin?";
            this.adminMisinCB.UseVisualStyleBackColor = true;
            // 
            // adLB
            // 
            this.adLB.AutoSize = true;
            this.adLB.Location = new System.Drawing.Point(116, 34);
            this.adLB.Name = "adLB";
            this.adLB.Size = new System.Drawing.Size(23, 13);
            this.adLB.TabIndex = 10;
            this.adLB.Text = "Ad:";
            // 
            // soyadLB
            // 
            this.soyadLB.AutoSize = true;
            this.soyadLB.Location = new System.Drawing.Point(99, 83);
            this.soyadLB.Name = "soyadLB";
            this.soyadLB.Size = new System.Drawing.Size(40, 13);
            this.soyadLB.TabIndex = 11;
            this.soyadLB.Text = "Soyad:";
            // 
            // kullaniciAdiLB
            // 
            this.kullaniciAdiLB.AutoSize = true;
            this.kullaniciAdiLB.Location = new System.Drawing.Point(76, 130);
            this.kullaniciAdiLB.Name = "kullaniciAdiLB";
            this.kullaniciAdiLB.Size = new System.Drawing.Size(67, 13);
            this.kullaniciAdiLB.TabIndex = 12;
            this.kullaniciAdiLB.Text = "Kullanıcı Adı:";
            // 
            // sifreLB
            // 
            this.sifreLB.AutoSize = true;
            this.sifreLB.Location = new System.Drawing.Point(108, 177);
            this.sifreLB.Name = "sifreLB";
            this.sifreLB.Size = new System.Drawing.Size(31, 13);
            this.sifreLB.TabIndex = 13;
            this.sifreLB.Text = "Şifre:";
            // 
            // TcNoLB
            // 
            this.TcNoLB.AutoSize = true;
            this.TcNoLB.Location = new System.Drawing.Point(72, 228);
            this.TcNoLB.Name = "TcNoLB";
            this.TcNoLB.Size = new System.Drawing.Size(67, 13);
            this.TcNoLB.TabIndex = 14;
            this.TcNoLB.Text = "Tc kimlik no:";
            // 
            // telNoLB
            // 
            this.telNoLB.AutoSize = true;
            this.telNoLB.Location = new System.Drawing.Point(76, 280);
            this.telNoLB.Name = "telNoLB";
            this.telNoLB.Size = new System.Drawing.Size(63, 13);
            this.telNoLB.TabIndex = 15;
            this.telNoLB.Text = "Telefon No:";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(104, 328);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(35, 13);
            this.emailLB.TabIndex = 16;
            this.emailLB.Text = "Email:";
            // 
            // AdresLB
            // 
            this.AdresLB.AutoSize = true;
            this.AdresLB.Location = new System.Drawing.Point(343, 34);
            this.AdresLB.Name = "AdresLB";
            this.AdresLB.Size = new System.Drawing.Size(40, 13);
            this.AdresLB.TabIndex = 17;
            this.AdresLB.Text = "Adres: ";
            // 
            // adminSifreLB
            // 
            this.adminSifreLB.AutoSize = true;
            this.adminSifreLB.Location = new System.Drawing.Point(343, 177);
            this.adminSifreLB.Name = "adminSifreLB";
            this.adminSifreLB.Size = new System.Drawing.Size(70, 13);
            this.adminSifreLB.TabIndex = 18;
            this.adminSifreLB.Text = "Admin Şifresi:";
            // 
            // KaydolButonu
            // 
            this.KaydolButonu.Location = new System.Drawing.Point(419, 276);
            this.KaydolButonu.Name = "KaydolButonu";
            this.KaydolButonu.Size = new System.Drawing.Size(150, 65);
            this.KaydolButonu.TabIndex = 10;
            this.KaydolButonu.Text = "Kaydol";
            this.KaydolButonu.UseVisualStyleBackColor = true;
            this.KaydolButonu.Click += new System.EventHandler(this.KaydolButonu_Click);
            // 
            // adHataLB
            // 
            this.adHataLB.AutoSize = true;
            this.adHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adHataLB.ForeColor = System.Drawing.Color.Brown;
            this.adHataLB.Location = new System.Drawing.Point(307, 31);
            this.adHataLB.Name = "adHataLB";
            this.adHataLB.Size = new System.Drawing.Size(25, 31);
            this.adHataLB.TabIndex = 20;
            this.adHataLB.Text = "*";
            this.adHataLB.Visible = false;
            // 
            // sifreHataLB
            // 
            this.sifreHataLB.AutoSize = true;
            this.sifreHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreHataLB.ForeColor = System.Drawing.Color.Brown;
            this.sifreHataLB.Location = new System.Drawing.Point(307, 174);
            this.sifreHataLB.Name = "sifreHataLB";
            this.sifreHataLB.Size = new System.Drawing.Size(25, 31);
            this.sifreHataLB.TabIndex = 21;
            this.sifreHataLB.Text = "*";
            this.sifreHataLB.Visible = false;
            // 
            // kullaniciadiHataLB
            // 
            this.kullaniciadiHataLB.AutoSize = true;
            this.kullaniciadiHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadiHataLB.ForeColor = System.Drawing.Color.Brown;
            this.kullaniciadiHataLB.Location = new System.Drawing.Point(307, 127);
            this.kullaniciadiHataLB.Name = "kullaniciadiHataLB";
            this.kullaniciadiHataLB.Size = new System.Drawing.Size(25, 31);
            this.kullaniciadiHataLB.TabIndex = 22;
            this.kullaniciadiHataLB.Text = "*";
            this.kullaniciadiHataLB.Visible = false;
            // 
            // soyadHataLB
            // 
            this.soyadHataLB.AutoSize = true;
            this.soyadHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadHataLB.ForeColor = System.Drawing.Color.Brown;
            this.soyadHataLB.Location = new System.Drawing.Point(307, 83);
            this.soyadHataLB.Name = "soyadHataLB";
            this.soyadHataLB.Size = new System.Drawing.Size(25, 31);
            this.soyadHataLB.TabIndex = 23;
            this.soyadHataLB.Text = "*";
            this.soyadHataLB.Visible = false;
            // 
            // tcnoHataLB
            // 
            this.tcnoHataLB.AutoSize = true;
            this.tcnoHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcnoHataLB.ForeColor = System.Drawing.Color.Brown;
            this.tcnoHataLB.Location = new System.Drawing.Point(307, 225);
            this.tcnoHataLB.Name = "tcnoHataLB";
            this.tcnoHataLB.Size = new System.Drawing.Size(25, 31);
            this.tcnoHataLB.TabIndex = 24;
            this.tcnoHataLB.Text = "*";
            this.tcnoHataLB.Visible = false;
            // 
            // telnoHataLB
            // 
            this.telnoHataLB.AutoSize = true;
            this.telnoHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telnoHataLB.ForeColor = System.Drawing.Color.Brown;
            this.telnoHataLB.Location = new System.Drawing.Point(307, 277);
            this.telnoHataLB.Name = "telnoHataLB";
            this.telnoHataLB.Size = new System.Drawing.Size(25, 31);
            this.telnoHataLB.TabIndex = 25;
            this.telnoHataLB.Text = "*";
            this.telnoHataLB.Visible = false;
            // 
            // emailHataLB
            // 
            this.emailHataLB.AutoSize = true;
            this.emailHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailHataLB.ForeColor = System.Drawing.Color.Brown;
            this.emailHataLB.Location = new System.Drawing.Point(307, 325);
            this.emailHataLB.Name = "emailHataLB";
            this.emailHataLB.Size = new System.Drawing.Size(25, 31);
            this.emailHataLB.TabIndex = 26;
            this.emailHataLB.Text = "*";
            this.emailHataLB.Visible = false;
            // 
            // adresHataLB
            // 
            this.adresHataLB.AutoSize = true;
            this.adresHataLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adresHataLB.ForeColor = System.Drawing.Color.Brown;
            this.adresHataLB.Location = new System.Drawing.Point(622, 31);
            this.adresHataLB.Name = "adresHataLB";
            this.adresHataLB.Size = new System.Drawing.Size(25, 31);
            this.adresHataLB.TabIndex = 27;
            this.adresHataLB.Text = "*";
            this.adresHataLB.Visible = false;
            // 
            // KayitOlmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 426);
            this.Controls.Add(this.adresHataLB);
            this.Controls.Add(this.emailHataLB);
            this.Controls.Add(this.telnoHataLB);
            this.Controls.Add(this.tcnoHataLB);
            this.Controls.Add(this.soyadHataLB);
            this.Controls.Add(this.kullaniciadiHataLB);
            this.Controls.Add(this.sifreHataLB);
            this.Controls.Add(this.adHataLB);
            this.Controls.Add(this.KaydolButonu);
            this.Controls.Add(this.adminSifreLB);
            this.Controls.Add(this.AdresLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.telNoLB);
            this.Controls.Add(this.TcNoLB);
            this.Controls.Add(this.sifreLB);
            this.Controls.Add(this.kullaniciAdiLB);
            this.Controls.Add(this.soyadLB);
            this.Controls.Add(this.adLB);
            this.Controls.Add(this.adminMisinCB);
            this.Controls.Add(this.adminSifreTB);
            this.Controls.Add(this.adresRTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.TelNoTB);
            this.Controls.Add(this.TcNoTB);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.KullaniciAdiTB);
            this.Controls.Add(this.SoyadTB);
            this.Controls.Add(this.AdTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitOlmaEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdTB;
        private System.Windows.Forms.TextBox SoyadTB;
        private System.Windows.Forms.TextBox KullaniciAdiTB;
        private System.Windows.Forms.TextBox SifreTB;
        private System.Windows.Forms.TextBox TcNoTB;
        private System.Windows.Forms.MaskedTextBox TelNoTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.RichTextBox adresRTB;
        private System.Windows.Forms.TextBox adminSifreTB;
        private System.Windows.Forms.CheckBox adminMisinCB;
        private System.Windows.Forms.Label adLB;
        private System.Windows.Forms.Label soyadLB;
        private System.Windows.Forms.Label kullaniciAdiLB;
        private System.Windows.Forms.Label sifreLB;
        private System.Windows.Forms.Label TcNoLB;
        private System.Windows.Forms.Label telNoLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label AdresLB;
        private System.Windows.Forms.Label adminSifreLB;
        private System.Windows.Forms.Button KaydolButonu;
        private System.Windows.Forms.Label adHataLB;
        private System.Windows.Forms.Label sifreHataLB;
        private System.Windows.Forms.Label kullaniciadiHataLB;
        private System.Windows.Forms.Label soyadHataLB;
        private System.Windows.Forms.Label tcnoHataLB;
        private System.Windows.Forms.Label telnoHataLB;
        private System.Windows.Forms.Label emailHataLB;
        private System.Windows.Forms.Label adresHataLB;
    }
}