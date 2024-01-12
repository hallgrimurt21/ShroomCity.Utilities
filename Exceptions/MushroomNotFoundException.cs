namespace ShroomCity.Utilities.Exceptions;

public class MushroomNotFoundException : Exception
{
    public MushroomNotFoundException()
        : base($"Mushroom not found")
    {
    }
}
