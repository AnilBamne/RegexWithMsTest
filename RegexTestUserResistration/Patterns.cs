using System;
using System.Text.RegularExpressions;

namespace RegexTestUserResistration
{
    public class Patterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Testing with Ms test");
        }

        public  bool FirstName(string firstName)
        {
            string regex = "^[A-Z]{1}[a-zA-z]{2,}$";
            bool result = Regex.IsMatch(firstName, regex);
            return result;
        }
    }
}
