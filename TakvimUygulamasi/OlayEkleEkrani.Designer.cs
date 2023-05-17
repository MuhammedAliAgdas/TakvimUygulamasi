namespace TakvimUygulamasi
{
    partial class OlayEkleEkrani
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
            this.tarihSec = new System.Windows.Forms.DateTimePicker();
            this.baslangicSaatCB = new System.Windows.Forms.ComboBox();
            this.baslangicDkCB = new System.Windows.Forms.ComboBox();
            this.bitisSaatCB = new System.Windows.Forms.ComboBox();
            this.bitisDkCB = new System.Windows.Forms.ComboBox();
            this.olayTanimiTB = new System.Windows.Forms.TextBox();
            this.olayAciklamasıRTB = new System.Windows.Forms.RichTextBox();
            this.olayTarihiLB = new System.Windows.Forms.Label();
            this.baslangicSaatiLB = new System.Windows.Forms.Label();
            this.baslangicDkLB = new System.Windows.Forms.Label();
            this.bitisSaatiLB = new System.Windows.Forms.Label();
            this.bitisDkLB = new System.Windows.Forms.Label();
            this.olayTanimiLB = new System.Windows.Forms.Label();
            this.olayAciklamasiLB = new System.Windows.Forms.Label();
            this.alarmEkleCB = new System.Windows.Forms.CheckBox();
            this.olayEkleBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tarihSec
            // 
            this.tarihSec.Location = new System.Drawing.Point(320, 43);
            this.tarihSec.MaxDate = new System.DateTime(2033, 12, 31, 0, 0, 0, 0);
            this.tarihSec.Name = "tarihSec";
            this.tarihSec.Size = new System.Drawing.Size(200, 20);
            this.tarihSec.TabIndex = 0;
            this.tarihSec.Value = new System.DateTime(2023, 5, 15, 0, 0, 0, 0);
            // 
            // baslangicSaatCB
            // 
            this.baslangicSaatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslangicSaatCB.FormattingEnabled = true;
            this.baslangicSaatCB.Location = new System.Drawing.Point(209, 108);
            this.baslangicSaatCB.Name = "baslangicSaatCB";
            this.baslangicSaatCB.Size = new System.Drawing.Size(121, 21);
            this.baslangicSaatCB.TabIndex = 1;
            this.baslangicSaatCB.SelectedIndexChanged += new System.EventHandler(this.baslangicSaatCB_SelectedIndexChanged);
            // 
            // baslangicDkCB
            // 
            this.baslangicDkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslangicDkCB.FormattingEnabled = true;
            this.baslangicDkCB.Location = new System.Drawing.Point(399, 108);
            this.baslangicDkCB.Name = "baslangicDkCB";
            this.baslangicDkCB.Size = new System.Drawing.Size(121, 21);
            this.baslangicDkCB.TabIndex = 2;
            this.baslangicDkCB.SelectedIndexChanged += new System.EventHandler(this.baslangicDkCB_SelectedIndexChanged);
            // 
            // bitisSaatCB
            // 
            this.bitisSaatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitisSaatCB.FormattingEnabled = true;
            this.bitisSaatCB.Location = new System.Drawing.Point(209, 150);
            this.bitisSaatCB.Name = "bitisSaatCB";
            this.bitisSaatCB.Size = new System.Drawing.Size(121, 21);
            this.bitisSaatCB.TabIndex = 3;
            // 
            // bitisDkCB
            // 
            this.bitisDkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitisDkCB.FormattingEnabled = true;
            this.bitisDkCB.Location = new System.Drawing.Point(399, 150);
            this.bitisDkCB.Name = "bitisDkCB";
            this.bitisDkCB.Size = new System.Drawing.Size(121, 21);
            this.bitisDkCB.TabIndex = 4;
            // 
            // olayTanimiTB
            // 
            this.olayTanimiTB.Location = new System.Drawing.Point(302, 224);
            this.olayTanimiTB.MaxLength = 50;
            this.olayTanimiTB.Name = "olayTanimiTB";
            this.olayTanimiTB.Size = new System.Drawing.Size(218, 20);
            this.olayTanimiTB.TabIndex = 5;
            // 
            // olayAciklamasıRTB
            // 
            this.olayAciklamasıRTB.Location = new System.Drawing.Point(286, 303);
            this.olayAciklamasıRTB.MaxLength = 250;
            this.olayAciklamasıRTB.Name = "olayAciklamasıRTB";
            this.olayAciklamasıRTB.Size = new System.Drawing.Size(234, 96);
            this.olayAciklamasıRTB.TabIndex = 6;
            this.olayAciklamasıRTB.Text = "";
            // 
            // olayTarihiLB
            // 
            this.olayTarihiLB.AutoSize = true;
            this.olayTarihiLB.Location = new System.Drawing.Point(224, 43);
            this.olayTarihiLB.Name = "olayTarihiLB";
            this.olayTarihiLB.Size = new System.Drawing.Size(90, 13);
            this.olayTarihiLB.TabIndex = 7;
            this.olayTarihiLB.Text = "Olay Tarihi Seçin:";
            // 
            // baslangicSaatiLB
            // 
            this.baslangicSaatiLB.AutoSize = true;
            this.baslangicSaatiLB.Location = new System.Drawing.Point(122, 111);
            this.baslangicSaatiLB.Name = "baslangicSaatiLB";
            this.baslangicSaatiLB.Size = new System.Drawing.Size(81, 13);
            this.baslangicSaatiLB.TabIndex = 8;
            this.baslangicSaatiLB.Text = "Başlangıç saati:";
            // 
            // baslangicDkLB
            // 
            this.baslangicDkLB.AutoSize = true;
            this.baslangicDkLB.Location = new System.Drawing.Point(345, 111);
            this.baslangicDkLB.Name = "baslangicDkLB";
            this.baslangicDkLB.Size = new System.Drawing.Size(51, 13);
            this.baslangicDkLB.TabIndex = 9;
            this.baslangicDkLB.Text = "Dakikası:";
            // 
            // bitisSaatiLB
            // 
            this.bitisSaatiLB.AutoSize = true;
            this.bitisSaatiLB.Location = new System.Drawing.Point(150, 153);
            this.bitisSaatiLB.Name = "bitisSaatiLB";
            this.bitisSaatiLB.Size = new System.Drawing.Size(56, 13);
            this.bitisSaatiLB.TabIndex = 10;
            this.bitisSaatiLB.Text = "Bitiş Saati:";
            // 
            // bitisDkLB
            // 
            this.bitisDkLB.AutoSize = true;
            this.bitisDkLB.Location = new System.Drawing.Point(345, 153);
            this.bitisDkLB.Name = "bitisDkLB";
            this.bitisDkLB.Size = new System.Drawing.Size(51, 13);
            this.bitisDkLB.TabIndex = 11;
            this.bitisDkLB.Text = "Dakikası:";
            // 
            // olayTanimiLB
            // 
            this.olayTanimiLB.AutoSize = true;
            this.olayTanimiLB.Location = new System.Drawing.Point(209, 227);
            this.olayTanimiLB.Name = "olayTanimiLB";
            this.olayTanimiLB.Size = new System.Drawing.Size(87, 13);
            this.olayTanimiLB.TabIndex = 12;
            this.olayTanimiLB.Text = "Olay Tanımı girin:";
            // 
            // olayAciklamasiLB
            // 
            this.olayAciklamasiLB.AutoSize = true;
            this.olayAciklamasiLB.Location = new System.Drawing.Point(172, 303);
            this.olayAciklamasiLB.Name = "olayAciklamasiLB";
            this.olayAciklamasiLB.Size = new System.Drawing.Size(108, 13);
            this.olayAciklamasiLB.TabIndex = 13;
            this.olayAciklamasiLB.Text = "Olay Açıklaması Girin:";
            // 
            // alarmEkleCB
            // 
            this.alarmEkleCB.AutoSize = true;
            this.alarmEkleCB.Location = new System.Drawing.Point(286, 429);
            this.alarmEkleCB.Name = "alarmEkleCB";
            this.alarmEkleCB.Size = new System.Drawing.Size(115, 17);
            this.alarmEkleCB.TabIndex = 14;
            this.alarmEkleCB.Text = "Alarm Eklensin Mi?";
            this.alarmEkleCB.UseVisualStyleBackColor = true;
            // 
            // olayEkleBT
            // 
            this.olayEkleBT.Location = new System.Drawing.Point(348, 489);
            this.olayEkleBT.Name = "olayEkleBT";
            this.olayEkleBT.Size = new System.Drawing.Size(75, 57);
            this.olayEkleBT.TabIndex = 15;
            this.olayEkleBT.Text = "Olayı Ekle";
            this.olayEkleBT.UseVisualStyleBackColor = true;
            this.olayEkleBT.Click += new System.EventHandler(this.olayEkleBT_Click);
            // 
            // OlayEkleEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.olayEkleBT);
            this.Controls.Add(this.alarmEkleCB);
            this.Controls.Add(this.olayAciklamasiLB);
            this.Controls.Add(this.olayTanimiLB);
            this.Controls.Add(this.bitisDkLB);
            this.Controls.Add(this.bitisSaatiLB);
            this.Controls.Add(this.baslangicDkLB);
            this.Controls.Add(this.baslangicSaatiLB);
            this.Controls.Add(this.olayTarihiLB);
            this.Controls.Add(this.olayAciklamasıRTB);
            this.Controls.Add(this.olayTanimiTB);
            this.Controls.Add(this.bitisDkCB);
            this.Controls.Add(this.bitisSaatCB);
            this.Controls.Add(this.baslangicDkCB);
            this.Controls.Add(this.baslangicSaatCB);
            this.Controls.Add(this.tarihSec);
            this.Name = "OlayEkleEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OlayEkleEkrani";
            this.Load += new System.EventHandler(this.OlayEkleEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tarihSec;
        private System.Windows.Forms.ComboBox baslangicSaatCB;
        private System.Windows.Forms.ComboBox baslangicDkCB;
        private System.Windows.Forms.ComboBox bitisSaatCB;
        private System.Windows.Forms.ComboBox bitisDkCB;
        private System.Windows.Forms.TextBox olayTanimiTB;
        private System.Windows.Forms.RichTextBox olayAciklamasıRTB;
        private System.Windows.Forms.Label olayTarihiLB;
        private System.Windows.Forms.Label baslangicSaatiLB;
        private System.Windows.Forms.Label baslangicDkLB;
        private System.Windows.Forms.Label bitisSaatiLB;
        private System.Windows.Forms.Label bitisDkLB;
        private System.Windows.Forms.Label olayTanimiLB;
        private System.Windows.Forms.Label olayAciklamasiLB;
        private System.Windows.Forms.CheckBox alarmEkleCB;
        private System.Windows.Forms.Button olayEkleBT;
    }
}