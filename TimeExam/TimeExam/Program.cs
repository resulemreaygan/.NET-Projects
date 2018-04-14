using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Time t1 = new Time();
            t1.edit(-5, 4, 1900);
            t1.write();

            Time t2 = new Time();
            t2.edit();
            t2.write();

            Time t3 = new Time();
            t3.edit(1, 1, 2000);

            t2 = t3; // adress
            t2.edit(9, 9, 1909);
            t3.write();

            book b1 = new book();
            b1.name = "kıs bahcesi";

            book b2 = new book();
            b2.name = "alamut";

            b1 = b2; // içerik
            b2.name = "deneme";

            Console.WriteLine(b1.name);

            Time t4 = new Time(1, 2, 2003); */

            Time t1 = new Time();

            Time t2 = new Time(1, 2, 2012);

            Console.ReadKey();
        }
    }
    // class larda adresler kopyalanır struct lar da değerler kopyalanır.!
    struct book
    {
        public string name;
    }
}
