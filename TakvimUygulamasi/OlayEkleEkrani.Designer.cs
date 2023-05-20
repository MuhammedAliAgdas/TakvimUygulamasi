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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlayEkleEkrani));
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
            this.tarihSec.Location = new System.Drawing.Point(427, 53);
            this.tarihSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tarihSec.MaxDate = new System.DateTime(2033, 12, 31, 0, 0, 0, 0);
            this.tarihSec.Name = "tarihSec";
            this.tarihSec.Size = new System.Drawing.Size(265, 22);
            this.tarihSec.TabIndex = 0;
            this.tarihSec.Value = new System.DateTime(2023, 5, 15, 0, 0, 0, 0);
            // 
            // baslangicSaatCB
            // 
            this.baslangicSaatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslangicSaatCB.FormattingEnabled = true;
            this.baslangicSaatCB.Location = new System.Drawing.Point(279, 133);
            this.baslangicSaatCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslangicSaatCB.Name = "baslangicSaatCB";
            this.baslangicSaatCB.Size = new System.Drawing.Size(160, 24);
            this.baslangicSaatCB.TabIndex = 1;
            this.baslangicSaatCB.SelectedIndexChanged += new System.EventHandler(this.baslangicSaatCB_SelectedIndexChanged);
            // 
            // baslangicDkCB
            // 
            this.baslangicDkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslangicDkCB.FormattingEnabled = true;
            this.baslangicDkCB.Location = new System.Drawing.Point(532, 133);
            this.baslangicDkCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslangicDkCB.Name = "baslangicDkCB";
            this.baslangicDkCB.Size = new System.Drawing.Size(160, 24);
            this.baslangicDkCB.TabIndex = 2;
            this.baslangicDkCB.SelectedIndexChanged += new System.EventHandler(this.baslangicDkCB_SelectedIndexChanged);
            // 
            // bitisSaatCB
            // 
            this.bitisSaatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitisSaatCB.FormattingEnabled = true;
            this.bitisSaatCB.Location = new System.Drawing.Point(279, 185);
            this.bitisSaatCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitisSaatCB.Name = "bitisSaatCB";
            this.bitisSaatCB.Size = new System.Drawing.Size(160, 24);
            this.bitisSaatCB.TabIndex = 3;
            this.bitisSaatCB.SelectedIndexChanged += new System.EventHandler(this.bitisSaatCB_SelectedIndexChanged);
            // 
            // bitisDkCB
            // 
            this.bitisDkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitisDkCB.FormattingEnabled = true;
            this.bitisDkCB.Location = new System.Drawing.Point(532, 185);
            this.bitisDkCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitisDkCB.Name = "bitisDkCB";
            this.bitisDkCB.Size = new System.Drawing.Size(160, 24);
            this.bitisDkCB.TabIndex = 4;
            // 
            // olayTanimiTB
            // 
            this.olayTanimiTB.Location = new System.Drawing.Point(403, 276);
            this.olayTanimiTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.olayTanimiTB.MaxLength = 50;
            this.olayTanimiTB.Name = "olayTanimiTB";
            this.olayTanimiTB.Size = new System.Drawing.Size(289, 22);
            this.olayTanimiTB.TabIndex = 5;
            // 
            // olayAciklamasıRTB
            // 
            this.olayAciklamasıRTB.Location = new System.Drawing.Point(381, 373);
            this.olayAciklamasıRTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.olayAciklamasıRTB.MaxLength = 250;
            this.olayAciklamasıRTB.Name = "olayAciklamasıRTB";
            this.olayAciklamasıRTB.Size = new System.Drawing.Size(311, 117);
            this.olayAciklamasıRTB.TabIndex = 6;
            this.olayAciklamasıRTB.Text = "";
            // 
            // olayTarihiLB
            // 
            this.olayTarihiLB.AutoSize = true;
            this.olayTarihiLB.Location = new System.Drawing.Point(299, 53);
            this.olayTarihiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olayTarihiLB.Name = "olayTarihiLB";
            this.olayTarihiLB.Size = new System.Drawing.Size(112, 16);
            this.olayTarihiLB.TabIndex = 7;
            this.olayTarihiLB.Text = "Olay Tarihi Seçin:";
            // 
            // baslangicSaatiLB
            // 
            this.baslangicSaatiLB.AutoSize = true;
            this.baslangicSaatiLB.Location = new System.Drawing.Point(163, 137);
            this.baslangicSaatiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslangicSaatiLB.Name = "baslangicSaatiLB";
            this.baslangicSaatiLB.Size = new System.Drawing.Size(102, 16);
            this.baslangicSaatiLB.TabIndex = 8;
            this.baslangicSaatiLB.Text = "Başlangıç saati:";
            // 
            // baslangicDkLB
            // 
            this.baslangicDkLB.AutoSize = true;
            this.baslangicDkLB.Location = new System.Drawing.Point(460, 137);
            this.baslangicDkLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baslangicDkLB.Name = "baslangicDkLB";
            this.baslangicDkLB.Size = new System.Drawing.Size(63, 16);
            this.baslangicDkLB.TabIndex = 9;
            this.baslangicDkLB.Text = "Dakikası:";
            // 
            // bitisSaatiLB
            // 
            this.bitisSaatiLB.AutoSize = true;
            this.bitisSaatiLB.Location = new System.Drawing.Point(200, 188);
            this.bitisSaatiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitisSaatiLB.Name = "bitisSaatiLB";
            this.bitisSaatiLB.Size = new System.Drawing.Size(69, 16);
            this.bitisSaatiLB.TabIndex = 10;
            this.bitisSaatiLB.Text = "Bitiş Saati:";
            // 
            // bitisDkLB
            // 
            this.bitisDkLB.AutoSize = true;
            this.bitisDkLB.Location = new System.Drawing.Point(460, 188);
            this.bitisDkLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitisDkLB.Name = "bitisDkLB";
            this.bitisDkLB.Size = new System.Drawing.Size(63, 16);
            this.bitisDkLB.TabIndex = 11;
            this.bitisDkLB.Text = "Dakikası:";
            // 
            // olayTanimiLB
            // 
            this.olayTanimiLB.AutoSize = true;
            this.olayTanimiLB.Location = new System.Drawing.Point(279, 279);
            this.olayTanimiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olayTanimiLB.Name = "olayTanimiLB";
            this.olayTanimiLB.Size = new System.Drawing.Size(110, 16);
            this.olayTanimiLB.TabIndex = 12;
            this.olayTanimiLB.Text = "Olay Tanımı girin:";
            // 
            // olayAciklamasiLB
            // 
            this.olayAciklamasiLB.AutoSize = true;
            this.olayAciklamasiLB.Location = new System.Drawing.Point(229, 373);
            this.olayAciklamasiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olayAciklamasiLB.Name = "olayAciklamasiLB";
            this.olayAciklamasiLB.Size = new System.Drawing.Size(137, 16);
            this.olayAciklamasiLB.TabIndex = 13;
            this.olayAciklamasiLB.Text = "Olay Açıklaması Girin:";
            // 
            // alarmEkleCB
            // 
            this.alarmEkleCB.AutoSize = true;
            this.alarmEkleCB.Location = new System.Drawing.Point(381, 528);
            this.alarmEkleCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alarmEkleCB.Name = "alarmEkleCB";
            this.alarmEkleCB.Size = new System.Drawing.Size(142, 20);
            this.alarmEkleCB.TabIndex = 14;
            this.alarmEkleCB.Text = "Alarm Eklensin Mi?";
            this.alarmEkleCB.UseVisualStyleBackColor = true;
            // 
            // olayEkleBT
            // 
            this.olayEkleBT.Location = new System.Drawing.Point(464, 602);
            this.olayEkleBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.olayEkleBT.Name = "olayEkleBT";
            this.olayEkleBT.Size = new System.Drawing.Size(100, 70);
            this.olayEkleBT.TabIndex = 15;
            this.olayEkleBT.Text = "Olayı Ekle";
            this.olayEkleBT.UseVisualStyleBackColor = true;
            this.olayEkleBT.Click += new System.EventHandler(this.olayEkleBT_Click);
            // 
            // OlayEkleEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 706);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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