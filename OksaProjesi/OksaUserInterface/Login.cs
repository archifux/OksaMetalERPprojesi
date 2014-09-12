using OksaUserInterface.MakineKontrol;
using OksaUserInterface.Punch;
using OksaUserInterface.Uretim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OksaMachineLayer;
using OksaMachineLayer.DAL;

namespace OksaUserInterface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar(comboBox1.SelectedItem.ToString(), textBox2.Text);
           

            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Üretim":
                        uretimAnaEkrani ua = new uretimAnaEkrani();
                        ua.Show();
                        break;

                    case "Satın Alma":
                        siparisPanel sp = new siparisPanel();
                        sp.Show();
                        break;

                    case "Lazer":
                        PunchIsTakip lt = new PunchIsTakip();
                        lt.Name = "Lazer Takip Formu";
                        lt.Show();
                        break;

                    case "Punch":
                        PunchIsTakip wr = new PunchIsTakip();
                        wr.Show();
                        break;

                    case "Abkant 1":
                        Abkant1 a1 = new Abkant1();
                        a1.Show();
                        break;

                    case "Abkant 2":
                        Abkant2 a2 = new Abkant2();
                        a2.Show();
                        break;

                    case "Abkant 3":
                        Abkant3 a3 = new Abkant3();
                        a3.Show();
                        break;

                    case "Abkant 4":
                        Abkant4 a4 = new Abkant4();
                        a4.Show();
                        break;


                    default:
                        MessageBox.Show("Lütfen kullanıcı seçiniz");
                        this.Show();
                        break;
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Lütfen kullanıcı seçiniz");

            }
        }





        
    }
}
