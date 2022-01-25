using System;
using System.Text.RegularExpressions;

namespace Regex_User_Registration
{
    class UserRegister:Validator
    {
        public void ValidateFirstName(string firstName)
        {
            var expr = @"^[A-Z]{1}[a-z]{2,}$";
            var match = Regex.Match(firstName, expr, RegexOptions.None);
            if (match.Success)
                Console.WriteLine("Valid First Name");
            else
                Console.WriteLine("Invalid First Name");

        }

        static void Main(string[] args)
        {
            UserRegister user = new UserRegister();

            string firstName = Input.inputName(); // taking first name from user
            user.ValidateFirstName(firstName); // validating first name
        }
    }
}
