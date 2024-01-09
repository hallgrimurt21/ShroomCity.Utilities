namespace ShroomCity.Utilities.Exceptions;

public class MushroomNotFoundException : Exception
{
    public MushroomNotFoundException(string mushroomName)
        : base($"Mushroom with name '{mushroomName}' not found in external API.")
    {
    }
}
