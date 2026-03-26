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
}
