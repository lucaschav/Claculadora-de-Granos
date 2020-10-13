using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class silAir1Cono : Form
    {
        public silAir1Cono()
        {
            InitializeComponent();
        }

        private void txthC2_TextChanged(object sender, EventArgs e)
        {
            double h, r;

            r = (double.Parse(txtrC2.Text));
            h = (double.Parse(txthC2.Text));

            lblSupBXAC2.Text = (3.14 * (r * r) * h).ToString();
            lblCA.Text = (3.14 * (r * r)).ToString();
            lblVolConoC2.Text = ((3.14 * (r * r) * h) / 3).ToString();
            lblVolSiloC.Text = ((3.14 * (r * r) * h) + (((3.14 * (r * r) * h) / 3))).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPH_TextChanged(object sender, EventArgs e)
        {
            double ph,i;

            ph = (double.Parse(txtPH.Text));
            i = (double.Parse(lblVolSiloC.Text));

            lblCA.Text = ((ph * 10) * i).ToString();
        }
    }
}
