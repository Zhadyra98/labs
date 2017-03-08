using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace complex
{
[Serializable]
    public class Complex
    {
        int a, b;
        public Complex()
        {
            a = 0;
            b = 0;
        }
        public Complex(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public int A//used to have an access of each field of an objects Complex
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }

        }

        public int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
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
        public override string ToString()
        {
            return this.a + "/" + this.b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer x2 = new XmlSerializer(typeof(Complex));//creating variavle for XML serialization
            FileStream f2 = new FileStream("2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);//file to keep serializsd data

            XmlSerializer x1 = new XmlSerializer(typeof(Complex));
            FileStream f1 = new FileStream("1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer x3 = new XmlSerializer(typeof(Complex));
            FileStream f3 = new FileStream("3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer x4 = new XmlSerializer(typeof(Complex));
            FileStream f4 = new FileStream("4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            Complex c1 = new Complex(4, 2);//first complex number to work with
            Complex c2 = new Complex(5, 6);
            Complex c3 = c1 + c2;// 4 basic operations
            Complex c4 = c1 - c2;
            Complex c5 = c1 * c2;
            Complex c6 = c1 / c2;

            x2.Serialize(f2, c3);//process of serializing
            f2.Close();//close it, to use file second time 
            Complex c7 = new Complex();//creating new Complex variable to keep Deserialized Complex
            FileStream fs2 = new FileStream("2.txt", FileMode.Open, FileAccess.Read);//file which keeps des.data
            c7 = x2.Deserialize(fs2) as Complex;//process of deserialixing 
            Console.WriteLine(c7);//writing data into console
            fs2.Close();//close file 

            x1.Serialize(f1, c4);
            f1.Close();
            Complex c8 = new Complex();
            FileStream fs1 = new FileStream("1.txt", FileMode.Open, FileAccess.Read);
            c8 = x1.Deserialize(fs1) as Complex;
            Console.WriteLine(c8);
            fs1.Close();

            x3.Serialize(f3, c5);
            f3.Close();
            Complex c9 = new Complex();
            FileStream fs3 = new FileStream("3.txt", FileMode.Open, FileAccess.Read);
            c9 = x3.Deserialize(fs3) as Complex;
            Console.WriteLine(c9);
            fs3.Close();

            x4.Serialize(f4, c6);
            f4.Close();
            Complex c10 = new Complex();
            FileStream fs4 = new FileStream("4.txt", FileMode.Open, FileAccess.Read);
            c10 = x4.Deserialize(fs4) as Complex;
            Console.WriteLine(c10);
            fs4.Close();

            Console.ReadKey();
        }
    }
}
