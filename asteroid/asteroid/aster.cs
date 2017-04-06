using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace asteroid
{
    class aster
    {
        int x;
        int y;
        int width;
        int height;
        Pen pen;
        public aster(int x, int y, int width, int height, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.pen = pen;
        }
        public void Draw(Graphics g)
        {
            Point[] triangle1 = { new Point(x + width / 2, y), new Point(x + width, y + height * 3 / 4), new Point(x, y + height * 3 / 4) };
            Point[] triangle2 = { new Point(x, y + height / 4), new Point(x + width, y + height / 4), new Point(x + width / 2, y + height) };
            g.FillPolygon(pen.Brush, triangle2);
            g.FillPolygon(pen.Brush, triangle1);
        }
    }
}
