using System;

public class MobileNumberValidator
{
    public  bool ValidateMobileNumber(string mobileNumber)
    {
        if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 12)
        {
            return false;
        }

        // Check country code
        if (mobileNumber.Substring(0, 2) != "91")
        {
            return false;
        }

        // Check if the remaining part is numeric
        string remainingDigits = mobileNumber.Substring(3);
        if (!IsNumeric(remainingDigits))
        {
            return false;
        }

        return true;
    }

    private static bool IsNumeric(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }

   
    }
