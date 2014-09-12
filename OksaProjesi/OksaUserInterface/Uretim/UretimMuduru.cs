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
    public partial class UretimMuduru : Form
    {
        public UretimMuduru()
        {
            InitializeComponent();
        }
        OksaDBDataContext oksa = new OksaDBDataContext();
        private void UretimMuduru_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            satinAl al = new satinAl();
            al.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
