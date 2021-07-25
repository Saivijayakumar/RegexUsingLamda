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
        public static bool ValidatingFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, FIRSTNAME);
        }

    }
}
