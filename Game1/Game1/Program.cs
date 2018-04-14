using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayiJen = new Random();
            int p1skor = 0;
            int p2skor = 0;
           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Oyuncu'nun İsmi :");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string player1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2. Oyuncu'nun İsmi :");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string player2 = Console.ReadLine();

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("1. Oyuncu zar atmak icin Enter a basiniz  ");
                Console.ReadKey();
                int p1 = sayiJen.Next(1, 6);
                Console.WriteLine(p1);


                Console.WriteLine("2. Oyuncu zar atmak için Enter a basiniz ");
                Console.ReadKey();
                int p2 = sayiJen.Next(1, 6);
                Console.WriteLine(p2);

                if (p1 > p2)
                {
                    p1skor++;
                }
                else
                {   
                    p2skor++;
                }
            }

            Console.WriteLine("{0} {1} - {2} {3} ",player1,p1skor,p2skor,player2);

            if (p1skor > p2skor)
            {
                Console.WriteLine("{0} kazandi.", player1);
            }
            
            else if (p1skor == p2skor)
            {
                Console.WriteLine("{0} - {1} Berabere.", p1skor, p2skor);
            }
            else
                Console.WriteLine("{0} kazandi.", player2);


            Console.ReadKey();


        }
    }
}
