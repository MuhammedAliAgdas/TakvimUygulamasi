using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
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

        bool varMi = false;
        private void TakvimEkrani_Load(object sender, EventArgs e)
        {
            ayPaneli.BringToFront();
            yılCB.SelectedIndex = 0;
            int olaySayisi = 0;
            var aylar = ayPaneli.Controls.OfType<Button>();
            foreach (var ay in aylar) { ay.Click += new EventHandler(this.ayButonlarinaTiklama); }
            //bool varMi = false;
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("Select OlayTarihi,AlarmVarMi from Olaylar Where OlayKod = '" + AnaEkran.kullaniciSifre + "'", olayGrountuleBaglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (tarihler(DateTime.Now.ToString())[3] == rdr["OlayTarihi"].ToString().TrimEnd() && Convert.ToBoolean(rdr["AlarmVarMi"].ToString().TrimEnd()) == true) { varMi = true; }
                if (tarihler(DateTime.Now.ToString())[1] == tarihler(rdr["OlayTarihi"].ToString().TrimEnd())[1] && Convert.ToBoolean(rdr["AlarmVarMi"].ToString().TrimEnd()) == true) { olaySayisi++; }
            }
            //MessageBox.Show("bu ay "+olaySayisi + " tane olay var");
            olayGrountuleBaglanti.Close();

        }

        private void TakvimEkrani_Shown(object sender, EventArgs e)
        {
            if (varMi)
            {
                SoundPlayer alarm = new SoundPlayer(@"C:\Users\Ayfer\OneDrive\Belgeler\GitHub\TakvimUygulamasi\AlarmSes.wav"); alarm.Play();
                DialogResult kullaniciCevabi = MessageBox.Show("Bugüne tanımlanan olaylar var!!!","UYARI!!!");
                if(kullaniciCevabi == DialogResult.OK) { alarm.Stop(); }


            }
        }

        private void ayButonlarinaTiklama(object sender, EventArgs e)
        {
            Button tiklananAy= (Button)sender;
            gunOlusturma(Convert.ToInt32(tiklananAy.Tag));
            ayIsmi.Text = tiklananAy.Text +" "+yılCB.Text;
            ayIsmi.Visible = true;
            ayPaneli.Visible = false;
            gunPaneli.Visible = true;
            panelDegistirBT.Visible = true;
            ay = tiklananAy.Tag.ToString();
            for (int i = 1; i <= 7; i++)
            {
                this.Controls["gun"+i.ToString()].Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)DateTime.Parse(yılCB.Text + "-" + tiklananAy.Tag.ToString() + "-0"+i.ToString()).DayOfWeek];
                this.Controls["gun" + i.ToString()].Visible = true;
            }

        }
        private void gunOlusturma(int kacinciAy)
        {
            int x = 0, y = 0;
            gunPaneli.Controls.Clear();
            int gunSayisi=0;
            if(kacinciAy == 4 || kacinciAy == 6 || kacinciAy == 9 || kacinciAy == 11) {gunSayisi = 30;}
            else if (kacinciAy == 2 && Convert.ToInt32(yılCB.Text) % 4 == 0) { gunSayisi = 29; }
            else if(kacinciAy==2) { gunSayisi = 28; }
            else if(kacinciAy == 1 || kacinciAy == 3 || kacinciAy == 5 || kacinciAy == 7 || kacinciAy == 8 || kacinciAy == 10 || kacinciAy == 12) { gunSayisi = 31; }
            for (int i = 1; i <= gunSayisi; i++)
            {
                Button gunButonu = new Button();
                gunButonu.Name = i.ToString();
                if (i <10) { gunButonu.Tag = ("0" + i).ToString(); } else { gunButonu.Tag = i.ToString(); }
                gunButonu.Text =i.ToString();
                gunButonu.Click += new EventHandler(this.gunTikla);
                gunButonu.Size = new Size(70,60);
                gunButonu.Location = new Point(x,y);
                x+=70;
                if (i%7==0){y += 60; x = 0;}
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
            baslangicSaatiCB.Items.Clear();
            baslangicDkCB.Items.Clear();
            bitisSaatiCB.Items.Clear();
            bitisDkCB.Items.Clear();
            Boolean alarmVarYok = false;
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar Where OlayKod LIKE '" + AnaEkran.kullaniciSifre + "' AND OlayTanimi LIKE '" + olayTanimlarıCB.Text + "'", olayGrountuleBaglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                olayTanimiGoruntuTB.Text = rdr[3].ToString(); olayAciklamaGoruntuRTB.Text = rdr[4].ToString(); baslangicGoruntuTB.Text = rdr[1].ToString(); bitisGoruntuTB.Text = rdr[2].ToString(); olayTarihiGoruntuTB.Text = rdr[0].ToString();
                olayTanimiGuncelleTB.Text = rdr[3].ToString(); olayAciklamasiGuncelleRTB.Text = rdr[4].ToString(); alarmVarYok = Convert.ToBoolean(rdr[5].ToString());
                saatGuncelleme(rdr[1].ToString(), rdr[2].ToString());
            }
            if (alarmVarYok) { alarmCB.Checked = true; }
            olayGrountuleBaglanti.Close();
            var labellar = this.GoruntulemeSayfasi.Controls.OfType<Label>();
            foreach (var label in labellar) { label.Visible = true; }
        }

        private void guncelleButonu_Click(object sender, EventArgs e)
        {
            bool alarmVarYok = false;
            if (alarmCB.Checked == true) { alarmVarYok = true; }
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Olaylar SET OlayTanimi = '"+ olayTanimiGuncelleTB.Text + "',OlayAciklamasi = '"+ olayAciklamasiGuncelleRTB.Text + "',OlayBaslangicSaati = '" + baslangicSaatiCB.Text + ":" + baslangicDkCB.Text + "',OlayBitisSaati ='" + bitisSaatiCB.Text + ":" + bitisDkCB.Text + "',AlarmVarMi = '"+alarmVarYok+"' Where OlayKod LIKE '" + AnaEkran.kullaniciSifre+ "'AND OlayTanimi LIKE '" + olayTanimlarıCB.Text + "'", olayGrountuleBaglanti);
            cmd.ExecuteNonQuery();
            olayGrountuleBaglanti.Close();
            olayTanimlarıCB.Items.Add(olayTanimiGuncelleTB.Text);
            olayTanimlarıCB.Items.Remove(olayTanimlarıCB.SelectedItem);
            olayTanimlarıCB.SelectedItem = null;
            olayTanimiGuncelleTB.Text = null;
            olayAciklamasiGuncelleRTB.Text = null;
            olayTanimiGoruntuTB.Text = null;
            olayAciklamaGoruntuRTB.Text = null;
            olayTarihiGoruntuTB.Text = null;
            baslangicGoruntuTB.Text = null;
            bitisGoruntuTB.Text = null;
            var comboboxlar = this.GuncellemeSayfasi.Controls.OfType<ComboBox>();
            foreach (var combobox in comboboxlar) { combobox.SelectedItem = null; }

        }

        private void olaySilButonu_Click(object sender, EventArgs e)
        {
            olayGrountuleBaglanti.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Olaylar Where OlayKod LIKE '" + AnaEkran.kullaniciSifre + "' AND OlayTanimi LIKE '" + olayTanimlarıCB.Text + "'", olayGrountuleBaglanti);
            cmd.ExecuteNonQuery();
            olayGrountuleBaglanti.Close();
            olayTanimiGoruntuTB.Text = null;
            olayAciklamaGoruntuRTB.Text = null;
            olayTarihiGoruntuTB=null;
            baslangicGoruntuTB = null;
            bitisGoruntuTB= null;
            olayTanimlarıCB.Items.Remove(olayTanimlarıCB.Text);
        }

        private void yılCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            gunPaneli.Visible = false;
            ayPaneli.Visible = true;
            ayIsmi.Visible = false;
        }

        private void panelDegistirBT_Click(object sender, EventArgs e)
        {
            gunPaneli.Visible = false;
            panelDegistirBT.Visible = false;
            ayPaneli.Visible = true;
            var labellar = this.Controls.OfType<Label>();
            foreach (var label in labellar) { label.Visible = false; }
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
        
        private void saatGuncelleme(string birlesikBaslangicS, string birlesikBitisS)
        {
            char[] baslangicSaatDk=new char[5];
            baslangicSaatDk = birlesikBaslangicS.ToCharArray();
            char[] bitisSaatDk = new char[5];
            bitisSaatDk = birlesikBitisS.ToCharArray();
            string baslangicSaat = "", baslangicDk = "", bitisSaat = "", bitisDk = "";
            for (int i = 0; i <= 5; i++)
            {
                if (i < 2) { baslangicSaat += baslangicSaatDk[i]; bitisSaat += bitisSaatDk[i];}
                else if(i > 2 && i < 5) { baslangicDk += baslangicSaatDk[i]; bitisDk += bitisSaatDk[i]; }
            }

            saatSecme(0);
            DkSecme(0);
            
            baslangicSaatiCB.SelectedIndex =Convert.ToInt32(baslangicSaat);
            baslangicDkCB.SelectedIndex = Convert.ToInt32(baslangicDk);
            bitisSaatiCB.SelectedIndex = Convert.ToInt32(bitisSaat);
            bitisDkCB.SelectedIndex = Convert.ToInt32(bitisDk);
            
        }

        private void bitisSaatiCB_Click(object sender, EventArgs e)
        {
            bitisSaatiCB.Items.Clear();
            saatSecme(Convert.ToInt32(baslangicSaatiCB.Text));
        }

        private void bitisDkCB_Click(object sender, EventArgs e)
        {
            bitisDkCB.Items.Clear();
            DkSecme(Convert.ToInt32(baslangicDkCB.Text));
        }

        private void saatSecme(int sayi)
        {
            for (int i = 0; i < 24; i++)
            {
                if (baslangicSaatiCB.SelectedItem == null)
                {
                    if (i < 10) { baslangicSaatiCB.Items.Add("0" + i); }
                    else { baslangicSaatiCB.Items.Add(i); }
                }
                if (i >= sayi && bitisSaatiCB.SelectedItem == null)
                {
                    if (i < 10) { bitisSaatiCB.Items.Add("0" + i); }
                    else { bitisSaatiCB.Items.Add(i); }
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

                if (baslangicSaatiCB.Text != bitisSaatiCB.Text)
                {
                    if (i < 10) { bitisDkCB.Items.Add("0" + i); }
                    else { bitisDkCB.Items.Add(i); }
                }


                if (i >= sayi && baslangicSaatiCB.Text == bitisSaatiCB.Text)
                {
                    if (i < 10) { bitisDkCB.Items.Add("0" + i); }
                    else { bitisDkCB.Items.Add(i); }
                }
            }
        }
        
    }
}
