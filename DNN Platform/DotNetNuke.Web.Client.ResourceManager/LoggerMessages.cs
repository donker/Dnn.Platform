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
    [LoggerMessage(EventId = 8_000_000, Level = LogLevel.Debug, Message = "ClientResourceController initialized with ID {ControllerId}")]
    public static partial void ClientResourceControllerControllerInitialized(this ILogger logger, Guid controllerId);

    [LoggerMessage(EventId = 8_000_001, Level = LogLevel.Debug, Message = "Rendering dependencies for CRC id {ControllerId} with ResourceType={ResourceType}, Provider={Provider}, ApplicationPath={ApplicationPath}. We have {ScriptsCount} scripts, {StylesheetsCount} stylesheets and {FontsCount} fonts.")]
    public static partial void ClientResourceControllerRenderingDependencies(this ILogger logger, Guid controllerId, ResourceType resourceType, string provider, string applicationPath, int scriptsCount, int stylesheetsCount, int fontsCount);

    [LoggerMessage(EventId = 8_000_002, Level = LogLevel.Debug, Message = "Adding resource {ResolvedPath} to CRC id {ControllerId} which currently has {Count} resources")]
    public static partial void ClientResourceControllerAddingResource(this ILogger logger, string resolvedPath, Guid controllerId, int count);

    [LoggerMessage(EventId = 8_000_003, Level = LogLevel.Error, Message = "Cannot add resource {ResolvedPath} to CRC id {ControllerId} because rendering has already begun")]
    public static partial void ClientResourceControllerCannotAddResourceBecauseRenderingHasAlreadyBegun(this ILogger logger, string resolvedPath, Guid controllerId);
}
