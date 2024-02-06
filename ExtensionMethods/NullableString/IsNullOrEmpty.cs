namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Determines if the specified string is null or an empty string.
    /// </summary>
    /// <param name="value">The string to test.</param>
    /// <returns>True if the specified string is null or an empty string; otherwise false.</returns>
    public static bool IsNullOrEmpty(this string? value)
    {
        return string.IsNullOrEmpty(value);
    }
}