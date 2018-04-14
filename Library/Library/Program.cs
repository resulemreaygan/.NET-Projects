using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("WELCOME TO LIBRARY");

            LibraryBook entryBook = new LibraryBook();

            do
            {
                Console.WriteLine("******** MENU ********");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("* 1)Entry List       *");
                Console.WriteLine("* 2)Add New Entry    *");
                Console.WriteLine("* 3)Delete Entry     *");
                Console.WriteLine("* 4)Search Entry     *");
                Console.WriteLine("* 0)Quit             *");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("**********************");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        entryBook.List();
                        break;
                    case 2:
                        Console.WriteLine("Please enter the name : ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Please enter the surname : ");
                        string newSurname = Console.ReadLine();
                        Console.WriteLine("Please enter the student number : ");
                        string newStudentNumber = Console.ReadLine();
                        Console.WriteLine("Please enter the book name : ");
                        string newBookName = Console.ReadLine();

                        entryBook.addEntry(newName, newSurname, newStudentNumber, newBookName);

                        break;
                    case 3:
                        Console.WriteLine("Please enter the book's name :");
                        string dBookName = Console.ReadLine();

                        entryBook.deleteEntry(dBookName);

                        break;
                    case 4:
                        Console.WriteLine("Please enter the student number :");
                        string sStudentNumber = Console.ReadLine();

                        entryBook.searchEntry(sStudentNumber);

                        break;
                    default:
                        break;
                }
            }
            while (menu != 0);

        }
    }
}
