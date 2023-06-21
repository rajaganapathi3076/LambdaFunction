using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LambdaFUnctionUC13");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your mobile number: ");
            string mobile = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Define lambda functions for validation
            Func<string, bool> validateFirstName = (name) =>
            {
                Regex pattern = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
                return pattern.IsMatch(name);
            };

            Func<string, bool> validateLastName = (name) =>
            {
                Regex pattern = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
                return pattern.IsMatch(name);
            };

            Func<string, bool> validateEmail = (Email) =>
            {
                Regex pattern = new Regex(@"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*\.(?:[a-zA-Z]{2,})$");
                return pattern.IsMatch(email);
            };

            Func<string, bool> validateMobile = (Mobile) =>
            {
                Regex pattern = new Regex(@"^91[6-9]{1}[0-9]{9}$");
                return pattern.IsMatch(mobile);
            };

            Func<string, bool> validatePassword = (Password) =>
            {
                Regex pattern = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$");
                return pattern.IsMatch(password);
            };

            // Check if the entered details are valid using lambda functions
            if (validateFirstName(firstName) &&
                validateLastName(lastName) &&
                validateEmail(email) &&
                validateMobile(mobile) &&
                validatePassword(password))
            {
                Console.WriteLine("Valid details!");
            }
            else
            {
                Console.WriteLine("Invalid details! Please check your input.");
            }
        }
    }
}
