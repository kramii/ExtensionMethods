namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Returns a value from the dictionary if it exists; otherwise returns the default value.
    /// </summary>
    public static TValue GetValueOrDefault<TKey, TValue>
        (this IDictionary<TKey, TValue> dictionary,
        TKey key,
        TValue defaultValue) where TValue : notnull
    {
        if (dictionary.ContainsKey(key))
        {
            return dictionary[key];
        }
        return defaultValue;
    }
}