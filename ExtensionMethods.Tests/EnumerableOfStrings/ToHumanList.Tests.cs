using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
[Fact]
    public void ToHumanList_ShouldMakeEmptyList_WhenGivenNoElements()
    {
        var elements = new List<string> ();
        elements.ToHumanList().ToString().Should().Be("");
    }

    [Fact]
    public void ToHumanList_ShouldMakeList_WhenGivenFiveElements()
    {
        var elements = new List<string> { "one", "two", "three", "four", "five" };
        elements.ToHumanList().ToString().Should().Be("one, two, three, four and five");
    }

    [Fact]
    public void ToHumanList_ShouldMakeSingleWord_WhenGivenOneElements()
    {
        var elements = new List<string> { "one" };
        elements.ToHumanList().ToString().Should().Be("one");
    }

    [Fact]
    public void ToHumanList_ShouldMakePair_WhenGivenTwoElements()
    {
        var elements = new List<string> { "one", "two" };
        elements.ToHumanList(" followed by ").ToString().Should().Be("one followed by two");
    }
}