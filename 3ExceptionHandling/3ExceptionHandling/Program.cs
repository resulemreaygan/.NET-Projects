using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
         
            try
            {
                Console.WriteLine("İki sayi giriniz :");
                int bolunen = Convert.ToInt32(Console.ReadLine());
                int bolen = Convert.ToInt32(Console.ReadLine());
                int bolum = bolunen / bolen;
                Console.WriteLine("{0}", bolum);
            }

            catch (FormatException)// bosluk yada string girdiginde olusur
            {
                Console.WriteLine("Sayi giriniz !!");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Adam gibi sayi gir !");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Bolenler 0 olamaz !");
            }
            catch
            {
                Console.WriteLine("Diger hatalar");
            }

            finally
            {
                Console.WriteLine("Try veya Catch farketmez benden kacamazsın ! ");
            }
            Console.ReadKey();
        }
    }
}
