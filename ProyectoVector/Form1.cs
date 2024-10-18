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
            triangulo = new DibujarTriangulo(pictureBox1);
            direccion = new DireccionYSentido(pictureBox1);
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
            direccion._LimpiarRespuestas(txtRespuestaFi, txtRespuestaSentido, txtRespuestaSentidoString);
            triangulo._ActualizarInterfaz(txtMostrarCantidadDeVectores);
        }

        private void buttonBorrar1_Click(object sender, EventArgs e)
        {
            direccion._LimpiarRespuestas(txtRespuestaFi, txtRespuestaSentido, txtRespuestaSentidoString);
            triangulo._LimpiarPlano();
            triangulo._ActualizarInterfaz(txtMostrarCantidadDeVectores);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            direccion._Graficar(textBoxDireccionX, textBoxDireccionY);
            direccion._CalcularDireccionYSentido(txtRespuestaFi, txtRespuestaSentido, txtRespuestaSentidoString);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            direccion._LimpiarPlano();
            direccion._LimpiarRespuestas(txtRespuestaFi, txtRespuestaSentido, txtRespuestaSentidoString);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDireccionX_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxDireccionY_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void btnAgregarVector_Click(object sender, EventArgs e)
        {
            direccion._LimpiarRespuestas(txtRespuestaFi, txtRespuestaSentido, txtRespuestaSentidoString);
            triangulo._AgregarVector(txtX1, txtY1);
            triangulo._ActualizarInterfaz(txtMostrarCantidadDeVectores);
        }

        private void textBoxY1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDireccionX_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void textBoxDireccionY_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxY1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if(!char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenos1vector_Click(object sender, EventArgs e)
        {
            triangulo._EliminarVector();
            triangulo._ActualizarInterfaz(txtMostrarCantidadDeVectores);
        }
    }
}
