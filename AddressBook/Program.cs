using System;
namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Adress Book Program");
            Contact contact = new Contact();
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
        }
    }
}