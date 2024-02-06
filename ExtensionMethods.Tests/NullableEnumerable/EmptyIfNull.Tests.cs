using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void EmptyIfNull_ShouldReturnEmptyIfNull()
    {
        IEnumerable<string>? enumerable = null;
        enumerable.EmptyIfNull().Should().NotBeNull();
    }
}