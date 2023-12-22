namespace ShroomCity.Utilities.Exceptions;

public class RoleNotFoundException : Exception
{
    public RoleNotFoundException(string roleName)
        : base($"Role '{roleName}' not found.")
    {
    }
}
