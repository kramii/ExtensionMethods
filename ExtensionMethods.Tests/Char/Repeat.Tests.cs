using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void Repeat_Should_RepeatTheChar()
    {
        var setOfThreeTabs = '\t'.Repeat(3);
        setOfThreeTabs.Should().Be("\t\t\t");
    }
}