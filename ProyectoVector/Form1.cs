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
        public FormPlanoCartesiano()
        {
            InitializeComponent();
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
        }
    }
}
