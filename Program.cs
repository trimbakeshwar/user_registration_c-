using System;
using System.Text.RegularExpressions;

public class userRegistration
{
    public void validFirstName(String name)
    {
        var expression = "^[A-Z][a-z]{3,}$";
        var match = Regex.Match(name, expression, RegexOptions.None);
        if (match.Success)
            Console.WriteLine("valid");
        else
            Console.WriteLine("invalid");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ENTER NAME : ");
        String name = Console.ReadLine();
        userRegistration user = new userRegistration();
        user.validFirstName(name);

    }
}
