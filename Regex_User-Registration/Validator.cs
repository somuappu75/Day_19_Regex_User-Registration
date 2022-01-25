using System;
using System.Collections.Generic;
using System.Text;

namespace Regex_User_Registration
{
    interface Validator
    {
        string validateName(string firstName);
        string validateEmail(string email);
    }
}
