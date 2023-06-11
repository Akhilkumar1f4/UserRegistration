
public class MobileNumberValidator
{
    public bool ValidateMobileNumber(string mobileNumber)
    {
        string pattern = @"^[0-9]{2}\s[0-9]{10}$";
        return Regex.IsMatch(mobileNumber, pattern);
    }
}
