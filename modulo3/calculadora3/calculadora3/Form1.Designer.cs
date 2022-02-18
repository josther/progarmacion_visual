namespace calculadora3
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelText1 = new System.Windows.Forms.Label();
            this.labelText2 = new System.Windows.Forms.Label();
            this.radioButtonSuma = new System.Windows.Forms.RadioButton();
            this.radioButtonRestar = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplicacion = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(359, 151);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(359, 193);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Location = new System.Drawing.Point(147, 65);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(50, 13);
            this.labelNumero1.TabIndex = 2;
            this.labelNumero1.Text = "Numero1";
            this.labelNumero1.Click += new System.EventHandler(this.labelNumero1_Click);
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Location = new System.Drawing.Point(147, 109);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(53, 13);
            this.labelNumero2.TabIndex = 3;
            this.labelNumero2.Text = "Numero 2";
            this.labelNumero2.Click += new System.EventHandler(this.labelNumero2_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(142, 244);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Location = new System.Drawing.Point(309, 65);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(35, 13);
            this.labelText1.TabIndex = 5;
            this.labelText1.Text = "label4";
            this.labelText1.Visible = false;
            this.labelText1.Click += new System.EventHandler(this.labelText1_Click);
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Location = new System.Drawing.Point(309, 109);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(35, 13);
            this.labelText2.TabIndex = 6;
            this.labelText2.Text = "label5";
            this.labelText2.Visible = false;
            this.labelText2.Click += new System.EventHandler(this.labelText2_Click);
            // 
            // radioButtonSuma
            // 
            this.radioButtonSuma.AutoSize = true;
            this.radioButtonSuma.Checked = true;
            this.radioButtonSuma.Location = new System.Drawing.Point(150, 157);
            this.radioButtonSuma.Name = "radioButtonSuma";
            this.radioButtonSuma.Size = new System.Drawing.Size(61, 17);
            this.radioButtonSuma.TabIndex = 7;
            this.radioButtonSuma.TabStop = true;
            this.radioButtonSuma.Text = "+ Suma";
            this.radioButtonSuma.UseVisualStyleBackColor = true;
            this.radioButtonSuma.CheckedChanged += new System.EventHandler(this.radioButtonSuma_CheckedChanged);
            // 
            // radioButtonRestar
            // 
            this.radioButtonRestar.AutoSize = true;
            this.radioButtonRestar.Location = new System.Drawing.Point(282, 157);
            this.radioButtonRestar.Name = "radioButtonRestar";
            this.radioButtonRestar.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRestar.TabIndex = 8;
            this.radioButtonRestar.Text = "- Restar";
            this.radioButtonRestar.UseVisualStyleBackColor = true;
            this.radioButtonRestar.CheckedChanged += new System.EventHandler(this.radioButtonRestar_CheckedChanged);
            // 
            // radioButtonMultiplicacion
            // 
            this.radioButtonMultiplicacion.AutoSize = true;
            this.radioButtonMultiplicacion.Location = new System.Drawing.Point(150, 199);
            this.radioButtonMultiplicacion.Name = "radioButtonMultiplicacion";
            this.radioButtonMultiplicacion.Size = new System.Drawing.Size(96, 17);
            this.radioButtonMultiplicacion.TabIndex = 9;
            this.radioButtonMultiplicacion.Text = "* Multiplicacion";
            this.radioButtonMultiplicacion.UseVisualStyleBackColor = true;
            this.radioButtonMultiplicacion.CheckedChanged += new System.EventHandler(this.radioButtonMultiplicacion_CheckedChanged);
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(274, 199);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDivision.TabIndex = 10;
            this.radioButtonDivision.Text = "/ Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            this.radioButtonDivision.CheckedChanged += new System.EventHandler(this.radioButtonDivision_CheckedChanged);
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(203, 58);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero1.TabIndex = 11;
            this.textBoxNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(203, 102);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero2.TabIndex = 12;
            this.textBoxNumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Enabled = false;
            this.textBoxResultado.Location = new System.Drawing.Point(203, 237);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultado.TabIndex = 13;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::calculadora3.Properties.Resources.diseno_en_la_naturaleza_entrada;
            this.ClientSize = new System.Drawing.Size(720, 322);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.radioButtonDivision);
            this.Controls.Add(this.radioButtonMultiplicacion);
            this.Controls.Add(this.radioButtonRestar);
            this.Controls.Add(this.radioButtonSuma);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalcular);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelNumero2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.RadioButton radioButtonSuma;
        private System.Windows.Forms.RadioButton radioButtonRestar;
        private System.Windows.Forms.RadioButton radioButtonMultiplicacion;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}

