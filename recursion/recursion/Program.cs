using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace recursion
{
    class Program
    {
        public static void emptySpaces(int lv)//for creating symbols before the fullnames of files and folders
        {
            for (int i = 0; i < lv * 2; i++)
                Console.Write("-->");
        }
        public static void call(int level, string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);//links with the path shown in main
            emptySpaces(level);// calling function to draw --> to show the level
            Console.WriteLine("Files:" + directory.GetFiles().Length);//displays how many files are there
            foreach (FileInfo file in directory.GetFiles())// working with each element 
            {
                emptySpaces(level);
                Console.WriteLine(file.FullName);//dispalying its fullname
            }

            emptySpaces(level);
            Console.WriteLine("Directories:" + directory.GetDirectories().Length);
            foreach (DirectoryInfo dInfo in directory.GetDirectories())
            {
                emptySpaces(level);
                Console.WriteLine(dInfo.FullName);
                call(level + 1,dInfo.FullName);//recursively runs each folder in the path and their levels' are incremented
            }
        }
        static void Main(string[] args)
        {
            call(1, @"C:\Users\user\lab1");
            Console.ReadKey();
        }
    }
}
