using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class FirstName
    {
        public const string Regex_Email = "^[a-zA-Z0-9]+([._#][a-zA-Z0-9]+)*[@][a-zA-Z]+[.][A-Za-z]{2,}([.][a-z]{2})?$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
      
