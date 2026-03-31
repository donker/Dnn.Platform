// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.PersonaBar.Library;

using System;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(6_000_000, LogLevel.Information, "Type \"{TypeFullName}\"'s version ({TypeVersion}) doesn't match current version({CurrentVersion}) so ignored")]
    public static partial void EventsControllerVersionMismatch(this ILogger logger, string typeFullName, Version typeVersion, Version currentVersion);

    [LoggerMessage(6_000_001, LogLevel.Error, "{TypeFullName}.ApplicationStart threw an exception.")]
    public static partial void EventsControllerApplicationStartThrewAnException(this ILogger logger, Exception exception, string typeFullName);

    [LoggerMessage(6_000_002, LogLevel.Error, "{TypeFullName}.ApplicationEnd threw an exception.")]
    public static partial void EventsControllerApplicationEndThrewAnException(this ILogger logger, Exception exception, string typeFullName);

    [LoggerMessage(6_000_003, LogLevel.Error, "Unable to create {TypeFullName} while calling Application start implementors.")]
    public static partial void EventsControllerUnableToCreateAppEventHandler(this ILogger logger, Exception exception, string typeFullName);

    [LoggerMessage(6_000_100, LogLevel.Warning, "No instance of type '{TypeFullName}' and name '{Name}' is registered in the IOC container.")]
    public static partial void IocUtilNoInstanceOfTypeAndNameIsRegisteredInTheIocContainer(this ILogger logger, string typeFullName, string name);

    [LoggerMessage(EventId = 6_000_101, Level = LogLevel.Error)]
    public static partial void IocUtilRegisterComponentException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_102, Level = LogLevel.Error)]
    public static partial void IocUtilRegisterComponentInstanceException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_200, Level = LogLevel.Error)]
    public static partial void MenuPermissionControllerGetMenuPermissionsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_201, Level = LogLevel.Error)]
    public static partial void MenuPermissionControllerEnsureMenuDefaultPermissionsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_202, Level = LogLevel.Error)]
    public static partial void MenuPermissionControllerSaveMenuDefaultPermissionsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_203, Level = LogLevel.Error, Message = "Role \"{RoleName}\" in portal \"{PortalId}\" doesn't marked as system role, will ignore add this default permission to {MenuItemIdentifier}.")]
    public static partial void MenuPermissionControllerRoleInPortalNotMarkedAsSystemRoleIgnoring(this ILogger logger, string roleName, int portalId, string menuItemIdentifier);

    [LoggerMessage(EventId = 6_000_300, Level = LogLevel.Error)]
    public static partial void PersonaBarControllerIsVisibleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_301, Level = LogLevel.Error)]
    public static partial void PersonaBarControllerGetMenuItemControllerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_302, Level = LogLevel.Error)]
    public static partial void PersonaBarControllerUpdateParametersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_303, Level = LogLevel.Error)]
    public static partial void PersonaBarControllerGetMenuSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_400, Level = LogLevel.Error)]
    public static partial void ModulesControllerCopyModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000_401, Level = LogLevel.Error)]
    public static partial void ModulesControllerDeleteModuleException(this ILogger logger, Exception exception);
}
