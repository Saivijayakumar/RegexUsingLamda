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
            string firstName = Convert.ToString(Console.ReadLine());

            if (RegexValidation.ValidatingFirstName(firstName))
            {
                Console.WriteLine($"{firstName} Is Valid");
            }
            else
            {
                Console.WriteLine($"{firstName} Is Not Valid");
            }

            Console.Write("\nEnter Last Name : ");
            string lastName = Convert.ToString(Console.ReadLine());

            if (RegexValidation.ValidatingLastName(lastName))
            {
                Console.WriteLine($"{lastName} Is Valid");
            }
            else
            {
                Console.WriteLine($"{lastName} Is Not Valid");
            }
            Console.ReadLine();
        }
    }
}
