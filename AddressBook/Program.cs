using System;
namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Adress Book Program");
            bool end = true;
            Console.WriteLine("1. Add Contact\n2. Add Contact To Adress Book\n3. End Program ");
            Contact contact = new Contact();
            AddressBookMain addContact = new AddressBookMain();
            while (end)
            {
                Console.WriteLine("Choose program to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addContact.CreateContact();
                        break;
                    case 2:
                        addContact.Display();
                        break;
                    case 3:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Choose the right option");
                        break;
                }
            }
            
        }
    }
}