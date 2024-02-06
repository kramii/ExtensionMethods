using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void ToHex_ShouldReturnHex()
    {
        byte fe = 0xFE;
        fe.ToHex().Should().Be("fe");
    }

    [Fact]
    public void ToHex_ShouldReturnPrefixedHex_WhenPrefixSupplied()
    {
        byte fe = 0xFE;
        fe.ToHex("0x").Should().Be("0xfe");
    }
}