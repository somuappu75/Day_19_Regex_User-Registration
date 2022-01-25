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
        public string validateEmail(string email)
        {
            var expr = @"^abc((\.[A-Z]+[a-z]*[0-9]*)|(\.[A-Z]*[a-z]+[0-9]*)|(\.[A-Z]*[a-z]*[0-9]+)?)?@bl\.co(\.[a-z]{2,})?$";
            var match = Regex.Match(email, expr, RegexOptions.None);
            if (match.Success)
                return "valid";
            else
                return "invalid";
        }

        public string validateNumber(string number)
        {
            var expr = @"^([0-9]{2}[ ]{1}[0-9]{10})$";
            var match = Regex.Match(number, expr, RegexOptions.None);
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

            string email = Input.inputEmail(); // taking email form user
            Console.WriteLine($"Email {user.validateEmail(email)}"); // validating email

            string number = Input.inputNumber(); // taking number from user
            Console.WriteLine($"Number {user.validateNumber(number)}"); // validating number

        }

    }
}
