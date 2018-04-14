using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int tahmin = 0;
            int i = 0;

            Random sayiJen = new Random();

            sayi = sayiJen.Next(1, 100);

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Tahmininizi giriniz :");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin < sayi)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Daha büyük bir sayi  giriniz :");
                }
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Daha kücük bir sayi giriniz :");
                }

                i++;

            }
            while (sayi != tahmin);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tebrikler {0}. tahminde buldunuz ! :) ", i);

            Console.ReadKey();
        }
    }
}
