using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dia;

            dia = textBoxSemana.Text;

            if (dia == "1")
            {
                MessageBox.Show("lunes");
            }

            if (dia == "2")
            {
                MessageBox.Show("Martes");
            }

            if (dia == "3")
            {
                MessageBox.Show("Miercoles");
            }

            if (dia == "4")
            {
                MessageBox.Show("Jueves");
            }

            if (dia == "5")
            {
                MessageBox.Show("Viernes");
            }

            if (dia == "6")
            {
                MessageBox.Show("Sabado");
            }

            if (dia == "7")
            {
                MessageBox.Show("Domingo");
            }
           

            
        }

        private void textBoxnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelmensaje_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clik");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
           // MessageBox.Show("Mouse dentro");

            button2.BackColor = Color.Green;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }
    }
}
