namespace ShroomCity.Utilities.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException(string emailAddress)
        : base($"User with email address '{emailAddress}' not found.")
    {
    }
}
