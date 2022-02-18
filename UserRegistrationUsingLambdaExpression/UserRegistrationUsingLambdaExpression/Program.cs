using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingLambdaExpression
{
    public class Program
    {
        //Instance Variable
        public static string firstName,lastName;
        //Main Method i.e. Program execution start from here
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME to User Registration using Lambda Expression");
            Console.WriteLine("Choose an Option:\n 1. First Name\t2.Last Name\t3.exit");
            bool flag=true;
            int option=Convert.ToInt32(Console.ReadLine()); 
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter your first name (first lettershould be in capital format)");
                        firstName = Console.ReadLine();
                        RegexPattern.CheckFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last Name(first lettershould be in capital format)");
                        lastName = Console.ReadLine();
                        RegexPattern.CheckLastName(lastName);
                        break;
                    case 3:
                        flag = false;                   
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            
            
            Console.ReadLine();
        }
    }
}
