using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace game_project
{
    public class rec
    {
        int x, y, width, height;
        SolidBrush brush;
        public rec(int x, int y, int width, int height, SolidBrush brush)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.brush = brush;
        }

        public void drawrec(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, x, y, width, height);
        }
    }
}
