using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asteroid
{
    class Ellipse
    {
        int x;
        int y;
        int width;
        int height;
        Pen pen;

        public Ellipse(int x, int y, int width, int height, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.pen = pen;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(pen.Brush, x, y, width, height);
        }

    }
}
