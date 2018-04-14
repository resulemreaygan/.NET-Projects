using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k=2;
            string[] name = new string[10];
            int[] mark = new int[10];
            double avarage = 0;

            for (i = 0; i < k; i++)
            {
                Console.WriteLine("Name and Mark");
                name[i] = Console.ReadLine();
                mark[i]  = Convert.ToInt32(Console.ReadLine());
                avarage = avarage + mark[i];
            }


            for (int h = 0; h < k; h++)
            {
                Console.WriteLine(name[h] + "---" + mark[h]);
            }

            for (j = 0; j < k; j++)
            {
                string condition;
                if (mark[j] >= (avarage/k))
                {
                    condition = "pass";
                }
                else
                    condition = "lose";

                Console.WriteLine("Name : {0} Mark : {1} Avarage : {2} Condition {3}", name[j], mark[j], avarage, condition);
            }

            Console.ReadKey();
        }
    }
}
