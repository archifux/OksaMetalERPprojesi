using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OksaUserInterface.Uretim
{
    public partial class satinAl : Form
    {
        public satinAl()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
        OksaDBDataContext oksa = new OksaDBDataContext();
        private void SatınAl_Load(object sender, EventArgs e)
        {
            MaddeTipiCB.DataSource = oksa.tblMalzemes;
            MaddeTipiCB.DisplayMember = "malzemeAdi";
            MaddeTipiCB.ValueMember = "malzemeID";

           
        }
    }
}
