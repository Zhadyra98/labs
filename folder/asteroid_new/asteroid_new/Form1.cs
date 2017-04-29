using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace asteroid_new
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        ship spaceship;
        Asteroids ast1, ast2, ast3;
        Brush brush_ship = new SolidBrush(Color.Yellow);
        Star star1, star2, star3;
        public int x=150;
        public int y=100;
        public int x1 = 50, y1 = 50;//first asteroid's location
        public int x2 = 200, y2 = 170;//second
        public int x3, y3;//third
        Random rand = new Random();
        Random rand2 = new Random();
        Random rand3 = new Random();
        int change;


        enum move {LEFT,RIGHT,UP,DOWN,None };
        move movement_dir;
        public Form1()
        {
            InitializeComponent();
            bmp=new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            x3 = this.Width - 50;
            y3 = this.Height - 50;
            ast1 = new Asteroids(x1, y1);
            ast2 = new Asteroids(x2, y2);
            ast3 = new Asteroids(x3, y3);

            star1 = new Star(x1 + 90, y - 50);
            star2 = new Star(x2 - 150, y2 + 60);
            star3 = new Star(x3 - 200, y3 - 150);
            spaceship = new ship(x, y);
            movement_dir = move.None;
        }
        public void draw()
        {
            g.FillPath(brush_ship, spaceship.shipPoints1);
            g.FillPath(new SolidBrush(Color.Green), spaceship.shipPoints2);
            g.FillPath(new SolidBrush(Color.Red), ast1.asteroid_points1);
            g.FillPath(new SolidBrush(Color.Red), ast1.asteroid_points2);
            g.FillPath(new SolidBrush(Color.Red), ast2.asteroid_points2);
            g.FillPath(new SolidBrush(Color.Red), ast2.asteroid_points1);
            g.FillPath(new SolidBrush(Color.Red), ast3.asteroid_points1);
            g.FillPath(new SolidBrush(Color.Red), ast3.asteroid_points2);

            g.FillPath(new SolidBrush(Color.White), star1.star_points);
            g.FillPath(new SolidBrush(Color.White), star2.star_points);
            g.FillPath(new SolidBrush(Color.White), star3.star_points);
            //g.FillPath(new SolidBrush(Color.White), star1.star_points);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Press OK, to start!!!");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            if (movement_dir == move.LEFT)
            {
                brush_ship = new SolidBrush(Color.Magenta);
                x = x - 20;
                if (x < 0)
                {
                    x = this.Width;
                }
                spaceship = new ship(x, y);
            }
            if (movement_dir == move.RIGHT)
            {
                brush_ship = new SolidBrush(Color.Lime);
                x = x + 20;
                if (x > this.Width)
                {
                    x = 0;
                }
                spaceship = new ship(x, y);
            }
            if (movement_dir == move.UP)
            {
                brush_ship = new SolidBrush(Color.Yellow);
                y = y - 20;
                if (y<0)
                {
                    y=this.Height;
                }
                spaceship = new ship(x, y);
            }
            if (movement_dir == move.DOWN)
            {
                brush_ship = new SolidBrush(Color.Silver);
                y = y + 20;
                if (y > this.Height)
                {
                    y = 0;
                }
                spaceship = new ship(x, y);
            }
            change = rand.Next(-10,100);
            x1 = x1 + change;
            if (x1 >= pictureBox1.Width)
            {
                x1 = 0;
            }
            y1 = y1 - rand.Next(100);
            if (y1 <=0)
            {
                y1 = pictureBox1.Height;
            }

            x2 = x2 - change;
            if (x2<=0)
            {
                x2 = pictureBox1.Width;
            }
            y2 = y2 - rand.Next(100);
            if (y2 <= 0)
            {
                y2 = pictureBox1.Height;
            }

            x3 = x3 - change;
            if (x3 <= 0)
            {
                x3 = pictureBox1.Width;
            }
            y3 = y3 - rand.Next(100);
            if (y3 <= 0)
            {
                y3 = pictureBox1.Height;
            }
           
            ast1 = new Asteroids(x1, y1);
            ast2 = new Asteroids(x2, y2);
            ast3 = new Asteroids(x3, y3);

            star1 = new Star(x2, y1);
            star2 = new Star(x3, y2);
            star3 = new Star(x1, y3);

            //pictureBox1.Refresh();
            draw();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                movement_dir = move.LEFT;
            }
            if (e.KeyCode == Keys.Right)
            {
                movement_dir = move.RIGHT;
            }
            if (e.KeyCode == Keys.Up)
            {
                movement_dir = move.UP;
            }
            if (e.KeyCode == Keys.Down)
            {
                movement_dir = move.DOWN;
            }
        }
    }
}
