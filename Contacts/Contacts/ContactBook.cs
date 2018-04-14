using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class ContactBook
    {
        Person[] people = new Person[5];

        int added_Person = 0;

        public void addPerson(string name, string surname, string phone_number)
        {
            people[added_Person] = new Person();
            people[added_Person].name = name;
            people[added_Person].surname = surname;
            people[added_Person].phone_number = phone_number;
            added_Person++;
        }

        public void removePerson(string name, string surname)
        {
            int k = 0;

            bool j = false;

            for (int i = 0; (i < added_Person) && (j == false); i++)
            {
               if (people[i].name == name && people[i].surname == surname)
                {
                    k = i;
                    j = true;
                    
                }  
            }

            int l = 0;

            bool h = true;

            for (l = k; l < added_Person-1 && (h == true); l++)
            {
                if (l != added_Person)
                {
                    people[l].name = people[l + 1].name;
                    people[l].surname = people[l + 1].surname;
                    people[l].phone_number = people[l + 1].phone_number;
                }
                else
                    h = false;
            }

            added_Person--;
        }

        public void edit(string name, string surname)
        {
            bool j = false;

            for (int i = 0; (i < added_Person) && (j == false); i++)
            {
                if (people[i].name == name && people[i].surname == surname)
                {
                    Console.WriteLine("Please enter the new name :");
                    string editedName = Console.ReadLine();
                    Console.WriteLine("Please enter the new surname :");
                    string editedSurname = Console.ReadLine();
                    Console.WriteLine("Please enter the new phone number :");
                    string editedPhone_Number = Console.ReadLine();

                    people[i].name = editedName;
                    people[i].surname = editedSurname;
                    people[i].phone_number = editedPhone_Number;
                    j = true;
                }
                else
                {
                    Console.WriteLine("Wrong name and surname , please try again!!");
                    
                }
                i = 0;
                continue;
            }
        }

        public void List()
        {
            for (int i = 0; i < added_Person; i++)
            {
                Console.WriteLine("{0} {1} {2}", people[i].name, people[i].surname, people[i].phone_number);
            }
        }

        public string Search(string name, string surname)
        {
            string result = "";

            for (int i = 0; i < added_Person; i++)
            {
                if (people[i].name == name && people[i].surname == surname)
                {
                    result = people[i].phone_number;
                }
            }

            return result;
        }

    }
}
