using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{

    [Fact]
    public void ToEnumerable_ShouldYieldEnumerable_ForInteger()
    {
        // Arrange: Take a simple value.
        const int TEST_VALUE = 1;

        // Act: By converting the value to an enumeration.
        var enumerable = 1.ToEnumerable();

        // Assert: That the enumeration contains just the single value.
        enumerable.Single().Should().Be(TEST_VALUE);
    }
}