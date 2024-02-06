using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    private const string EMPTY_STRING = "";
    private const string NON_EMPTY_STRING = "some value";

    [Fact]
    public void IsEmpty_ShouldReturnTrue_WhenParameterIsEmptyString()
    {
        EMPTY_STRING.IsEmpty().Should().Be(true);
    }

    [Fact]
    public void IsEmpty_ShouldReturnFalse_WhenParameterIsNotEmptyString()
    {
        NON_EMPTY_STRING.IsEmpty().Should().Be(false);
    }

    [Fact]
    public void IsNotEmpty_ShouldReturnFalse_WhenParameterIsEmptyString()
    {
        EMPTY_STRING.IsNotEmpty().Should().Be(false);
    }

    [Fact]
    public void IsNotEmpty_ShouldReturnTrue_WhenParameterIsNotEmptyString()
    {
        NON_EMPTY_STRING.IsNotEmpty().Should().Be(true);
    }
}