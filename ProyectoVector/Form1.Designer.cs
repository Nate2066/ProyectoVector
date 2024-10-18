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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBorrar1 = new System.Windows.Forms.Button();
            this.buttonDibujar1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxDireccionY = new System.Windows.Forms.TextBox();
            this.labelVector = new System.Windows.Forms.Label();
            this.textBoxDireccionX = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.labelFi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRespuestaFi = new System.Windows.Forms.TextBox();
            this.txtRespuestaSentido = new System.Windows.Forms.TextBox();
            this.txtRespuestaSentidoString = new System.Windows.Forms.TextBox();
            this.btnAgregarVector = new System.Windows.Forms.Button();
            this.txtMostrarCantidadDeVectores = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.btnMenos1vector = new System.Windows.Forms.Button();
            this.groupBoxDibujarFiguras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDibujarFiguras
            // 
            this.groupBoxDibujarFiguras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxDibujarFiguras.Controls.Add(this.btnMenos1vector);
            this.groupBoxDibujarFiguras.Controls.Add(this.txtY1);
            this.groupBoxDibujarFiguras.Controls.Add(this.txtX1);
            this.groupBoxDibujarFiguras.Controls.Add(this.txtMostrarCantidadDeVectores);
            this.groupBoxDibujarFiguras.Controls.Add(this.btnAgregarVector);
            this.groupBoxDibujarFiguras.Controls.Add(this.label2);
            this.groupBoxDibujarFiguras.Controls.Add(this.label1);
            this.groupBoxDibujarFiguras.Controls.Add(this.buttonBorrar1);
            this.groupBoxDibujarFiguras.Controls.Add(this.buttonDibujar1);
            this.groupBoxDibujarFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDibujarFiguras.Location = new System.Drawing.Point(11, 11);
            this.groupBoxDibujarFiguras.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDibujarFiguras.Name = "groupBoxDibujarFiguras";
            this.groupBoxDibujarFiguras.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDibujarFiguras.Size = new System.Drawing.Size(223, 131);
            this.groupBoxDibujarFiguras.TabIndex = 0;
            this.groupBoxDibujarFiguras.TabStop = false;
            this.groupBoxDibujarFiguras.Text = "Trazar lineas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonBorrar1
            // 
            this.buttonBorrar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBorrar1.Location = new System.Drawing.Point(81, 98);
            this.buttonBorrar1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrar1.Name = "buttonBorrar1";
            this.buttonBorrar1.Size = new System.Drawing.Size(62, 22);
            this.buttonBorrar1.TabIndex = 17;
            this.buttonBorrar1.Text = "Borrar";
            this.buttonBorrar1.UseVisualStyleBackColor = false;
            this.buttonBorrar1.Click += new System.EventHandler(this.buttonBorrar1_Click);
            // 
            // buttonDibujar1
            // 
            this.buttonDibujar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDibujar1.Location = new System.Drawing.Point(11, 98);
            this.buttonDibujar1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDibujar1.Name = "buttonDibujar1";
            this.buttonDibujar1.Size = new System.Drawing.Size(62, 22);
            this.buttonDibujar1.TabIndex = 16;
            this.buttonDibujar1.Text = "Dibujar";
            this.buttonDibujar1.UseVisualStyleBackColor = false;
            this.buttonDibujar1.Click += new System.EventHandler(this.buttonDibujar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(242, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRespuestaSentidoString);
            this.groupBox2.Controls.Add(this.labelFi);
            this.groupBox2.Controls.Add(this.txtRespuestaSentido);
            this.groupBox2.Controls.Add(this.Direccion);
            this.groupBox2.Controls.Add(this.txtRespuestaFi);
            this.groupBox2.Controls.Add(this.labelY);
            this.groupBox2.Controls.Add(this.labelX);
            this.groupBox2.Controls.Add(this.buttonBorrar);
            this.groupBox2.Controls.Add(this.buttonCalcular);
            this.groupBox2.Controls.Add(this.textBoxDireccionY);
            this.groupBox2.Controls.Add(this.labelVector);
            this.groupBox2.Controls.Add(this.textBoxDireccionX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(223, 259);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encontrar Direccion y sentido";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(78, 53);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(23, 13);
            this.labelY.TabIndex = 15;
            this.labelY.Text = "Y :";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(7, 53);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 13);
            this.labelX.TabIndex = 14;
            this.labelX.Text = "X :";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBorrar.Location = new System.Drawing.Point(80, 99);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(62, 22);
            this.buttonBorrar.TabIndex = 12;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCalcular.Location = new System.Drawing.Point(10, 99);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(62, 22);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxDireccionY
            // 
            this.textBoxDireccionY.Location = new System.Drawing.Point(101, 50);
            this.textBoxDireccionY.Name = "textBoxDireccionY";
            this.textBoxDireccionY.Size = new System.Drawing.Size(41, 20);
            this.textBoxDireccionY.TabIndex = 11;
            this.textBoxDireccionY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDireccionY_KeyPress_1);
            // 
            // labelVector
            // 
            this.labelVector.AutoSize = true;
            this.labelVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVector.Location = new System.Drawing.Point(7, 28);
            this.labelVector.Name = "labelVector";
            this.labelVector.Size = new System.Drawing.Size(44, 13);
            this.labelVector.TabIndex = 9;
            this.labelVector.Text = "Vector";
            // 
            // textBoxDireccionX
            // 
            this.textBoxDireccionX.Location = new System.Drawing.Point(31, 50);
            this.textBoxDireccionX.Name = "textBoxDireccionX";
            this.textBoxDireccionX.Size = new System.Drawing.Size(41, 20);
            this.textBoxDireccionX.TabIndex = 10;
            this.textBoxDireccionX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDireccionX_KeyPress_1);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(8, 143);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(65, 13);
            this.Direccion.TabIndex = 19;
            this.Direccion.Text = "Direccion ";
            // 
            // labelFi
            // 
            this.labelFi.AutoSize = true;
            this.labelFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFi.Location = new System.Drawing.Point(8, 166);
            this.labelFi.Name = "labelFi";
            this.labelFi.Size = new System.Drawing.Size(54, 13);
            this.labelFi.TabIndex = 20;
            this.labelFi.Text = "Sentido ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sentido ";
            // 
            // txtRespuestaFi
            // 
            this.txtRespuestaFi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRespuestaFi.Location = new System.Drawing.Point(73, 140);
            this.txtRespuestaFi.Name = "txtRespuestaFi";
            this.txtRespuestaFi.ReadOnly = true;
            this.txtRespuestaFi.Size = new System.Drawing.Size(143, 20);
            this.txtRespuestaFi.TabIndex = 16;
            // 
            // txtRespuestaSentido
            // 
            this.txtRespuestaSentido.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRespuestaSentido.Location = new System.Drawing.Point(73, 163);
            this.txtRespuestaSentido.Name = "txtRespuestaSentido";
            this.txtRespuestaSentido.ReadOnly = true;
            this.txtRespuestaSentido.Size = new System.Drawing.Size(143, 20);
            this.txtRespuestaSentido.TabIndex = 25;
            this.txtRespuestaSentido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRespuestaSentidoString
            // 
            this.txtRespuestaSentidoString.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRespuestaSentidoString.Location = new System.Drawing.Point(73, 185);
            this.txtRespuestaSentidoString.Name = "txtRespuestaSentidoString";
            this.txtRespuestaSentidoString.ReadOnly = true;
            this.txtRespuestaSentidoString.Size = new System.Drawing.Size(143, 20);
            this.txtRespuestaSentidoString.TabIndex = 26;
            // 
            // btnAgregarVector
            // 
            this.btnAgregarVector.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarVector.Location = new System.Drawing.Point(10, 68);
            this.btnAgregarVector.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarVector.Name = "btnAgregarVector";
            this.btnAgregarVector.Size = new System.Drawing.Size(132, 22);
            this.btnAgregarVector.TabIndex = 21;
            this.btnAgregarVector.Text = "Vector +";
            this.btnAgregarVector.UseVisualStyleBackColor = false;
            this.btnAgregarVector.Click += new System.EventHandler(this.btnAgregarVector_Click);
            // 
            // txtMostrarCantidadDeVectores
            // 
            this.txtMostrarCantidadDeVectores.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtMostrarCantidadDeVectores.Location = new System.Drawing.Point(108, 41);
            this.txtMostrarCantidadDeVectores.Name = "txtMostrarCantidadDeVectores";
            this.txtMostrarCantidadDeVectores.ReadOnly = true;
            this.txtMostrarCantidadDeVectores.Size = new System.Drawing.Size(34, 20);
            this.txtMostrarCantidadDeVectores.TabIndex = 22;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(10, 41);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(41, 20);
            this.txtX1.TabIndex = 29;
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            this.txtX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX1_KeyPress);
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(57, 41);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(41, 20);
            this.txtY1.TabIndex = 30;
            this.txtY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY1_KeyPress);
            // 
            // btnMenos1vector
            // 
            this.btnMenos1vector.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenos1vector.Location = new System.Drawing.Point(151, 98);
            this.btnMenos1vector.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenos1vector.Name = "btnMenos1vector";
            this.btnMenos1vector.Size = new System.Drawing.Size(64, 22);
            this.btnMenos1vector.TabIndex = 31;
            this.btnMenos1vector.Text = "-1.V";
            this.btnMenos1vector.UseVisualStyleBackColor = false;
            this.btnMenos1vector.Click += new System.EventHandler(this.btnMenos1vector_Click);
            // 
            // FormPlanoCartesiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(652, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDibujarFiguras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPlanoCartesiano";
            this.Text = "Vectores y plano";
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
        private System.Windows.Forms.TextBox textBoxDireccionY;
        private System.Windows.Forms.Label labelVector;
        private System.Windows.Forms.TextBox textBoxDireccionX;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonBorrar1;
        private System.Windows.Forms.Button buttonDibujar1;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRespuestaFi;
        private System.Windows.Forms.TextBox txtRespuestaSentido;
        private System.Windows.Forms.TextBox txtRespuestaSentidoString;
        private System.Windows.Forms.Button btnAgregarVector;
        private System.Windows.Forms.TextBox txtMostrarCantidadDeVectores;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Button btnMenos1vector;
    }
}

