using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
      
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem");
        firstname: Console.WriteLine("Enter First Name : start with capital and min 3 characters");
            string frstName = Console.ReadLine();
            String pattern = "^[A-Z][a-zA-Z0-9]{2}";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(frstName))
                Console.WriteLine("valid username entered");
            else
            {
                Console.WriteLine("Not a valid user name");
                goto firstname;
            }

        }
    }
}
