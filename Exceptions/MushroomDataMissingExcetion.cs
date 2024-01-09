namespace ShroomCity.Utilities.Exceptions;

public class MushroomDataMissingException : Exception
{
    public MushroomDataMissingException()
        : base("External Mushroom API data is null.")
    {
    }
}
