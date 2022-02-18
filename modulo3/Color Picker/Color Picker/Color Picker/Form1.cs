using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            // Cambiar el color de fondo del from
            // BackColor = Color.FromArgb(25, 170, 0);

            // OBTENER LOS VALORES
            int red, green, blue;

            red = (int)numericUpDownRed.Value;
            green = (int)numericUpDownGreen.Value;
            blue = (int)numericUpDownBlue.Value;

            BackColor = Color.FromArgb(red, green, blue); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAplicar2_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 0, 0);

            int red, green, blue;

            red = trackBarRed.Value;
            green = trackBarGreen.Value;
            blue = trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = trackBarRed.Value.ToString();

            BackColor = Color.FromArgb(0, 0, 0);

            int red, green, blue;

            red = trackBarRed.Value;
            green = trackBarGreen.Value;
            blue = trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = trackBarGreen.Value.ToString();

            BackColor = Color.FromArgb(0, 0, 0);

            int red, green, blue;

            red = trackBarRed.Value;
            green = trackBarGreen.Value;
            blue = trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = trackBarBlue.Value.ToString();

            BackColor = Color.FromArgb(0, 0, 0);

            int red, green, blue;

            red = trackBarRed.Value;
            green = trackBarGreen.Value;
            blue = trackBarBlue.Value;

            BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
