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
        public List<point> body;
        public ConsoleColor color;
        

        public wall()
        {
            body = new List<point>();
            color = ConsoleColor.Yellow;     
        }       
        public void load(int x)
        {
            
            string path = string.Format("Levels/wall{0}.txt", x);
            StreamReader sr = new StreamReader(path);
            
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

            Console.ForegroundColor = color;
            foreach (point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine(sign);
            }
        }
        public void draw()
        {
            Console.Clear();
        }
        
    }
}
