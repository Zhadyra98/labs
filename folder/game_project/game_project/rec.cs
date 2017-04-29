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
        public GraphicsPath el = new GraphicsPath();
        public rec(int x, int y)
        {
            el.AddEllipse(x, y, 60, 40);
        }
    }
}
