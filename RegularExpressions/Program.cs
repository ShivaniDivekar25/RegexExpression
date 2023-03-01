namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression program");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Validate first name\n2:Validate last name\n3:Validate Email\n4:Validate Phone number\n5:Validate password with least 8 char");
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
                    regex.ValidatePassword("ShivaniD");
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}