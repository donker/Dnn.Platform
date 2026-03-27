// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Mvc;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(1_000_000, LogLevel.Trace, "Registered a total of {Count} routes")]
    public static partial void MvcRoutingManagerRegisteredRoutes(this ILogger logger, int count);

    [LoggerMessage(1_000_001, LogLevel.Trace, "Mapping route: {FullRouteName} @ {RouteUrl}")]
    public static partial void MvcRoutingManagerMappingRoute(this ILogger logger, string fullRouteName, string routeUrl);

    [LoggerMessage(1_000_100, LogLevel.Warning, "The specified moniker ({Moniker}) is not defined in the system")]
    public static partial void StandardTabAndModuleInfoProviderMonikerIsNotDefined(this ILogger logger, string moniker);
}
