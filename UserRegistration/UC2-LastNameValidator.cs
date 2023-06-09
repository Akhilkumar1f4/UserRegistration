using System;

public class LastNameValidator
{
    public  bool ValidateLastName(string lastName)
    {
        if (string.IsNullOrEmpty(lastName) || lastName.Length < 3 || !char.IsUpper(lastName[0]))
        {
            return false;
        }
        return true;
    }

}