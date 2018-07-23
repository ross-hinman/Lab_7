using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Name());
            Console.WriteLine(Email());
            Console.WriteLine(PhoneNumber());
            Console.WriteLine(Date());
            Console.ReadKey();
     
        }

        public static string Name()
        {
            Console.WriteLine("Please enter your name: ");
            string name1 = Console.ReadLine();
            var pattern = @"^[A-Z]([a-z]{1,29})$";
            bool checkName = true;
            do
            {
                if (Regex.IsMatch(name1, pattern))
                {
                    checkName = false;
                    return "Name is valid!";
                }
                else
                {
                   return "Sorry, name is not valid!";
                }
            } while (checkName == true);
        }

        public static string Email()
        {
            Console.WriteLine("Please enter a valid email: ");
            string email = Console.ReadLine();
            var pattern = @"^([A-Z|a-z|0-9]{5,30})@([A-Z|a-z|0-9]{5,10}).([A-Z|a-z|0-9]{2,3})$";
            bool checkEmail = true;
            do
            {
                if (Regex.IsMatch(email, pattern))
                {
                    checkEmail = false;
                    return "Email is valid!";
                }
                else
                {
                    return "Sorry, email is not valid!";
                }
            } while (checkEmail == true);
        }

        public static string PhoneNumber()
        {
            Console.WriteLine("Please enter a valid phone number (xxx-xxx-xxxx): ");
            string phoneNumber = Console.ReadLine();
            var pattern = @"^([0-9]{3})-([0-9]{3})-([0-9]{4})$";
            bool checkPhone = true;

            do
            {
                if (Regex.IsMatch(phoneNumber, pattern))
                {
                    checkPhone = false;
                    return "Phone numer is valid!";
                }
                else
                {
                    return "Sorry, phone number is not valid!";
                }
            } while (checkPhone == true);
        }

        private static string Date()
        {
            Console.WriteLine("Please enter a valid date (DD/MM/YYYY): ");
            string date = Console.ReadLine();
            var pattern = @"^([0-9]{2})/([0-9]{2})/([0-9]{4})$";
            bool checkDate = true;

            do
            {
                if (Regex.IsMatch(date, pattern))
                {
                    checkDate = false;
                    return "Date is valid!";
                }
                else
                {
                    return "Sorry, date is not valid!";
                }
            } while (checkDate == true);
        }
    }
}
