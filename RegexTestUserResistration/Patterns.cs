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
        /// <summary>
        /// Validating Regex patterns with Ms test
        /// uc1:First name
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public  bool FirstName(string firstName)
        {
            string regex = "^[A-Z]{1}[a-zA-z]{2,}$";
            bool result = Regex.IsMatch(firstName, regex);
            return result;
        }
        ///uc2:Last name
        public bool LastName(string lastName)
        {
            string regex = "^[A-Z]{1}[a-zA-z]{2,}$";
            bool result = Regex.IsMatch(lastName, regex);
            return result;
        }
    }
}
