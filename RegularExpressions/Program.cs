namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression program");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Validate first name\n2:Validate last name");
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
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}