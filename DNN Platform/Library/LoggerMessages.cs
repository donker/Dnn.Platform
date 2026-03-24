// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke;

using System;

using Lucene.Net.Search;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(1_000, LogLevel.Debug, "PortalModuleBase.OnInit Start (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnInitStart(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_001, LogLevel.Debug, "PortalModuleBase.OnInit End (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnInitEnd(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_002, LogLevel.Debug, "PortalModuleBase.OnLoad Start (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnLoadStart(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_003, LogLevel.Debug, "PortalModuleBase.OnLoad End (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnLoadEnd(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_100, LogLevel.Debug, "{Origin} {Action} (TabId:{TabId},{Message})")]
    public static partial void PageBaseTrace(this ILogger logger, string origin, string action, int tabId, string message);

    [LoggerMessage(1_200, LogLevel.Debug, "ScheduleHistoryItem.Succeeded Info (ScheduledTask Start): {FriendlyName}")]
    public static partial void ScheduleHistoryItemSucceededStart(this ILogger logger, string friendlyName);

    [LoggerMessage(1_201, LogLevel.Debug, "ScheduleHistoryItem.Succeeded Info (ScheduledTask End): {FriendlyName}")]
    public static partial void ScheduleHistoryItemSucceededEnd(this ILogger logger, string friendlyName);

    [LoggerMessage(EventId = 1300, Level = LogLevel.Debug)]
    public static partial void SchedulerReaderLockRequestTimeout(this ILogger logger, Exception exception);

    [LoggerMessage(1_301, LogLevel.Debug, "loadqueue executingServer: {ExecutingServer}")]
    public static partial void SchedulerLoadQueue(this ILogger logger, string executingServer);

    [LoggerMessage(1_302, LogLevel.Debug, "LoadQueueFromTimer executingServer: {ExecutingServer}")]
    public static partial void SchedulerLoadQueueFromTimer(this ILogger logger, string executingServer);

    [LoggerMessage(1_400, LogLevel.Trace, "Query: {Query}\n{Explanation}")]
    public static partial void LuceneControllerSearchResultExplanation(this ILogger logger, Query query, string explanation);

    [LoggerMessage(1_500, LogLevel.Debug, "Container.ProcessModule Start (TabId:{TabId},ModuleID: {DesktopModuleId}): Module FriendlyName: '{ModuleFriendlyName}')")]
    public static partial void ContainerProcessModuleStart(this ILogger logger, int tabId, int desktopModuleId, string moduleFriendlyName);

    [LoggerMessage(1_501, LogLevel.Debug, "Container.ProcessModule Info (TabId:{TabId},ModuleID: {DesktopModuleId}): ControlPane.Controls.Add(ModuleHost:{ModuleHostId})")]
    public static partial void ContainerProcessModuleInfo(this ILogger logger, int tabId, int desktopModuleId, string moduleHostId);

    [LoggerMessage(1_502, LogLevel.Debug, "Container.ProcessModule End (TabId:{TabId},ModuleID: {DesktopModuleId}): Module FriendlyName: '{ModuleFriendlyName}')")]
    public static partial void ContainerProcessModuleEnd(this ILogger logger, int tabId, int desktopModuleId, string moduleFriendlyName);

    [LoggerMessage(1_600, LogLevel.Debug, "ModuleControlFactory.LoadModuleControl Start (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadModuleControlStart(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(1_601, LogLevel.Debug, "ModuleControlFactory.LoadModuleControl End (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadModuleControlEnd(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(1_602, LogLevel.Debug, "ModuleControlFactory.LoadSettingsControl Start (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadSettingsControlStart(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(1_603, LogLevel.Debug, "ModuleControlFactory.LoadSettingsControl End (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadSettingsControlEnd(this ILogger logger, int tabId, int moduleId, string moduleControlSource);
}
