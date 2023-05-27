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
using System.Net.Mail;

namespace TakvimUygulamasi
{
    public partial class KayitOlmaEkrani : Form
    {
        SqlConnection kayitBaglanti = AnaEkran.AnaBaglanti;
        public KayitOlmaEkrani()
        {
            InitializeComponent();
        }

        private void adminSifreTB_TextChanged(object sender, EventArgs e)
        {
            if(adminSifreTB.Text == "çok gizli şifre")
            {
                adminMisinCB.Enabled = true;
            }
            else
            {
                adminMisinCB.Enabled = false;
            }
        }
  
        private void KaydolButonu_Click(object sender, EventArgs e)
        {

            bool adminMi = false;
            bool hataliMi = false;
            if (adminMisinCB.Checked == true) { adminMi = true; }
            if (hatalıDurumlar(hataliMi)) { }
            else
            {
                try
                {
                    kayitBaglanti.Open();
                    SqlCommand kayitKomutu = new SqlCommand("Insert into Kullanicilar (AdminMi,Ad,Soyad,KullaniciAdi,Sifre,TcKimlikNo,TelefonNo,Email,Adres) values ('" + adminMi + "','" + AdTB.Text + "','" + SoyadTB.Text + "','" + KullaniciAdiTB.Text + "','" + SifreTB.Text + "','" + TcNoTB.Text + "','" + TelNoTB.Text + "','" + EmailTB.Text + "','" + adresRTB.Text + "')", kayitBaglanti);
                    kayitKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kaydoldunuz.","Tebrikler!");
                    var nesneler = this.Controls.OfType<TextBox>();
                    foreach (var nesne in nesneler) { nesne.Text = null; }
                    TelNoTB.Text = " ";
                    adresRTB.Text = " ";

                }
                catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Girdiğiniz bilgiler veri tabanında soruna yol açtı. Bazı bilgileri değiştirmeyi deneyin.","Uyarı!!!"); }
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
        
        private bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return false;
            }
            catch
            {
                return true;
            }
        }
        
        void yildizlariYokEt()
        {
            var nesneler = this.Controls.OfType<Label>();
            foreach (var nesne in nesneler) { if (nesne.Text == "*") { nesne.Visible = false; } }
        }
        private bool hatalıDurumlar(bool hataliMi)
        {
            if (AdTB.Text.Length < 2) { yildizlariYokEt(); yildiz1.Visible = true; MessageBox.Show("Ad 2 karakterden az olamaz", "Uyarı!"); hataliMi = true; }

            else if (SoyadTB.Text.Length < 2) { yildizlariYokEt(); yildiz2.Visible = true; MessageBox.Show("Soyad 2 karakterden az olamaz", "Uyarı!"); hataliMi = true; }

            else if (KullaniciAdiTB.Text.Length < 8) { yildizlariYokEt(); yildiz3.Visible = true; MessageBox.Show("Kullanıcı adı 8 karakterden az olamaz", "Uyarı!"); hataliMi = true; }

            else if (SifreTB.Text.Length < 8) { yildizlariYokEt(); yildiz4.Visible = true; MessageBox.Show("Şifre 8 karakterden az olamaz", "Uyarı!"); hataliMi = true; }

            else if (TcNoTB.Text.Length < 11) { yildizlariYokEt(); yildiz5.Visible = true; MessageBox.Show("Yanlış Tc no girişi", "Uyarı!"); hataliMi = true; }

            else if (TelNoTB.Text.Length < 15) { yildizlariYokEt(); yildiz6.Visible = true; MessageBox.Show("Yanlış tel no girişi", "Uyarı!"); hataliMi = true; }

            else if (Email_Format_Kontrol(EmailTB.Text)) { yildizlariYokEt(); yildiz7.Visible = true; MessageBox.Show("Yanlış Email formatı", "Uyarı!"); hataliMi = true; }

            else if (adresRTB.Text.Length < 10) { yildizlariYokEt(); yildiz8.Visible = true; MessageBox.Show("Adres çok kısa","Uyarı!"); hataliMi = true; }

            else { yildizlariYokEt(); hataliMi = false; }
            return hataliMi;
        }

        private void KayitOlmaEkrani_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 8; i++) { this.Controls["yildiz" + i.ToString()].Parent = ArkaPlan; }
            foreach (var item in this.Controls.OfType<Label>()){item.Parent = ArkaPlan;}
            soyadLB.Parent = ArkaPlan;
            sifreLB.Parent = ArkaPlan;
            telNoLB.Parent = ArkaPlan;
            AdresLB.Parent = ArkaPlan;
            adminMisinCB.Parent = ArkaPlan;
        }
    }
}
