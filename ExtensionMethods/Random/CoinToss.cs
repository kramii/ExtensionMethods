namespace ExtensionMethods;

public static partial class ExtensionMethods
{
    /// <summary>
    /// Randomly returns <c>true</c> or <c>false</c>.
    /// </summary>
    /// <param name="this">A random number generator.</param>
    /// <returns>Either <c>true</c> or <c>false</c>.</returns>
    public static bool CoinToss(this Random @this)
    {
        return @this.NextDouble() < .5;
    }
}