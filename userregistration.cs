using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using userRegistration;

namespace regestration
{
    public class userRegistration :user
    {
         string validateName = "^[A-Z][a-z]{3,}$";//name pattern
         string validateEmail = @"^((.[A-Z]+[a-z]*[0-9]*)|(.[A-Z]*[a-z]+[0-9]*)|(.[A-Z]*[a-z]*[0-9]+)?)?@.co(.[a-z]{2,})?$";//email pattern
         string validateMobileNumber = @"^[0-9]{2}[ ][0-9]{10}$";//number pattern
         string validationPassword = @"^.*(?=.*[A-Z])*(?=.*[0-9])*(?=.*[a-z])*(?=.*[!@#$%^&*_+]{1})(.{8,})$";//passwod pattern

        public string validation(Regex regexPattern, string usserPattern)//check pattern valid or not
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

            Regex RegexName = new Regex(validateName);//create regex object
            return this.validation(RegexName, name);//call to check validation
        }

        public string validationlastName(string lastName)//check for validation last name
        {

            Regex RegexName = new Regex(validateName);//create regex object
            return this.validation(RegexName, lastName);//call to check validation
        }
        public string validationEmail(string email)
        {

            Regex RegexEmail = new Regex(validateEmail);//create regex object
            return this.validation(RegexEmail, email);//call to check validation

        }
        public string validateNumber(string number)
        {

            Regex RegexNumber = new Regex(validateMobileNumber);//create regex object
            return this.validation(RegexNumber, number);//call to check validation

        }
        public string validatePassword(string password)
        {
            Regex RegexPassword = new Regex(validationPassword);//create regex object
            return this.validation(RegexPassword, password);//call to check validation
        }

    }
}