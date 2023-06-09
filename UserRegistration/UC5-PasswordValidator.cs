using System;
using System.Linq;

public class PasswordValidator
{
    public  bool ValidatePassword(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }

        // Rule 1: Minimum 8 Characters
        // Rule 2: Should have at least 1 Upper Case
        // Rule 3: Should have at least 1 numeric number
        // Rule 4: Has exactly 1 Special Character

        bool hasUpperCase = false;
        bool hasNumeric = false;
        bool hasSpecialChar = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUpperCase = true;
            }
            else if (char.IsDigit(c))
            {
                hasNumeric = true;
            }
            else if (!char.IsLetterOrDigit(c))
            {
                hasSpecialChar = true;
            }

            if (hasUpperCase && hasNumeric && hasSpecialChar)
            {
                return true;
            }
        }

        return false;
    }

}