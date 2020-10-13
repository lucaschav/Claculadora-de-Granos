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
    public partial class entreSil : Form
    {
        public entreSil()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double L, D, h, r;

            L = (double.Parse(txtL.Text));
            D = (double.Parse(txtD.Text));
            r = (double.Parse(txtr.Text));
            h = (double.Parse(txth.Text));

            lblSupCua.Text = (L * L).ToString();
            lblVolCua.Text = ((L * L) * h).ToString();
            lblVol1Sil.Text = (3.14 * (r * r) * h).ToString();
            lblVolEntreSil.Text = (((L * L) * h) - (3.14 * (r * r) * h)).ToString();
        }
    }
}
