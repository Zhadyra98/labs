using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\file\input.txt");//to connect with the input file
            string s = sr.ReadLine();
            string[] arr = s.Split();// separate by spaces
            
            int max = 0, k =arr.Length, min =0;
            for (int i=1; i<k; i++)
            {
                int j = int.Parse(arr[i]);//converting into the integer each string in file


                if (j > max)//conditon to be max
                {
                    max = j;
                }
            }
            for (int i = 1; i < k; i++)
            {
                int j = int.Parse(arr[i]);


                if (j < min)//condition for min
                {
                    min = j;
                }
            }
            Console.WriteLine("max="+max);//output
            Console.WriteLine("min="+min);//output
            Console.ReadKey();
            sr.Close();
        }
    }
}
