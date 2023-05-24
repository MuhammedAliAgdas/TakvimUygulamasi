using System;
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
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            kayitEkraniac.MdiParent = this;
          
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            bool AlarmVarMi = false;
            AnaBaglanti.Open();
            SqlCommand girisKomutu = new SqlCommand("Select *from Kullanicilar", AnaBaglanti);
            SqlDataReader kullaniciBilgileri = girisKomutu.ExecuteReader();
            while (kullaniciBilgileri.Read())
            {
                if (KullaniciAdiTB.Text == kullaniciBilgileri["KullaniciAdi"].ToString().TrimEnd() && SifreTB.Text == kullaniciBilgileri["Sifre"].ToString().TrimEnd()) { AlarmVarMi = true; break; }
            }
            AnaBaglanti.Close();
            if (AlarmVarMi == true)
            {
                olayKod = SifreTB.Text;
                KullaniciAdiTB.Text = null;
                SifreTB.Text = null;
                TakvimEkrani takvimekrani = new TakvimEkrani();
                takvimekrani.ShowDialog();
                
            }
            if (AlarmVarMi == false) { MessageBox.Show("Bilgileriniz yanlış veya kayıt değilsiniz. kaydolun"); }
        }
        
        private void KayıtAcmaLLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Text = "Kayıt Ekranı";
            this.Icon = new Icon(@"C:\Users\Ayfer\OneDrive\Belgeler\GitHub\TakvimUygulamasi\Kullanıcılar.ico");
            GirisPaneli.Visible = false;
            kayitEkraniac.FormBorderStyle = FormBorderStyle.None;
            BilgiPaneli.Controls.Add(kayitEkraniac);
            kayitEkraniac.Show();
        }

        private void GeriButonu_Click(object sender, EventArgs e)
        {
            this.Text = "Giriş Ekranı";
            this.Icon = new Icon(@"C:\Users\Ayfer\OneDrive\Belgeler\GitHub\TakvimUygulamasi\Takvim.ico");
            BilgiPaneli.Controls.Remove(kayitEkraniac);
            GirisPaneli.Visible = true;
        }
    }
}
