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
            int pr = 0;
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
                        if(pr != -1)
                        {
                            snake.move(0, -1);
                            pr = 1;
                        }
                        else
                        {
                            Console.WriteLine("WRONG DIRECTION");
                            Console.ReadKey();
                        }
                     }
             
                     if (prkey.Key == ConsoleKey.DownArrow )
                    {
                        if (pr != 1)
                        {
                            snake.move(0, 1);
                            pr = -1;
                        }
                        else
                        {
                            Console.WriteLine("WRONG DIRECTION");
                            Console.ReadKey();
                        }
                    }
                    if (prkey.Key == ConsoleKey.RightArrow)
                    {
                        if (pr != -2)
                        {
                            snake.move(1, 0);
                            pr = 2;
                        }
                        else
                        {
                            Console.WriteLine("WRONG DIRECTION");
                            Console.ReadKey();
                        }
                    }
                    if (prkey.Key == ConsoleKey.LeftArrow)
                    {
                        if (pr != 2)
                        {
                            snake.move(-1, 0);
                            pr = -2;
                        }
                        else
                        {
                            Console.WriteLine("WRONG DIRECTION");
                            Console.ReadKey();
                        }
                    }
              
                    if (prkey.Key == ConsoleKey.Escape)
                        break;


                    foreach (point k in wall.body)
                    {
                        if (k.x == snake.body[0].x && k.y == snake.body[0].y)
                        {

                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Game over!!!");
                            while (true)
                            {
                                Console.ReadKey();
                            }
                        }
                    }

                if (snake.CanEat(food))
                    {
                        food = new food();
                        f++;
                    }

                if (f == 5)
                {
                    wall.sr = new StreamReader(@"wall2.txt");
                }


            }
    } }

}