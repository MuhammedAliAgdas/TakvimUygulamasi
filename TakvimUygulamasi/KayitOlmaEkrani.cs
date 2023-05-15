using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TakvimUygulamasi
{
    public partial class KayitOlmaEkrani : Form
    {
        SqlConnection kayitBaglanti = AnaEkran.girisBaglanti;
        public KayitOlmaEkrani()
        {
            InitializeComponent();
        }


        private void adminSifreTB_TextChanged(object sender, EventArgs e)
        {
            if(adminSifreTB.Text == "wuhuhiuw") { adminMisinCB.Enabled = true; }
            else { adminMisinCB.Enabled = false; }
        }
  
        private void KaydolButonu_Click(object sender, EventArgs e)
        {

            int adminMi = 0;
            bool hataliMi = false;
            if (adminMisinCB.Checked == true) { adminMi = 1; }
            if (hatalıDurumlar(hataliMi)) { }
            else
            {
                try
                {
                    kayitBaglanti.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Kullanicilar (AdminMi,Ad,Soyad,KullaniciAdi,Sifre,TcKimlikNo,TelefonNo,Email,Adres) values ('" + adminMi + "','" + AdTB.Text + "','" + SoyadTB.Text + "','" + KullaniciAdiTB.Text + "','" + SifreTB.Text + "','" + TcNoTB.Text + "','" + TelNoTB.Text + "','" + EmailTB.Text + "','" + adresRTB.Text + "')", kayitBaglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kaydoldun");
                    kayitBaglanti.Close();
                    var nesneler = this.Controls.OfType<TextBox>();
                    foreach (var nesne in nesneler) { nesne.Text = " "; }
                    TelNoTB.Text = " ";
                    adresRTB.Text = " ";

                }
                catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Girdiğiniz bilgiler veri tabanında soruna yol açtı. Bazı bilgileri değiştirmeyi deneyin."); }
                finally { kayitBaglanti.Close(); }
            }
        }

        private void KullaniciAdiTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space)) { }
            else { e.Handled = false; }
        }

        private void SifreTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space)) { }
            else { e.Handled = false; }
        }

        private void TcNoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (TcNoTB.Text.Trim().Length == 11 && e.KeyChar != (char)Keys.Back)
            { e.Handled = true; }
        }

        private void TelNoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (TelNoTB.Text.Trim().Length == 11 && e.KeyChar != (char)Keys.Back)
            { e.Handled = true; }
        }

        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space)) { }
            else { e.Handled = false; }
        }

        private bool hatalıDurumlar(bool hataliMi)
        {
            var nesneler = this.Controls.OfType<Label>();
            if (AdTB.Text.Length < 2) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } adHataLB.Visible = true; MessageBox.Show("Ad 2 karakterden az olamaz"); hataliMi = true; }
            else if (SoyadTB.Text.Length < 2) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } soyadHataLB.Visible = true; MessageBox.Show("Soyad 2 karakterden az olamaz"); hataliMi = true; }
            else if (KullaniciAdiTB.Text.Length < 8) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } kullaniciadiHataLB.Visible = true; MessageBox.Show("Kullanıcı adı 8 karakterden az olamaz"); hataliMi = true; }
            else if (SifreTB.Text.Length < 8) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } sifreHataLB.Visible = true; MessageBox.Show("Şifre 8 karakterden az olamaz"); hataliMi = true; }
            else if (TcNoTB.Text.Length < 11) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } tcnoHataLB.Visible = true; MessageBox.Show("Yanlış Tc no girişi"); hataliMi = true; }
            else if (TelNoTB.Text.Length < 15) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } telnoHataLB.Visible = true; MessageBox.Show("Yanlış tel no girişi"); hataliMi = true; }
            else if (EmailTB.Text.Length < 12) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } emailHataLB.Visible = true; MessageBox.Show("e posta çok kısa"); hataliMi = true; }
            else if (adresRTB.Text.Length < 10) { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } adresHataLB.Visible = true; MessageBox.Show("Adres çok uzun"); hataliMi = true; }
            else { foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } } hataliMi = false; }

            return hataliMi;
        }



    }
}
