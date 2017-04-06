using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace asteroid
{
    class Gun
    {
        int x;
        int y;
        int width;
        int height;
        Pen pen;
        public Gun(int x, int y, int width, int height, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.pen = pen;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(pen.Brush, x, y, width, height);
            Point[] p = { new Point(x-width/2,y), new Point(x+width/2,y-width), new Point(x+width*3/2,y) };
            g.FillPolygon(pen.Brush, p);
            
        }
    }
}
