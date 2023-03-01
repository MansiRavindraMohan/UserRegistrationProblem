using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            FirstName PassWord = new FirstName();
            Console.WriteLine("Please enter the Password:");

            string Password = Console.ReadLine();
            bool val = PassWord.ValidatePassword(Password);

            if (val)
            {
                Console.WriteLine("Password matched");
            }
            else
            {
                Console.WriteLine("Password not matched");
            }
        }
    }
}
