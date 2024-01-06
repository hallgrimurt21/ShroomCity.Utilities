namespace ShroomCity.Utilities.Exceptions;

public class JwtConfigMissingException : Exception
{
    public JwtConfigMissingException()
        : base("JwtConfiguration section is missing in appsettings.json")
    {
    }
}
