namespace WindowsFormsApplication9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelvalidarNombre = new System.Windows.Forms.Label();
            this.labelvalidarApellido = new System.Windows.Forms.Label();
            this.labelvalidarCorreo = new System.Windows.Forms.Label();
            this.labelvalidarContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label1.Location = new System.Drawing.Point(133, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label2.Location = new System.Drawing.Point(127, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label3.Location = new System.Drawing.Point(5, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tu dirección de correo electrónico :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label4.Location = new System.Drawing.Point(87, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "contrrseña nueva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label5.Location = new System.Drawing.Point(142, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label6.Location = new System.Drawing.Point(65, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.button1.Location = new System.Drawing.Point(190, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(190, 100);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(166, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(190, 130);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(166, 20);
            this.textBoxApellido.TabIndex = 8;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(190, 163);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(166, 20);
            this.textBoxCorreo.TabIndex = 9;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(190, 196);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(166, 20);
            this.textBoxContraseña.TabIndex = 11;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(190, 254);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(30, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(226, 254);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(73, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(305, 256);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(51, 21);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label7.Location = new System.Drawing.Point(187, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "¿Por que tengo que dar esta imformacion ?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada1;
            this.label8.Location = new System.Drawing.Point(185, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Registrate";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.label9.Location = new System.Drawing.Point(129, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Es gratis(y lo seguirá siendolo).";
            // 
            // labelvalidarNombre
            // 
            this.labelvalidarNombre.AutoSize = true;
            this.labelvalidarNombre.Location = new System.Drawing.Point(362, 107);
            this.labelvalidarNombre.Name = "labelvalidarNombre";
            this.labelvalidarNombre.Size = new System.Drawing.Size(0, 13);
            this.labelvalidarNombre.TabIndex = 19;
            this.labelvalidarNombre.Visible = false;
            // 
            // labelvalidarApellido
            // 
            this.labelvalidarApellido.AutoSize = true;
            this.labelvalidarApellido.Location = new System.Drawing.Point(362, 137);
            this.labelvalidarApellido.Name = "labelvalidarApellido";
            this.labelvalidarApellido.Size = new System.Drawing.Size(0, 13);
            this.labelvalidarApellido.TabIndex = 20;
            this.labelvalidarApellido.Visible = false;
            this.labelvalidarApellido.Click += new System.EventHandler(this.labelvalidarApellido_Click);
            // 
            // labelvalidarCorreo
            // 
            this.labelvalidarCorreo.AutoSize = true;
            this.labelvalidarCorreo.Location = new System.Drawing.Point(362, 170);
            this.labelvalidarCorreo.Name = "labelvalidarCorreo";
            this.labelvalidarCorreo.Size = new System.Drawing.Size(0, 13);
            this.labelvalidarCorreo.TabIndex = 21;
            this.labelvalidarCorreo.Visible = false;
            this.labelvalidarCorreo.Click += new System.EventHandler(this.labelvalidarCorreo_Click);
            // 
            // labelvalidarContraseña
            // 
            this.labelvalidarContraseña.AutoSize = true;
            this.labelvalidarContraseña.Location = new System.Drawing.Point(362, 203);
            this.labelvalidarContraseña.Name = "labelvalidarContraseña";
            this.labelvalidarContraseña.Size = new System.Drawing.Size(0, 13);
            this.labelvalidarContraseña.TabIndex = 22;
            this.labelvalidarContraseña.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::WindowsFormsApplication9.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.ClientSize = new System.Drawing.Size(739, 331);
            this.Controls.Add(this.labelvalidarContraseña);
            this.Controls.Add(this.labelvalidarCorreo);
            this.Controls.Add(this.labelvalidarApellido);
            this.Controls.Add(this.labelvalidarNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro de facebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelvalidarNombre;
        private System.Windows.Forms.Label labelvalidarApellido;
        private System.Windows.Forms.Label labelvalidarCorreo;
        private System.Windows.Forms.Label labelvalidarContraseña;
    }
}

