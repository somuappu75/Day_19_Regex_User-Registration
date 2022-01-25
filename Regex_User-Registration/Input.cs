using System;
using System.Collections.Generic;
using System.Text;

namespace Regex_User_Registration
{
    class Input
    {
        public static string[] inputName()
        {
            string[] name = new string[2];
            Console.Write("Enter Name : ");
            var nameString = Console.ReadLine();
            name = nameString.Split(" ");
            return name;

        }
        public static string inputEmail() // method to take email from user
        {
            Console.Write("Enter email : ");
            return Console.ReadLine();
        }
        public static string inputNumber() // method to take number from user
        {
            Console.Write("Enter number with country code : ");
            return Console.ReadLine();
        }
    }
}
