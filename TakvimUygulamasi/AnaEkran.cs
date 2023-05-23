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

namespace TakvimUygulamasi
{
    public partial class AnaEkran : Form
    {
        public static string olayKod;
        public static SqlConnection AnaBaglanti = new SqlConnection("Data Source=AYKSR\\SQLEXPRESS02;Initial Catalog=TakvimUygulamasi; Integrated Security=TRUE");
        public AnaEkran()
        {
            InitializeComponent();
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
        KayitOlmaEkrani kayitEkraniac = new KayitOlmaEkrani();
        private void KayıtAcmaLLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisPaneli.Visible = false;
            kayitEkraniac.MdiParent = this;
            kayitEkraniac.FormBorderStyle = FormBorderStyle.None;
            BilgiPaneli.Controls.Add(kayitEkraniac);
            kayitEkraniac.Show();
        }

        private void GeriButonu_Click(object sender, EventArgs e)
        {
            BilgiPaneli.Controls.Remove(kayitEkraniac);
            GirisPaneli.Visible = true;
        }

      
    }
}
