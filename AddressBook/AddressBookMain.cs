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
        public void CreateContact()
        {
            Console.WriteLine("Enter Your First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Your Address : ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter Your City : ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter Your State : ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Your Zip Code : ");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Your Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Email : ");
            contact.Email = Console.ReadLine();
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



    }
}
