using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace complex
{

    public class Complex
    {
        public int a;//to keep up value
        public int b;//to keep down value

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static int crt(int a1, int b1)
        {

            //to make complex number simple
            if (a1 > b1)
            {
                for (int d = b1; d > 0; d--)//loop begins with the smallest when among upper and down value
                {
                    if (a1 % d == 0 && b1 % d == 0)//checks wheter number is divsible to bath values
                    {
                        return d;
                    }
                }
            }
            else
                for (int d = a1; d > 0; d--)
                {
                    if (a1 % d == 0 && b1 % d == 0)
                    {
                        return d;
                    }
                }
            return 1;
            
        }
        public static Complex operator +(Complex c1, Complex c2)//if the operator is +
        {
            Complex c3 = new Complex(0, 0);//new complex with parameters a and b 
            c3.a = c1.a * c2.b + c2.a * c1.b;//how the up value calculated
            c3.b = c1.b * c2.b;//how the down value calculated
            int d = crt(c3.a, c3.b);
            c3.a /= d;
            c3.b /= d;
            return c3;
            
            
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c4 = new Complex(0, 0);
            c4.a = c1.a * c2.b - c2.a * c1.b;
            c4.b = c1.b * c2.b;
            int d = crt(c4.a, c4.b);
            c4.a /= d;
            c4.b /= d;
            return c4;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c5 = new Complex(0, 0);
            c5.a = c1.a * c2.a;
            c5.b = c1.b * c2.b;
            int d = crt(c5.a, c5.b);
            c5.a /= d;
            c5.b /= d;
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
            int d = crt(c6.a, c6.b);
            c6.a /= d;
            c6.b /= d;
            return c6;
        }
        /*public override string ToString()
        {
            return this.a + "/" + this.b;
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {

            Complex c1 = new Complex(4, 2);//first complex number to work with
            Complex c2 = new Complex(5, 6);
            Complex c3 = c1 + c2;// 4 basic operations
            Complex c4 = c1 - c2;
            Complex c5 = c1 * c2;
            Complex c6 = c1 / c2;

            /*FileStream f1 = new FileStream("1.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer x1 = new XmlSerializer(typeof(Complex));
           
            x1.Serialize(f1, c3);
            f1.Close();*/

            XmlSerializer x2 = new XmlSerializer(typeof(Complex));
            FileStream f2 = new FileStream("2.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            x2.Serialize(f2, c4);
            f2.Close();

            XmlSerializer x3 = new XmlSerializer(typeof(Complex));
            FileStream f3 = new FileStream("3.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            x3.Serialize(f3, c5);
            f3.Close();

            XmlSerializer x4 = new XmlSerializer(typeof(Complex));
            FileStream f4 = new FileStream("4.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            x4.Serialize(f4, c6);
            f4.Close();


            Complex c10 = new Complex(0,0);
            FileStream fr = new FileStream("1.xml", FileMode.Open, FileAccess.Read);
            c10 = x2.Deserialize(fr) as Complex;

            Console.WriteLine(c10);
            fr.Close();


            /*
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            */

            Console.ReadKey();
        }
    }
}
