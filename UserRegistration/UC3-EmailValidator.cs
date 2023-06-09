using System;

public class EmailValidator
{
    public  bool ValidateEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }

        // Split email into parts
        string[] parts = email.Split('@');
        if (parts.Length != 2)
        {
            return false;
        }

        string[] domainParts = parts[1].Split('.');
        if (domainParts.Length < 2 || domainParts.Length > 3)
        {
            return false;
        }

        string username = parts[0];
        string domain = domainParts[0];
        string topLevelDomain = domainParts[1];

        // Check username
        if (string.IsNullOrEmpty(username))
        {
            return false;
        }

        // Check domain
        if (string.IsNullOrEmpty(domain))
        {
            return false;
        }

        // Check top-level domain
        if (string.IsNullOrEmpty(topLevelDomain))
        {
            return false;
        }

        return true;
    }

}