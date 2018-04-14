using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6MetodTAnımlarıMatematik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Matematik.metod(3);

            Matematik m = new Matematik();
            int c = m.topla(2, 3);
            double d = m.topla(1.2, 3);

            int g = m.faktoriyel(5);
            Console.WriteLine(g);

            Console.ReadKey();
        }
    }
}
