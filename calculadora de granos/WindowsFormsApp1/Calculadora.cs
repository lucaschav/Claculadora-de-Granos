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
    public partial class Calculadora : Form
    {
        double num1, num2, resultado;
        string operacion;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(pantalla.Text);
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = num1 - num2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = num1 * num2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = num1 + num2;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }
    }
}
