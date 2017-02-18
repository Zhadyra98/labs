using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int k = s.Length;
            foreach (string g in s)
            {
                int count = 0;
                for(int i=1; i <= int.Parse(g); i++)
                {
                    if (int.Parse(g) % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(g + " ");
                    
                }
            }
            Console.ReadKey();
        }

    }
}
