using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxxoUserInterface.SatinAlma
{
    public partial class muhasebe : Form
    {
        public muhasebe()
        {
            InitializeComponent();
        }
        OksaDBDataContext nt = new OksaDBDataContext();
        private void muhasebe_Load(object sender, EventArgs e) 
        {
            tedarikci1CB.DataSource = nt.tblTedarikcis;
            tedarikci1CB.DisplayMember = "tedarikciAdi";
            tedarikci1CB.ValueMember = "tedarikciID";

            tedarikci2CB.DataSource = nt.tblTedarikcis;
            tedarikci2CB.DisplayMember = "tedarikciAdi";
            tedarikci2CB.ValueMember = "tedarikciID";

            tedarikci2CB.DataSource = nt.tblTedarikcis;
            tedarikci2CB.DisplayMember = "tedarikciAdi";
            tedarikci2CB.ValueMember = "tedarikciID";




        
        
        }

        private void tedarikci1CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblTedarikci secilen = comboBox1.SelectedItem as tblTedarikci;
            txtPuan1.Text = (from p in nt.tblTedarikcis
                             where p.tedarikciAdi == secilen.tedarikciAdi
                             select p.puan).ToString();

        }

        private void tedarikci2CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblTedarikci secilen = comboBox1.SelectedItem as tblTedarikci;
            txtPuan1.Text = (from p in nt.tblTedarikcis
                             where p.tedarikciAdi == secilen.tedarikciAdi
                             select p.puan).ToString();


        }

        private void tedarikci3CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblTedarikci secilen = comboBox1.SelectedItem as tblTedarikci;
            txtPuan1.Text = (from p in nt.tblTedarikcis
                             where p.tedarikciAdi == secilen.tedarikciAdi
                             select p.puan).ToString();

        }

        private void muhasebe_Load_1(object sender, EventArgs e)
        {

        }

       
      
    }
}
