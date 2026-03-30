// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Providers.AspNetClientCapabilityProvider;

using System;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(EventId = 16_000_000, Level = LogLevel.Error)]
    public static partial void AspNetClientCapabilityDetectOperatingSystemException(this ILogger logger, Exception exception);
}
