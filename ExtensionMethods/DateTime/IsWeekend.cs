namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Determines if the specified DateTime occurs at the weekend.
    /// </summary>
    /// <param name="dateTime">The DateTime to check.</param>
    /// <returns>True if the specified DateTime occurs at the weekend; otherwise false.</returns>
    public static bool IsWeekend(this DateTime dateTime)
    {
        DayOfWeek dayOfWeek = dateTime.DayOfWeek;
        return dayOfWeek == DayOfWeek.Saturday ||
               dayOfWeek == DayOfWeek.Sunday;
    }
}