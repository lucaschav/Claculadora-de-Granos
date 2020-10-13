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
    public partial class silAir2Conos : Form
    {
        public silAir2Conos()
        {
            InitializeComponent();
        }

        private void silAir_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double r, h,h2;

            r = (double.Parse(txtrC.Text));
            h = (double.Parse(txthC2.Text));
            h2 = (double.Parse(txthC1.Text));

            lblSupBxAC1.Text = (3.14 * (r * r) * h).ToString();
            lblSupBaseC1.Text = (3.14 * (r * r)).ToString();
            lblVolConoC1.Text = ((3.14 * (r * r) * h) / 3).ToString();
            lblSupBaseC2.Text = lblSupBaseC1.Text;
            lblSupBXAC2.Text = (3.14 * (r * r) * h2).ToString();
            lblVolConoC2.Text = ((3.14 * (r * r) * h2) / 3).ToString();
            lblVolSiloC.Text = ((3.14 * (r * r)) + (((3.14 * (r * r) * h) / 3) + ((3.14 * (r * r) * h2) / 3))).ToString();
        }

        private void txthC1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPH_TextChanged(object sender, EventArgs e)
        {
            double ph, i;

            ph = (double.Parse(txtPH.Text));
            i = (double.Parse(lblVolSiloC.Text));

            lblCA.Text = ((ph * 10) * i).ToString();
        }
    }
}
