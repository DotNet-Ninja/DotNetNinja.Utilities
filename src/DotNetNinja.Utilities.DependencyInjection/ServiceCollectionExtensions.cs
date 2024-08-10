using DotNetNinja.Utilities.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetNinja.Utilities.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTimeProvider(this IServiceCollection services)
    {
        return services.AddSingleton<ITimeProvider, SystemTimeProvider>();
    }
}
