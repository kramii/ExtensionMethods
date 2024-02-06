namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    public static string ToUtc(this DateTime dateTime)
    {
        return dateTime.ToString("o");
    }
}