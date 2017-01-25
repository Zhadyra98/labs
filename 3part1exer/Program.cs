using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3part1exer
{
    class Program
    {
        class Person
        {
            public string firstName;
            public string lastName;
            public int age;
            public enum Genders : int { Male, Female };
            public Genders gender;

            public Person(string _firstName, string _lastName, int _age, Genders _gender)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
            }

            public override string ToString()
            {
                return firstName + " " + lastName + " (" + gender + "), age " + age;
            }
           class Manager : Person
            {

                public string phoneNumber;
                public string officeLocation;


                public Manager(string _firstName, string _lastName, int _age,Genders _gender, string _phoneNumber, string _officeLocation)
                :base(_firstName, _lastName, _age, _gender)
                {
                  
                    phoneNumber = _phoneNumber;
                    officeLocation = _officeLocation;
                }

                public override string ToString()
                {
                    return base.ToString() + ", " + phoneNumber + ", " + officeLocation;
                }


            }
        }
            static void Main(string[] args)
        {
           Manager man = new Manager ("Tony", "Allen", 32, Manager:Person.Genders.Male,545878,"Street 25");
            Console.WriteLine(man.ToString());
            Console.ReadKey(); 
        }
    }
}
