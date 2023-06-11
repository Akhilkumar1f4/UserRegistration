
public class EmailValidator
{
    public bool ValidateEmail(string email)
    {
        string pattern = @"^[A-Za-z0-9]+([._%+-][A-Za-z0-9]+)*@[A-Za-z0-9]+([.-][A-Za-z0-9]+)*\.[A-Za-z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }
}
