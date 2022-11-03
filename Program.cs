namespace AddressBookProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Problem");
            Person person = new Person();
            while (true)
            {
                Console.WriteLine("Enter number: \n 1. create new person \n 2. Display Data \n 3. Edit person Data \n 4. Delete Person Data \n 5. Add Multiple Contacts \n 6.Add With UniqueBookName \n 7.Search For Duplicate \n 8.Sreach By CityName");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Person.AddPerson();
                        break;
                    case 2:
                        Person.listPerson();
                        break;
                    case 3:
                        Person.EditPerson();
                        break;
                    case 4:
                        Person.DeleteContact();
                        break;
                    case 5:
                        Person.MultipleContacts();
                        break;
                    case 6:
                        person.NewUser();
                        break;
                    case 7:
                        person.DuplicateContact();
                        break;
                    case 8:
                        person.SearchPersonByCityAndState();
                        break;
                }
            }
        }
    }
}
