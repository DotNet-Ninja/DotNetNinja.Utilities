using System;

namespace DotNetNinja.Utilities.Services
{
    public interface ITimeProvider
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateTimeOffset OffsetNow { get; }
        DateTimeOffset RequestTime { get; }
    }
}