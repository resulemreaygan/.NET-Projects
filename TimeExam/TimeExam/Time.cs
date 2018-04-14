using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeExam
{
    class Time
    {
        int day;
        int month;
        int year;

        // yapıcı metot(constructor) nesne oluşturulurken
        // calışması istenen metıtıları içeren bir metotdur.
        //sinif ismi ile ayni isimdedir.
        //metotlardan farklı olarak dönüş tipleri yoktur
        //public yada private olabilirler.
        // static yada non static olabilirler.


        public Time(int d, int m, int y)
        {
            Console.WriteLine("parametreli calıstı");
            edit(d, m, y);
        }

        public Time()
        {
            Console.WriteLine("parametresiz olan calisti");
            edit(1, 1, 1900);
            write();
        }

        // Constr. larında overloadı yazılabilir.

        public void edit(int d, int m, int y)
        {
            if (d < 1 || d > 31)
            {
                day = 1;
            }
            else
                day = d;
            if (m < 1 || m > 12)
            {
                month = 1;
            }
            else
                month = m;
            
            year = y;
        }

        public void edit()
        {
            day = DateTime.Now.Day;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;

        }

        public void write()
        {
            Console.WriteLine("{0}-{1}-{2}",day ,month, year);
        }
    }
}
