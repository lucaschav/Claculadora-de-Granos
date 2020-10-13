using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaxim.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = false;
            btnmaxim.Visible = true;
        }

        private void btnminim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnDFR_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new depoFregu());
        }

        private void btnDFIRR_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new depoFirregu());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new silAir1Cono());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new entreSil());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Calculadora());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new silAir1Cono());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new silAir2Conos());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
