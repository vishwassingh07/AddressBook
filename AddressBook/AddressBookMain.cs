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
        public void EditContact(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter option to update : ");
                }
            }
        }


    }
}
