using System.Text;

namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Converts to the sequence of bytes to a hexadecimal string..
    /// </summary>
    /// <param name="byteSequence">The byte sequence.</param>
    /// <returns>A hexadecimal string that represents the sequence of bytes.</returns>
    public static string ToHexString(this IEnumerable<byte> byteSequence)
    {
        if (byteSequence == null)
        {
            return "";
        }

        var result = new StringBuilder();

        foreach (byte @byte in byteSequence)
        {
            result.AppendFormat("{0:x2}", @byte);
        }

        return result.ToString();
    }
}