using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    const int KNOWN_KEY = 1;
    const string VALUE_FOR_KNOWN_KEY = "ONE";

    const int UNKNOWN_KEY = 0;
    const string DEFAULT_VALUE = "DEFAULT";

    [Fact]
    public void GetValueOrDefault_ShouldReturnValue_ForKnownKey()
    {
        // Arrange: A dictionary with one key-value pair.
        var TestDictionary = new Dictionary<int, string>{
            {KNOWN_KEY, VALUE_FOR_KNOWN_KEY}
        };

        // Act: Attempt to get the known value using its key.
        var result = TestDictionary.GetValueOrDefault(KNOWN_KEY, DEFAULT_VALUE);

        // Assert: That the value was returned correctly.
        result.Should().Be(VALUE_FOR_KNOWN_KEY);
    }

    [Fact]
    public void GetValueOrDefault_ShouldReturnDefault_ForUnknownKey()
    {
        // Arrange: A dictionary with one key-value pair.
        var TestDictionary = new Dictionary<int, string>{
            {KNOWN_KEY, VALUE_FOR_KNOWN_KEY}
        };

        // Act: Attempt to get a value using a key that's not in the dictionary.
        var result = TestDictionary.GetValueOrDefault(UNKNOWN_KEY, DEFAULT_VALUE);

        // Assert: That the default value was returned.
        result.Should().Be(DEFAULT_VALUE);
    }
}