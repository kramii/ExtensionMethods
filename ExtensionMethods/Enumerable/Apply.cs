using System.Collections.Generic;

namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// The signature of the acton that will be passed to the Apply method.
    /// </summary>
    /// <param name="element">The element to apply to the target.</param>
    /// <param name="isFirst"><c>true</c> if this is the first element in the enumeration; otherwise <c>false</c>.</param>
    /// <param name="isLast"><c>true</c> if this is the final element in the enumeration; otherwise <c>false</c>.</param>
    /// <param name="target">The target to which the element will be applied.</param>
    /// <typeparam name="TElement">The type of the element.</typeparam>
    /// <typeparam name="TTarget">The type of the target.</typeparam>
    /// <remarks>This is equivalent to <c>Action<TElement, bool, bool, TTarget></c>.</remarks>
    public delegate void ElementFirstLastActionTarget<TElement, TTarget>(
        TElement element,
        int index,
        bool isFirst,
        bool isLast,
        TTarget target);

    /// <summary>
    /// Applies each of the elements of an enumerable to a target.
    /// </summary>
    /// <param name="enumerable">The enumerable to apply.</param>
    /// <param name="target">The target to which the elements should be applied.</param>
    /// <param name="action">The action to apply to the target for each element in the enumerable.</param>
    /// <typeparam name="TElement">The type of element in the enumerable.</typeparam>
    /// <typeparam name="TTarget">The type of the target.</typeparam>
    /// <returns>The result of applying the enumerable to the target.</returns>
    public static TTarget Apply<TElement, TTarget>(
        this IEnumerable<TElement> enumerable,
        TTarget target,
        ElementFirstLastActionTarget<TElement, TTarget> action
        )
    {
        // Enumerate the elements...
        using (IEnumerator<TElement> enumerator = enumerable.GetEnumerator())
        {
            // If there are no elements...
            if (!enumerator.MoveNext())
            {
                // Just return the target unchanged.
                return target;
            }

            // Get the first element.
            TElement element = enumerator.Current;
            var first = true;
            int index = 0;

            // Apply each element except the last one.
            while (enumerator.MoveNext())
            {
                action(element, index, first, false, target);
                first = false;

                // Prepare for the next element.
                element = enumerator.Current;
                index++;
            }

            // Apply the last element.
            action(element, index, first, true, target);
        }
        
        return target;
    }
}
