using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void IsWeekend_ShouldReturnTrue_ForSaturday()
    {
        var saturday = new DateTime(2024, 1, 27);
        saturday.IsWeekend().Should().Be(true);
    }

    [Fact]
    public void IsWeekend_ShouldReturnFalse_ForWeekday()
    {
        var thursday = new DateTime(2024, 1, 25);
        thursday.IsWeekend().Should().Be(false);
    }
}