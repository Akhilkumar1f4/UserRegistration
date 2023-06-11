public class PasswordRule2Validator
{
    public bool ValidateRule2(string password)
    {
        string pattern = @"^(?=.*[A-Z]).+$";
        return Regex.IsMatch(password, pattern);
    }
}
