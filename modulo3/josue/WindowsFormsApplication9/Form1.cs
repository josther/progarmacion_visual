using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");

            //declarar la variable
            string nombre, apellido, correo, contraseña;

            // Asignarle un valor
            nombre = textBoxNombre.Text;
            apellido = textBoxApellido.Text;
            correo = textBoxCorreo.Text;
            contraseña = textBoxContraseña.Text;

            //validar las variables
            if (nombre.Trim() == "")
            
                //MessageBox.Show("El nombre no puede estar vacio.");
                //textBoxNombre.Focus();
                //return;

                labelvalidarNombre.Visible = true;
                labelvalidarNombre.Text = "El nombre no puede estar vacio";
                labelvalidarNombre.ForeColor = Color.Red;

            if (apellido.Trim() == "")

                 //MessageBox.Show("el apellido no puede estar vacio.");
                 //textBoxApellido.Focus();
                 //return;

               labelvalidarApellido.Visible = true;
               labelvalidarApellido.Text = "El apellido no puede estar vacio";
               labelvalidarApellido.ForeColor = Color.Red;

            if (correo.Trim() == "")
            
                /*MessageBox.Show("el correo no puede estar vacio.");
                textBoxCorreo.Focus();
                return;*/

                labelvalidarCorreo.Visible = true;
                labelvalidarCorreo.Text = "El correo no puede estar vacio";
                labelvalidarCorreo.ForeColor = Color.Red;


            if (contraseña.Trim() == "")
            
                /*MessageBox.Show("la contraseña no puede estar vacio.");
                textBoxContraseña.Focus();
                return;*/

                labelvalidarContraseña.Visible = true;
                labelvalidarContraseña.Text = "La contraseña no puede estar vacio";
                labelvalidarContraseña.ForeColor = Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            labelvalidarApellido.Visible = false;
        }

        private void labelvalidarApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelvalidarCorreo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            labelvalidarNombre.Visible = false;
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            labelvalidarCorreo.Visible = false;
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            labelvalidarContraseña.Visible = false;
        }
    }
}
