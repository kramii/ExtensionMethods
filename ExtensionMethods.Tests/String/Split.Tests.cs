using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void Split_ShouldSplitTheString()
    {
        "ABCxxxDEFxxxGHI".
            Split("xxx").
            Should().
            BeEquivalentTo(
                new string[] { "ABC", "DEF", "GHI" },
                options => options.WithStrictOrdering()
            );
    }

}