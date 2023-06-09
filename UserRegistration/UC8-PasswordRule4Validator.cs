using System;

public class PasswordRule4Validator
{
    public bool ValidateRule4(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return false;
        }

        int specialCharCount = 0;
        foreach (char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                specialCharCount++;
            }
        }

        if (specialCharCount == 1)
        {
            return true;
        }

        return false;
    }
}
