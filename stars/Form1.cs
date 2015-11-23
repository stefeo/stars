using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);
        }
        private void StarField(int x)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            int xcoord, ycoord, size, rcolor, gcolor, bcolor, w;
            Random randNum = new Random();

            for (w = 0; w <= x; w++)
            {
                rcolor = randNum.Next(1, 255);
                gcolor = randNum.Next(1, 255);
                bcolor = randNum.Next(1, 255);
                drawBrush.Color = Color.FromArgb(rcolor, gcolor, bcolor);
                xcoord = randNum.Next(1, 300);
                ycoord = randNum.Next(1, 300);
                size = randNum.Next(1, 10);
                formGraphics.FillRectangle(drawBrush, xcoord, ycoord, size, size);
            }
        }
    }
}
