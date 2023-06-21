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

            Console.WriteLine("Enter your PhoneNumber");
            string PhoneNumber=Console.ReadLine();

            Func<string, bool> validatePhoneNumber = (name) =>
            {
                Regex pattern = new Regex(@"^91[6-9]{1}[0-9]{9}$");
                return pattern.IsMatch(PhoneNumber);
            };

            if(validatePhoneNumber(PhoneNumber) )
            {
                Console.WriteLine("Valid PhoneNumber");
            }
            else
            {
                Console.WriteLine("Not Valid PhoneNumber.");
            }
        }
    }
}
