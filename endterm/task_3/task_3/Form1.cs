using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        int x, y, l, h, r;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 10;
            if (x > this.Width - 50)
            {
                x = 50;
            }
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            l = 100;
            h = 30;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), x + l / 3, y, l / 3, h);
            e.Graphics.DrawRectangle(new Pen(Color.Green), x, y + h, l,h);
            e.Graphics.FillEllipse(Brushes.Black, x + l / 3, y+2*h, 10, 10);
            e.Graphics.FillEllipse(Brushes.Black, x + l*2/ 3, y + 2 * h, 10, 10);
        }
    }
}
