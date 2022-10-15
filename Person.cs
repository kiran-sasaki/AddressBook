﻿using System;
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
        public static void listPerson()
        {
            foreach (var data in contacts)
            {
                Console.WriteLine(data.Firstname);
                Console.WriteLine(data.Lastname);
                Console.WriteLine(data.Phonenumber);
                Console.WriteLine(data.City);
                Console.WriteLine(data.Zipcode);

            }
        }
        public static void EditPerson()
        {
            Console.Write("enter the name to edit: ");
            string editname = Console.ReadLine();
            foreach (var data in contacts)
            {
                if (contacts.Contains(data))
                {
                    if (data.Firstname == editname)
                    {
                        Console.Write("enter the Phone number: ");
                        data.Phonenumber = long.Parse(Console.ReadLine());

                        Console.Write("Enter the zipcode: ");
                        data.Zipcode = int.Parse(Console.ReadLine());

                        Console.Write("Enter the city: ");
                        data.City = Console.ReadLine();
                    }
                }
            }
        }
        public static void DeleteContact()
        {
            Console.Write("enter the name to delete: ");
            string personName = Console.ReadLine();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Firstname == personName)
                {
                    Console.WriteLine("Record Of {0} Deleted Successfully", contacts[i].Firstname);
                    contacts.RemoveAt(i);
                }
            }
        }
        public static void MultipleContacts()
        {
            Console.WriteLine("Enter The Number of Contacts To Add");
            int A = int.Parse(Console.ReadLine());
            while(A > 0)
            {
                AddPerson();
                A--;
            }
        }
    }
}

