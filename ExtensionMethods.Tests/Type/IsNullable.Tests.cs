using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void IsNullable_ShouldReturnFalse_IfTypeIsNotNullable(){
        var type = typeof(int);
        type.IsNullable().Should().Be(false);
    }

        [Fact]
    public void IsNullable_ShouldReturnTrue_IfTypeIsNullable(){
        var type = typeof(int?);
        type.IsNullable().Should().Be(true);
    }
}