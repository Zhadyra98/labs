using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex
{
    class Complex
    {
        public int a;//to keep up value
        public int b;//to keep down value

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static void crt(int a1, int b1)
        {

            //to make complex number simple
            if (a1 > b1)
            {
                for (int d = b1; d > 0; d--)//loop begins with the smallest when among upper and down value
                {
                    if (a1 % d == 0 && b1 % d == 0)//checks wheter number is divsible to bath values
                    {
                        int nod = d;//prisvoit' znachenie
                        a1 = a1 / nod;//make it smaller by dividing the largest divisible number
                        b1 = b1 / nod;

                        break;// we do not need to go down as we already found the largest didvisible
                    }
                }
            }
            else
                for (int d = a1; d > 0; d--)
                {
                    if (a1 % d == 0 && b1 % d == 0)
                    {
                        int nod = d;
                        a1 = a1 / nod;
                        b1 = b1 / nod;

                        break;
                    }
                }
            Console.WriteLine(a1 + "/" + b1);
            
        }
        public static Complex operator +(Complex c1, Complex c2)//if the operator is +
        {
            Complex c3 = new Complex(0, 0);//new complex with parameters a and b 
            c3.a = c1.a * c2.b + c2.a * c1.b;//how the up value calculated
            c3.b = c1.b * c2.b;//how the down value calculated
            
            crt(c3.a, c3.b);
            
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c4 = new Complex(0, 0);
            c4.a = c1.a * c2.b - c2.a * c1.b;
            c4.b = c1.b * c2.b;
            crt(c4.a, c4.b);
            return c4;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c5 = new Complex(0, 0);
            c5.a = c1.a * c2.a;
            c5.b = c1.b * c2.b;
            crt(c5.a, c5.b);
            return c5;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c6 = new Complex(0, 0);
            int k = c2.b;
            c2.b = c2.a;
            c2.a = k;
            c6.a = c1.a * c2.a;
            c6.b = c1.b * c2.b;
            crt(c6.a, c6.b);
            return c6;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Complex c1 = new Complex(3, 2);//first complex number to work with
            Complex c2 = new Complex(5, 1);
            Complex c3 = c1 + c2;// 4 basic operations
            Complex c4 = c1 - c2;
            Complex c5 = c1 * c2;
            Complex c6 = c1 / c2;
            Console.WriteLine("number1+number2="+c3.a + "/" + c3.b);//print the outputs
            Console.WriteLine("number1-number2=" + c4.a + "/" + c4.b);
            Console.WriteLine("number1*number2="+c5.a + "/" + c5.b);
            Console.WriteLine("number1/number2="+c6.a + "/" + c6.b);
            Console.ReadKey();
        }
    }
}
