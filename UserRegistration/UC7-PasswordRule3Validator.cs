using System;

public class PasswordRule3Validator
{
    public bool ValidateRule3(string password)
    {
        if (string.IsNullOrEmpty(password) || !password.Any(char.IsDigit))
        {
            return false;
        }
        return true;
    }
}
