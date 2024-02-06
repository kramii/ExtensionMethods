using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void Left_ShouldReturnTheStartOfTheString()
    {
        "ABCDEF".Left(3).Should().Be("ABC");
    }

    [Fact]
    public void Left_ShouldReturnTheWholeString_WhenThereAreInsufficientCharacters()
    {
        "A".Left(3).Should().Be("A");
    }

    [Fact]
    public void Right_ShouldReturnTheEndOfTheString()
    {
        "ABCDEF".Right(3).Should().Be("DEF");
    }

    [Fact]
    public void Right_ShouldReturnTheWholeString_WhenThereAreInsufficientCharacters()
    {
        "A".Right(3).Should().Be("A");
    }
}