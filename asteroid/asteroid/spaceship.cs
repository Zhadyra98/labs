using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace asteroid
{
    class spaceship
    {
        int x;
        int y;
        int width;
        int height;
        Pen pen;

        public spaceship(int x, int y, int width, int height, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.pen = pen;
        }

        public void Draw(Graphics g)
        {
            Point[] points = { new Point(x + width / 2, y), new Point(x + width, y + height / 4), new Point(x + width, y + height / 4 * 3),
                new Point(x + width / 2, y + height), new Point(x, y + height / 4 * 3), new Point(x, y + height / 4) };
            g.FillPolygon(pen.Brush, points);
        }
    }
}
