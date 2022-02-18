using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonSuma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRestar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDivision_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = 0.0;
            double B = 0.0;
            double C = 0.0;



            string num1, num2;

            num1 = textBoxNumero1.Text;
            num2 = textBoxNumero2.Text;


            if (num1.Trim() == "")
            {
                labelText1.Visible = true;
                labelText1.Text = "no puede estar vacio";
            }

            if (num2.Trim() == "")
            {
                labelText2.Visible = true;
                labelText2.Text = "no puede estar vacio";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelText1_Click(object sender, EventArgs e)
        {
            labelText1.Visible = false;
        }

        private void labelText2_Click(object sender, EventArgs e)
        {
            labelText2.Visible = false;
        }

        private void labelNumero1_Click(object sender, EventArgs e)
        {

        }

        private void labelNumero2_Click(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
