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
    public partial class depoFirregu : Form
    {

        public depoFirregu()
        {
            InitializeComponent();
        }

        private void depoFirregu_Load(object sender, EventArgs e)
        {
            
        }

        private void txtHMN_TextChanged(object sender, EventArgs e)
        {
            double resultado, L, A, HM, Hm;

            L = (double.Parse(txtL.Text));
            A = (double.Parse(txtA.Text));
            HM = (double.Parse(txtHM.Text));
            Hm = (double.Parse(txtHMN.Text));

            resultado = L * A * ((HM + Hm) / 2);

            txtresul.Text = resultado.ToString();
        }
    }
}
