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
    public partial class uretimdekiler : Form
    {
        public uretimdekiler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uretimdekiler2 u = new uretimdekiler2();
            u.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uretimdekiler3 t = new uretimdekiler3();
            t.Show();
        }

      
       

      
    

    

      

       

       
    }
}
