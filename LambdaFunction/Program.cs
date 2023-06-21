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
            Console.WriteLine("Welcome to UserRegister In LambdaFunction UC3");

            Console.WriteLine("Enter your Email Id");
            string EmailId=Console.ReadLine();

            Func<string, bool> validateEmailId = (name) =>
            {
                Regex pattern = new Regex(@"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*\.(?:[a-zA-Z]{2,})$");
                return pattern.IsMatch(EmailId);
            };

            if(validateEmailId(EmailId) )
            {
                Console.WriteLine("Valid EmailId");
            }
            else
            {
                Console.WriteLine("Not Valid EmailId.");
            }
        }
    }
}
