using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_User_Registration
{
        public class RegexSample
        {
            string pattern = "^[A-Za-z]{2,}$";


            public void Validating()
            {
                Console.WriteLine("--------------------------");
                Regex regex = new Regex(pattern);
                Console.WriteLine("--------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Validating The First Name");
                Console.WriteLine("Enter the first name : ");
                string input = Console.ReadLine();
                ValidatingFirstName(input);
                Console.WriteLine("--------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Validating The Last Name");
                Console.WriteLine("Enter the last name : ");
                string input1 = Console.ReadLine();
                ValidatingLastName(input1);
                Console.WriteLine("--------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Validating The Email Id");
                Console.WriteLine("Enter Email Id");
                string input2 = Console.ReadLine();
                

            }



            public static string ValidatingFirstName(string firstName)
            {
                Regex regex = new Regex("^[A-Z][a-z]{2,}$");
                bool res = regex.IsMatch(firstName);
                try
                {
                    if (firstName.Equals(""))
                    {
                        throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "First name should not be empty");
                    }
                    if (firstName.Equals(null))
                    {
                        throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                    }
                    if (res)
                    {
                        Console.WriteLine("Valid");
                        return firstName;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "First should be valid"); throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "First should be valid");
                    }

                }
                catch (NullReferenceException ex)
                {
                    return ex.Message;

                }
            }
            public static string ValidatingLastName(string lastName)
            {
                string pattern = "^[A-Z][a-z]{2,}$";
                Regex regex = new Regex(pattern);
                bool res1 = regex.IsMatch(lastName);
                try
                {
                    if (lastName.Equals(""))
                    {
                        throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Last name should not be empty");
                    }
                    if (lastName.Equals(null))
                    {
                        throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                    }
                    if (res1)
                    {
                        Console.WriteLine("Valid");
                        return lastName;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Last name should be valid");
                    }
                    //return default;
                }
                catch (NullReferenceException ex)
                {
                    return ex.Message;
                }

            }

        }
    }


    

