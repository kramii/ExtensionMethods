namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Splits a string on the specified string separator.
    /// </summary>
    /// <param name="this">The string to split.</param>
    /// <param name="separator">The string separator.</param>
    /// <param name="stringSplitOptions">The string split options. The default is StringSplitOptions.None.</param>
    /// <returns>An array of strings containing the split strings.</returns>
    public static string[] Split(
        this string @this,
        string separator,
        StringSplitOptions stringSplitOptions = StringSplitOptions.None)
    {
        return @this.Split(new[] { separator }, stringSplitOptions);
    }
}