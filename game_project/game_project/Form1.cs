using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_project
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int score = 0;
        PictureBox[] shariki = new PictureBox[20];
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.TopMost = true;
            Cursor.Hide();
            rockets.Top = pictureBox1.Bottom - (pictureBox1.Bottom / 20);
            label1.Top = pictureBox1.Height / 2 - label1.Height / 2;
            label1.Left = pictureBox1.Width / 2 - label1.Width / 2;
            label1.Visible = false;
            
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rockets.Left = Cursor.Position.X - rockets.Width / 2;
            Square.Left += speed_left;
            Square.Top += speed_top;
            if(Square.Bottom>=rockets.Top && Square.Bottom<=rockets.Bottom && /*Square.Left>=rockets.Lef/ ||*/ Square.Right<=rockets.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                score += 1;
                points.Text = score.ToString();
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
            }
            if(Square.Top<=pictureBox2.Bottom)
            {
                pictureBox2.Visible = false;
                speed_top = -speed_top;
            }
            if (Square.Top <= pictureBox3.Bottom)
            {
                pictureBox3.Visible = false;
                speed_top = -speed_top;
            }
            if (Square.Top <= pictureBox8.Bottom)
            {
                pictureBox8.Visible = false;
                speed_top = -speed_top;
            }
            if (Square.Top <= pictureBox7.Bottom)
            {
                pictureBox7.Visible = false;
                speed_top = -speed_top;
            }
            if (Square.Top <= pictureBox4.Bottom)
            {
                pictureBox4.Visible = false;
                speed_top = -speed_top;
            }



        }


    }
}
