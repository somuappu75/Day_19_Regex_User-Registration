using System;
using System.Collections.Generic;
using System.Text;

namespace Regex_User_Registration
{
    interface Validator
    {
        string checkMatch(string exp, string stringToCheck);
        string validateName(string firstName);
        string validateEmail(string email);
        string validateNumber(string number);
        string validatePassword(string password);
    }
}
