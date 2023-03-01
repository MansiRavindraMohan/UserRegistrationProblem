using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            FirstName MobileNumber = new FirstName();
            Console.WriteLine("Please enter the mobile number:");

            string MobileNo = Console.ReadLine();
            bool val = MobileNumber.ValidateMobileNumber(MobileNo);

            if (val)
            {
                Console.WriteLine("Mobile number matched");
            }
            else
            {
                Console.WriteLine("Mobile number not matched");
            }
        }
    }
}
