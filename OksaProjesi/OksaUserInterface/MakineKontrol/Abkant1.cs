using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OksaUserInterface.MakineKontrol
{
    public partial class Abkant1 : Form
    {
        public Abkant1()
        {
            InitializeComponent();
        }

        private void btnEksik_Click(object sender, EventArgs e)
        {
            EksikIslem ei = new EksikIslem();
            ei.Show();
        }

        
    }
}
