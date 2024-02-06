namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    public static string ToUtc(this DateTime? dateTime)
    {
        if (dateTime == null)
        {
            return "";
        }
        return dateTime.Value.ToUtc();
    }
}