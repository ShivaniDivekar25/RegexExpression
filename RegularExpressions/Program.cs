namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression program");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Validate first name\n2:Validate last name\n3:Validate Email\n4:Validate Phone number\n5:Validate password with least 8 char\n6:Validate password with least one uppercase\n7:Validate password with least one numeric\n8:Validate password with exactly one special character\n9:Validate sample emails");
            int option = Convert.ToInt32(Console.ReadLine());
            RegexPattern regex = new RegexPattern();
            switch (option)
            {
                case 1:
                    regex.ValidateFirstName("Shivani");
                    break;
                case 2:
                    regex.ValidateLastName("Divekar");
                    break;
                case 3:
                    regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
                    break;
                case 4:
                    regex.ValidatePhoneNumber("91 8983922706");
                    break;
                case 5:
                    regex.ValidatePassword("ShivMalhar");
                    break;
                case 6:
                    regex.ValidatePasswordWithLeastOneUppercase("ShivaniD");
                    break;
                case 7:
                    regex.ValidatePasswordWithLeastOneNumeric("Shivani1");
                    break;
                case 8:
                    regex.ValidatePasswordWithExactlyOneSpecialCharacter("Shiva25@");
                    break;
                case 9:
                    regex.ValidateSampleEmails();
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}