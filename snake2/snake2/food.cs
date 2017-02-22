using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake2
{
    class food
    {
        public char sign ='&';
        public ConsoleColor color;
        public List<point> fd;
            
            public food()
            {
                fd = new List<point>();
                color = ConsoleColor.Red;
                
                StreamReader re = new StreamReader("food.txt");
                int n = int.Parse(re.ReadLine());
                for(int i=0; i<n; i++)
                {
                    string s = re.ReadLine();
                    for(int j=0; j<s.Length; j++)
                    {
                        if (s[j] == '-')
                        {
                        fd.Add(new point(j,i));
                        }
                    }
                }
                re.Close(); 
            }

        public void draw()
        {
            Console.ForegroundColor=color;
            foreach(point p in fd)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
