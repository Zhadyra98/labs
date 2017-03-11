using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace snake2
{
   class Program
    {
        static void Main(string[] args)
        {
            snake snake = new snake();
            wall wall = new wall(0);
            food food = new food();
            
            int pr = 0;
            int f = 0;
            int l = 0;
            int n = snake.body.Count();
            int kr=5;
            int d = 0;

            while (true)
            {
                    /*Console.SetCursorPosition(Console.WindowWidth - 10, Console.WindowHeight - 2);
                    Console.WriteLine("Score is" + f * 100);*/
                    Console.Clear();
                    
                    if (snake.body.Count == 3 && d!=-1)
                        {
                        wall = new snake2.wall(1);
                        snake = new snake ();
                    d = -1;
                        }

                    if (snake.body.Count + kr == 9)
                        {
                            wall = new snake2.wall(2);
                            snake = new snake();
                            
                        }

                    snake.draw();
                    food.draw();
                    wall.draw();

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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Press key 'N' to start game again");
                            ConsoleKeyInfo keys=Console.ReadKey();                     
                                if (keys.Key == ConsoleKey.N)
                                {
                                    wall = new snake2.wall();
                                    food = new food();
                                    snake = new snake();
                                }

                    }
                    }
                if (snake.CanEat(food))
                {
                    food = new food();
                    f++;
                    Console.WriteLine(l);
                }

                if (snake.foodsnake(food))
                {
                    food.plc = new point(new Random().Next() % 30, new Random().Next() % 30);
                }
                if (snake.foodwall(wall,food))
                {
                    food.plc = new point(new Random().Next() % 30, new Random().Next() % 30);
                }




            }
           // sr.Close();
    }
        

        }
    }