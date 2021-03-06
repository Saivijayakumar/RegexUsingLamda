using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUsingLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Regex Problems");

            Console.Write("\nEnter First Name : ");
            string firstName = Console.ReadLine();

            if (RegexValidation.ValidatingFirstName(firstName))
            {
                Console.WriteLine($"{firstName} Is Valid");
            }
            else
            {
                Console.WriteLine($"{firstName} Is Not Valid");
            }

            Console.Write("\nEnter Last Name : ");
            string lastName = Console.ReadLine();

            if (RegexValidation.ValidatingLastName(lastName))
            {
                Console.WriteLine($"{lastName} Is Valid");
            }
            else
            {
                Console.WriteLine($"{lastName} Is Not Valid");
            }

            Console.Write("\nEnter Email Address : ");
            string email = Console.ReadLine();

            if (RegexValidation.ValidatingEmail(email))
            {
                Console.WriteLine($"{email} Is Valid");
            }
            else
            {
                Console.WriteLine($"{email} Is Not Valid");
            }

            Console.Write("\nEnter Mobile Number : ");
            string mobileNumber = Console.ReadLine();

            if (RegexValidation.ValidatingMobileNumber(mobileNumber))
            {
                Console.WriteLine($"{mobileNumber} Is Valid");
            }
            else
            {
                Console.WriteLine($"{mobileNumber} Is Not Valid");
            }

            Console.Write("\nEnter Password : ");
            string password = Console.ReadLine();

            if (RegexValidation.ValidatingPassword(password))
            {
                Console.WriteLine($"{password} Is Valid");
            }
            else
            {
                Console.WriteLine($"{password} Is Not Valid");
            }
            Console.ReadLine();
        }
    }
}
