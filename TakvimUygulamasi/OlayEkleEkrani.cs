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

namespace TakvimUygulamasi
{
    public partial class OlayEkleEkrani : Form
    {
        SqlConnection olayEkleBaglanti = AnaEkran.AnaBaglanti;
        public OlayEkleEkrani()
        {
            InitializeComponent();
        }
        private void OlayEkleEkrani_Load(object sender, EventArgs e)
        {
            tarihSec.MinDate = DateTime.Now;
            saatSecme(0);
            DkSecme(0);
            for (int i = 1; i <= 3; i++) { this.Controls["yildiz" + i.ToString()].Parent = ArkaPlan; }
            foreach (var item in this.Controls.OfType<Label>()){ item.Parent = ArkaPlan;}
            baslangicSaatiLB.Parent = ArkaPlan;
            bitisSaatiLB.Parent = ArkaPlan;
            olayTanimiLB.Parent = ArkaPlan;
            alarmEkleCB.Parent = ArkaPlan;
        }

        private string tarihBilgisi()
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
            return yazılacakTarih;
        }
        private void olayEkleBT_Click(object sender, EventArgs e)
        {

            if (girisHatalari())
            {
                int alarmVarMi = 0;
                if (alarmEkleCB.Checked == true) { alarmVarMi = 1; }
                try
                {
                    olayEkleBaglanti.Open();
                    SqlCommand olayKayitKomutu = new SqlCommand("Insert into Olaylar (OlayTarihi,OlayBaslangicSaati,OlayBitisSaati,OlayTanimi,OlayAciklamasi,AlarmVarMi,OlayKod) values ('" + tarihBilgisi() + "','" + baslangicSaatCB.Text + ":" + baslangicDkCB.Text + "','" + bitisSaatCB.Text + ":" + bitisDkCB.Text + "','" + olayTanimiTB.Text + "','" + olayAciklamasıRTB.Text + "','" + alarmVarMi + "','" + AnaEkran.olayKod + "')", olayEkleBaglanti) ;
                    olayKayitKomutu.ExecuteNonQuery();
                    MessageBox.Show("Olay kaydedildi.","Tebrikler!");
                    olayEkleBaglanti.Close();
                    this.Dispose();
                }
                catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Veri tabanıyla ilgili bir sorun oluştu. Tekrar deneyin.","Uyarı!!!"); }
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
            if (baslangicSaatCB.SelectedItem == null||baslangicDkCB.SelectedItem==null|| bitisSaatCB.SelectedItem==null||bitisDkCB.SelectedItem==null) { hata = false; yildiz1.Visible = true; MessageBox.Show("Saat bilgileri boş olamaz.", "Uyarı!"); }
            else if (olayTanimiTB.Text.Length ==0) {hata = false; yildiz1.Visible = false; yildiz2.Visible = true; MessageBox.Show("Olay tanımı boş olamaz.", "Uyarı!"); }
            else if(olayAciklamasıRTB.Text.Length == 0) { hata = false; yildiz1.Visible=false; yildiz2.Visible = false; yildiz3.Visible = true; MessageBox.Show("Olay açıklaması boş olamaz.", "Uyarı!"); }
            else { hata = true; yildiz3.Visible = false; }

            return hata;
        }

 
    }
}
