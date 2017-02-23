using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class point
    {
        public int x;
        public int y;
        public point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public override bool Equals(object obj)
        {
            point o = obj as point;
            if (this.x == o.x && this.y == o.y) return true;
            return false;
        }
    }
}
