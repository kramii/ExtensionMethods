
namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Takes a value and returns an IEnumerable containing that value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <returns>An IEnumerable that contains the value.</returns>
    public static IEnumerable<T> ToEnumerable<T>(this T value)
    {
        yield return value;
    }
}