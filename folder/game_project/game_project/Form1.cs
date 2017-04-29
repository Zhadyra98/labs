using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_project
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        public int speed_left = 4;
        public int speed_top = 4;
        public int score = 0;
        /*rec rec1, rec2, rec3, rec4, rec5, rec6;
        int x1 = 30, x2 = 100, x3 = 170;
        int y1 = 10, y2 = 10, y3 = 10;
        int x4 = 30, x5 = 100, x6 = 170;
        int y4 = 60, y5 = 60, y6 = 60;*/
        int x = 20, y = 10;
        Rectangle rec1, rec2, rec3, rec4, rec5, rec6,rec7,rec8, rec9,rec10,rec11,rec12;


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            timer1.Enabled = true;
            this.TopMost = true;
            Cursor.Hide();
            rockets.Top = pictureBox1.Bottom - (pictureBox1.Bottom / 20);
            label1.Top = pictureBox1.Height / 2 - label1.Height / 2;
            label1.Left = pictureBox1.Width / 2 - label1.Width / 2;
            label1.Visible = false;
            rec1 = new Rectangle(x, y, 65, 40);//rectangles in the first row
            rec2 = new Rectangle(x+80, y, 65, 40);
            rec3 = new Rectangle(x+160, y, 65, 40);
            rec4 = new Rectangle(x+240, y, 65, 40);
            rec5 = new Rectangle(x+320, y, 65, 40);
            rec6 = new Rectangle(x+400, y, 65, 40);

            rec7 = new Rectangle(x, y+60, 60+5, 40);
            rec8 = new Rectangle(x + 80, y+60, 60+5, 40);
            rec9 = new Rectangle(x + 160, y+60, 60+5, 40);
            rec10 = new Rectangle(x + 240, y+60, 60+5, 40);
            rec11 = new Rectangle(x + 320, y+60, 60+5, 40);
            rec12 = new Rectangle(x + 400, y+60, 60+5, 40);
            /*rec1 = new rec(x1, y1);
            rec2 = new rec(x2, y2);
            rec3 = new rec(x3, y3);
            rec4 = new rec(x4, y4);
            rec5 = new rec(x5, y5);
            rec6 = new rec(x6, y6);
            //rec7 = new rec(x1, y1);*/
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Brush b = new SolidBrush(Color.Red))
            {
                e.Graphics.FillRectangle(b, rec1);
                e.Graphics.FillRectangle(b, rec3);
                e.Graphics.FillRectangle(b, rec2);
                e.Graphics.FillRectangle(b, rec4);
                e.Graphics.FillRectangle(b, rec5);
                e.Graphics.FillRectangle(b, rec6);
                e.Graphics.FillRectangle(b, rec7);
                e.Graphics.FillRectangle(b, rec8);
                e.Graphics.FillRectangle(b, rec9);
                e.Graphics.FillRectangle(b, rec10);
                e.Graphics.FillRectangle(b, rec11);
                e.Graphics.FillRectangle(b, rec12);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            rockets.Left = Cursor.Position.X - rockets.Width / 2;
            Square.Left += speed_left;
            Square.Top += speed_top;
            if(Square.Bottom>=rockets.Top && Square.Bottom<=rockets.Bottom && Square.Right<=rockets.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;

            }
            if (Square.Left <= pictureBox1.Left)
            {
                speed_left = -speed_left;
            }
            if(Square.Right >= pictureBox1.Right)
            {
                speed_left = -speed_left;
            }
            if(Square.Top <= pictureBox1.Top)
            {
                speed_top = -speed_top;
            }
            if (Square.Bottom >= rockets.Bottom)
            {
                timer1.Enabled = false;
                label1.Visible = true;
                label1.Text += Square.Top.ToString();
            }
            if (rec1.Bottom >= Square.Top && Square.Left<=rec1.Right && Square.Right >= rec1.Left)
            {
                rec1.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                pictureBox1.Refresh();
            }
            if (rec2.Bottom >= Square.Top && Square.Left <= rec2.Right && Square.Right >= rec2.Left)
            {
                rec2.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                pictureBox1.Refresh();
            }
            if (rec3.Bottom >= Square.Top && Square.Left <= rec3.Right && Square.Right>=rec3.Left)
            {
                rec3.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                pictureBox1.Refresh();
            }
            if (rec4.Bottom >= Square.Top && Square.Left <= rec4.Right && Square.Right >= rec4.Left)
            {
                rec4.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                pictureBox1.Refresh();
            }
            if (rec5.Bottom >= Square.Top && Square.Left <= rec5.Right && Square.Right >= rec5.Left)
            {
                rec5.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                pictureBox1.Refresh();
            }
            if (rec6.Bottom >= Square.Top && Square.Left <= rec6.Right && Square.Right >= rec6.Left)
            {
                rec6.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                pictureBox1.Refresh();
            }
            if (rec7.Bottom >= Square.Top && Square.Left <= rec7.Right && Square.Right >= rec7.Left)
            {
                rec7.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                speed_top = -speed_top;
                pictureBox1.Refresh();
            }
            if (rec8.Bottom >= Square.Top && Square.Left <= rec8.Right && Square.Right >= rec8.Left)
            {
                rec8.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                speed_top = -speed_top;
                pictureBox1.Refresh();
            }
            if (rec9.Bottom >= Square.Top && Square.Left <= rec9.Right && Square.Right >= rec9.Left)
            {
                rec9.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                speed_top = -speed_top;
                pictureBox1.Refresh();
            }
            if (rec10.Bottom >= Square.Top && Square.Left <= rec10.Right && Square.Right >= rec10.Left)
            {
                rec10.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                speed_top = -speed_top;
                pictureBox1.Refresh();
            }
            if (rec11.Bottom >= Square.Top && Square.Left <= rec11.Right && Square.Right >= rec11.Left)
            {
                rec11.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                speed_top = -speed_top;
                pictureBox1.Refresh();
            }
            if (rec12.Bottom >= Square.Top && Square.Left <= rec12.Right && Square.Right >= rec12.Left)
            {
                rec12.Location = new Point(-100, -100);
                score += 1;
                points.Text = score.ToString();
                speed_top = -speed_top;
                pictureBox1.Refresh();
            }
            if (score == 4)
            {
                this.pictureBox1.BackColor = System.Drawing.Color.Magenta;
            }
            if (score == 8)
            {
                this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            }
            if (score == 12)
            {
                timer1.Stop();
                Cursor.Show();
                MessageBox.Show("YOU WON!!!");
                this.Close();
                
            }
            

        }
    }
}
