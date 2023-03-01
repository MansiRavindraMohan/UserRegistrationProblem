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
        public const string Regex_Password = "^[A-Z]{1}[!@#$%^&*?<>0-9a-zA-Z]{7}$";
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }
    }
}
      
