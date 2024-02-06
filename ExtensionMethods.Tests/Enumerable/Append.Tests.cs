using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void Append_ShouldAppendElementToEnumerable()
    {
        var original = new List<string> { "one", "two", "three" };
        original
            .Append("four")
            .ToList()
            .Should().BeEquivalentTo(
                new List<string> { "one", "two", "three", "four" },
                    options => options.WithStrictOrdering()
                );
    }
}