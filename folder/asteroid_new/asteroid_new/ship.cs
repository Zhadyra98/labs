using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace asteroid_new
{  
    class ship
    {
        public GraphicsPath shipPoints1 = new GraphicsPath();
        public GraphicsPath shipPoints2 = new GraphicsPath();
        public ship(int x, int y)
        {
            Point[] points =
            {
                new Point(x,y-30),
                new Point(x+30,y-15),
                new Point(x+30,y+15),
                new Point(x,y+30),
                new Point(x-30,y+15),
                new Point(x-30,y-15)
            };
            Point[] strelka =
            {
                new Point(x,y-15),
                new Point(x+10,y),
                new Point(x+10,y+15),
                new Point(x-10,y+15),
                new Point(x-10,y)
            };
            shipPoints1.AddPolygon(points);
            shipPoints2.AddPolygon(strelka);
        }
    }
}
