using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    const string TRUE_VALUE = "true";
    const string FALSE_VALUE = "false";

    [Fact]
    public void To_Should_ConvertToTrueValue_WhenValueIsTrue()
    {
        bool value = true;

        value.To(TRUE_VALUE, FALSE_VALUE).Should().Be(TRUE_VALUE);
    }

    [Fact]
    public void To_Should_ConvertToFalseValue_WhenValueIsFalse()
    {
        bool value = false;

        value.To(TRUE_VALUE, FALSE_VALUE).Should().Be(FALSE_VALUE);
    }
}