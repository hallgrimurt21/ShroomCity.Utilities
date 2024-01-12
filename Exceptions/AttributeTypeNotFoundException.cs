namespace ShroomCity.Utilities.Exceptions;

public class AttributeTypeNotFoundException : Exception
{
    public AttributeTypeNotFoundException(string type)
        : base($"Attribute '{type}' not found")
    {
    }
}
