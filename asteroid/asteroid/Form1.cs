using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asteroid
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap b;
        Pen p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            g = Graphics.FromImage(b);
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;*/
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Ellipse ellipse = new Ellipse(50, 50, 50, 50, new Pen(Color.Red));
            ellipse.Draw(e.Graphics);
            Ellipse ellipse1 = new Ellipse(100, 150, 50, 50, new Pen(Color.Red));
            ellipse1.Draw(e.Graphics);
            Ellipse ellipse2 = new Ellipse(200, 170, 50, 50, new Pen(Color.Red));
            ellipse2.Draw(e.Graphics);
            Ellipse ellipse3 = new Ellipse(400, 180, 50, 50, new Pen(Color.Red));
            ellipse3.Draw(e.Graphics);
            Ellipse ellipse4 = new Ellipse(10, 350, 50, 50, new Pen(Color.Red));
            ellipse4.Draw(e.Graphics);


            spaceship ship = new spaceship(200, 250, 100, 100, new Pen(Color.Green));
            ship.Draw(e.Graphics);
            Gun gun = new Gun(240,300,20,20,new Pen(Color.Yellow));
            gun.Draw(e.Graphics);
            bullet bull = new bullet(230, 120, 30, 30, new Pen(Color.Purple));
            bull.Draw(e.Graphics);
            aster asteroid1 = new aster(280, 180, 50, 50, new Pen(Color.SteelBlue));
            asteroid1.Draw(e.Graphics);
            aster asteroid2 = new aster(80, 100, 50, 50, new Pen(Color.SteelBlue));
            asteroid2.Draw(e.Graphics);
            aster asteroid3 = new aster(280, 350, 50, 50, new Pen(Color.SteelBlue));
            asteroid3.Draw(e.Graphics);
            aster asteroid4 = new aster(60, 380, 50, 50, new Pen(Color.SteelBlue));
            asteroid4.Draw(e.Graphics);
        }
    }
}
