using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class LibraryBook
    {
        User[] entry = new User[100];

        int added_Entry = 0;

        public void List()
        {
            for (int i = 0; i < added_Entry; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", entry[i].name, entry[i].surname, entry[i].studentNumber, entry[i].bookName);
            }
        }

        public void addEntry(string name, string surname, string studentNumber, string bookName)
        {
            entry[added_Entry] = new User();
            entry[added_Entry].name = name;
            entry[added_Entry].surname = surname;
            entry[added_Entry].studentNumber = studentNumber;
            entry[added_Entry].bookName = bookName;
            added_Entry++;
        }

        public void deleteEntry(string bookName)
        {
            int k = 0;

            bool j = false;

            for (int i = 0; (i < added_Entry) && (j == false); i++)
            {
                if (entry[i].bookName == bookName)
                {
                    k = i;
                    j = true;
                }
            }

            int l = 0;

            bool h = true;

            for (l = k; l < added_Entry - 1 && (h == true); l++)
            {
                if (l != added_Entry)
                {
                    entry[l].name = entry[l + 1].name;
                    entry[l].surname = entry[l + 1].surname;
                    entry[l].studentNumber = entry[l + 1].studentNumber;
                    entry[l].bookName = entry[l + 1].bookName;
                }
                else
                    h = false;
            }
            added_Entry--;
            Console.WriteLine("Deleted");
        }

        public void searchEntry(string studentNumber)
        {
            for (int i = 0; i < added_Entry; i++)
            {
                if (entry[i].bookName == studentNumber)
                {
                    Console.WriteLine(entry[i].name);
                    Console.WriteLine(entry[i].surname);
                    Console.WriteLine(entry[i].studentNumber);
                    Console.WriteLine(entry[i].bookName);
                }
            }
        }
    }
}
