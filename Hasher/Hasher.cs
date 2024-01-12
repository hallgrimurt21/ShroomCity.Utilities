namespace ShroomCity.Utilities.Hasher;
using System.Security.Cryptography;

public static class Hasher
{
    public static string HashPassword(string password, string salt)
    {
        using var pbkdf2 = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000, HashAlgorithmName.SHA256);
        var hashBytes = pbkdf2.GetBytes(32); // 32 bytes = 256 bits
        var hashedPassword = Convert.ToBase64String(hashBytes);

        // Combine the salt and hash and convert to a Base64 string
        var combined = $"{salt}.{hashedPassword}";
        return combined;
    }
    public static string GenerateSalt()
    {
        var saltBytes = new byte[32];
        RandomNumberGenerator.Fill(saltBytes);
        return Convert.ToBase64String(saltBytes);
    }
}
