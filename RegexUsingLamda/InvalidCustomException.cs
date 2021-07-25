using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUsingLamda
{
    public class InvalidCustomException:Exception
    {
        public enum ExceptionType
        {
            INVALID_EMAIL, INVALID_PASSWORD,INVALID_LASTNAME,INVALID_FIRSTNAME,INVALID_MOBILENUMBER
        }
        ExceptionType type;
        public InvalidCustomException(ExceptionType type , string message ): base(message)
        {
            this.type = type;
        }
    }
}
