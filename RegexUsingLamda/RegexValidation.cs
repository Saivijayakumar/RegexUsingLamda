using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUsingLamda
{
    class RegexValidation
    {
        public const string FIRSTNAME = @"^[A-Z]{1}[a-z]{2,}";
        public const string LASTNAME = @"^[A-Z]{1}[a-z]{2,}";
        public const string EMAIL = @"^abc([+. \-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2,3})?$";
        public static bool ValidatingFirstName(string lirstName)
        {
            return Regex.IsMatch(lirstName, FIRSTNAME);
        }
        public static bool ValidatingLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LASTNAME);
        }
        public static bool ValidatingEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL);
        }
    }
}
