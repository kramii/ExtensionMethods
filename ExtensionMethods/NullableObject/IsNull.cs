namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Determines if the specified object is null.
    /// </summary>
    /// <param name="obj">The object to test.</param>
    /// <returns>True if the specified object is null; otherwise false.</returns>
    public static bool IsNull(this object? obj)
    {
        return obj == null;
    }

    /// <summary>
    /// Determines if the specified object is not null.
    /// </summary>
    /// <param name="obj">The object to test.</param>
    /// <returns>True if the specified object is not null; otherwise false.</returns>
      public static bool IsNotNull(this object? obj)
    {
        return obj != null;
    }
}