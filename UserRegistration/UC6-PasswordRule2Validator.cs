using System;

public class PasswordRule2Validator
{
    public bool ValidateRule2(string password)
    {
        if (string.IsNullOrEmpty(password) || !password.Any(char.IsUpper))
        {
            return false;
        }
        return true;
    }
}
