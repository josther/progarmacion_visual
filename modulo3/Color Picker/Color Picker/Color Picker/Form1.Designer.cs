namespace Color_Picker
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
            this.buttonAplicar1 = new System.Windows.Forms.Button();
            this.labelRED1 = new System.Windows.Forms.Label();
            this.labelGREEN1 = new System.Windows.Forms.Label();
            this.labelBLUE1 = new System.Windows.Forms.Label();
            this.labelRED2 = new System.Windows.Forms.Label();
            this.labelGREEN2 = new System.Windows.Forms.Label();
            this.labelBLUE2 = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.buttonAplicar2 = new System.Windows.Forms.Button();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAplicar1
            // 
            this.buttonAplicar1.Location = new System.Drawing.Point(186, 95);
            this.buttonAplicar1.Name = "buttonAplicar1";
            this.buttonAplicar1.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar1.TabIndex = 0;
            this.buttonAplicar1.Text = "Aplicar";
            this.buttonAplicar1.UseVisualStyleBackColor = true;
            this.buttonAplicar1.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // labelRED1
            // 
            this.labelRED1.AutoSize = true;
            this.labelRED1.Location = new System.Drawing.Point(232, 20);
            this.labelRED1.Name = "labelRED1";
            this.labelRED1.Size = new System.Drawing.Size(27, 13);
            this.labelRED1.TabIndex = 4;
            this.labelRED1.Text = "Red";
            // 
            // labelGREEN1
            // 
            this.labelGREEN1.AutoSize = true;
            this.labelGREEN1.Location = new System.Drawing.Point(350, 20);
            this.labelGREEN1.Name = "labelGREEN1";
            this.labelGREEN1.Size = new System.Drawing.Size(36, 13);
            this.labelGREEN1.TabIndex = 5;
            this.labelGREEN1.Text = "Green";
            // 
            // labelBLUE1
            // 
            this.labelBLUE1.AutoSize = true;
            this.labelBLUE1.Location = new System.Drawing.Point(476, 20);
            this.labelBLUE1.Name = "labelBLUE1";
            this.labelBLUE1.Size = new System.Drawing.Size(28, 13);
            this.labelBLUE1.TabIndex = 6;
            this.labelBLUE1.Text = "Blue";
            // 
            // labelRED2
            // 
            this.labelRED2.AutoSize = true;
            this.labelRED2.Location = new System.Drawing.Point(254, 169);
            this.labelRED2.Name = "labelRED2";
            this.labelRED2.Size = new System.Drawing.Size(27, 13);
            this.labelRED2.TabIndex = 7;
            this.labelRED2.Text = "Red";
            // 
            // labelGREEN2
            // 
            this.labelGREEN2.AutoSize = true;
            this.labelGREEN2.Location = new System.Drawing.Point(244, 213);
            this.labelGREEN2.Name = "labelGREEN2";
            this.labelGREEN2.Size = new System.Drawing.Size(36, 13);
            this.labelGREEN2.TabIndex = 8;
            this.labelGREEN2.Text = "Green";
            // 
            // labelBLUE2
            // 
            this.labelBLUE2.AutoSize = true;
            this.labelBLUE2.Location = new System.Drawing.Point(254, 259);
            this.labelBLUE2.Name = "labelBLUE2";
            this.labelBLUE2.Size = new System.Drawing.Size(28, 13);
            this.labelBLUE2.TabIndex = 9;
            this.labelBLUE2.Text = "Blue";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(336, 256);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(222, 45);
            this.trackBarBlue.TabIndex = 10;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(336, 205);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(222, 45);
            this.trackBarGreen.TabIndex = 11;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(339, 154);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(219, 45);
            this.trackBarRed.TabIndex = 12;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // buttonAplicar2
            // 
            this.buttonAplicar2.Location = new System.Drawing.Point(591, 205);
            this.buttonAplicar2.Name = "buttonAplicar2";
            this.buttonAplicar2.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar2.TabIndex = 13;
            this.buttonAplicar2.Text = "Aplicar";
            this.buttonAplicar2.UseVisualStyleBackColor = true;
            this.buttonAplicar2.Click += new System.EventHandler(this.buttonAplicar2_Click);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Enabled = false;
            this.textBoxBlue.Location = new System.Drawing.Point(295, 256);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(37, 20);
            this.textBoxBlue.TabIndex = 14;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Enabled = false;
            this.textBoxGreen.Location = new System.Drawing.Point(295, 210);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(35, 20);
            this.textBoxGreen.TabIndex = 15;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Enabled = false;
            this.textBoxRed.Location = new System.Drawing.Point(295, 162);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(35, 20);
            this.textBoxRed.TabIndex = 16;
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(186, 53);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRed.TabIndex = 20;
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(312, 53);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGreen.TabIndex = 21;
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(438, 53);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBlue.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 318);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.buttonAplicar2);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.labelBLUE2);
            this.Controls.Add(this.labelGREEN2);
            this.Controls.Add(this.labelRED2);
            this.Controls.Add(this.labelBLUE1);
            this.Controls.Add(this.labelGREEN1);
            this.Controls.Add(this.labelRED1);
            this.Controls.Add(this.buttonAplicar1);
            this.Name = "Form1";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAplicar1;
        private System.Windows.Forms.Label labelRED1;
        private System.Windows.Forms.Label labelGREEN1;
        private System.Windows.Forms.Label labelBLUE1;
        private System.Windows.Forms.Label labelRED2;
        private System.Windows.Forms.Label labelGREEN2;
        private System.Windows.Forms.Label labelBLUE2;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Button buttonAplicar2;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
    }
}

