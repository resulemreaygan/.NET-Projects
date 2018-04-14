using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = a;
            char c = new char();
            bool d = false;
            string name = "Ali";
            double e = 4.2;
            float f = 1.2f;

            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(name);
            Console.WriteLine(e);
            Console.WriteLine(f);

            //size
            Console.WriteLine("int boyutu {0}", sizeof(int));
            Console.WriteLine("double boyutu {0}", sizeof(double));
            Console.WriteLine("char boyutu {0}", sizeof(char));
            Console.WriteLine("float boyutu {0}", sizeof(float));
            Console.WriteLine("bool boyutu {0}", sizeof(bool));
            Console.WriteLine("decimal boyutu {0}", sizeof(decimal));
            //Console.WriteLine("string boyutu {0}", sizeof(string));

            string s1 = "123";
            string s2 = "10";
            string s3 = s1 + s2;

            int number1 = Convert.ToInt16(s1);
            int number2 = Convert.ToInt16(s2);
            int number3 = number1 + number2;

            Console.WriteLine("String Toplami {0}", s3);
            Console.WriteLine(number1);
            Console.WriteLine("int Toplami {0}", number3);


            Console.WriteLine("Bir sayi yaziniz");
            string x = Console.ReadLine();
            int convertNumber = Convert.ToInt16(x);
            Console.WriteLine(convertNumber);

            int h = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(h);

            Console.ReadKey();
        }   
    }
}
