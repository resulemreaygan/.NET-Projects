using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1StatikDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler = new string[5] { "ahmet", "mehmet", "ahmet", "ahmet", "ahmet" };
            string[] ogrenciler2 = new string[] {"ahmet", "mehmet", "ayse", "ahmet", "ahmet"};
            string[] ogrenciler3 = {"ahmet", "mehmet", "ayse", "ahmet", "ahmet"};

            Console.WriteLine("Siralamadan once");

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write("{0}    ", ogrenciler[i]);
            }

            Array.Sort(ogrenciler);

            Console.WriteLine("Siralamadan sonra ");

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write("{0}    ", ogrenciler[i]);
            }

            string aranan = "ahmet";

           /* foreach (string a in ogrenciler)
            {
                if (a == aranan)
                {
                    Console.WriteLine("Bulundu.");
                }
            }

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                string a = ogrenciler[i];
                if (a == aranan)
                {
                    Console.WriteLine("Bulundu.");
                }
            } */

            int bulunanIndis = Array.IndexOf(ogrenciler, aranan);

            Console.WriteLine("indis {0}", bulunanIndis);

            int sonIndis = Array.LastIndexOf(ogrenciler, aranan);

            Console.WriteLine("Son indis {0}", sonIndis, aranan);

            int binaryIndis = Array.BinarySearch(ogrenciler, aranan); // Dizinin orta elemana denk gelenin indisini göderir

            //Dizinin sıralı olduğunu biliyorsak binary search kullanabiliriz.

            Console.WriteLine("Binary search indis {0}", binaryIndis);

            /*int boyut = Convert.ToInt32(Console.ReadLine());

            //int[] dizi = new int[boyut];

            ArrayList dinamikDizi = new ArrayList();

            dinamikDizi.Add(3);
            dinamikDizi.Add("kedi");

            dinamikDizi.Insert(0, 3.12);

            dinamikDizi.InsertRange(4, ogrenciler);

            ArrayList dinamikDizi2 = new ArrayList();

            dinamikDizi2.Add(3);
            dinamikDizi2.Add(4);


            dinamikDizi2.Remove("Ayse");

            dinamikDizi2.RemoveAt(2);

            dinamikDizi2.RemoveRange(2, 5);

            int eklenenElemanSayisi = dinamikDizi.Count;

            int kapasite = dinamikDizi.Capacity; */

            

            Console.ReadKey();
        }
    }
}
