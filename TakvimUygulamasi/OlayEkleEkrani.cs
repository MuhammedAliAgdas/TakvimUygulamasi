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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            int bitisSaat=0;
            for (int i = 0; i < 60; i++)
            {
                if (i < 10) { baslangicSaatCB.Items.Add("0" + i); baslangicDkCB.Items.Add("0" + i); }
                else if (i < 24) { baslangicSaatCB.Items.Add(i); baslangicDkCB.Items.Add(i); }
                else { baslangicDkCB.Items.Add(i); }
            }

            for (int j = bitisSaat; j < 60; j++)
            {
                if (j < 10) { bitisSaatCB.Items.Add("0" + j); bitisDkCB.Items.Add("0" + j); }
                else if (j < 24) { bitisSaatCB.Items.Add(j); bitisDkCB.Items.Add(j); }
                else { bitisDkCB.Items.Add(j); }
            }
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


            int alarmVorMi = 0;
            if (alarmEkleCB.Checked == true) { alarmVorMi = 1; }
            try
            {
                olayEkleBaglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert into Olaylar (OlayTarihi,OlayBaslangicSaati,OlayBitisSaati,OlayTanimi,OlayAciklamasi,AlarmVarMi,OlayKod) values ('" + yazılacakTarih + "','" + baslangicSaatCB.Text + ":" + baslangicDkCB.Text + "','" + bitisSaatCB.Text + "." + bitisDkCB.Text + "','" + olayTanimiTB.Text + "','" + olayAciklamasıRTB.Text + "','" + alarmVorMi + "','" + AnaEkran.kullaniciSifre + "')", olayEkleBaglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("olay kaydoldu");
                olayEkleBaglanti.Close();
                this.Dispose();
            }
            catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Veri tabanıyla ilgili sorun oluştu"); }
            finally { olayEkleBaglanti.Close(); }
        }
    }
}
