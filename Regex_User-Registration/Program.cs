using System;
using System.Text.RegularExpressions;

namespace Regex_User_Registration
{
    class UserRegister:Validator
    {
        public string validateName(string firstName)
        {
            var expr = @"^[A-Z]{1}[a-z]{2,}$";
            var match = Regex.Match(firstName, expr, RegexOptions.None);
            if (match.Success)
                return "valid";
            else
                return "invalid";
        }

        static void Main(string[] args)
        {
            UserRegister user = new UserRegister();

            string[] name = Input.inputName(); // taking name from user
            string firstName = name[0]; // first name
            Console.WriteLine($"First name {user.validateName(firstName)}"); // validating first name
            string lastName = name[1]; // last name
            Console.WriteLine($"Last name {user.validateName(lastName)}"); // validating last name
        }

    }
}
