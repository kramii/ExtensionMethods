namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Fetches a the specified number of characters from the start of the string.
    /// </summary>
    /// <param name="this">The string to manipulate.</param>
    /// <param name="length">The number of characters to return.</param>
    /// <returns>The specified number of characters from the start of the string.</returns>
    public static string Left(this string @this, int length)
    {
        if (@this.Length < length)
        {
            return @this;
        }
        return @this.Substring(0, length);
    }

    /// <summary>
    /// Fetches a the specified number of characters from the end of the string.
    /// </summary>
    /// <param name="this">The string to manipulate.</param>
    /// <param name="length">The number of characters to return.</param>
    /// <returns>The specified number of characters from the end of the string.</returns>
    public static string Right(this string @this, int length)
    {
        if (@this.Length < length)
        {
            return @this;
        }

        return @this.Substring(@this.Length - length, length);
    }
}