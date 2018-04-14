using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static double Average(double c)
        {
            return (c / 11.0);
        }

        static int Median(int[] a)
        {
            int temp;

            for (int k = 0; k < 11; k++)
            {
                for (int sort = 0; sort < 11; sort++)
                {
                    if (a[sort + 1] > a[sort])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                }
            }

            return a[5];
        }
        
        static int mostFrequently(int[] y)
        {
            int max;
            int max_index;

            int size;

            size = y.Length;

            max_index = 0;

            int[] occurences = new int[101];

            for (int i = 0; i < size; i++)
            {
                occurences[y[i]]++;
            }

            max = occurences[0];

            for (int i = 0; i < 101; i++)
            {
                if (occurences[i] > max)
                {
                    max = occurences[i];
                    max_index = i;
                }
            }

            return max_index;
        }

        static double FindStandardDeviation(double z, int[] t)
        {
            double average = Average(z);
            double total = 0.0;
            
            for (int i = 0; i < t.Length; i++)
            {
                total += Math.Pow((t[i] - average), 2);
            }
            return Math.Sqrt(total / (t.Length - 1)) ;
        }

        static void Main(string[] args)
        {
            // get 11 student name and mark. And find middle mark and write who has this mark.
            int i, menu;
            string[] name = new string[11];
            int[] mark = new int[13];
            double average = 0;
            int median = 0;
            int mod = 0;
            double standard_deviation = 0;

            double x = 0;

            for (i = 0; i < 11; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Name please..");
                Console.ForegroundColor = ConsoleColor.Green;
                name[i] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Mark please..");
                Console.ForegroundColor = ConsoleColor.Green;
                mark[i] = Convert.ToInt32(Console.ReadLine());
                x += mark[i];
            }
            do
            {

            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("********* MENU *********");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("* 1)Arithmetic Average *");
            Console.WriteLine("* 2)Median             *");
            Console.WriteLine("* 3)MOD                *");
            Console.WriteLine("* 4)Standard Deviation *");
            Console.WriteLine("* 0)Quit               *");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("************************");

            menu = Convert.ToInt32(Console.ReadLine());

            
                switch (menu)

                {
                    case 1:
                        average = Average(x);
                        Console.WriteLine(average);
                        Console.ReadKey();
                        break;
                    case 2:
                        median = Median(mark);
                        Console.WriteLine(median);
                        Console.ReadKey();
                        break;
                    case 3:
                        mod = mostFrequently(mark);
                        Console.WriteLine(mod);
                        Console.ReadKey();
                        break;
                    case 4:
                        standard_deviation = FindStandardDeviation(x, mark);
                        Console.WriteLine(standard_deviation);
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        break;

                }
            }
            while (menu != 0);

            Console.ReadKey();
        }
    }
}
