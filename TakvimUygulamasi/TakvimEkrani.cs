using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakvimUygulamasi
{
    public partial class TakvimEkrani : Form
    {
        public TakvimEkrani()
        {
            InitializeComponent();
        }

        private void TakvimEkrani_Load(object sender, EventArgs e)
        {
            var nesneler = ayPaneli.Controls.OfType<Button>();
            foreach (var nesne in nesneler) { nesne.Click+= new EventHandler(this.ayButonlarinaTiklama); }
        }

        private void ayButonlarinaTiklama(object sender, EventArgs e)
        {
            Button tiklananAy;
            tiklananAy = (Button)sender;
            gunOlusturma(Convert.ToInt32(tiklananAy.Tag));
            gunPaneli.Visible = true;
        }


        private void gunOlusturma(int kacinciAy)
        {
            int x = 0, y = 0;
            gunPaneli.Controls.Clear();
            int gunSayisi=0;
            if(kacinciAy == 4 || kacinciAy == 6 || kacinciAy == 9 || kacinciAy == 11) {gunSayisi = 30;}
            else if(kacinciAy==2) { gunSayisi = 28; }
            else if(kacinciAy == 1 || kacinciAy == 3 || kacinciAy == 5 || kacinciAy == 7 || kacinciAy == 8 || kacinciAy == 10 || kacinciAy == 12) { gunSayisi = 31; }
            for (int i = 1; i <= gunSayisi; i++)
            {
                Button gunButonu = new Button();
                gunButonu.Name=i.ToString();
                gunButonu.Text=i.ToString();
                //gunButonu.Click += new EventHandler(this.gunTikla);
                gunButonu.Size = new Size(50,50);
                gunButonu.Location = new Point(x,y);
                x+=50;
                if (i%7==0){y += 50; x = 0;}
                gunPaneli.Controls.Add(gunButonu);
                       
            }

        }

        private void OlayEkle_Click(object sender, EventArgs e)
        {
            OlayEkleEkrani olayEkleEkrani = new OlayEkleEkrani();
            olayEkleEkrani.ShowDialog();
        }
    }
}
