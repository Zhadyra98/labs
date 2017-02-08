using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace farman2
{
    class Program
    {
        static void process(DirectoryInfo d,int cur)
        {
            FileSystemInfo[] df = d.GetFileSystemInfos();
              
            for (int i = 0; i < df.Length; i++)
            {
                Console.WriteLine(df[i].Name);
                if (cur == i)
                {
                    Console.WriteLine("*****");
                }
            }
        }


        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\file");
            int cur = 0;
                      
            while (true)
            {
                FileSystemInfo[] df = d.GetFileSystemInfos();
                int n = df.Length;
                Console.Clear();
                process (d, cur);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (cur > 0)
                    {
                        cur = cur - 1;
                    }
                }
               if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (cur < n)
                    {
                        cur = cur + 1;
                    }
                }
                if (pressedKey.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (cur > 0)
                    {
                        cur = cur - 1;
                    }
                }
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (cur > 0)
                    {
                        cur = cur - 1;
                    }
                }
            }
                    Console.ReadKey();

        }
    }
}
