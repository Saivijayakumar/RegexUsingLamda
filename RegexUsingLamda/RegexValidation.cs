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
        public static bool ValidatingFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName,FIRSTNAME))
                return true;
            else
                throw new InvalidCustomException(InvalidCustomException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
        }
        public static bool ValidatingLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LASTNAME))
                return true;
            else
                throw new InvalidCustomException(InvalidCustomException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
        }
        public static bool ValidatingEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
                return true;
            else
                throw new InvalidCustomException(InvalidCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        }
        public static bool ValidatingMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILENUMBER))
                return true;
            else
                throw new InvalidCustomException(InvalidCustomException.ExceptionType.INVALID_MOBILENUMBER, "Invalid Mobile Number");
        }
        public static bool ValidatingPassword(string password)
        {
            if (Regex.IsMatch(password, PASSWORD))
                return true;
            else
                throw new InvalidCustomException(InvalidCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }
    }
}
