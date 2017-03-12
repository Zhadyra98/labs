using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake_final
{
    public class wall
    {
        public char sign;
        public List<point> body;
        public ConsoleColor col;
        public wall()
        {

        }
        public  wall(int level)
        {
            sign = '=';
            col = ConsoleColor.Red;
            body = new List<point>();

            DirectoryInfo dir = new DirectoryInfo(@"C:\levels");
            FileInfo[] f = dir.GetFiles();

            if (level < 4)
            {
                StreamReader sr = new StreamReader(f[level].FullName);
                int k = int.Parse(sr.ReadLine());

                for(int i=0; i<k; i++)
                {
                    string s = sr.ReadLine();
                    for(int j=0; j<s.Length; j++)
                    {
                        if (s[j] == '*')
                        {
                            body.Add(new point(j,i));
                        }
                    }
                }
                sr.Close();
            }
            if (level == 4)
            {
                Console.WriteLine("YOU WON!!!");
            }
        }

        public void draw()
        {
            Console.ForegroundColor = col;
            foreach (point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);

                Console.Write(sign);
            }
        }
    }
}
