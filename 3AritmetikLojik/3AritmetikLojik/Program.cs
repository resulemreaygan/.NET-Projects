using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AritmetikLojik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            //arithmetic examples

            int s1 = a + b;
            int s2 = a - b;
            int s3 = a * b;
            double s4 = (double)a / (double)b;
            //double s4 = a / b;
            //Console.WriteLine(s4);
            int s5 = a++; // s5 = 5, a = 6
            int s6 = ++a; // a = 7, s6 = 7
            int s7 = b--; // s7 = 2, b =1
            int s8 = --b; // b = 0, s8 = 0

            //lojik examples

            bool b1 = true;
            bool b2 = false;

            bool b3 = b1 || b2; // or  veya
            bool b4 = b1 && b2; // and ve
            bool b5 = !b1; // not değil
            bool b6 = b1 == b2; // if equal true , not equal false
            bool b7 = b1 != b2; // if equal false , not equal true
            bool b8 = a > b;
            bool b9 = a >= b;
            bool b10 = a < b;
            bool b11 = a <= b;

            bool b12 = a < b ? true : false; // int b12 = 10 < 9 ? true : false;

            Console.ReadKey();
        }
    }
}
