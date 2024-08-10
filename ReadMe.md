# DotNetNinja.Utilities
A set of utility classes for common functionality.

# Installation
Coming Soon...

# Features

## ITimeProvider
Provides a way to get the current time in a way that can be easily mocked for testing.

**Usage**

```csharp
    // Dependency Injection (Add to StartUp.cs or Program.cs)
    services.AddTimeProvider();

    // Get the current time
    var time = TimeProvider.Now;

    // Get the current time in UTC
    var utcTime = TimeProvider.UtcNow;

    // Get the current time with offset
    var offsetTime = TimeProvider.OffsetNow;

    // Get the time the provider was created
    var requestTime = TimeProvider.RequestTime;
```

> Note: Using the AddTimeProvider extension method will add provider with scoped lifetime.  This will effectively make RequestTime ~ the time the request was received.  This is useful for logging, or putting timestamps onto multiple objects you are creating/updating in a single request and having consistent timestamps across them all.