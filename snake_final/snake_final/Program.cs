using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake_final
{
    public class Program
    {
        public static snake snake;
        public static food food;
        public static wall wall;
        public static int pr;
        public static int o;

        static void moveit()
        {
            Console.Clear();
            while (true)
            {
                if (pr == 1)
                {
                    snake.move(0, -1);
                }
                if (pr == -1)
                {
                    snake.move(0, 1);
                }
                if (pr == 2)
                {
                    snake.move(1, 0);
                }
                if (pr == -2)
                {
                    snake.move(-1, 0);
                }
                if (snake.EatFood(food))
                {
                    food.findposition();
                    o++;
                }

                snake.draw();
                food.draw();
                wall.draw();
                if (snake.body.Count == 4)
                {
                    Console.Clear();
                    wall = new wall(1);
                    snake = new snake();
                }
                if (food.inwall(wall))
                {
                    food.findposition();
                }
                if (snake.withwall(wall))
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GAME OVER!!!");
                    break;
                }

                Thread.Sleep(300);
            }

        }
        static void Main(string[] args)
        {
            snake = new snake_final.snake();
            food = new snake_final.food();
            wall = new snake_final.wall(0);
            Thread t = new Thread(moveit);
            t.Start();
            while (true)
            {
                ConsoleKeyInfo prkey = Console.ReadKey();

                if (prkey.Key == ConsoleKey.UpArrow && pr != -1)
                {
                    pr = 1;
                }
                if (prkey.Key == ConsoleKey.DownArrow && pr != 1)
                {
                    pr = -1;
                }
                if (prkey.Key == ConsoleKey.LeftArrow && pr != 2)
                {
                    pr = -2;
                }
                if (prkey.Key == ConsoleKey.RightArrow && pr != -2)
                {
                    pr = 2;
                }
            }

        }
    }
}
