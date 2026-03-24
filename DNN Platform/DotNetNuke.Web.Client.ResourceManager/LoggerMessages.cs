// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Client.ResourceManager;

using System;

using DotNetNuke.Abstractions.ClientResources;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(8_000_000, LogLevel.Debug, "ClientResourceController initialized with ID {ControllerId}")]
    public static partial void ClientResourceControllerControllerInitialized(this ILogger logger, Guid controllerId);

    [LoggerMessage(8_000_001, LogLevel.Debug, "Rendering dependencies for CRC id {ControllerId} with ResourceType={ResourceType}, Provider={Provider}, ApplicationPath={ApplicationPath}. We have {ScriptsCount} scripts, {StylesheetsCount} stylesheets and {FontsCount} fonts.")]
    public static partial void ClientResourceControllerRenderingDependencies(this ILogger logger, Guid controllerId, ResourceType resourceType, string provider, string applicationPath, int scriptsCount, int stylesheetsCount, int fontsCount);

    [LoggerMessage(8_000_002, LogLevel.Debug, "Adding resource {ResolvedPath} to CRC id {ControllerId} which currently has {Count} resources")]
    public static partial void ClientResourceControllerAddingResource(this ILogger logger, string resolvedPath, Guid controllerId, int count);
}
