using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingLambdaExpression
{
    
    public class RegexPattern
    {
        public static Func<string, string> CheckFirstName = (firstName) =>
        {
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("entered name is valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Entered name is Invalid\n please give first character in capital and minimum 3 characters name");
            }
            return firstName;
        };
        public static Func<string, string> CheckLastName = (lName) =>
        {
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(lName, pattern))
            {
                Console.WriteLine("entered name is valid");
                return lName;
            }
            else
            {
                Console.WriteLine("Entered name is Invalid\n please give first character in capital and minimum 3 characters name");
            }
            return lName;
        };
    }
}
