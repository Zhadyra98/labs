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
        public static Complex operator +(Complex c1, Complex c2)//if the operator is +
        {
            Complex c3 = new Complex(0, 0);//new complex with parameters a and b 
            c3.a = c1.a * c2.b + c2.a * c1.b;//how the up value calculated
            c3.b = c1.b * c2.b;//how the down value calculated



            //to make complex bumber simple
            if (c3.a > c3.b)
            {
                for (int d = c3.b; d > 0; d--)//loop begins with the smallest when among upper and down value
                {
                    if (c3.a % d == 0 && c3.b % d == 0)//checks wheter number is divsible to bath values
                    {
                        int nod = d;//prisvoit' znachenie
                        c3.a = c3.a / nod;//make it smaller by dividing the largest divisible number
                        c3.b = c3.b / nod;
                   
                        break;// we do not need to go down as we already found the largest didvisible
                    }
                }
            }
            else
                for (int d = c3.a; d > 0; d--)
                {
                    if (c3.a % d == 0 && c3.b % d == 0)
                    {
                        int nod = d;
                        c3.a = c3.a / nod;
                        c3.b = c3.b / nod;
                       
                        break;
                    }
                }
            return c3;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c4 = new Complex(0, 0);
            c4.a = c1.a * c2.b - c2.a * c1.b;
            c4.b = c1.b * c2.b;
            if (c4.a > c4.b)
            {
                for (int d = c4.b; d > 0; d--)
                {
                    if (c4.a % d == 0 && c4.b % d == 0)
                    {
                        int nod = d;
                        c4.a = c4.a / nod;
                        c4.b = c4.b / nod;
                        
                        break;
                    }
                }
            }
            else if (c4.a > c4.b)
                for (int d = c4.a; d > 0; d--)
                {
                    if (c4.a % d == 0 && c4.b % d == 0)
                    {
                        int nod = d;
                        c4.a = c4.a / nod;
                        c4.b = c4.b / nod;
                        
                        break;
                    }
                }
            else if (c4.a == c4.b)
            {
                c4.a = 1;
                c4.b = 1;
            }
            return c4;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c5 = new Complex(0, 0);
            c5.a = c1.a * c2.a;
            c5.b = c1.b * c2.b;
            if (c5.a > c5.b)
            {
                for (int d = c5.b; d > 0; d--)
                {
                    if (c5.a % d == 0 && c5.b % d == 0)
                    {
                        int nod = d;
                        c5.a = c5.a / nod;
                        c5.b = c5.b / nod;
                       
                        break;
                    }
                }
            }
            else
                for (int d = c5.a; d > 0; d--)
                {
                    if (c5.a % d == 0 && c5.b % d == 0)
                    {
                        int nod = d;
                        c5.a = c5.a / nod;
                        c5.b = c5.b / nod;
                     
                        break;
                    }
                }
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
            if (c6.a > c6.b)
            {
                for (int d = c6.b; d > 0; d--)
                {
                    if (c6.a % d == 0 && c6.b % d == 0)
                    {
                        int nod = d;
                        c6.a = c6.a / nod;
                        c6.b = c6.b / nod;
                        
                        break;
                    }
                }
            }
            else
                for (int d = c6.a; d > 0; d--)
                {
                    if (c6.a % d == 0 && c6.b % d == 0)
                    {
                        int nod = d;
                        c6.a = c6.a / nod;
                        c6.b = c6.b / nod;
                      
                        break;
                    }
                }
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
