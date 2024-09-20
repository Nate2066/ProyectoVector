using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVector
{
    public partial class FormPlanoCartesiano : Form
    {
        DibujarTriangulo triangulo;
        DireccionYSentido direccion;
        public FormPlanoCartesiano()
        {
            InitializeComponent();
            triangulo = new DibujarTriangulo(textBoxX1, textBoxX2, textBoxX3, textBoxY1, textBoxY2, textBoxY3, pictureBox1);
            direccion = new DireccionYSentido(textBoxDireccionX, textBoxDireccionY, pictureBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPlanoCartesiano_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int xCentro = pictureBox1.Width / 2;
            int yCentro = pictureBox1.Height / 2;

            e.Graphics.TranslateTransform(xCentro, yCentro);
            Pen lapiz = new Pen(Color.Black, 1);

            e.Graphics.DrawLine(lapiz, xCentro, 0, -xCentro, 0);
            e.Graphics.DrawLine(lapiz, 0, yCentro, 0, -yCentro);

            for(int i = -xCentro; i <= yCentro; i += 8)
            {
                e.Graphics.DrawLine(lapiz, i, 2, i, -2);
                e.Graphics.DrawLine(lapiz, 2, i, -2, i);
            }
        }

        private void buttonDibujar1_Click(object sender, EventArgs e)
        {
            triangulo._Graficar();
        }

        private void buttonBorrar1_Click(object sender, EventArgs e)
        {
            triangulo._LimpiarPlano();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            direccion._Graficar();
            direccion._CalcularDireccionYSentido(labelRespuestaFi, labelRespuestaSentido, labelRespuestaSentidoString);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            direccion._LimpiarPlano();
            direccion._LimpiarRespuestas(labelRespuestaFi, labelRespuestaSentido, labelRespuestaSentidoString);
        }
    }
}
