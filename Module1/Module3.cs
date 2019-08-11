using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Module3
    {
        public static void Main()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            // Code to finish getting the rest of the student data
            Console.WriteLine("Enter the student's birthdate: ");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Enter your addressline: ");
            string addressline = Console.ReadLine();
            Console.WriteLine("Enter your city ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your zip: ");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter your country: ");
            string country = Console.ReadLine();
            Console.WriteLine($"{firstName}, {lastName}, {birthDate}, {addressline}, {city}, {state}, {zip}, {country}");
        }
    }
}
