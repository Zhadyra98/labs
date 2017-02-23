using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace snake2
{
    class snake
    {
        public char sign = '*';
        public List<point> body;
        public ConsoleColor color;
        public int cnt;

        public snake()
        {
            cnt = 0;
            body = new List<point>();
            body.Add(new point(10, 10));
            color = ConsoleColor.Gray;
        }

        public void move(int dx, int dy)
        {
            
            for(int i=body.Count-1; i>0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;
        
            if (body[0].x > Console.WindowWidth - 5)
                body[0].x = 1;
            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 5;

            if (body[0].y > Console.WindowHeight)
                body[0].y = 1;
            if (body[0].y < 1)
                body[0].y = Console.WindowHeight;
        }

        public void draw()
        {
            Console.ForegroundColor = color;
            foreach(point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine(sign);
                
            }
        }

        public bool CanEat(food food)
        {
            if (body[0].Equals(food.plc))
            {
              
                body.Add(food.plc);
                return true;
            }
            return false;
        }

      /*  public bool crash(wall wall)
        {
            if (body[0].Equals(wall.w))
            {
                return true;
            }
            return false;
        }
     */

    }
}
