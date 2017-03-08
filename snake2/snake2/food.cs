using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake2
{
    class food
    {
        public char sign ='&';
        public ConsoleColor color;
        public point plc;

        public food()
        {
            plc = new point(new Random().Next() % 30, new Random().Next()%30);
            color = ConsoleColor.Red;
        }
        
        public void draw()
        {
            Console.SetCursorPosition(plc.x, plc.y);
            Console.Write(sign);
        }
    }
}
