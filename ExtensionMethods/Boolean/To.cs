namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Converts a boolean to one of two values.
    /// </summary>
    /// <typeparam name="TResult">The type of the output value.</typeparam>
    /// <param name="value">The original boolean value.</param>
    /// <param name="trueValue">The value to return if the original value is true.</param>
    /// <param name="falseValue">The value to return if the original value is false.</param>
    /// <returns>The <c>trueValue</c> if the original boolean value is true; otherwise the <c>falseValue</c>.</returns>
    public static TResult To<TResult>(this bool value, TResult trueValue, TResult falseValue)
    {
        return value
            ? trueValue
            : falseValue;
    }
}