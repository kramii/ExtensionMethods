using System.Text;

namespace ExtensionMethods;
public static partial class ExtensionMethods
{
    /// <summary>
    /// Appends a delimiter and string to a StringBuilder, but skipping the delimiter if the StringBuilder is empty.
    /// </summary>
    /// <param name="original">The original StringBuilder.</param>
    /// <param name="value">The string to append.</param>
    /// <param name="delimiter">The delimiter to place before the appended string. This will be "," is no value is supplied.</param>
    public static void AppendWithDelimiter(this StringBuilder original, string value, string delimiter = ",")
    {
        if (original.Length == 0)
        {
            original.Append(value);
        }
        else
        {
            original.Append(delimiter);
            original.Append(value);
        }
    }
}
