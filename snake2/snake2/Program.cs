using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            snake snake = new snake();
            wall wall = new wall();
            food f = new food();

            while (true)
            {
                ConsoleKeyInfo prkey = Console.ReadKey();

                if (prkey.Key == ConsoleKey.UpArrow)
                {
                    snake.move(0,-1);
                }
                if (prkey.Key == ConsoleKey.DownArrow)
                {
                    snake.move(0, 1);
                }
                if (prkey.Key == ConsoleKey.RightArrow)
                {
                    snake.move(1,0);
                }
                if (prkey.Key == ConsoleKey.LeftArrow)
                {
                    snake.move(-1, 0);
                }
                if (prkey.Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
                snake.draw();
                wall.draw();
                f.draw();

            }
        }
    }
}
