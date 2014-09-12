using OksaUserInterface.MakineKontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OksaUserInterface.Punch
{
    public partial class PunchIsTakip : Form
    {
        public PunchIsTakip()
        {
            InitializeComponent();
        }

        private void btnPunchEksik_Click(object sender, EventArgs e)
        {
            EksikIslem ei = new EksikIslem();
            ei.Show();
        }








    }
}
