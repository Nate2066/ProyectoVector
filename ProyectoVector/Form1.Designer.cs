namespace ProyectoVector
{
    partial class FormPlanoCartesiano
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDibujarFiguras = new System.Windows.Forms.GroupBox();
            this.labelVector1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.labelVector2 = new System.Windows.Forms.Label();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.labelVector3 = new System.Windows.Forms.Label();
            this.textBoxY11 = new System.Windows.Forms.TextBox();
            this.textBoxX11 = new System.Windows.Forms.TextBox();
            this.labelVector11 = new System.Windows.Forms.Label();
            this.groupBoxDibujarFiguras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDibujarFiguras
            // 
            this.groupBoxDibujarFiguras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDibujarFiguras.Controls.Add(this.textBoxY3);
            this.groupBoxDibujarFiguras.Controls.Add(this.textBoxX3);
            this.groupBoxDibujarFiguras.Controls.Add(this.labelVector3);
            this.groupBoxDibujarFiguras.Controls.Add(this.textBoxY2);
            this.groupBoxDibujarFiguras.Controls.Add(this.textBoxX2);
            this.groupBoxDibujarFiguras.Controls.Add(this.labelVector2);
            this.groupBoxDibujarFiguras.Controls.Add(this.textBoxY1);
            this.groupBoxDibujarFiguras.Controls.Add(this.textBoxX1);
            this.groupBoxDibujarFiguras.Controls.Add(this.labelVector1);
            this.groupBoxDibujarFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDibujarFiguras.Location = new System.Drawing.Point(12, 45);
            this.groupBoxDibujarFiguras.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDibujarFiguras.Name = "groupBoxDibujarFiguras";
            this.groupBoxDibujarFiguras.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDibujarFiguras.Size = new System.Drawing.Size(221, 368);
            this.groupBoxDibujarFiguras.TabIndex = 0;
            this.groupBoxDibujarFiguras.TabStop = false;
            this.groupBoxDibujarFiguras.Text = "Dibujar Triangulos";
            // 
            // labelVector1
            // 
            this.labelVector1.AutoSize = true;
            this.labelVector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVector1.Location = new System.Drawing.Point(8, 31);
            this.labelVector1.Name = "labelVector1";
            this.labelVector1.Size = new System.Drawing.Size(79, 13);
            this.labelVector1.TabIndex = 0;
            this.labelVector1.Text = "Vector Nro.1";
            this.labelVector1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(239, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 399);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.textBoxY11);
            this.groupBox2.Controls.Add(this.labelVector11);
            this.groupBox2.Controls.Add(this.textBoxX11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(644, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(221, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encontrar Direccion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(791, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 22);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(94, 28);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(41, 20);
            this.textBoxX1.TabIndex = 1;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(141, 28);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(41, 20);
            this.textBoxY1.TabIndex = 2;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(141, 54);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(41, 20);
            this.textBoxY2.TabIndex = 5;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(94, 54);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(41, 20);
            this.textBoxX2.TabIndex = 4;
            // 
            // labelVector2
            // 
            this.labelVector2.AutoSize = true;
            this.labelVector2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVector2.Location = new System.Drawing.Point(8, 57);
            this.labelVector2.Name = "labelVector2";
            this.labelVector2.Size = new System.Drawing.Size(79, 13);
            this.labelVector2.TabIndex = 3;
            this.labelVector2.Text = "Vector Nro.2";
            // 
            // textBoxY3
            // 
            this.textBoxY3.Location = new System.Drawing.Point(141, 80);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(41, 20);
            this.textBoxY3.TabIndex = 8;
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(94, 80);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(41, 20);
            this.textBoxX3.TabIndex = 7;
            // 
            // labelVector3
            // 
            this.labelVector3.AutoSize = true;
            this.labelVector3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVector3.Location = new System.Drawing.Point(8, 83);
            this.labelVector3.Name = "labelVector3";
            this.labelVector3.Size = new System.Drawing.Size(79, 13);
            this.labelVector3.TabIndex = 6;
            this.labelVector3.Text = "Vector Nro.3";
            // 
            // textBoxY11
            // 
            this.textBoxY11.Location = new System.Drawing.Point(140, 25);
            this.textBoxY11.Name = "textBoxY11";
            this.textBoxY11.Size = new System.Drawing.Size(41, 20);
            this.textBoxY11.TabIndex = 11;
            // 
            // textBoxX11
            // 
            this.textBoxX11.Location = new System.Drawing.Point(93, 25);
            this.textBoxX11.Name = "textBoxX11";
            this.textBoxX11.Size = new System.Drawing.Size(41, 20);
            this.textBoxX11.TabIndex = 10;
            // 
            // labelVector11
            // 
            this.labelVector11.AutoSize = true;
            this.labelVector11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVector11.Location = new System.Drawing.Point(7, 28);
            this.labelVector11.Name = "labelVector11";
            this.labelVector11.Size = new System.Drawing.Size(79, 13);
            this.labelVector11.TabIndex = 9;
            this.labelVector11.Text = "Vector Nro.1";
            // 
            // FormPlanoCartesiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(880, 422);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDibujarFiguras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPlanoCartesiano";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPlanoCartesiano_Paint);
            this.groupBoxDibujarFiguras.ResumeLayout(false);
            this.groupBoxDibujarFiguras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDibujarFiguras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelVector1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label labelVector2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.Label labelVector3;
        private System.Windows.Forms.TextBox textBoxY11;
        private System.Windows.Forms.Label labelVector11;
        private System.Windows.Forms.TextBox textBoxX11;
    }
}

