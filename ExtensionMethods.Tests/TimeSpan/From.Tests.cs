using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void From_Should_AddTimeToDate()
    {
        3.Minutes().From(new DateTime(2023, 12, 25, 12, 45, 1)).Should().Be(new DateTime(2023, 12, 25, 12, 48, 1));
    }

}