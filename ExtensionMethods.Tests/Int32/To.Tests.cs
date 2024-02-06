using ExtensionMethods;
using FluentAssertions;

namespace ExtensionMethods.Tests;

public partial class ExtensionMethodsTests
{
    [Fact]
    public void Seconds_ShouldBeFiveSeconds_WhenValueIsFive()
    {
        TimeSpan fiveSeconds = new TimeSpan(0, 0, 5);
        5.Seconds().Should().Be(fiveSeconds);
    }

    [Fact]
    public void Minutes_ShouldBeFiveMinutes_WhenValueIsFive()
    {
        TimeSpan fiveMinutes = new TimeSpan(0, 5, 0);
        5.Minutes().Should().Be(fiveMinutes);
    }

        [Fact]
    public void Hours_ShouldBeFiveHours_WhenValueIsFive()
    {
        TimeSpan fiveHours = new TimeSpan(5, 0, 0);
        5.Hours().Should().Be(fiveHours);
    }

    
}