﻿namespace TakvimUygulamasi
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
            this.BilgiPaneli.SuspendLayout();
            this.GirisPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // GirisButonu
            // 
            this.GirisButonu.Location = new System.Drawing.Point(383, 299);
            this.GirisButonu.Margin = new System.Windows.Forms.Padding(4);
            this.GirisButonu.Name = "GirisButonu";
            this.GirisButonu.Size = new System.Drawing.Size(100, 80);
            this.GirisButonu.TabIndex = 0;
            this.GirisButonu.Text = "Giriş Yap";
            this.GirisButonu.UseVisualStyleBackColor = true;
            this.GirisButonu.Click += new System.EventHandler(this.GirisButonu_Click);
            // 
            // BilgiPaneli
            // 
            this.BilgiPaneli.Controls.Add(this.GeriButonu);
            this.BilgiPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BilgiPaneli.Location = new System.Drawing.Point(0, 0);
            this.BilgiPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.BilgiPaneli.Name = "BilgiPaneli";
            this.BilgiPaneli.Size = new System.Drawing.Size(879, 530);
            this.BilgiPaneli.TabIndex = 1;
            // 
            // GeriButonu
            // 
            this.GeriButonu.Location = new System.Drawing.Point(4, 4);
            this.GeriButonu.Margin = new System.Windows.Forms.Padding(4);
            this.GeriButonu.Name = "GeriButonu";
            this.GeriButonu.Size = new System.Drawing.Size(67, 62);
            this.GeriButonu.TabIndex = 0;
            this.GeriButonu.Text = "<-";
            this.GeriButonu.UseVisualStyleBackColor = true;
            this.GeriButonu.Click += new System.EventHandler(this.GeriButonu_Click);
            // 
            // KullaniciAdiTB
            // 
            this.KullaniciAdiTB.Location = new System.Drawing.Point(327, 133);
            this.KullaniciAdiTB.Margin = new System.Windows.Forms.Padding(4);
            this.KullaniciAdiTB.MaxLength = 20;
            this.KullaniciAdiTB.Name = "KullaniciAdiTB";
            this.KullaniciAdiTB.Size = new System.Drawing.Size(208, 22);
            this.KullaniciAdiTB.TabIndex = 0;
            // 
            // SifreTB
            // 
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
            this.KullaniciAdiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiLB.Location = new System.Drawing.Point(201, 137);
            this.KullaniciAdiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KullaniciAdiLB.Name = "KullaniciAdiLB";
            this.KullaniciAdiLB.Size = new System.Drawing.Size(106, 20);
            this.KullaniciAdiLB.TabIndex = 2;
            this.KullaniciAdiLB.Text = "Kullanıcı Adı:";
            // 
            // SifreLB
            // 
            this.SifreLB.AutoSize = true;
            this.SifreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreLB.Location = new System.Drawing.Point(264, 225);
            this.SifreLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SifreLB.Name = "SifreLB";
            this.SifreLB.Size = new System.Drawing.Size(49, 20);
            this.SifreLB.TabIndex = 3;
            this.SifreLB.Text = "Şifre:";
            // 
            // KayıtAcmaLLB
            // 
            this.KayıtAcmaLLB.AutoSize = true;
            this.KayıtAcmaLLB.Location = new System.Drawing.Point(401, 396);
            this.KayıtAcmaLLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KayıtAcmaLLB.Name = "KayıtAcmaLLB";
            this.KayıtAcmaLLB.Size = new System.Drawing.Size(52, 16);
            this.KayıtAcmaLLB.TabIndex = 4;
            this.KayıtAcmaLLB.TabStop = true;
            this.KayıtAcmaLLB.Text = "Kayıt Ol";
            this.KayıtAcmaLLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KayıtAcmaLLB_LinkClicked);
            // 
            // GirisPaneli
            // 
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
            this.GirisPaneli.Size = new System.Drawing.Size(879, 530);
            this.GirisPaneli.TabIndex = 6;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(879, 530);
            this.Controls.Add(this.GirisPaneli);
            this.Controls.Add(this.BilgiPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.BilgiPaneli.ResumeLayout(false);
            this.GirisPaneli.ResumeLayout(false);
            this.GirisPaneli.PerformLayout();
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
    }
}