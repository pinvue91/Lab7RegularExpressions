using System;
using System.Text.RegularExpressions;

namespace Lab7RegEx
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a valid name: ");
            string userName = Console.ReadLine();
            string userNameResponse = NameValidation(userName);
            Console.WriteLine(userNameResponse);

            Console.WriteLine();

            Console.WriteLine("Please enter a valid email: ");
            string userEmail = Console.ReadLine();
            string userEmailResponse = EmailValidation(userEmail);
            Console.WriteLine(userEmailResponse);

            Console.WriteLine();

            Console.WriteLine("Please enter a valid phone number: ");
            string userPhone = Console.ReadLine();
            string userPhoneResponse = PhoneValidation(userPhone);
            Console.WriteLine(userPhoneResponse);

            Console.WriteLine();

            Console.WriteLine("Please enter a valid date: ");
            string userDate = Console.ReadLine();
            string userDateResponse = DateValidation(userDate);
            Console.WriteLine(userDateResponse);

            Console.WriteLine();

        }


        public static string NameValidation(string input)
        {

            string response;
            char[] inputArray = input.ToCharArray();
            string pattern = @"^(?<firstchar>(?=[A-Z]).{1,30})$";

            foreach (char letter in inputArray)
            {
                if (!char.IsLetter(letter))
                {
                    response = "Name is NOT valid!";
                    return response;
                }
            }

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                response="Name is valid!";
                return response;
            }
            else
            {
                response = "Name is NOT valid!";
                return response;
            }

        }

        public static string EmailValidation(string input)
        {
            string pattern2 = @"^(\w){5,30}@(\w){5,10}.([a-z]){2,3}";
            string response;

            Match match2 = Regex.Match(input, pattern2);
            if (match2.Success)
            {
                response =("Email is valid!");
                return response;
            }
            else
            {
                response ="Email is NOT valid!";
                return response;
            }

        }

        public static string PhoneValidation(string input)
        {
            string pattern2 = @"^\d{3}[-]\d{3}[-]\d{4}$";
            string response;
            Match match2 = Regex.Match(input, pattern2);
            if (match2.Success)
            {
                response="Phone# is valid!";
                return response;

            }
            else
            {
                response="Phone# is NOT valid!";
                return response;
            }

        }


        public static string DateValidation(string input)
        {
            string pattern2 = @"^[0-9]{1,2}/[0-9]{1,2}/[0-9]{4}";
            string response;

            Match match2 = Regex.Match(input, pattern2);
            if (match2.Success)
            {
                response = "Date is valid!";
                return response; 
            }
            else
            {
                response = "Date is NOT valid!";
                return response;
            }
        }

    }
}
