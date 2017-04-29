using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace asteroid_new
{
    class Asteroids
    {
        public GraphicsPath asteroid_points1 = new GraphicsPath();
        public GraphicsPath asteroid_points2= new GraphicsPath();
        public Asteroids(int x, int y)
        {
            Point[] p1 = {
                new Point(x-20,y-10),
                new Point(x+20,y-10),
                new Point(x,y+20)
            };
            Point [] p2={
                new Point(x,y-20),
                new Point(x+20,y+10),
                new Point(x-20,y+10)
            };
            asteroid_points1.AddPolygon(p1);
            asteroid_points2.AddPolygon(p2);
        }
    }
}
