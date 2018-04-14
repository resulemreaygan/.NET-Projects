using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int lastNumber = 0;

            for (i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                lastNumber += number;
                number = 0;
            }

            Console.WriteLine(lastNumber);

            Console.ReadKey();
        }
    }
}
