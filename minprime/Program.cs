using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace minprime
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\file\input.txt");//to connect with the input file
            StreamWriter sw = new StreamWriter(@"C:\file\output.txt");//file for writng the answer
            string s = sr.ReadLine();//reads from file
            string[] arr = s.Split();// separate by spaces

            int k = arr.Length;
            int[] el = new int[k];//new array to keep sorted elements 
          
            for (int i = 0; i < k; i++)//loop to store
            {
                el[i] = int.Parse(arr[i]);
            }
            Array.Sort(el);//sorting numbers
            


            for (int i = 0; i < k; i++)
            {
                int count = 0;//for counting divisable numbers
                for (int l = 1; l <= el[i]; l++) //loop for checking divisable numbers
                {

                    if (el[i] % l == 0)//if there is no remainder ...
                    {
                        count++;
                    }
                }

                if (count == 2)//only to divideable numbers
                {
                       sw.WriteLine(el[i]);//to store first met prime number
                        break;//after founding min prime number exit from the loop
                    
                }

            }
                           
            sr.Close();
            sw.Close();

        }
    }
}
