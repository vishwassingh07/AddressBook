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
        Contact contact = new Contact();
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


            addressBook.Add(contact1);
            addressBook.Add(contact2);

        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
            Display();
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
        public void EditContact()
        {
            string name = Console.ReadLine();

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
        public void DeleteTheContact()
        {
            string name = Console.ReadLine();
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
    }


    
}
