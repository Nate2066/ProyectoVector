using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVector
{
    public class DireccionYSentido
    {
        private TextBox direccionX;
        private TextBox direccionY;
        private int X, Y, X1, Y1, X2, Y2;
        private PictureBox pictureBox1;
        private int xCentro, yCentro;
        private Graphics vector;
        private Pen lapiz;
        public DireccionYSentido(TextBox direccionX, TextBox direccionY, PictureBox pictureBox1)
        {
            this.direccionX = direccionX;
            this.direccionY = direccionY;
            this.pictureBox1 = pictureBox1;
        }
        public void _Graficar()
        {
            if(direccionX.Text == "")
            {
                direccionX.Focus();
            }
            else
            {
                if (direccionY.Text == "")
                {
                    direccionY.Focus();
                }
                else
                {
                    _GraficarDireccionYSentido();
                }
            }
        }
        private void _GraficarDireccionYSentido()
        {
            lapiz = new Pen(Color.Red, 1);
            xCentro = pictureBox1.Width  / 2;
            yCentro = pictureBox1.Height / 2;
            X = Convert.ToInt32(direccionX.Text) * 8;
            Y = Convert.ToInt32(direccionY.Text) * 8;
            X1 = X;
            Y2 = 0;
            X2 = 0;
            Y2 = 0;

            vector = pictureBox1.CreateGraphics();
            vector.TranslateTransform(xCentro, yCentro);

            Point vector1 = new Point(X, -Y);
            Point vector2 = new Point(X1, -Y1);
            Point vector3 = new Point(X2, -Y2);

            vector.DrawLine(lapiz, vector1, vector2);
            vector.DrawLine(lapiz, vector2, vector3);
            vector.DrawLine(lapiz, vector3, vector1);
        }
        public void _CalcularDireccionYSentido(Label respuestaDireccion, Label respuestaSentido, Label respuestaSentido2)
        {

            double X = Convert.ToDouble(direccionX.Text);
            double Y = Convert.ToDouble(direccionY.Text);
            if(X > 0 && Y >= 0)
            {
                //primer cuadrante
                double fi = Math.Atan((Y/X)) * (180/ Math.PI);

                double grados = Math.Floor(fi);
                double minutosDecimales = (fi - grados) * 60;
                double minutos = Math.Floor(minutosDecimales);
                double segundos = (minutosDecimales - minutos) * 60;

                respuestaDireccion.Text = Convert.ToString($"{fi:N3}");
                respuestaSentido.Text = Convert.ToString($"{grados}° {minutos}' {segundos:N3}\"");
                respuestaSentido2.Text = "Positivo";
            }
            else if(X <= 0 && Y > 0)
            {
                //segundo cuadrante
                double fi = Math.Atan((Y / X)) * (180 / Math.PI);

                double grados = Math.Floor(fi);
                double minutosDecimales = (fi - grados) * 60;
                double minutos = Math.Floor(minutosDecimales);
                double segundos = (minutosDecimales - minutos) * 60;

                double gradosDecimales = grados + (minutos / 60.0) + (segundos / 3600.0);

                double resultadoDecimales = gradosDecimales + 180.00;

                grados = Math.Floor(resultadoDecimales);
                double resultadoMinutosDecimales = (resultadoDecimales - grados) * 60;
                minutos = Math.Floor(resultadoMinutosDecimales);
                segundos = (resultadoMinutosDecimales - minutos) * 60;

                respuestaDireccion.Text = Convert.ToString($"{fi:N3}");
                respuestaSentido.Text = Convert.ToString($"{grados}° {minutos}' {segundos:N3}\"");
                respuestaSentido2.Text = "Positivo";
            }
            else if (X < 0 && Y <= 0)
            {
                //tercer cuadrante
                double fi = Math.Atan((Y / X)) * (180 / Math.PI);

                double grados = Math.Floor(fi);
                double minutosDecimales = (fi - grados) * 60;
                double minutos = Math.Floor(minutosDecimales);
                double segundos = (minutosDecimales - minutos) * 60;

                double gradosDecimales = grados + (minutos / 60.0) + (segundos / 3600.0);

                double resultadoDecimales = gradosDecimales + 180;

                grados = Math.Floor(resultadoDecimales);
                double resultadoMinutosDecimales = (resultadoDecimales - grados) * 60;
                minutos = Math.Floor(resultadoMinutosDecimales);
                segundos = (resultadoMinutosDecimales - minutos) * 60;

                respuestaDireccion.Text = Convert.ToString($"{fi:N3}");
                respuestaSentido.Text = Convert.ToString($"{grados}° {minutos}' {segundos:N3}\"");
                respuestaSentido2.Text = "Negativo";
            }
            else
            {
                //cuarto cuadrante
                double fi = Math.Atan((Y / X)) * (180 / Math.PI);

                double grados = Math.Floor(fi);
                double minutosDecimales = (fi - grados) * 60;
                double minutos = Math.Floor(minutosDecimales);
                double segundos = (minutosDecimales - minutos) * 60;

                double gradosDecimales = grados + (minutos / 60.0) + (segundos / 3600.0);

                double resultadoDecimales = gradosDecimales + 360;

                grados = Math.Floor(resultadoDecimales);
                double resultadoMinutosDecimales = (resultadoDecimales - grados) * 60;
                minutos = Math.Floor(resultadoMinutosDecimales);
                segundos = (resultadoMinutosDecimales - minutos) * 60;

                respuestaDireccion.Text = Convert.ToString($"{fi:N3}");
                respuestaSentido.Text = Convert.ToString($"{grados}° {minutos}' {segundos:N3}\"");
                respuestaSentido2.Text = "Negativo";
            }
        }
        public void _LimpiarRespuestas(Label respuestaDireccion, Label respuestaSentido, Label respuestaSentidoString)
        {
            respuestaDireccion.Text = "0";
            respuestaSentido.Text = "0";
            respuestaSentidoString.Text = "-";
        }

        public void _LimpiarPlano()
        {
            pictureBox1.Image = null;
        }
    }
}
