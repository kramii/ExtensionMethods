using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{

    [Theory]
    [InlineData((string?)null)]
    [InlineData("")]
    public void IsNullOrEmpty_ShouldReturnTrue_WhenParameterIsNullOrEmpty(string? value)
    {
        value.IsNullOrEmpty().Should().Be(true);
    }

    [Fact]
    public void IsNullOrEmpty_ShouldReturnFalse_WhenParameterIsNotNullOrEmpty()
    {
        string emptyString = "some value";
        emptyString.IsNullOrEmpty().Should().Be(false);
    }
}