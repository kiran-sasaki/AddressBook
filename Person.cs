using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Person
    {
        public static List<Contact> contacts = new List<Contact>();
        public static void AddPerson()
        {
            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.Lastname = Console.ReadLine();

            Console.Write("enter the Phone number: ");
            contact.Phonenumber = long.Parse(Console.ReadLine());

            Console.Write("Enter the zipcode: ");
            contact.Zipcode = int.Parse(Console.ReadLine());

            Console.Write("Enter the city: ");
            contact.City = Console.ReadLine();

            contacts.Add(contact);
        }
    }
}

