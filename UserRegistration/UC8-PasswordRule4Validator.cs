public class PasswordRule4Validator
{
    public bool ValidateRule4(string password)
    {
        string pattern = @"^(?=.*[@#$%^&+=]).+$";
        return Regex.IsMatch(password, pattern);
    }
}
