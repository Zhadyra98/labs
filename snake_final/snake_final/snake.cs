using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_final
{
    public class snake
    {
        public char sign;
        public ConsoleColor col;
        public List<point> body;
        public snake()
        {
            sign = '*';
            col = ConsoleColor.Magenta;
            body = new List<point>();
            body.Add(new point(10, 10));
        }
        public void move(int dx, int dy)
        {
            for (int i = body.Count() - 1; i >= 0; i--)
            {
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(' ');
            }
            for (int i = body.Count - 1; i >= 1; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;

            if (body[0].x > Console.WindowWidth - 2)
                body[0].x = 1;
            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 2;

            if (body[0].y > Console.WindowHeight - 2)
                body[0].y = 1;
            if (body[0].y < 0)
                body[0].y = Console.WindowHeight - 2;
        }
        public void draw()
        {
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Score:"+Program.o);
            Console.ForegroundColor = col;
            foreach (point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        public bool EatFood(food food)
        {
            if(body[0].x==food.plc.x && body[0].y == food.plc.y)
            {
                body.Add(food.plc);
                return true;
                
            }
            return false;
        }
        public bool withwall(wall wall)
        {
            foreach (point p in wall.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
