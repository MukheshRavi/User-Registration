using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class User
    {
        public static bool ValidateName(string frstName)
        {
         //Console.WriteLine("Enter First Name : start with capital and min 3 characters");
           // string frstName = Console.ReadLine();
            String pattern = "^[A-Z][a-zA-Z0-9]{2}";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(frstName))
        {        Console.WriteLine("valid username entered");
              return true;
            }
            else
            {
                
                throw new InvalidUserNameException("Invalid user name entered");
               
               
            }
        }


        public static bool ValidateEmail(string email)
        {
            
       // Email: Console.WriteLine("Enter mail id");
         //   string email = Console.ReadLine();
            String emailPattern = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Regex regex = new Regex(emailPattern);
            if (regex.IsMatch(email))
            {
                Console.WriteLine("valid email entered");
                return true;
            }
            else
            {
                throw new InvalidEmailException("Invalid Email entered");

            }
        }

        public static bool  ValidatePhoneNumber(string phnNo)
        {
       // Phone: Console.WriteLine("Enter Phone Number");
         //   string phnNo = Console.ReadLine();
            String phnPattern = "^[9][1][ ][6-9]([0-9]{9})$";
            Regex regex = new Regex(phnPattern);
            if (regex.IsMatch(phnNo))
            {
                Console.WriteLine("valid Phone Number entered");
                return true;
            }
            else
            {
                throw new InvalidPhnNoException("Invalid Phone Number entered");

            }
        

    }
        public static bool ValidatePassword(string password)
        {

     //   Password: Console.WriteLine("Enter Password");
       //     string password = Console.ReadLine();
        
            String passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            Regex regex = new Regex(passwordPattern);
            if (regex.IsMatch(password))
            {
                Console.WriteLine("valid Password entered");
                return true;
            }
            else
            {
                throw new InvalidPasswordException("Invalid Password entered");
            }

        }

        public void ValidateSampleEmail()
        {
            string patternOfEmail = "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
            string[] sampleEmail = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                    "abc@1.com","abc@gmail.com.com","abc+100@gmail.com","Abc","abc@.com.my" ,"abc123@gmail.1a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            Console.WriteLine("\n\nThe valid sample emails are :");
            foreach (string sample in sampleEmail)
            {
                if (Regex.IsMatch(sample, patternOfEmail))
                    Console.WriteLine(sample);

            }
        }




    }


    }

