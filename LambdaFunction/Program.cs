using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UserRegister In LambdaFunction UC2");

            Console.WriteLine("Enter your Last name");
            string LastName=Console.ReadLine();

            Func<string, bool> validateLastName = (name) =>
            {
                Regex pattern = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
                return pattern.IsMatch(name);
            };

            if(validateLastName(LastName) )
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Not Valid Last Name \t\nFirst name should start with a capital letter and have a minimum of 3 characters.");
            }
        }
    }
}
