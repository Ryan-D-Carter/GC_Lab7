using System;
using System.Text.RegularExpressions;

namespace GC_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateName();

            ValidateEmail();

            ValidatePhoneNumber();

            ValidateDate();

            ValidateHTML();
        }

        public static void ValidateName()
        {
            Console.WriteLine("Please enter a valid Name:");

            string nameInput = Console.ReadLine();

            string nameKey = @"^[A-Z][A-z]{1,30}$";

            if (Regex.IsMatch(nameInput, nameKey))
            {
                Console.WriteLine($"Hello, {nameInput}!");
            }
            else
                Console.WriteLine("Sorry, name is not valid!");
        }

        public static void ValidateEmail()
        {
            Console.WriteLine($"Please enter your email \n(eg.James@james.com)");
            string email = Console.ReadLine();

            string emailKey = @"^[A-z0-9]{5,30}@[A-z0-9]{5,10}\.[A-z]{1,3}$$";

            if (Regex.IsMatch(email, emailKey))
            {
                Console.WriteLine($"Email is valid!");
            }
            else
                Console.WriteLine("Sorry, that is not a valid email.");
        }

        public static void ValidatePhoneNumber()
        {
            Console.WriteLine($"Please enter your phone number \n(eg.123-456-7890)");
            string phone = Console.ReadLine();

            string phoneKey = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";

            if (Regex.IsMatch(phone, phoneKey))
            {
                Console.WriteLine($"Phone number is valid!");
            }
            else
                Console.WriteLine("Sorry, that is not a valid phone number.");
        }

        public static void ValidateDate()
        {
            Console.WriteLine($"Please enter a valid date \n(eg.01/01/2021)");
            string date = Console.ReadLine();

            string dateKey = @"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}$";

            if (Regex.IsMatch(date, dateKey))
            {
                Console.WriteLine($"This date is valid!");
            }
            else
                Console.WriteLine("Sorry, that is not a valid date.");
        }

        public static void ValidateHTML()
        {
            Console.WriteLine($"Please enter an HTML element \n(eg <p>Hello world</p>)");
            string htmlElement = Console.ReadLine();

            string htmlKey = @"^<[a-z]{1,10}[0-9]?>.*<\/[a-z]{1,10}[0-9]?>$";

            if (Regex.IsMatch(htmlElement, htmlKey))
            {
                Console.WriteLine($"This element is valid!");
            }
            else
                Console.WriteLine("Sorry, that is not a valid element.");
        }
    }
}
