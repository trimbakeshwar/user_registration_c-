using System;
using System.Text.RegularExpressions;

namespace regestration
{
    class userRegistration
    {
        static string validateName = "^[A-Z][a-z]{3,}$";
        static string validateEmail = @"^((.[A-Z]+[a-z]*[0-9]*)|(.[A-Z]*[a-z]+[0-9]*)|(.[A-Z]*[a-z]*[0-9]+)?)?.co(.[a-z]{2,})?$";

        Regex RegexName = new Regex(validateName);
        Regex RegexEmail = new Regex(validateEmail);
        public void validation(string name)
        {

            if (RegexName.IsMatch(name))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        public void validationEmail(string email)
        {

            if (RegexEmail.IsMatch(email))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

        static void Main(string[] args)
        {
            userRegistration user = new userRegistration();
            Console.WriteLine("ENTER NAME : ");
            string name = Console.ReadLine();
            user.validation(name);
            Console.WriteLine("ENTER LASTNAME : ");
            string lastName = Console.ReadLine();
            user.validation(lastName);
            Console.WriteLine("ENTER Email : ");
            string email = Console.ReadLine();
            user.validationEmail(email);
        }
    }
}