using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace snake2
{
   class wall
    {
        public char sign = '+';
        public List<point> body = new List<point>();
        public ConsoleColor color= ConsoleColor.Yellow;
        public int lv = 0;
        public wall() { }
        
        public wall(int x)
        {
            lv = x ;
            DirectoryInfo dr = new DirectoryInfo(@"Levels");
            FileInfo[] f = dr.GetFiles();
            StreamReader sr = new StreamReader(f[x].FullName);
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();

                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new point(j, i));
                }
            }
            sr.Close();
        }       
        public void draw()
        {
            Console.ForegroundColor = color;
            foreach (point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine(sign);
            }
            Console.SetCursorPosition(71, 3);
            Console.WriteLine("Level:" + lv);

        }
        
    }
}
