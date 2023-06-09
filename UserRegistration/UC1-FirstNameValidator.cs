using System;

public class FirstNameValidator
{
    public  bool ValidateFirstName(string firstName)
    {
        if (string.IsNullOrEmpty(firstName) || firstName.Length < 3 || !char.IsUpper(firstName[0]))
        {
            return false;
        }
        return true;
    }

}