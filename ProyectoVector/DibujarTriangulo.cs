using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVector
{
    public class DibujarTriangulo
    {
        private PictureBox pictureBox1;
        private int xCentro;
        private int yCentro;
        private Graphics vector;
        private Pen lapiz;

        private List<Point> vectores = new List<Point>();
        private int contador = 0;
        public DibujarTriangulo(PictureBox pictureBox1)
        {
            this.pictureBox1 = pictureBox1;
        }
        public void _AgregarVector(TextBox X, TextBox Y)
        {
            if (int.TryParse(X.Text, out int XS))
            {
                if ( XS > 27)
                {
                    X.Focus();
                }
                else
                {
                    if (int.TryParse(Y.Text, out int YS))
                    {
                        if (YS > 27)
                        {
                            Y.Focus();
                        }
                        else
                        {
                            if (contador < 10)
                            {
                                xCentro = pictureBox1.Width / 2;
                                yCentro = pictureBox1.Height / 2;
                                vectores.Add(new Point(xCentro + (XS * 8), yCentro - (YS * 8)));
                                contador += 1;
                                X.Text = "";
                                Y.Text = "";
                            }
                        }
                    }
                    else
                    {
                        Y.Focus();
                    }
                }
            }
            else
            {
                X.Focus();
            }
            
        }
        public void _Reset()
        {
            contador = 0;
            vectores.Clear();
        }
        public void _ActualizarInterfaz(TextBox pResumen)
        {
            pResumen.Text = Convert.ToString(contador);
            _Graficar();
        }
        public void _EliminarVector()
        {
            if(contador > 0)
            {
                _LimpiarPlano();
                contador -= 1;
                vectores.RemoveAt(contador);
                _Graficar();
            }
        }
        public void _Graficar()
        {
            if(vectores.Count > 1)
            {
                vector = pictureBox1.CreateGraphics();
                lapiz = new Pen(Color.Blue, 1);
                for (int i = 0; i < vectores.Count; i++)
                {
                    if (i == (vectores.Count - 1))
                    {
                        vector.DrawLine(lapiz, vectores[i], vectores[i - 1]);
                    }
                    else
                    {
                        vector.DrawLine(lapiz, vectores[i], vectores[i + 1]);
                    }
                }
            }
        }
        public void _LimpiarPlano()
        {
            pictureBox1.Image = null;
        }
    }
}
