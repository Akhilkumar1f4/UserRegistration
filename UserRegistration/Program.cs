using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Use Case 1: Validating First Name
        string firstName = Console.ReadLine();
        FirstNameValidator firstNameValidator = new FirstNameValidator();
        if (firstNameValidator.ValidateFirstName(firstName))
        {
            Console.WriteLine("Valid first name");
        }
        else
        {
            Console.WriteLine("Invalid first name");
        }

        // Use Case 2: Validating Last Name
        string lastName = Console.ReadLine();
        LastNameValidator lastNameValidator = new LastNameValidator();
        if (lastNameValidator.ValidateLastName(lastName))
        {
            Console.WriteLine("Valid last name");
        }
        else
        {
            Console.WriteLine("Invalid last name");
        }

        // Use Case 3: Validating Email
        string email = Console.ReadLine();
        EmailValidator emailValidator = new EmailValidator();
        if (emailValidator.ValidateEmail(email))
        {
            Console.WriteLine("Valid email");
        }
        else
        {
            Console.WriteLine("Invalid email");
        }

        // Use Case 4: Validating Mobile Number
        string mobileNumber = Console.ReadLine();
        MobileNumberValidator mobileNumberValidator = new MobileNumberValidator();
        if (mobileNumberValidator.ValidateMobileNumber(mobileNumber))
        {
            Console.WriteLine("Valid mobile number");
        }
        else
        {
            Console.WriteLine("Invalid mobile number");
        }

        // Use Case 5: Validating Password (with rules)
        string password = Console.ReadLine();
        PasswordValidator passwordValidator = new PasswordValidator();
        if (passwordValidator.ValidatePassword(password))
        {
            Console.WriteLine("Valid password");
        }
        else
        {
            Console.WriteLine("Invalid password");
        }

        // Use Case 6: Validating Rule 2 - Password Should Have at Least 1 Upper Case
        string passwordForRule2 = Console.ReadLine();
        PasswordRule2Validator rule2Validator = new PasswordRule2Validator();
        if (rule2Validator.ValidateRule2(passwordForRule2))
        {
            Console.WriteLine("Valid password - Rule 2 passed");
        }
        else
        {
            Console.WriteLine("Invalid password - Rule 2 failed");
        }

        // Use Case 7: Validating Rule 3 - Password Should Have at Least 1 Numeric Number
        string passwordForRule3 = Console.ReadLine();
        PasswordRule3Validator rule3Validator = new PasswordRule3Validator();
        if (rule3Validator.ValidateRule3(passwordForRule3))
        {
            Console.WriteLine("Valid password - Rule 3 passed");
        }
        else
        {
            Console.WriteLine("Invalid password - Rule 3 failed");
        }

        // Use Case 8: Validating Rule 4 - Password Has Exactly 1 Special Character
        string passwordForRule4 = Console.ReadLine();
        PasswordRule4Validator rule4Validator = new PasswordRule4Validator();
        if (rule4Validator.ValidateRule4(passwordForRule4))
        {
            Console.WriteLine("Valid password - Rule 4 passed");
        }
        else
        {
            Console.WriteLine("Invalid password - Rule 4 failed");
        }

        // Use Case 9: Validating Email Samples Separately
        string emailSample = Console.ReadLine();
        EmailSampleValidator emailSampleValidator = new EmailSampleValidator();
        if (emailSampleValidator.ValidateEmailSample(emailSample))
        {
            Console.WriteLine("Valid email sample");
        }
        else
        {
            Console.WriteLine("Invalid email sample");
        }
    }
}
