using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class RegexPattern
    {
        public void ValidateFirstName(string name)
        {
            string firstName = "^[A-z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("First name is valid");
            }
            else
            {
                Console.WriteLine("First name is not valid");
            }
        }
        public void ValidateLastName(string name)
        {
            string lastName = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name is valid");
            }
            else
            {
                Console.WriteLine("Last name is not valid");
            }
        }
        public void ValidateEmail(string email)
        {
            string emailId = "^[a-zA-z]{3}[.][a-zA-Z]{3}@[a-zA-z]{10}[.][a-z]{2}[.][a-z]{2}$";//"^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(email, emailId))
            {
                Console.WriteLine("The email id is valid");
            }
            else
            {
                Console.WriteLine("The email is not valid email");
            }
        }
        public void ValidatePhoneNumber(string number)
        {
            string phoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
            if (Regex.IsMatch(number, phoneNumber))
            {
                Console.WriteLine("The phone number is valid");
            }
            else
            {
                Console.WriteLine("The phone number is not valid");
            }
        }
        public void ValidatePassword(string password)
        {
            string passwords = "^[A-Za-z]{8,}$";
            if (Regex.IsMatch(password, passwords))
            {
                Console.WriteLine("The password is valid");
            }
            else
            {
                Console.WriteLine("The password is not valid");
            }
        }
        public void ValidatePasswordWithLeastOneUppercase(string password)
        {
            string passwords = "^[A-Za-z]{1,}$";
            if (Regex.IsMatch(password, passwords))
            {
                Console.WriteLine("The password is valid");
            }
            else
            {
                Console.WriteLine("The password is not valid");
            }
        }
        public void ValidatePasswordWithLeastOneNumeric(string password)
        {
            string passwords = "^[A-Za-z0-9]{1,}$";
            if (Regex.IsMatch(password, passwords))
            {
                Console.WriteLine("The password is valid");
            }
            else
            {
                Console.WriteLine("The password is not valid");
            }
        }
    }
}
