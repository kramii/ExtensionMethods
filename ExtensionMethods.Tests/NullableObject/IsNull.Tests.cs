using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    private object? nullObject = null;
    private object? notNullObject = new object();

    [Fact]
    public void IsNull_ShouldReturnTrue_WhenObjectIsNull()
    {
        nullObject.IsNull().Should().Be(true);
    }

    [Fact]
    public void IsNull_ShouldReturnFalse_WhenObjectIsNotNull()
    {
        notNullObject.IsNull().Should().Be(false);
    }

    [Fact]
    public void IsNotNull_ShouldReturnFalse_WhenObjectIsNull()
    {
        nullObject.IsNotNull().Should().Be(false);
    }

    [Fact]
    public void IsNotNull_ShouldReturnTrue_WhenObjectIsNotNull()
    {
        notNullObject.IsNotNull().Should().Be(true);
    }
}