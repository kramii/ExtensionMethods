namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Determines if the specified string is an empty string.
    /// </summary>
    /// <param name="value">The string to test.</param>
    /// <returns>True if the specified string is an empty string; otherwise false.</returns>
    public static bool IsEmpty(this string value)
    {
        return value == "";
    }

    /// <summary>
    /// Determines if the specified string is not an empty string.
    /// </summary>
    /// <param name="value">The string to test.</param>
    /// <returns>True if the specified string is not an empty string; otherwise false.</returns>
    public static bool IsNotEmpty(this string value)
    {
        return value != "";
    }
}