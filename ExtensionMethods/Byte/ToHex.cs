namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Converts the specified byte to a two-digit hex string.
    /// </summary>
    /// <param name="byte">The byte to convert.</param>
    /// <returns>A two-digit hex string that represents the byte.</returns>
    public static string ToHex(this byte @byte, string? prefix = null)
    {
        return string.Format($"{prefix}{@byte:x2}");
    }
}