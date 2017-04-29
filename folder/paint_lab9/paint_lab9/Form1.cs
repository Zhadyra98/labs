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

namespace paint_lab9
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        Graphics g;
        Graphics gPic;
        public Pen pen = new Pen(Color.Black);
        public Point prevPoint;
        public Point curPoint;
        public enum Shape {PEN, LINE, RECTANGLE, CIRCLE, BRUSH };
        public Shape shape = Shape.PEN;
        public bool mouseClicked = false;
        Color placeColor;
       
        public void Draw(Graphics g, Point curPoint)
        {
            if (shape == Shape.PEN)
            { 
                g.DrawLine(pen, prevPoint, curPoint);
                prevPoint = curPoint;
            }
        }
        public void SetPenColor(Color color)
        {
            pen.Color = color;
        }
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            g = Graphics.FromImage(bmp);
            gPic = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;
  
    }

        private void penColor_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Color color = btn.BackColor;
            SetPenColor(color);
        }
        private void brush(int x, int y, Color placeColor)
        {
            Queue<Point> q = new Queue<Point>();
            Point p = new Point(x, y);
            q.Enqueue(p);

            if (x > pictureBox1.Width) return;
            if (x < 0) return;
            if (y > pictureBox1.Height) return;
            if (y < 0) return;
            if (bmp.GetPixel(x, y) != placeColor) return;
            while (q.Count > 0)
            {
                Point cur = q.Dequeue();
                int a = cur.X;
                int b = cur.Y;
                if (bmp.GetPixel(a,b) == placeColor) 
                {
                    bmp.SetPixel(a,b,pen.Color);
                    q.Enqueue(new Point( a + 1, b));
                    q.Enqueue(new Point(a - 1, b));
                    q.Enqueue(new Point(a , b+1));
                    q.Enqueue(new Point(a , b-1));
                }
            }
            
            pictureBox1.Refresh();           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Queue<Point> q = new Queue<Point>();           
            mouseClicked = true;
            prevPoint = e.Location;
            placeColor = bmp.GetPixel(prevPoint.X, prevPoint.Y);
            if (shape == Shape.BRUSH)
            {
                brush(prevPoint.X, prevPoint.Y,placeColor);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            int w = Math.Abs(prevPoint.X - e.Location.X);
            int h = Math.Abs(prevPoint.Y - e.Location.Y);
            int minX = Math.Min(prevPoint.X, e.Location.X);
            int minY = Math.Min(prevPoint.Y, e.Location.Y);
            if (shape == Shape.RECTANGLE)
            {
                g.DrawRectangle(pen, minX, minY, w, h);
            }
            if (shape == Shape.CIRCLE)
            {
                g.DrawEllipse(pen, minX, minY, w, h);
            }
            if (shape == Shape.LINE)
            {
                g.DrawLine(pen, prevPoint,e.Location);
            }
            pictureBox1.Refresh();           
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                if (shape == Shape.PEN)
                {
                    Draw(pictureBox1.CreateGraphics(), e.Location);
                }
                
                if (shape == Shape.LINE)
                {
                    gPic.DrawLine(pen, prevPoint, e.Location);
                }
                if (shape == Shape.RECTANGLE)
                {
                    int w = Math.Abs(prevPoint.X - e.Location.X);
                    int h = Math.Abs(prevPoint.Y - e.Location.Y);
                    int minX = Math.Min(prevPoint.X, e.Location.X);
                    int minY = Math.Min(prevPoint.Y, e.Location.Y);

                    gPic.DrawRectangle(pen, minX, minY, w, h);
                }
                
                if (shape == Shape.CIRCLE)
                {
                    int w = Math.Abs(prevPoint.X - e.Location.X);
                    int h = Math.Abs(prevPoint.Y - e.Location.Y);
                    int minX = Math.Min(prevPoint.X, e.Location.X);
                    int minY = Math.Min(prevPoint.Y, e.Location.Y);

                    gPic.DrawEllipse(pen, minX, minY, w, h);
                }
                pictureBox1.Refresh();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shape = Shape.LINE;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shape = Shape.RECTANGLE;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            shape = Shape.CIRCLE;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pen.Color = c.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save image";
                save.Filter = "Image_Type(*.bmp, *.png, *.jpeg)| *.bmp; *.png; *.jpeg";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                    {
                        pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                        bmp.Save(save.FileName);
                    }
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Title = "Open Image";
                dlgOpen.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png ; *.bmp";

                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    g.DrawImage(new Bitmap(dlgOpen.FileName), 0, 0);         
                          
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            shape = Shape.BRUSH;   
        }
    }
}
