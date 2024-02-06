namespace ExtensionMethods;
public static partial class ExtensionMethods
{
    /// <summary>
    /// Returns a DateTime that is the specified time after the specified DateTime.
    /// </summary>
    /// <param name="timeSpan">The amount of time to add.</param>
    /// <param name="dateTime">The original DateTime.</param>
    /// <returns>A DateTime that is the specified time after the specified DateTime</returns>
    public static DateTime From(this TimeSpan timeSpan, DateTime dateTime)
    {
        return dateTime.Add(timeSpan);
    }
}