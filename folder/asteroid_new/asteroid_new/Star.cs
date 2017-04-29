using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace asteroid_new
{

    class Star
    {
        public GraphicsPath star_points = new GraphicsPath();
        public Star(int x, int y)
        {
            star_points.AddEllipse(x, y, 40, 40);
        }
    }
}
