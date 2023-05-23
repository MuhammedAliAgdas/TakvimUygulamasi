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
    public partial class OlayEkleEkrani : Form
    {
        SqlConnection olayEkleBaglanti = AnaEkran.girisBaglanti;
        public OlayEkleEkrani()
        {
            InitializeComponent();
        }
        private void OlayEkleEkrani_Load(object sender, EventArgs e)
        {
            tarihSec.MinDate = DateTime.Now;
            saatSecme(0);
            DkSecme(0);
        }

        private void olayEkleBT_Click(object sender, EventArgs e)
        {
            char[] tarih = new char[10];
            tarih = tarihSec.Value.ToString().ToCharArray();
            string yazılacakTarih = "";
            bool kontrol = true;
            for (int i = 0; i < tarihSec.Value.ToString().Length; i++)
            {
                if (tarih[i] == ' ') { kontrol = false; continue; }
                if (kontrol) { yazılacakTarih += tarih[i]; }
            }

            if (girisHatalari())
            {
                int alarmVorMi = 0;
                if (alarmEkleCB.Checked == true) { alarmVorMi = 1; }
                try
                {
                    olayEkleBaglanti.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Olaylar (OlayTarihi,OlayBaslangicSaati,OlayBitisSaati,OlayTanimi,OlayAciklamasi,AlarmVarMi,OlayKod) values ('" + yazılacakTarih + "','" + baslangicSaatCB.Text + ":" + baslangicDkCB.Text + "','" + bitisSaatCB.Text + ":" + bitisDkCB.Text + "','" + olayTanimiTB.Text + "','" + olayAciklamasıRTB.Text + "','" + alarmVorMi + "','" + AnaEkran.kullaniciSifre + "')", olayEkleBaglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("olay kaydoldu");
                    olayEkleBaglanti.Close();
                    this.Dispose();
                }
                catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Veri tabanıyla ilgili sorun oluştu"); }
                finally { olayEkleBaglanti.Close(); }
            }
    
        }

        private void baslangicSaatCB_SelectedIndexChanged(object sender, EventArgs e)
        { 
            bitisSaatCB.Items.Clear();
            saatSecme(Convert.ToInt32(baslangicSaatCB.Text));
        }

        private void baslangicDkCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bitisDkCB.Items.Clear();
            DkSecme(Convert.ToInt32(baslangicDkCB.Text));
       
        }

        private void bitisSaatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            baslangicDkCB.Items.Clear();
            bitisDkCB.Items.Clear();
            DkSecme(0);
        }

        private void saatSecme(int sayi)
        {
            for (int i = 0; i < 60; i++)
            {
                if(baslangicSaatCB.SelectedItem == null)
                { 
                    if (i < 10) { baslangicSaatCB.Items.Add("0" + i); }
                    else if (i < 24) { baslangicSaatCB.Items.Add(i);}
                }
                if (baslangicSaatCB.SelectedItem!=null && i>=sayi&& bitisSaatCB.SelectedItem==null)
                {
                    if (i < 10) { bitisSaatCB.Items.Add("0" + i); }
                    else if (i < 24) { bitisSaatCB.Items.Add(i); }
                }
            }
        }
         
        private void DkSecme(int sayi)
        {
            for (int i = 0; i < 60; i++)
            {
                if (baslangicDkCB.SelectedItem==null)
                {
                    if (i < 10) { baslangicDkCB.Items.Add("0" + i); }
                    else { baslangicDkCB.Items.Add(i); }
                 
                }

                if (baslangicSaatCB.Text != bitisSaatCB.Text)
                {
                    if (i < 10) { bitisDkCB.Items.Add("0" + i); }
                    else { bitisDkCB.Items.Add(i); }
                }


                if (baslangicDkCB.SelectedItem != null && i >= sayi && bitisDkCB.SelectedItem == null&& baslangicSaatCB.Text==bitisSaatCB.Text)
                {
                    if (i < 10) { bitisDkCB.Items.Add("0" + i); }
                    else { bitisDkCB.Items.Add(i); }
                }
            }
        }
        private bool girisHatalari()
        {
            bool hata = true;
            if (baslangicSaatCB.SelectedItem == null||baslangicDkCB.SelectedItem==null|| bitisSaatCB.SelectedItem==null||bitisDkCB.SelectedItem==null) { hata = false; bosSaatHatasi.Visible = true; MessageBox.Show("Saat bilgileri boş olamaz."); }
            else if (olayTanimiTB.Text.Length ==0) {hata = false; bosSaatHatasi.Visible = false; bosTanimHatasi.Visible = true; MessageBox.Show("Olay tanımı boş olamaz."); }
            else if(olayAciklamasıRTB.Text.Length == 0) { hata = false; bosSaatHatasi.Visible=false; bosTanimHatasi.Visible = false; bosAciklamaHatasi.Visible = true; MessageBox.Show("Olay açıklaması boş olamaz."); }
            else { hata = true; bosAciklamaHatasi.Visible = false; }

            return hata;
        }
    }
}
