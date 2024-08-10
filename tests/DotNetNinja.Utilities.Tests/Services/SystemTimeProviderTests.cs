using DotNetNinja.Utilities.Services;
using FluentAssertions;

namespace DotNetNinja.Utilities.Tests.Services;

public class SystemTimeProviderTests
{
    [Fact]
    public void Now_ShouldReturnCurrentSystemTime()
    {
        var provider = CreateSut();

        var now = provider.Now;

        now.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(300));
    }

    [Fact]
    public void UtcNow_ShouldReturnCurrentUtcTime()
    {
        var provider = CreateSut();

        var now = provider.UtcNow;

        now.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromMilliseconds(300));
    }

    [Fact]
    public void OffsetNow_ShouldReturnCurrentDateTimeOffset()
    {
        var provider = CreateSut();

        var now = provider.OffsetNow;

        now.Should().BeCloseTo(DateTimeOffset.Now, TimeSpan.FromMilliseconds(300));
    }

    [Fact]
    public void RequestTime_ShouldReturnConsistentTimeOfInstantiation()
    {
        var expected = DateTime.Now;
        var provider = CreateSut();

        var result1 = provider.RequestTime;
        Thread.Sleep(50);
        var result2 = provider.RequestTime;

        result1.Should().BeCloseTo(expected, TimeSpan.FromMilliseconds(300));
        result2.Should().Be(result1);
    }

    private SystemTimeProvider CreateSut()
    {
        return new SystemTimeProvider();
    }
}