using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_2student
{
    class Program
    {
        class Student
        {    //declaring new variable to the class Student
            public string firstName;
            public string lastName;
            public int gpa;

            public Student(string _firstName, string _lastName, int _gpa)//constructor for class Student 
            {
                firstName = _firstName;
                lastName = _lastName;
                gpa = _gpa;

            }

            public override string ToString()//funcltion to return values
            { 
                return firstName + " " + lastName + " " + gpa;
            }
        }
            static void Main(string[] args)
        {
            Student s = new Student("Alice","Kim",3);//initialisation of variables
                Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }
}
