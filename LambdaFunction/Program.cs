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


            Console.WriteLine("Enter your First name");
            string FirstName=Console.ReadLine();

            Func<string, bool> validateFirstName = (name) =>
            {
                Regex pattern = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
                return pattern.IsMatch(name);
            };

            if(validateFirstName(FirstName) )
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Not Valid First Name \t\nFirst name should start with a capital letter and have a minimum of 3 characters.");
            }
        }
    }
}
