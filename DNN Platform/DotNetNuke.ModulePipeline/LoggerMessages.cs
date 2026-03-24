// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.ModulePipeline;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(1, LogLevel.Debug, "ModuleControlFactory.LoadModuleControl Start (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlPipelineLoadModuleControlStart(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(2, LogLevel.Debug, "ModuleControlFactory.LoadModuleControl End (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlPipelineLoadModuleControlEnd(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(3, LogLevel.Debug, "ModuleControlFactory.LoadSettingsControl Start (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlPipelineLoadSettingsControlStart(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(4, LogLevel.Debug, "ModuleControlFactory.LoadSettingsControl End (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlPipelineLoadSettingsControlEnd(this ILogger logger, int tabId, int moduleId, string moduleControlSource);
}
