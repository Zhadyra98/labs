using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace farman2
{
    class Program
    {
        static void process(DirectoryInfo d,int cur)//the main function to display the files and directories
        {
            Console.Clear();//when the function is runned again console should be cleared, to avoid continiuos output
            FileSystemInfo[] df = d.GetFileSystemInfos();//array of all files and directories in "d"
            for (int i = 0; i < df.Length; i++)//runs through all things in folder
            {
                if (cur == i)//if we are at current place
                {
                    Console.BackgroundColor = ConsoleColor.Blue;//make it blue
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;//otherwise it should become black 
                }

                if (df[i].GetType() == typeof(DirectoryInfo))//to distinguish between directory and file
                {
                    Console.ForegroundColor = ConsoleColor.Green;//green is folders
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;//files are darkgrey
                }

                Console.WriteLine(df[i].Name);//to display array
             
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\inme");//initialising variable "d"
            int cur = 0;//shows our place like pointer through files
            while (true)
            {
                process(d, cur);//сalling main function
                
                ConsoleKeyInfo pressedKey = Console.ReadKey();//variable for keeping data of pressed button
                if (pressedKey.Key == ConsoleKey.UpArrow)//if UP is pressed
                {
                    if (cur > 0)//it curdor decreses only if the current place is greater than 0
                    {
                        cur=cur-1;//decrement
                     
                    }
                }
               if (pressedKey.Key == ConsoleKey.DownArrow)//Down button is pressed
                {
                    if (cur < d.GetFileSystemInfos().Length - 1)//again cursor cannot move abroad from max length of array
                    {
                        cur = cur + 1;//increment
                       
                    }
                }
                if (pressedKey.Key == ConsoleKey.Escape)//escape button is pressed
                {
                    d = d.Parent;//changes path to previous path 
                    cur = 0;
                }
                if (pressedKey.Key == ConsoleKey.Enter)//Enter button is pressed
                {
                    FileSystemInfo df = d.GetFileSystemInfos()[cur];
                    if (df.GetType() == typeof(DirectoryInfo))//if it is file
                    {
                        d = new DirectoryInfo(df.FullName);//it changes it's path to current folder
                        cur = 0;
                    }
                    else
                    {
                        Process.Start(df.FullName);//otherwise, open the file 
                    }
                }
       
            }
                    Console.ReadKey();
        }
    }
}
