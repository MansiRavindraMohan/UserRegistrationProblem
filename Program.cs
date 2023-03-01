using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            FirstName LName = new FirstName();
            Console.WriteLine("Please enter the Last name:");

            string lastName = Console.ReadLine();
            bool val = LName.validateFirstName(lastName);

            if (val)
            {
                Console.WriteLine("Last name matched");
            }
            else
            {
                Console.WriteLine("Last name not matched");
            }
        }
    }
}
