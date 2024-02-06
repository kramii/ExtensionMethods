using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void Repeat_ShouldRepeatTheString()
    {
        "abc".Repeat(3).Should().Be("abcabcabc");
    }
}