// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web;

using System;
using System.IO;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(EventId = 7_000_000, Message = "{Message}")]
    public static partial void TraceWriterLogMessage(this ILogger logger, LogLevel logLevel, string message);

    [LoggerMessage(7_000_100, LogLevel.Information, "Watcher Activity: {ChangeType}. Path: {FullPath}")]
    public static partial void ShutdownOverloadWatcherActivity(this ILogger logger, WatcherChangeTypes changeType, string fullPath);

    [LoggerMessage(7_000_101, LogLevel.Information, "Watcher Activity: {ChangeType}. New Path: {NewPath}. Old Path: {OldPath}")]
    public static partial void ShutdownOverloadWatcherRenamedActivity(this ILogger logger, WatcherChangeTypes changeType, string newPath, string oldPath);

    [LoggerMessage(7_000_102, LogLevel.Information, "Watcher Activity: N/A. Error:")]
    public static partial void ShutdownOverloadWatcherError(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_000_103, Level = LogLevel.Information)]
    public static partial void ShutdownOverloadInitializeFcnSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(7_000_104, LogLevel.Information, "fileChangesMonitor is null")]
    public static partial void ShutdownOverloadFileChangesMonitorIsNull(this ILogger logger);

    [LoggerMessage(7_000_105, LogLevel.Information, "FCNMode = {fcnMode} (Modes: NotSet/Default=0, Disabled=1, Single=2)")]
    public static partial void ShutdownOverloadFileChangeNotificationMode(this ILogger logger, object fcnMode);

    [LoggerMessage(7_000_200, LogLevel.Information, "Application Starting ({ElapsedSinceAppStart})")]
    public static partial void ApplicationStarting(this ILogger logger, TimeSpan elapsedSinceAppStart);

    [LoggerMessage(7_000_201, LogLevel.Information, "Application Started ({ElapsedSinceAppStart})")]
    public static partial void ApplicationStarted(this ILogger logger, TimeSpan elapsedSinceAppStart);

    [LoggerMessage(7_000_202, LogLevel.Information, "Application Ending")]
    public static partial void ApplicationEnding(this ILogger logger);

    [LoggerMessage(7_000_203, LogLevel.Information, "Application Ended")]
    public static partial void ApplicationEnded(this ILogger logger);

    [LoggerMessage(7_000_300, LogLevel.Trace, "Authorization header scheme in the request is not equal to {AuthScheme}")]
    public static partial void ApiTokenControllerAuthorizationHeaderSchemeDoesNotMatchAuthScheme(this ILogger logger, string authScheme);

    [LoggerMessage(7_000_301, LogLevel.Trace, "Missing authorization header value in the request")]
    public static partial void ApiTokenControllerMissingAuthorizationHeaderValue(this ILogger logger);

    [LoggerMessage(7_000_302, LogLevel.Trace, "Token expired")]
    public static partial void ApiTokenControllerTokenExpired(this ILogger logger);

    [LoggerMessage(7_000_303, LogLevel.Trace, "Invalid user")]
    public static partial void ApiTokenControllerInvalidUser(this ILogger logger);

    [LoggerMessage(7_000_400, LogLevel.Trace, "Authenticated using API token {ApiTokenId}")]
    public static partial void ApiTokenAuthMessageHandlerAuthenticatedUsingApiToken(this ILogger logger, int apiTokenId);

    [LoggerMessage(7_000_500, LogLevel.Trace, "{AuthScheme}: Validating request vs. SSL mode ({ForceSsl}) failed. ")]
    public static partial void AuthMessageHandlerBaseValidatingRequestVsSslModeFailed(this ILogger logger, string authScheme, bool forceSsl);

    [LoggerMessage(7_000_600, LogLevel.Trace, "Mapping route: {FullRouteName} @ {RouteUrl}")]
    public static partial void ServicesRoutingManagerMappingRoute(this ILogger logger, string fullRouteName, string routeUrl);

    [LoggerMessage(7_000_601, LogLevel.Trace, "Mapping route: {OldRouteName} @ {OldRouteUrl}")]
    public static partial void ServicesRoutingManagerMappingOldRoute(this ILogger logger, string oldRouteName, string oldRouteUrl);
}
