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
                Console.WriteLine("entered first name is valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Enteredfirst  name is Invalid\n please give first character in capital and minimum 3 characters name");
            }
            return firstName;
        };
        public static Func<string, string> CheckLastName = (lName) =>
        {
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(lName, pattern))
            {
                Console.WriteLine("entered Last name is valid");
                return lName;
            }
            else
            {
                Console.WriteLine("Entered Last name is Invalid\n please give first character in capital and minimum 3 characters name");
            }
            return lName;
        };
        public static Func<string, string> CheckEmail = (email) =>
        {
            string pattern = "^[a-zA-Z0-9]{3,}([._+-][0-9a-zA-Z]{2,})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("entered email is valid");
                Nlog.SuccessLog("Entered mail is valid  " + email);
                return email;
            }
            else
            {
                Console.WriteLine("Entered email is Invalid");
                Nlog.ErrorInfo("Entered mail not valid  " + email);
            }
            return email;
        };
        public static Func<string, string> CheckMobileNumber = (mobileNumber) =>
        {
            string pattern = "^91[ ][1-9][0-9]{9}$";
            if(Regex.IsMatch(mobileNumber, pattern))
            {
                Console.WriteLine("Mobile number is valid");
                Nlog.SuccessLog("Entered mobile number is valid  " + mobileNumber);
                return mobileNumber;
            }
            else
            {
                Console.WriteLine("Entered mobile number is invalid");
                Nlog.ErrorInfo("Entered mobile number is invalid  " + mobileNumber);
                return mobileNumber;
            }
        };
        public static Func<string, string> CheckPassword = (password) =>
        {
            string pattern = "^(?=.*[A-Z])(?=.*[\\d])(?=.*[\\W_])[a-zA-Z0-9\\[~!\\.@_#\\$%^\\/&*()+\\-{}:\"<>?\\]]{8,}$";
            if( Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Entered password is valid");
                Nlog.SuccessLog("Entered password valid  "+password);
                return password;
            }
            else
            {
                Console.WriteLine("Entered password Invalid");
                Nlog.ErrorInfo("Entered password Invalid  " + password);
                return password;
            }
        };
    }
}
