// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.PersonaBar.UI;

using System;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(EventId = 3_000_000, Level = LogLevel.Information, Message = "{LogStart}Removal of assembly:{AssemblyName}")]
    public static partial void BusinessControllerRemovalOfAssembly(this ILogger logger, string logStart, string assemblyName);

    [LoggerMessage(EventId = 3_000_001, Level = LogLevel.Information, Message = "{AssemblyUnregistered} - {FileName}")]
    public static partial void BusinessControllerAssemblyUnregistered(this ILogger logger, string assemblyUnregistered, string fileName);

    [LoggerMessage(EventId = 3_000_002, Level = LogLevel.Information, Message = "{AssemblyInUse} - {AssemblyName}")]
    public static partial void BusinessControllerAssemblyInUse(this ILogger logger, string assemblyInUse, string assemblyName);

    [LoggerMessage(EventId = 3_000_100, Level = LogLevel.Error, Message = "{TypeFullName}.Init threw an exception.")]
    public static partial void PersonaBarModuleSkinEventsInitThrewAnException(this ILogger logger, Exception exception, string typeFullName);

    [LoggerMessage(EventId = 3_000_101, Level = LogLevel.Error, Message = "{TypeFullName}.Load threw an exception.")]
    public static partial void PersonaBarModuleSkinEventsLoadThrewAnException(this ILogger logger, Exception exception, string typeFullName);

    [LoggerMessage(EventId = 3_000_102, Level = LogLevel.Error, Message = "{TypeFullName}.PreRender threw an exception.")]
    public static partial void PersonaBarModuleSkinEventsPreRenderThrewAnException(this ILogger logger, Exception exception, string typeFullName);

    [LoggerMessage(EventId = 3_000_102, Level = LogLevel.Error, Message = "{TypeFullName}.UnLoad threw an exception.")]
    public static partial void PersonaBarModuleSkinEventsUnLoadThrewAnException(this ILogger logger, Exception exception, string typeFullName);

    [LoggerMessage(EventId = 3_000_200, Level = LogLevel.Error)]
    public static partial void ComponentsControllerGetRoleGroupsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_201, Level = LogLevel.Error)]
    public static partial void ComponentsControllerGetSuggestionUsersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_202, Level = LogLevel.Error)]
    public static partial void ComponentsControllerGetSuggestionRolesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_300, Level = LogLevel.Error)]
    public static partial void TabsControllerGetPortalTabsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_301, Level = LogLevel.Error)]
    public static partial void TabsControllerSearchPortalTabsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_302, Level = LogLevel.Error)]
    public static partial void TabsControllerGetPortalTabException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_303, Level = LogLevel.Error)]
    public static partial void TabsControllerGetTabsDescendantsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_400, Level = LogLevel.Error)]
    public static partial void PortalsControllerGetPortalsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_000_500, Level = LogLevel.Error)]
    public static partial void MenuExtensionsControllerGetExtensionControllerException(this ILogger logger, Exception exception);
}
