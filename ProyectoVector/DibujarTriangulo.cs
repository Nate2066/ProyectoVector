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
        private TextBox X1, X2, X3, Y1, Y2, Y3;
        private int TX1, TX2, TX3, TY1, TY2, TY3;
        private PictureBox pictureBox1;
        private int xCentro;
        private int yCentro;
        private Graphics vector;
        private Pen lapiz;
        public DibujarTriangulo(TextBox pX1, TextBox pX2, TextBox pX3, TextBox pY1, TextBox pY2, TextBox pY3, PictureBox pictureBox1)
        {
            X1 = pX1;
            X2 = pX2;
            X3 = pX3;
            Y1 = pY1;
            Y2 = pY2;
            Y3 = pY3;
            this.pictureBox1 = pictureBox1;
        }
        public void _Graficar()
        {
            if (X1.Text == "")
            {
                X1.Focus();
            }
            else
            {
                if (X2.Text == "")
                {
                    X2.Focus();
                }
                else
                {
                    if (X3.Text == "")
                    {
                        X3.Focus();
                    }
                    else
                    {
                        if (Y1.Text == "")
                        {
                            Y1.Focus();
                        }
                        else
                        {
                            if (Y2.Text == "")
                            {
                                Y2.Focus();
                            }
                            else
                            {
                                if (Y3.Text == "")
                                {
                                    Y3.Focus();
                                }
                                else
                                {
                                    _DibujarTriangulo();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void _DibujarTriangulo()
        {
            xCentro = pictureBox1.Width / 2;
            yCentro = pictureBox1.Height / 2;

            vector = pictureBox1.CreateGraphics();
            TX1 = xCentro + (Convert.ToInt32(X1.Text) * 8);
            TY1 = xCentro - (Convert.ToInt32(Y1.Text) * 8);
            TX2 = xCentro + (Convert.ToInt32(X2.Text) * 8);
            TY2 = xCentro - (Convert.ToInt32(Y2.Text) * 8);
            TX3 = xCentro + (Convert.ToInt32(X3.Text) * 8);
            TY3 = xCentro - (Convert.ToInt32(Y3.Text) * 8);

            Point Vector1 = new Point(TX1, TY1);
            Point Vector2 = new Point(TX2, TY2);
            Point Vector3 = new Point(TX3, TY3);

            lapiz = new Pen(Color.Blue, 1);
            vector.DrawLine(lapiz, Vector1, Vector2);
            vector.DrawLine(lapiz, Vector2, Vector3);
            vector.DrawLine(lapiz, Vector3, Vector1);
        }
        public void _LimpiarPlano()
        {
            pictureBox1.Image = null;
        }
    }
}
