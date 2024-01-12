namespace ShroomCity.Utilities.Exceptions;

public class ResearcherNotFoundException : Exception
{
    public ResearcherNotFoundException(string researcherEmailAddress)
        : base($"Researcher with email '{researcherEmailAddress}' not found")
    {
    }
}
