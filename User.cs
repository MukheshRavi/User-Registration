﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {

        public void validateFrstName()
        {
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

        public void validateLastName()
        {
        lastname: Console.WriteLine("Enter last Name : start with capital and min 3 characters");
            string lstName = Console.ReadLine();
            String pattern = "^[A-Z][a-zA-Z0-9]{2}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(lstName))
                Console.WriteLine("valid username entered");
            else
            {
                Console.WriteLine("Not a valid user name");
                goto lastname;
            }
        }

        public void validateEmail()
        {
            
        Email: Console.WriteLine("Enter mail id");
            string email = Console.ReadLine();
            String emailPattern = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Regex regex = new Regex(emailPattern);
            if (regex.IsMatch(email))
                Console.WriteLine("valid email entered");
            else
            {
                Console.WriteLine("Not a valid email");
                goto Email;
            }
        }
    }


    }
}
