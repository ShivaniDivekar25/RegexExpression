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
    }
}
