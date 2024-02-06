using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Turns a collection of strings into a human-readable list.
    /// </summary>
    /// <param name="stringItems">The items in the collection.</param>
    /// <param name="and">The separator to use before the last item.</param>
    /// <param name="separator">The separator to be used before all other items.</param>
    /// <returns>A string that lists all the items.</returns>
    public static StringBuilder ToHumanList(
        this IEnumerable<string> stringItems,
        string and = " and ",
        string separator = ", ")
    {
        // Apply the elements on the string...
        return stringItems.Apply<string, StringBuilder>(

            // ... to a StringBuilder.
            new StringBuilder(),

            // To apply each element...
            (element, index,  isFirst, isLast, target) =>
            {
                if (isFirst)
                {
                    target.Append(element);
                }
                else
                {
                    if (!isLast)
                    {
                        target.Append(separator + element);
                    }
                    else
                    {
                        target.Append(and + element);
                    }
                }
            }
        );
    }
}
