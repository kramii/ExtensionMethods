namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Repeats the specified string the specified number of times.
    /// </summary>
    /// <param name="this">The string to repeat.</param>
    /// <param name="number">The number of times to repeat the string.</param>
    /// <returns>The string, repeated the specified number of times.</returns>
    public static string Repeat(this string @this, int number)
    {
        return string.Concat(Enumerable.Repeat(@this, number));
    }
}