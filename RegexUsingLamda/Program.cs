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

            Console.Write("\n Enter First Name : ");
            string firstName = Convert.ToString(Console.ReadLine());

            if (RegexValidation.ValidatingFirstName(firstName))
            {
                Console.WriteLine($"{firstName} Is Valid");
            }
            else
            {
                Console.WriteLine($"{firstName} Is Not Valid");
            }
            Console.ReadLine();
        }
    }
}
