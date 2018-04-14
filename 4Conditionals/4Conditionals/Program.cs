using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int temprature = Convert.ToInt32(s);

            int airconditioningdegree = 20;

            if ( temprature < -10)
            {
                Console.WriteLine("Weather very cool");
                airconditioningdegree += 5;
            }
            else if ((temprature >= -10) && (temprature < 10))
            {
                Console.WriteLine("Weather cool");
                airconditioningdegree += 2;
            }
            else if ((temprature >= 10) && (temprature < 20))
            {
                Console.WriteLine("Weather warm, don't change temprature");
            }
            else
            {
                Console.WriteLine("Weather very hot, down the degree of airconditioning");
                airconditioningdegree -= 2;
            }

            Console.WriteLine("Temprature : {0}, klima : {1}", temprature, airconditioningdegree);

            switch (temprature)
            {
                case 10:
                    {
                        Console.WriteLine("Temprature 10");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("Temprature normal");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Other conditions");
                        break;
                    }
            }


            airconditioningdegree = temprature > 10 ? 25 : 30;
            if (temprature > 10)
                airconditioningdegree = 25;
            else
                airconditioningdegree = 30;

            Console.ReadKey();
        }
    }
}
