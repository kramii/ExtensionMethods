   namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Returns an empty enumeration if the original enumeration is null.
    /// </summary>
    /// <typeparam name="T">The type of element in the enumeration</typeparam>
    /// <returns>An enumeration that is not null.
    public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T>? @this)
    {
        return @this ?? Enumerable.Empty<T>();
    }
}