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
            this.yildiz1 = new System.Windows.Forms.Label();
            this.yildiz2 = new System.Windows.Forms.Label();
            this.yildiz3 = new System.Windows.Forms.Label();
            this.ArkaPlan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArkaPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tarihSec
            // 
            this.tarihSec.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.tarihSec.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.tarihSec.CalendarTrailingForeColor = System.Drawing.Color.IndianRed;
            this.tarihSec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihSec.Location = new System.Drawing.Point(154, 43);
            this.tarihSec.MaxDate = new System.DateTime(2033, 12, 31, 0, 0, 0, 0);
            this.tarihSec.Name = "tarihSec";
            this.tarihSec.Size = new System.Drawing.Size(338, 24);
            this.tarihSec.TabIndex = 0;
            this.tarihSec.Value = new System.DateTime(2023, 5, 15, 0, 0, 0, 0);
            // 
            // baslangicSaatCB
            // 
            this.baslangicSaatCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baslangicSaatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslangicSaatCB.FormattingEnabled = true;
            this.baslangicSaatCB.Location = new System.Drawing.Point(160, 91);
            this.baslangicSaatCB.Name = "baslangicSaatCB";
            this.baslangicSaatCB.Size = new System.Drawing.Size(121, 21);
            this.baslangicSaatCB.TabIndex = 1;
            this.baslangicSaatCB.SelectedIndexChanged += new System.EventHandler(this.baslangicSaatCB_SelectedIndexChanged);
            // 
            // baslangicDkCB
            // 
            this.baslangicDkCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baslangicDkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslangicDkCB.FormattingEnabled = true;
            this.baslangicDkCB.Location = new System.Drawing.Point(377, 93);
            this.baslangicDkCB.Name = "baslangicDkCB";
            this.baslangicDkCB.Size = new System.Drawing.Size(121, 21);
            this.baslangicDkCB.TabIndex = 2;
            this.baslangicDkCB.SelectedIndexChanged += new System.EventHandler(this.baslangicDkCB_SelectedIndexChanged);
            // 
            // bitisSaatCB
            // 
            this.bitisSaatCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bitisSaatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitisSaatCB.FormattingEnabled = true;
            this.bitisSaatCB.Location = new System.Drawing.Point(160, 146);
            this.bitisSaatCB.Name = "bitisSaatCB";
            this.bitisSaatCB.Size = new System.Drawing.Size(121, 21);
            this.bitisSaatCB.TabIndex = 3;
            this.bitisSaatCB.SelectedIndexChanged += new System.EventHandler(this.bitisSaatCB_SelectedIndexChanged);
            // 
            // bitisDkCB
            // 
            this.bitisDkCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bitisDkCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitisDkCB.FormattingEnabled = true;
            this.bitisDkCB.Location = new System.Drawing.Point(377, 145);
            this.bitisDkCB.Name = "bitisDkCB";
            this.bitisDkCB.Size = new System.Drawing.Size(121, 21);
            this.bitisDkCB.TabIndex = 4;
            // 
            // olayTanimiTB
            // 
            this.olayTanimiTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.olayTanimiTB.Location = new System.Drawing.Point(160, 199);
            this.olayTanimiTB.MaxLength = 50;
            this.olayTanimiTB.Name = "olayTanimiTB";
            this.olayTanimiTB.Size = new System.Drawing.Size(338, 21);
            this.olayTanimiTB.TabIndex = 5;
            // 
            // olayAciklamasıRTB
            // 
            this.olayAciklamasıRTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.olayAciklamasıRTB.Location = new System.Drawing.Point(160, 254);
            this.olayAciklamasıRTB.MaxLength = 250;
            this.olayAciklamasıRTB.Name = "olayAciklamasıRTB";
            this.olayAciklamasıRTB.Size = new System.Drawing.Size(338, 105);
            this.olayAciklamasıRTB.TabIndex = 6;
            this.olayAciklamasıRTB.Text = "";
            // 
            // olayTarihiLB
            // 
            this.olayTarihiLB.AutoSize = true;
            this.olayTarihiLB.BackColor = System.Drawing.Color.Transparent;
            this.olayTarihiLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olayTarihiLB.ForeColor = System.Drawing.Color.Thistle;
            this.olayTarihiLB.Location = new System.Drawing.Point(55, 43);
            this.olayTarihiLB.Name = "olayTarihiLB";
            this.olayTarihiLB.Size = new System.Drawing.Size(93, 22);
            this.olayTarihiLB.TabIndex = 7;
            this.olayTarihiLB.Tag = "yazi";
            this.olayTarihiLB.Text = "Olay Tarihi:";
            // 
            // baslangicSaatiLB
            // 
            this.baslangicSaatiLB.AutoSize = true;
            this.baslangicSaatiLB.BackColor = System.Drawing.Color.Transparent;
            this.baslangicSaatiLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangicSaatiLB.ForeColor = System.Drawing.Color.Thistle;
            this.baslangicSaatiLB.Location = new System.Drawing.Point(20, 92);
            this.baslangicSaatiLB.Name = "baslangicSaatiLB";
            this.baslangicSaatiLB.Size = new System.Drawing.Size(128, 22);
            this.baslangicSaatiLB.TabIndex = 8;
            this.baslangicSaatiLB.Tag = "yazi";
            this.baslangicSaatiLB.Text = "Başlangıç saati:";
            // 
            // baslangicDkLB
            // 
            this.baslangicDkLB.AutoSize = true;
            this.baslangicDkLB.BackColor = System.Drawing.Color.Transparent;
            this.baslangicDkLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangicDkLB.ForeColor = System.Drawing.Color.Thistle;
            this.baslangicDkLB.Location = new System.Drawing.Point(292, 91);
            this.baslangicDkLB.Name = "baslangicDkLB";
            this.baslangicDkLB.Size = new System.Drawing.Size(79, 22);
            this.baslangicDkLB.TabIndex = 9;
            this.baslangicDkLB.Tag = "yazi";
            this.baslangicDkLB.Text = "Dakikası:";
            // 
            // bitisSaatiLB
            // 
            this.bitisSaatiLB.AutoSize = true;
            this.bitisSaatiLB.BackColor = System.Drawing.Color.Transparent;
            this.bitisSaatiLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisSaatiLB.ForeColor = System.Drawing.Color.Thistle;
            this.bitisSaatiLB.Location = new System.Drawing.Point(59, 146);
            this.bitisSaatiLB.Name = "bitisSaatiLB";
            this.bitisSaatiLB.Size = new System.Drawing.Size(89, 22);
            this.bitisSaatiLB.TabIndex = 10;
            this.bitisSaatiLB.Tag = "yazi";
            this.bitisSaatiLB.Text = "Bitiş Saati:";
            // 
            // bitisDkLB
            // 
            this.bitisDkLB.AutoSize = true;
            this.bitisDkLB.BackColor = System.Drawing.Color.Transparent;
            this.bitisDkLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisDkLB.ForeColor = System.Drawing.Color.Thistle;
            this.bitisDkLB.Location = new System.Drawing.Point(292, 145);
            this.bitisDkLB.Name = "bitisDkLB";
            this.bitisDkLB.Size = new System.Drawing.Size(79, 22);
            this.bitisDkLB.TabIndex = 11;
            this.bitisDkLB.Tag = "yazi";
            this.bitisDkLB.Text = "Dakikası:";
            // 
            // olayTanimiLB
            // 
            this.olayTanimiLB.AutoSize = true;
            this.olayTanimiLB.BackColor = System.Drawing.Color.Transparent;
            this.olayTanimiLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olayTanimiLB.ForeColor = System.Drawing.Color.Thistle;
            this.olayTanimiLB.Location = new System.Drawing.Point(46, 197);
            this.olayTanimiLB.Name = "olayTanimiLB";
            this.olayTanimiLB.Size = new System.Drawing.Size(102, 22);
            this.olayTanimiLB.TabIndex = 12;
            this.olayTanimiLB.Tag = "yazi";
            this.olayTanimiLB.Text = "Olay Tanımı:";
            // 
            // olayAciklamasiLB
            // 
            this.olayAciklamasiLB.AutoSize = true;
            this.olayAciklamasiLB.BackColor = System.Drawing.Color.Transparent;
            this.olayAciklamasiLB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olayAciklamasiLB.ForeColor = System.Drawing.Color.Thistle;
            this.olayAciklamasiLB.Location = new System.Drawing.Point(15, 254);
            this.olayAciklamasiLB.Name = "olayAciklamasiLB";
            this.olayAciklamasiLB.Size = new System.Drawing.Size(133, 22);
            this.olayAciklamasiLB.TabIndex = 13;
            this.olayAciklamasiLB.Tag = "yazi";
            this.olayAciklamasiLB.Text = "Olay Açıklaması:";
            // 
            // alarmEkleCB
            // 
            this.alarmEkleCB.AutoSize = true;
            this.alarmEkleCB.BackColor = System.Drawing.Color.Transparent;
            this.alarmEkleCB.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarmEkleCB.ForeColor = System.Drawing.Color.Thistle;
            this.alarmEkleCB.Location = new System.Drawing.Point(227, 368);
            this.alarmEkleCB.Name = "alarmEkleCB";
            this.alarmEkleCB.Size = new System.Drawing.Size(170, 26);
            this.alarmEkleCB.TabIndex = 14;
            this.alarmEkleCB.Text = "Alarm Eklensin Mi?";
            this.alarmEkleCB.UseVisualStyleBackColor = false;
            // 
            // olayEkleBT
            // 
            this.olayEkleBT.BackColor = System.Drawing.Color.LavenderBlush;
            this.olayEkleBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.olayEkleBT.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.olayEkleBT.FlatAppearance.BorderSize = 2;
            this.olayEkleBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.olayEkleBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.olayEkleBT.Font = new System.Drawing.Font("Ebrima", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olayEkleBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.olayEkleBT.Location = new System.Drawing.Point(257, 400);
            this.olayEkleBT.Name = "olayEkleBT";
            this.olayEkleBT.Size = new System.Drawing.Size(100, 60);
            this.olayEkleBT.TabIndex = 15;
            this.olayEkleBT.Text = "Olayı Ekle";
            this.olayEkleBT.UseVisualStyleBackColor = false;
            this.olayEkleBT.Click += new System.EventHandler(this.olayEkleBT_Click);
            // 
            // yildiz1
            // 
            this.yildiz1.AutoSize = true;
            this.yildiz1.BackColor = System.Drawing.Color.Transparent;
            this.yildiz1.CausesValidation = false;
            this.yildiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildiz1.ForeColor = System.Drawing.Color.Red;
            this.yildiz1.Location = new System.Drawing.Point(504, 119);
            this.yildiz1.Name = "yildiz1";
            this.yildiz1.Size = new System.Drawing.Size(31, 39);
            this.yildiz1.TabIndex = 16;
            this.yildiz1.Text = "*";
            this.yildiz1.Visible = false;
            // 
            // yildiz2
            // 
            this.yildiz2.AutoSize = true;
            this.yildiz2.BackColor = System.Drawing.Color.Transparent;
            this.yildiz2.CausesValidation = false;
            this.yildiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildiz2.ForeColor = System.Drawing.Color.Red;
            this.yildiz2.Location = new System.Drawing.Point(504, 197);
            this.yildiz2.Name = "yildiz2";
            this.yildiz2.Size = new System.Drawing.Size(31, 39);
            this.yildiz2.TabIndex = 17;
            this.yildiz2.Text = "*";
            this.yildiz2.Visible = false;
            // 
            // yildiz3
            // 
            this.yildiz3.AutoSize = true;
            this.yildiz3.BackColor = System.Drawing.Color.Transparent;
            this.yildiz3.CausesValidation = false;
            this.yildiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildiz3.ForeColor = System.Drawing.Color.Red;
            this.yildiz3.Location = new System.Drawing.Point(504, 254);
            this.yildiz3.Name = "yildiz3";
            this.yildiz3.Size = new System.Drawing.Size(31, 39);
            this.yildiz3.TabIndex = 18;
            this.yildiz3.Text = "*";
            this.yildiz3.Visible = false;
            // 
            // ArkaPlan
            // 
            this.ArkaPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArkaPlan.Image = ((System.Drawing.Image)(resources.GetObject("ArkaPlan.Image")));
            this.ArkaPlan.Location = new System.Drawing.Point(0, 0);
            this.ArkaPlan.Name = "ArkaPlan";
            this.ArkaPlan.Size = new System.Drawing.Size(606, 472);
            this.ArkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArkaPlan.TabIndex = 19;
            this.ArkaPlan.TabStop = false;
            // 
            // OlayEkleEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 472);
            this.Controls.Add(this.yildiz3);
            this.Controls.Add(this.yildiz2);
            this.Controls.Add(this.yildiz1);
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
            this.Controls.Add(this.ArkaPlan);
            this.Font = new System.Drawing.Font("Candara", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OlayEkleEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olay Ekle";
            this.Load += new System.EventHandler(this.OlayEkleEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArkaPlan)).EndInit();
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
        private System.Windows.Forms.Label yildiz1;
        private System.Windows.Forms.Label yildiz2;
        private System.Windows.Forms.Label yildiz3;
        private System.Windows.Forms.PictureBox ArkaPlan;
    }
}