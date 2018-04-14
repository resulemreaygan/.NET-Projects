using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int mark = Convert.ToInt16(Console.ReadLine());

            if (mark >= 50)
            {
                Console.WriteLine("You Pass");
            }
            else
                Console.WriteLine("You Lose :) ");

            Console.ReadKey();
        }
    }
}
