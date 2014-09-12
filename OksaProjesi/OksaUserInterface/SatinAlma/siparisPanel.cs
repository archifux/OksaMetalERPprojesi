using OksaUserInterface.SatinAlma;
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
    public partial class siparisPanel : Form
    {
        public siparisPanel()
        {
            InitializeComponent();
        }

        private void siparişGrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisGir sp = new SiparisGir();
            sp.Show();
        }

        private void stokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokGir sp = new stokGir();
            sp.Show();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raporlar r = new raporlar();
            r.Show();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullaniciİslem k = new Kullaniciİslem();
            k.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticket t = new ticket();
            t.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
