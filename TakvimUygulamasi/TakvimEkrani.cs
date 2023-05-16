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
    public partial class TakvimEkrani : Form
    {
        SqlConnection olayGrountuleBaglanti = AnaEkran.girisBaglanti;
        string gun, ay;
        public TakvimEkrani()
        {
            InitializeComponent();
        }

        private void TakvimEkrani_Load(object sender, EventArgs e)
        {
            yılCB.SelectedIndex = 0;
            int ahey = 0;
            var nesneler = ayPaneli.Controls.OfType<Button>();
            foreach (var nesne in nesneler) { nesne.Click+= new EventHandler(this.ayButonlarinaTiklama); }
            bool varMi = false;
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("Select OlayTarihi,AlarmVarMi from Olaylar Where OlayKod = '"+AnaEkran.kullaniciSifre+"'", olayGrountuleBaglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (tarihler(DateTime.Now.ToString())[3] == rdr["OlayTarihi"].ToString().TrimEnd() &&Convert.ToBoolean(rdr["AlarmVarMi"].ToString().TrimEnd())==true) { varMi = true;}
                if (tarihler(DateTime.Now.ToString())[1] == tarihler(rdr["OlayTarihi"].ToString().TrimEnd())[1] && Convert.ToBoolean(rdr["AlarmVarMi"].ToString().TrimEnd()) == true) { ahey++; }
            }
            MessageBox.Show("bu ay "+ahey + " tane olay var");
            if (varMi) {MessageBox.Show("Bugüne tanımlanan olaylar var!!!"); }
            olayGrountuleBaglanti.Close();

        }

        private void ayButonlarinaTiklama(object sender, EventArgs e)
        {
            Button tiklananAy= (Button)sender;
            gunOlusturma(Convert.ToInt32(tiklananAy.Tag));
            ayIsmi.Text = tiklananAy.Text;
            ayIsmi.Visible = true;
            ayPaneli.Visible = false;
            gunPaneli.Visible = true;
            panelDegistirBT.Visible = true;
            ay=tiklananAy.Tag.ToString();
        }


        private void gunOlusturma(int kacinciAy)
        {
            int x = 0, y = 40;
            gunPaneli.Controls.Clear();
            int gunSayisi=0;
            if(kacinciAy == 4 || kacinciAy == 6 || kacinciAy == 9 || kacinciAy == 11) {gunSayisi = 30;}
            else if (kacinciAy == 2 && Convert.ToInt32(yılCB.Text) % 4 == 0) { gunSayisi = 29; }
            else if(kacinciAy==2) { gunSayisi = 28; }
            else if(kacinciAy == 1 || kacinciAy == 3 || kacinciAy == 5 || kacinciAy == 7 || kacinciAy == 8 || kacinciAy == 10 || kacinciAy == 12) { gunSayisi = 31; }
            for (int i = 1; i <= gunSayisi; i++)
            {
                Button gunButonu = new Button();
                gunButonu.Name=i.ToString();
                gunButonu.Text=i.ToString();
                gunButonu.Click += new EventHandler(this.gunTikla);
                gunButonu.Size = new Size(50,50);
                gunButonu.Location = new Point(x,y);
                x+=50;
                if (i%7==0){y += 50; x = 0;}
                gunPaneli.Controls.Add(gunButonu);
                       
            }

        }

        private void gunTikla(object sender, EventArgs e)
        {
            olayTanimlarıCB.Items.Clear();
            Button tiklananGun = (Button)sender;
            if (Convert.ToInt32(tiklananGun.Name) < 10) { gun = "0" + tiklananGun.Name; }
            else { gun = tiklananGun.Name;}
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT OlayTanimi FROM Olaylar Where OlayKod LIKE '" + AnaEkran.kullaniciSifre + "' AND OlayTarihi LIKE '" + (gun+"."+ay+"."+yılCB.Text) + "'", olayGrountuleBaglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                olayTanimlarıCB.Items.Add(rdr[0].ToString());
            }
            olayGrountuleBaglanti.Close();
        }

        private void OlayEkle_Click(object sender, EventArgs e)
        {
            OlayEkleEkrani olayEkleEkrani = new OlayEkleEkrani();
            olayEkleEkrani.ShowDialog();
        }

        private void olayTanimlarıCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean alarmVarYok = false;
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar Where OlayKod LIKE '" + AnaEkran.kullaniciSifre + "' AND OlayTanimi LIKE '" + olayTanimlarıCB.Text + "'", olayGrountuleBaglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                olayTanimLB.Text = rdr[3].ToString(); olayAciklamasiLB.Text = rdr[4].ToString(); olayBaslangic.Text = rdr[1].ToString(); olayBitis.Text = rdr[2].ToString(); olayTarih.Text = rdr[0].ToString();
                olayTanimiTB.Text = rdr[3].ToString(); olayAciklamasiRTB.Text = rdr[4].ToString(); alarmVarYok = Convert.ToBoolean(rdr[5].ToString());
            }
            if (alarmVarYok) { alarmCB.Checked = true; }
            olayGrountuleBaglanti.Close();

            for (int i = 0; i < 60; i++)
            {
                if (i < 10) { baslangicSaatiCB.Items.Add("0" + i); baslangicDkCB.Items.Add("0" + i); }
                else if (i < 24) { baslangicSaatiCB.Items.Add(i); baslangicDkCB.Items.Add(i); }
                else { baslangicDkCB.Items.Add(i); }
            }

            for (int i = 0; i < 60; i++)
            {
                if (i < 10) { bitisSaatiCB.Items.Add("0" + i); bitisDkCB.Items.Add("0" + i); }
                else if (i < 24) { bitisSaatiCB.Items.Add(i); bitisDkCB.Items.Add(i); }
                else { bitisDkCB.Items.Add(i); }
            }
        }

        private void guncelleButonu_Click(object sender, EventArgs e)
        {
            bool alarmVarYok = false;
            if (alarmCB.Checked == true) { alarmVarYok = true; }
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Olaylar SET OlayTanimi = '"+ olayTanimiTB.Text + "',OlayAciklamasi = '"+ olayAciklamasiRTB.Text + "',OlayBaslangicSaati = '" + baslangicSaatiCB.Text + ":" + baslangicDkCB.Text + "',OlayBitisSaati ='" + bitisSaatiCB.Text + ":" + bitisDkCB.Text + "',AlarmVarMi = '"+alarmVarYok+"' Where OlayKod LIKE '" + AnaEkran.kullaniciSifre+ "'AND OlayTanimi LIKE '" + olayTanimlarıCB.Text + "'", olayGrountuleBaglanti);
            cmd.ExecuteNonQuery();
            olayGrountuleBaglanti.Close();
            olayTanimlarıCB.Items.Clear();
            olayTanimLB.Text = " ";
            olayTarih.Text = " ";
            olayAciklamasiLB.Text = " ";
            olayBaslangic.Text = " ";
            olayBitis.Text = " ";
        }

        private void olaySilButonu_Click(object sender, EventArgs e)
        {
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Olaylar Where OlayKod LIKE '" + AnaEkran.kullaniciSifre + "' AND OlayTanimi LIKE '" + olayTanimlarıCB.Text + "'", olayGrountuleBaglanti);
            cmd.ExecuteNonQuery();
            olayGrountuleBaglanti.Close();
            olayTanimLB.Text = " ";
            olayTarih.Text = " ";
            olayAciklamasiLB.Text = " ";
            olayBaslangic.Text = " ";
            olayBitis.Text = " ";
            olayTanimlarıCB.Items.Remove(olayTanimlarıCB.Text);
        }

        private void yılCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            gunPaneli.Visible = false;
            ayPaneli.Visible = true;
        }

        private void panelDegistirBT_Click(object sender, EventArgs e)
        {
            gunPaneli.Visible = false;
            panelDegistirBT.Visible = false;
            ayPaneli.Visible = true;
            ayIsmi.Visible= false;
        }
        
        private string[] tarihler(string tarih)
        {
            char[] simdi = new char[10];
            simdi = tarih.ToCharArray();
            string gun="",ay="",yil="",tamTarih="";
            for (int i = 0; i <= 10; i++)
            {
                if (i<2) { gun += simdi[i]; }
                else if (i>=3&&i<5) { ay += simdi[i];}
                else if(i>=6&&i<10){ yil += simdi[i];}
            }
            tamTarih = gun +"."+ ay + "." + yil;
            string[] simdik = {gun,ay,yil,tamTarih};
            return simdik;
        }
        
    }
}
