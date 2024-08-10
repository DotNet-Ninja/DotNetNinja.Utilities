using System;

namespace DotNetNinja.Utilities.Services
{
    public class SystemTimeProvider : ITimeProvider
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;

        public DateTimeOffset OffsetNow => DateTimeOffset.Now;
        public DateTimeOffset RequestTime { get; } = DateTimeOffset.Now;
    }
}
