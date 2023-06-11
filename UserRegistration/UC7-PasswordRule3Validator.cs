public class PasswordRule3Validator
{
    public bool ValidateRule3(string password)
    {
        string pattern = @"^(?=.*\d).+$";
        return Regex.IsMatch(password, pattern);
    }
}
