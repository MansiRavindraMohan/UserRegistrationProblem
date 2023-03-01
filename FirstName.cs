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
        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2,}$";

        public bool validateFirstName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
    }
}
      
