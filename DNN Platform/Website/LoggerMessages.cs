// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Website
{
    using System;
    using System.Threading;
    using System.Web.Security;

    using Microsoft.Extensions.Logging;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(EventId = 900_000, Level = LogLevel.Debug)]
        public static partial void SecurityRolesThreadAbortException(this ILogger logger, ThreadAbortException exception);

        [LoggerMessage(EventId = 900_001, Level = LogLevel.Debug)]
        public static partial void ModuleSettingsThreadAbortException(this ILogger logger, ThreadAbortException exception);

        [LoggerMessage(EventId = 900_100, Level = LogLevel.Error)]
        public static partial void InstallDeletePortalResourcesFileException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_101, Level = LogLevel.Error)]
        public static partial void InstallNoUpgradeException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_200, Level = LogLevel.Error)]
        public static partial void UpgradeWizardAntiForgeryTokenException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_300, Level = LogLevel.Error)]
        public static partial void ToastInitializeConfigException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_400, Level = LogLevel.Error)]
        public static partial void PayPalSubscriptionUserAddressException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_500, Level = LogLevel.Error)]
        public static partial void EditUserUpdateException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_600, Level = LogLevel.Error)]
        public static partial void PasswordResetArgumentException(this ILogger logger, ArgumentException exception);

        [LoggerMessage(EventId = 900_601, Level = LogLevel.Error)]
        public static partial void PasswordResetGeneralException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_602, Level = LogLevel.Error)]
        public static partial void PasswordUserResetArgumentException(this ILogger logger, ArgumentException exception);

        [LoggerMessage(EventId = 900_603, Level = LogLevel.Error)]
        public static partial void PasswordUserResetGeneralException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_604, Level = LogLevel.Error)]
        public static partial void PasswordUserUpdateMembershipPasswordException(this ILogger logger, MembershipPasswordException exception);

        [LoggerMessage(EventId = 900_605, Level = LogLevel.Error)]
        public static partial void PasswordUserUpdateGeneralException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_606, Level = LogLevel.Error)]
        public static partial void PasswordUserAdminUpdateMembershipPasswordException(this ILogger logger, MembershipPasswordException exception);

        [LoggerMessage(EventId = 900_607, Level = LogLevel.Error)]
        public static partial void PasswordUserAdminUpdateGeneralException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_700, Level = LogLevel.Error)]
        public static partial void UserUpdateException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_800, Level = LogLevel.Error)]
        public static partial void DnnLoginCleanUsernameException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_801, Level = LogLevel.Error)]
        public static partial void DnnLoginSetFormFocusException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 900_900, Level = LogLevel.Error)]
        public static partial void AuthenticationLoginPageNoException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 901_000, Level = LogLevel.Error, Message = "CSP error")]
        public static partial void DefaultCspError(this ILogger logger, Exception exception);
    }
}
