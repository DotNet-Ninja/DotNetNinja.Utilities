using DotNetNinja.Utilities.Services;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetNinja.Utilities.DependencyInjection.Tests;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddTimeProvider_ShouldAddSystemTimeProviderInSingletonScope()
    {
        var services = new ServiceCollection();

        services.AddTimeProvider();

        var descriptor = services.SingleOrDefault(s => s.ServiceType == typeof(ITimeProvider));

        descriptor.Should().NotBeNull();
        descriptor!.ImplementationType.Should().Be(typeof(SystemTimeProvider));
        descriptor.Lifetime.Should().Be(ServiceLifetime.Singleton);
    }
}