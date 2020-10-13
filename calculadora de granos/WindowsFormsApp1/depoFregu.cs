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
    public partial class depoFregu : Form
    {
        public depoFregu()
        {
            InitializeComponent();
        }

        private void txth_TextChanged(object sender, EventArgs e)
        {
            double resultado, L, A, h;

            L = (double.Parse(txtL.Text));
            A = (double.Parse(txtA.Text));
            h = (double.Parse(txth.Text));

            resultado = L * A;

            lblSUP.Text = resultado.ToString();
            lblVOL.Text = (resultado * h).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
