public class LastNameValidator
{
    public bool ValidateLastName(string lastName)
    {
        string pattern = @"^[A-Z][a-zA-Z]{2,}$";
        return Regex.IsMatch(lastName, pattern);
    }
}
