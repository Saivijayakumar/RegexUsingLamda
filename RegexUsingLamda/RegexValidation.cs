using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUsingLamda
{
    public class RegexValidation
    {
        public const string FIRSTNAME = @"^[A-Z]{1}[a-z]{2,}";
        public const string LASTNAME = @"^[A-Z]{1}[a-z]{2,}";
        public const string EMAIL = @"^abc([+. \-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2,3})?$";
        public const string MOBILENUMBER = @"^[1-9]{2}[ ][0-9]{10}$";
        public const string PASSWORD = @"^[a-z]*[A-Z][a-z]*.[a-z]*[0-9][a-z]*$";
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
        public static bool ValidatingMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILENUMBER);
        }
        public static bool ValidatingPassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD);
        }
    }
}
