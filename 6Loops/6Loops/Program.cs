using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            i = 0;

            while (i < 20)
            {
                Console.WriteLine(i++ + "\n \n");
            }

            i = 0;

            do
            {
                Console.WriteLine(i++);
            }
            while (i < 10);



            Console.ReadKey();
        }
    }
}
