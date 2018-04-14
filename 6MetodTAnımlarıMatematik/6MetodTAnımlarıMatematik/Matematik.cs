using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6MetodTAnımlarıMatematik
{
    class Matematik
    {
        public int topla(int a, int b)
        {
            return a + b;
        }

        public double topla(double a, int b)
        {
            return a + b;
        }

        public static int metod(int a)
        {
            return a * a;
        }

        public int faktoriyel(int a)
        {
            int b = 1;

            for (int i = 2; i <= a; i++)
            {
                b *= i;
            }
            return b;
        }
    }
}
