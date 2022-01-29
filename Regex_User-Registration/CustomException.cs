using System;
using System.Collections.Generic;
using System.Text;

namespace Regex_User_Registration
{
   public  class CustomException:Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, INVALID_MESSAGE,NO_CONSTRUCTOR_FOUND, NO_SUCH_CLASS
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
