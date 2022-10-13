using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public static class Person
    {
        public static void CreatePerson()
        {
            Console.Write("Enter First Name: ");
            string Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string Lastname = Console.ReadLine();

            Console.Write("enter the Phone number: ");
            long Phonenumber = long.Parse(Console.ReadLine());

            Console.Write("Enter the zipcode: ");
            int Zipcode = int.Parse(Console.ReadLine());

            Console.Write("Enter the city: ");
            string City = Console.ReadLine();
        }
    }
}
