namespace ShroomCity.Utilities.Exceptions;

public class InvalidInputException : Exception
{
    public InvalidInputException(string input, string shouldBe)
        : base($"Invalid input '{input}'. Should be '{shouldBe}'")
    {
    }
}
