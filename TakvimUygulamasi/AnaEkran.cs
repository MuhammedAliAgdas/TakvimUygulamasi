﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TakvimUygulamasi
{
    public partial class AnaEkran : Form
    {
        public static string olayKod;
        public static SqlConnection AnaBaglanti = new SqlConnection("Data Source=DESKTOP-HU58BL8\\SQLEXPRESS;Initial Catalog=TakvimUygulamasi; Integrated Security=TRUE");
        KayitOlmaEkrani kayitEkraniac = new KayitOlmaEkrani();

        public AnaEkran()
        {
            InitializeComponent();
            kayitEkraniac.MdiParent = this;
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            bool bilgilerDogruMu = false;
            try
            {
                AnaBaglanti.Open();
                SqlCommand girisKomutu = new SqlCommand("Select *from Kullanicilar", AnaBaglanti);
                SqlDataReader kullaniciBilgileri = girisKomutu.ExecuteReader();
                while (kullaniciBilgileri.Read())
                {
                    if (KullaniciAdiTB.Text == kullaniciBilgileri["KullaniciAdi"].ToString().TrimEnd() && SifreTB.Text == kullaniciBilgileri["Sifre"].ToString().TrimEnd()) { bilgilerDogruMu = true; break; }
                }
            }
            catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Üzgünüz, veri tabanında bir sorun oluştu lütfen tekrar deneyiniz.", "Uyarı!!!"); }
            finally
            {
                AnaBaglanti.Close();
                if (bilgilerDogruMu == true)
                {
                    olayKod = SifreTB.Text;
                    KullaniciAdiTB.Text = null;
                    SifreTB.Text = null;
                    AnaEkran.ActiveForm.Hide();
                    TakvimEkrani takvimekrani = new TakvimEkrani();
                    takvimekrani.ShowDialog();
                    this.Show();

                }
                if (bilgilerDogruMu == false) { MessageBox.Show("Bilgileriniz yanlış veya kayıt değilsiniz. Kayıt Ol seçeneğinden kaydolabilirsiniz.", "Uyarı!!!"); }
            }
        }
        
        private void KayıtAcmaLLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Text = "Kayıt Ekranı";
            this.Icon = new Icon(@"C:\Users\aliag\Documents\GitHub\TakvimUygulamasi\Kullanıcılar.ico");
            KullaniciAdiTB.Text = null;
            SifreTB.Text = null;
            GirisPaneli.Visible = false;
            kayitEkraniac.FormBorderStyle = FormBorderStyle.None;
            BilgiPaneli.Controls.Add(kayitEkraniac);
            kayitEkraniac.Show();
        }

        private void GeriButonu_Click(object sender, EventArgs e)
        {
            this.Text = "Giriş Ekranı";
            this.Icon = new Icon(@"C:\Users\aliag\Documents\GitHub\TakvimUygulamasi\Takvim.ico");
            BilgiPaneli.Controls.Remove(kayitEkraniac);
            GirisPaneli.Visible = true;
        }
    }
}
