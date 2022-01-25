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
    }
}
