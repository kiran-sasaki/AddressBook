﻿namespace AddressBookProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Problem");
            Person person = new Person();
            while (true)
            {
                Console.WriteLine("Please enter a command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Entered Command is "+command);

                if (command == "add")
                {
                    Person.AddPerson();
                }
                if(command == "view")
                {
                    Person.listPerson();
                }
                if (command == "edit")
                {
                    Person.EditPerson();
                }
                if(command == "delete")
                {
                    Person.DeleteContact();                
                }
            }
        }
    }
}
