using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("********** MENU **********");
            Console.WriteLine("**************************");

            ContactBook myBook = new ContactBook();
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter the name :");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the surname :");
                string surname = Console.ReadLine();
                Console.WriteLine("Please enter the phone number :");
                string phone_number = Console.ReadLine();

                myBook.addPerson(name, surname, phone_number);
            }

            myBook.List();

            Console.WriteLine("SEARCH");
            Console.WriteLine("Enter the name :");
            string searched_name = Console.ReadLine();
            Console.WriteLine("Enter the surname :");
            string searched_surname = Console.ReadLine();
            string searched_phone_number = myBook.Search(searched_name, searched_surname);

            if (searched_phone_number == "")
            {
                Console.WriteLine("404 NOT FOUND");
            }
            else
                Console.WriteLine("Phone Number :{0}", searched_phone_number);

            Console.WriteLine("DELETE CONTACT");

            Console.WriteLine("Please enter the name :");
            string removeName = Console.ReadLine();
            Console.WriteLine("Please enter the surname :");
            string removeSurname = Console.ReadLine();

            myBook.removePerson(removeName, removeSurname);

            Console.WriteLine("Deleted :" + removeName + " " + removeSurname);

            myBook.List();

            Console.WriteLine("EDIT CONTACT");

            Console.WriteLine("Please enter the name :");
            string editName = Console.ReadLine();
            Console.WriteLine("Please enter the surname :");
            string editSurname = Console.ReadLine();

            myBook.edit(editName, editSurname);

            Console.WriteLine("Your information edited.");

            myBook.List();

            Console.ReadKey();
        }
    }
}
