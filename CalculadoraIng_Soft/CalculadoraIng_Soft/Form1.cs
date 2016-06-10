using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIng_Soft
{
    
    public partial class Form1 : Form
    {
        //variables para las operaciones
        double PrimeraCant;
        double SegundaCant;
        double Resultado;
        string Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdisplayC.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operador = "+";
            PrimeraCant = double.Parse(txtdisplayC.Text);
            txtdisplayC.Clear();
        }

        private void txtdisplayC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            txtdisplayC.Text = txtdisplayC.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtdisplayC.Text = txtdisplayC.Text + ".";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Operador = "/";
            PrimeraCant = Double.Parse(txtdisplayC.Text);
            txtdisplayC.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            Operador = "*";
            PrimeraCant = Double.Parse(txtdisplayC.Text);
            txtdisplayC.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            PrimeraCant = Double.Parse(txtdisplayC.Text);
            txtdisplayC.Clear();
        } 

        private void btnigual_Click(object sender, EventArgs e)
        {
            SegundaCant = Double.Parse(txtdisplayC.Text);

            switch (Operador) {
                case "+":
                    Resultado = PrimeraCant + SegundaCant;
                    txtdisplayC.Text = Resultado.ToString();
                break;
                case "-":
                    Resultado = PrimeraCant - SegundaCant;
                    txtdisplayC.Text = Resultado.ToString();
                    break;
                case "*":
                    Resultado = PrimeraCant * SegundaCant;
                    txtdisplayC.Text = Resultado.ToString();
                    break;
                case "/":
                    Resultado = PrimeraCant / SegundaCant;
                    txtdisplayC.Text = Resultado.ToString();
                    break;

            }
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            Operador = "√";
            PrimeraCant = double.Parse(txtdisplayC.Text);
            Resultado = PrimeraCant;
            txtdisplayC.Text = Math.Sqrt(PrimeraCant).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
