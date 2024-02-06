namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Determines is the specified type is nullable.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns><c>true</c> if the type is a nullable type; otherwise <c>false</c>.</returns>
    public static bool IsNullable(this Type type)
    {
        return System.Nullable.GetUnderlyingType(type) != null;
    }
}