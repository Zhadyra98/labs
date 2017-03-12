using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_final
{
    public class food
    {
        public char sign ='@';
        public point plc;
        public ConsoleColor col = ConsoleColor.Green;
 
 
        public food()
        {
            findposition();      
        }
        public void findposition()
        {
            plc = new point(new Random().Next(5,50), new Random().Next(8,49));
        }
        public void draw()
        {
            Console.ForegroundColor = col;
            Console.SetCursorPosition(plc.x, plc.y);
            Console.Write(sign);
        }

        public bool inwall(wall wall)
        {
            foreach(point p in wall.body)
            {
                if(plc.x==p.x && plc.y == p.y)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
