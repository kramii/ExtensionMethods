namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Creates a TimeSpan from the specified number of seconds.
    /// </summary>
    /// <param name="seconds">The number of seconds.</param>
    /// <returns>A TimeSpan from the specified number of seconds.</returns>
    public static TimeSpan Seconds(this int seconds)
    {
        return TimeSpan.FromSeconds(seconds);
    }

    /// <summary>
    /// Creates a TimeSpan from the specified number of minutes.
    /// </summary>
    /// <param name="minutes">The number of minutes.</param>
    /// <returns>A TimeSpan from the specified number of minutes.</returns>
    public static TimeSpan Minutes(this int minutes)
    {
        return TimeSpan.FromMinutes(minutes);
    }

    /// <summary>
    /// Creates a TimeSpan from the specified number of hours.
    /// </summary>
    /// <param name="hours">The number of hours.</param>
    /// <returns>A TimeSpan from the specified number of hours.</returns>
    public static TimeSpan Hours(this int hours)
    {
        return TimeSpan.FromHours(hours);
    }

   /// <summary>
    /// Creates a TimeSpan from the specified number of days.
    /// </summary>
    /// <param name="hours">The number of days.</param>
    /// <returns>A TimeSpan from the specified number of days.</returns>
    public static TimeSpan Days(this int days)
    {
        return new TimeSpan(days, 0, 0, 0, 0);
    }
}