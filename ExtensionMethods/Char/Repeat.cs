namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Repeats the specified char the specified number of times.
    /// </summary>
    /// <param name="this">The char to repeat.</param>
    /// <param name="number">The number of times to repeat the char.</param>
    /// <returns>A string containing the repeated char.</returns>
    public static string Repeat(this char @this, int number)
    {
        return new string(@this, number);
    }
}