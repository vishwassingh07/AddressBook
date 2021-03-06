using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
        public AddressBookMain()
        {
            Contact contact1 = new Contact()
            {
                FirstName = "Vishwas",
                LastName = "Singh Baghel",
                Address = "Shakti Bhawan Jabalpur",
                City = "Jabalpur",
                State = "Madhya Pradesh",
                Zip = "480661",
                PhoneNumber = "9424777313",
                Email = "baghel.vishwas0@gmail.com"

            };
            Contact contact2 = new Contact()
            {
                FirstName = "Vivek",
                LastName = "Singh Baghel",
                Address = "Andheri East",
                City = "Mumbai",
                State = "Maharashtra",
                Zip = "480661",
                PhoneNumber = "9424777312",
                Email = "viveksingh@gmail.com"
            };
            Console.WriteLine("Enter the details\n FirstName\n LastName\n Address\n City\n State\n Email\n postalCode\n mobile Number");
            Contact contact3 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Console.ReadLine(),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine()
            };

            addressBook.Add(contact1);
            addressBook.Add(contact2);
            addressBook.Add(contact3);

        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine("FirstName: " + contact.FirstName + "\nLastName: " + contact.LastName +
                    "\nAddress : " + contact.Address + "\nState : " + contact.State + "\nEMail : " + contact.Email +
                    "\nMobile : " + contact.PhoneNumber + "\nZIPCode : " + contact.Zip + ".");
            }
        }
        public void EditContact(string name)
        {

            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter option to update : 1. Last Name\n2. Address\n3. City\n4. State\n5. Zip\n6. Phone Number\n7. Email\n8. Exit ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string lastName = Console.ReadLine();
                            contact.LastName = lastName;
                            break;
                        case 2:
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 3:
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 4:
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 5:
                            string zipcode = Console.ReadLine();
                            contact.Zip = zipcode;
                            break;
                        case 6:
                            string phoneNumber = Console.ReadLine();
                            contact.PhoneNumber = phoneNumber;
                            break;
                        case 7:
                            string mailId = Console.ReadLine();
                            contact.Email = mailId;
                            break;
                        case 8:
                            Console.WriteLine("you chose not to edit the contact");
                            break;
                    }
                }
                Display();

            }
        }
        public void DeleteTheContact(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
        }
        public bool NameExists(string name)
        {
            foreach (var data in dict.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public void AddDictionary(string name)
        {
            Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
            if (dict == null)
            {
                dict.Add(name, addressBook);
            }
            if (NameExists(name)== false)
            {
                dict.Add(name, addressBook);
            }
        }
        public void EditDictionary(string name , string contactName)
        {
            foreach(var data in dict)
            {
                if (dict.Keys.Equals(name))
                {
                    addressBook = data.Value;
                    EditContact(contactName);
                }
            }
        }
        public void DeleteFromDictionary(string name, string contactName)
        {
            foreach(var data in dict)
            {
                if (data.Key.Equals(name))
                {
                    addressBook = data.Value;
                    DeleteTheContact(contactName);
                }
            }
            dict.Remove(name);
        }
    }


    
}
