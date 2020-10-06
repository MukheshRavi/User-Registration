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
            User user = new User();
            user.validateFrstName();
            user.validateLastName();
            user.validateEmail();
            user.validatePhoneNumber();
            user.validatePassword();



        }
    }
}
