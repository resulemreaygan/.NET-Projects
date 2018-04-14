using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ListYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dinamikDizi = new List<string>();
            dinamikDizi.Add("fatma");
            dinamikDizi.Add("Ahmet");
            dinamikDizi.Add("ali");
            dinamikDizi.Add("veli");
            dinamikDizi.Add("mehmet");
            dinamikDizi.Add("mehmet");

            List<string> sonuclar = new List<string>();

            for (int i = 0; i < dinamikDizi.Count; i++)
            {
                if ( dinamikDizi[i].StartsWith("a"))
                {
                    sonuclar.Add(dinamikDizi[i]);
                }
            }

            //sonuclar = dinamikDizi.FindAll(x => x.StartsWith("a"));
            //Console.WriteLine(sonuclar);

            //for (int i = 0; i < sonuclar.Count; i++)
            //{
            //    Console.WriteLine(sonuclar[i]);
            //}

            dinamikDizi.RemoveAll(y => y.Contains("li"));

            for(int i = 0; i < dinamikDizi.Count; i++)
            {
                Console.WriteLine(dinamikDizi[i]);
            }

            /*
            for (int i = 0; i < dinamikDizi.Count; i++)
            {
                if (dinamikDizi[i] == "mehmet")
                {
                    
                }
            }

            /*for (int i = 0; i < dinamikDizi.Count; i++)
            {
                if (dinamikDizi[i] == "mehmet")
                {
                    dinamikDizi.RemoveAt(i);
                }
            }*/
            /*
            dinamikDizi.RemoveAll(x => x == "mehmet");
            for (int i = 0; i < dinamikDizi.Count; i++)
            {
                Console.WriteLine(dinamikDizi[i]);
            }

            */

            Console.ReadKey();
        }
    }
}
