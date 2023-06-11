public class PasswordValidator
{
    public bool ValidatePassword(string password)
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=])(?=.*[a-zA-Z\d@#$%^&+=]).{8,}$";
        return Regex.IsMatch(password, pattern);
    }
}
