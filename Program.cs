using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            FirstName FName = new FirstName();
            Console.WriteLine("Please enter the First name:");

            string firstName = Console.ReadLine();
            bool val = FName.validateFirstName(firstName);

            if (val)
            {
                Console.WriteLine("First name matched");
            }
            else
            {
                Console.WriteLine("First name not matched");
            }
        }
    }
}
