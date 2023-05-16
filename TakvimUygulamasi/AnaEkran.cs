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
        public static string kullaniciSifre;
        public static SqlConnection girisBaglanti = new SqlConnection("Data Source=DESKTOP-HU58BL8\\SQLEXPRESS;Initial Catalog=TakvimUygulamasi; Integrated Security=TRUE");
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
          
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            bool varMi = false;
            girisBaglanti.Open();
            SqlCommand cmd = new SqlCommand("Select *from Kullanicilar", girisBaglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (KullaniciAdiTB.Text == rdr["KullaniciAdi"].ToString().TrimEnd() && SifreTB.Text == rdr["Sifre"].ToString().TrimEnd()) { varMi = true; break; }
            }
            girisBaglanti.Close();
            if (varMi == true)
            {
                kullaniciSifre = SifreTB.Text;
                KullaniciAdiTB.Text = null;
                SifreTB.Text = null;
                TakvimEkrani takvimekrani = new TakvimEkrani();
                takvimekrani.ShowDialog();
                
            }
            if (varMi == false) { MessageBox.Show("Bilgileriniz yanlış veya kayıt değilsiniz. kaydolun"); }
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
