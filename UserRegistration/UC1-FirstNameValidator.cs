using System;
using System.Text.RegularExpressions;

public class FirstNameValidator
{
    public bool ValidateFirstName(string firstName)
    {
        string pattern = @"^[A-Z][a-zA-Z]{2,}$";
        return Regex.IsMatch(firstName, pattern);
    }
}
