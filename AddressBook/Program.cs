using System;
namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Adress Book Program :");
            bool end = true;
            Console.WriteLine("1. Add Contact\n2. Add Contact To Adress Book\n3. Edit A Contact\n4. Delete Contact\n5." +
                "Add Dictionary\n6. Edit Dictioary\n7. Delete Dictionary\n8.  End Program ");
            Contact contact = new Contact();
   
            AddressBookMain addContact = new AddressBookMain();
           
            while (end)
            {
                Console.WriteLine("Choose program to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addContact.Display();
                        break;
                    case 2:
                        addContact.AddContactToAddressBook(contact);
                        break;
                    case 3:
                        string name = Console.ReadLine();
                        addContact.EditContact(name);
                        break;
                    case 4:
                        string name2 = Console.ReadLine();
                        addContact.DeleteTheContact(name2);
                        break;
                    case 5:
                        addContact.AddContactToAddressBook(contact);
                        break;
                    case 6:
                        string name3 = Console.ReadLine();
                        string contactName = Console.ReadLine();
                        addContact.EditDictionary(name3 , contactName);
                        break;
                    case 7:
                        string name4 = Console.ReadLine();
                        string contactName2 = Console.ReadLine();
                        addContact.DeleteFromDictionary(name4, contactName2);
                        break;
                    case 8:
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