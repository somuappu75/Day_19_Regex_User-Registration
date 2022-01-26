using System;
using System.Collections.Generic;
using System.Text;

namespace Regex_User_Registration
{
   public  class Input
    {

        public static string inputFirstName() // method to take first name from user
        {
            Console.Write("Enter First name : ");
            return Console.ReadLine();
        }

        public static string inputLastName() // method to take last name from user
        {
            Console.Write("Enter Last name : ");
            return Console.ReadLine();
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

        public static string inputPassword() // method to take password from user
        {
            Console.Write("Enter password : ");
            return Console.ReadLine();
        }
    }
    }

