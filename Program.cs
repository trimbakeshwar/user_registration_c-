using System;
using System.Text.RegularExpressions;

namespace regestration
{
    class userRegistration
    {
   
         
        public string validation(Regex regexPattern,string usserPattern)//check pattern valid or not
        {

            if (regexPattern.IsMatch(usserPattern))
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }
        }
        public string validationName(string name)//check for validation name
        {
            string validateName = "^[A-Z][a-z]{3,}$";//name pattern
            Regex RegexName = new Regex(validateName);//create regex object
            return this.validation(RegexName, name);//call to check validation
        }
        
         public string validationlastName(string lastName)//check for validation last name
        {
            string validateName = "^[A-Z][a-z]{3,}$";//last name pattern
            Regex RegexName = new Regex(validateName);//create regex object
            return this.validation(RegexName, lastName);//call to check validation
        }
        public string validationEmail(string email)
        {
            string validateEmail = @"^((.[A-Z]+[a-z]*[0-9]*)|(.[A-Z]*[a-z]+[0-9]*)|(.[A-Z]*[a-z]*[0-9]+)?)?@.co(.[a-z]{2,})?$";//email pattern
            Regex RegexEmail = new Regex(validateEmail);//create regex object
            return this.validation(RegexEmail, email);//call to check validation

        }
        public string validateNumber(string number)
        {
            string validateMobileNumber = @"^[0-9]{2}[ ][0-9]{10}$";//number pattern
            Regex RegexNumber = new Regex(validateMobileNumber);//create regex object
            return this.validation(RegexNumber, number);//call to check validation

        }
        public string validatePassword(string password)
        {
            string validationPassword = @"^.*(?=.*[A-Z])*(?=.*[0-9])*(?=.*[a-z])*(?=.*[!@#$%^&*_+]{1})(.{8,})$";//passwod pattern
            Regex RegexPassword = new Regex(validationPassword);//create regex object
            return this.validation(RegexPassword, password);//call to check validation
        }

        static void Main(string[] args)
        {
            userRegistration user = new userRegistration();//object of class
            Console.WriteLine("ENTER NAME : ");
            string name = Console.ReadLine();//take input from user
            Console.WriteLine(user.validationName(name));//call the name function and shows output its valid or not

            Console.WriteLine("ENTER LASTNAME : ");
            string lastName = Console.ReadLine();//take input from user
            Console.WriteLine(user.validationlastName(lastName));//call the last name function and shows output its valid or not

            Console.WriteLine("ENTER Email : ");
            string email = Console.ReadLine();//take input from user
            Console.WriteLine(user.validationEmail(email));//call the emailfunction and shows output its valid or not

            Console.WriteLine("ENTER number : ");
            string number = Console.ReadLine();//take input from user
            Console.WriteLine(user.validateNumber(number));//call the number function and shows output its valid or not

            Console.WriteLine("ENTER password : ");
            string password = Console.ReadLine();//take input from user
            Console.WriteLine(user.validatePassword(password));//call the password function and shows output its valid or not
        }
    }
}