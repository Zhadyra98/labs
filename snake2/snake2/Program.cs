using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            snake snake = new snake();
            wall wall = new wall();
            food food = new food();
            int f = 0;
            

            while (true)
            {
                    Console.Clear();
                    snake.draw();
                    wall.draw();
                    food.draw();

                ConsoleKeyInfo prkey = Console.ReadKey();

                    if (prkey.Key == ConsoleKey.UpArrow)
                    {
                        snake.move(0, -1);
                    }
                    if (prkey.Key == ConsoleKey.DownArrow)
                    {
                        snake.move(0, 1);
                    }
                    if (prkey.Key == ConsoleKey.RightArrow)
                    {
                        snake.move(1, 0);
                    }
                    if (prkey.Key == ConsoleKey.LeftArrow)
                    {
                        snake.move(-1, 0);
                    }
                    if (prkey.Key == ConsoleKey.Escape)
                        break;

                    if (snake.CanEat(food))
                    {
                        food = new food();
                        f++;
                    }

                if (f == 5)
                {
                    wall.sr = new StreamReader(@"wall2.txt");
                }

                StreamReader sr = new StreamReader(@"wall1.txt");
                int n = int.Parse(sr.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string s = sr.ReadLine();

                    for (int j = 0; j < s.Length; j++)
                    {
                        if (j == snake.body[0].x && i == snake.body[0].y)
                        {
                            Console.WriteLine("GAME OVER!!!!!");
                            Console.Clear();
                            break;
                        }
                    }
                }
                sr.Close();


            }
    } }

}