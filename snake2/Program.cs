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
            x = _x;
            y = _y;
        }

    }
    class snake
    {
        public char sign;
        public List<point> body;
        public ConsoleColor color;
        int count;
        
        public snake()
        {
            color = ConsoleColor.Red;
            sign = '*';
            body = new List<point>();
            body.Add(new point(10, 10));
            count = 1;
        }
        public void Move(int dx, int dy)
        {
            if (count % 10 == 0)
                body.Add(new point(0, 0));
            for(int i=body.Count-1; i >= 1; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            if (body[0].x > Console.WindowWidth - 10)
                body[0].x = 1;

            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 10;

            if (body[0].y > Console.WindowHeight - 10)
                body[0].y = 1;

            if (body[0].y < 1)
                body[0].y = Console.WindowHeight - 10;
            count++;
        }

        public void Draw()
        {
            Console.Clear();
            Console.ForegroundColor = color;

            foreach(point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine(sign);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            snake snk = new snake();
            while (true)
            {
                ConsoleKeyInfo keyinf = Console.ReadKey();
                if (keyinf.Key == ConsoleKey.UpArrow)
                    snk.Move(0, -1);
                if (keyinf.Key == ConsoleKey.DownArrow)
                    snk.Move(0,1);
                if (keyinf.Key == ConsoleKey.LeftArrow)
                    snk.Move(-1, 0);
                if (keyinf.Key == ConsoleKey.RightArrow)
                    snk.Move(1, 0);
                Console.Clear();
                snk.Draw();
                                
            }
        }
    }
}
