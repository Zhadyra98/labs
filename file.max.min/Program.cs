using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file.max.min
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;//for cointing divisible numbers
            int k = args.Length;// variable for keeping number of entered data
            for(int i=0; i < k; i++) {
               count = 0;
           
                for (int l = 1; l <= int.Parse(args[i]); l++) //loop for checking dividable numbers
                {

                    if (int.Parse(args[i]) % l == 0)//if there is no remainder ...
                    {
                        count++;
                    }
                }

                if (count == 2)//only to divideable numbers
                {
                    Console.WriteLine(args[i]);//output
                }

            }
            Console.ReadKey();
        }
    }
}
