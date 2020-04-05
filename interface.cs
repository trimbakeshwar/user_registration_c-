using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace userRegistration
{
    public interface user

    {
        
        string validationName(string name);//check for validation name
        string validationlastName(string lastName);//check for validation last name
        string validationEmail(string email);

    }
}
