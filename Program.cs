using System;
using System.Text.RegularExpressions;

namespace regestration
{
    public class calling
    {
        public static void Main(string[] args)
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