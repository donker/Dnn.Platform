// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Client;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(2_000_000, LogLevel.Information, "Removing ClientDependency from web.config")]
    public static partial void ClientResourceManagerRemovingClientDependencyFromWebConfig(this ILogger logger);

    [LoggerMessage(2_000_001, LogLevel.Information, "Removing configSections/clientDependency")]
    public static partial void ClientResourceManagerRemovingClientDependencyConfigSection(this ILogger logger);

    [LoggerMessage(2_000_002, LogLevel.Information, "Removing system.webServer/modules/ClientDependencyModule")]
    public static partial void ClientResourceManagerRemovingClientDependencyModule(this ILogger logger);

    [LoggerMessage(2_000_003, LogLevel.Information, "Removing system.webServer/handlers/ClientDependencyHandler")]
    public static partial void ClientResourceManagerRemovingClientDependencyHandler(this ILogger logger);

    [LoggerMessage(2_000_004, LogLevel.Information, "Removing clientDependency")]
    public static partial void ClientResourceManagerRemovingClientDependencyElement(this ILogger logger);
}
