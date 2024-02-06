
namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Adds the specified element to the enumeration.
    /// </summary>
    /// <param name="this">The original enumeration.</param>
    /// <param name="element">The element to add.</param>
    /// <typeparam name="T">The type of the enumerable.</typeparam>
    /// <returns>The enumeration, with the element added.</returns>
    public static IEnumerable<T> Append<T>(this IEnumerable<T> @this, T element)
    {
        return @this.Concat(element.ToEnumerable());
    }
}
