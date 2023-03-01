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
        public const string Regex_MobileNo = "^[0-9]{1,2}[ ][0-9]{10}$";
        public bool ValidateMobileNumber(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, Regex_MobileNo);
        }
    }
}
      
