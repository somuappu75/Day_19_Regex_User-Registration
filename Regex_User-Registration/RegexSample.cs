using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration
{
 public    class RegexSample
    {

        public static string ValidatingFirstName(string firstName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            bool res = regex.IsMatch(firstName);
            if (res)
            {
                Console.WriteLine("Valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }
    }
}
