﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar la variables
            string num1, num2;

            // asignarle un valor
            num1 = textBoxNumero1.Text;
            num2 = textBoxNumero2.Text;

            // Validar que no esté vacio
            if (num1.Trim() == "")
            {
                MessageBox.Show("El numero 1 no puede estar vacio");
                return;
            }

            if (num2.Trim() == "")
            {
                MessageBox.Show("El numero 2 no puede estar vacio");
                return;
            }

            //Realizar calculo
            int resultado = int.Parse(num1) + int.Parse(num2);
            textBoxResultado.Text = resultado.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelNumero2_Click(object sender, EventArgs e)
        {

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            string num1, num2;

            num1 = textBoxNumero1.Text;
            num2 = textBoxNumero2.Text;

            int resultado = int.Parse(num1) - int.Parse(num2);
            textBoxResultado.Text = resultado.ToString();
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            string num1, num2;

            num1 = textBoxNumero1.Text;
            num2 = textBoxNumero2.Text;

            int resultado = int.Parse(num1) * int.Parse(num2);
            textBoxResultado.Text = resultado.ToString();
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            string num1, num2;

            num1 = textBoxNumero1.Text;
            num2 = textBoxNumero2.Text;

            int resultado = int.Parse(num1) / int.Parse(num2);
            textBoxResultado.Text = resultado.ToString(); 
        }
    }
}
