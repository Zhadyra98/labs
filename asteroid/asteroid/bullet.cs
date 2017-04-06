using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace asteroid
{
    class bullet
    {
        int x;
        int y;
        int width;
        int height;
        Pen pen;
        public bullet(int x, int y, int width, int height, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.pen = pen;
        }
        public void Draw(Graphics g)
        {
            Point[] p = { new Point(x + width / 2, y), new Point(x + width * 3 / 4, y + height / 2), new Point(x + width / 2, y + height), new Point(x + width / 4, y + height / 2), new Point(x + width / 2, y) };
            Point[] p1 = {  new Point(x, y + height / 2), new Point(x + width/2, y + height / 4),new Point(x + width, y + height / 2), new Point(x + width / 2, y + height / 4 * 3) };
            g.FillPolygon(pen.Brush, p);
            g.FillPolygon(pen.Brush, p1);
        }
    }
}
