using System.Text;

namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Appends a formatted string to a StringBuilder, and then appends a new line.
    /// </summary>
    /// <param name="builder">The StringBuilder.</param>
    /// <param name="format">A composite format string.</param>
    /// <param name="arguments">The arguments.</param>
    /// <returns>A reference to this instance with <c>format</c> appended. Each format item in <c>format</c> is replaced by the string representation of the corresponding object argument.</returns>
    public static StringBuilder AppendFormatLine(
        this StringBuilder builder,
        string format,
        params object[] arguments)
    {
        builder.AppendFormat(format, arguments);
        builder.AppendLine();
        return builder;
    }
}