using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void ToUtc_ShouldReturnUtcDateTime_ForDateTime()
    {
        var someDateTime = new DateTime(2024, 1, 24, 16, 15, 4);
        someDateTime.ToUtc().Should().Be("2024-01-24T16:15:04.0000000");
    }
}