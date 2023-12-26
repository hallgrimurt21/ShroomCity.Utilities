namespace ShroomCity.Utilities.Exceptions;

public class TokenNotFoundException : Exception
{
    public TokenNotFoundException(int tokenId)
        : base($"Token '{tokenId}' not found.")
    {
    }
}
