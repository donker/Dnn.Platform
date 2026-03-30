// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.Groups
{
    using System;

    using Microsoft.Extensions.Logging;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(EventId = 22_000_000, Level = LogLevel.Error)]
        public static partial void ModerationServiceControllerApproveGroupException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 22_000_001, Level = LogLevel.Error)]
        public static partial void ModerationServiceControllerRejectGroupException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 22_000_002, Level = LogLevel.Error)]
        public static partial void ModerationServiceControllerJoinGroupException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 22_000_003, Level = LogLevel.Error)]
        public static partial void ModerationServiceControllerLeaveGroupException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 22_000_004, Level = LogLevel.Error)]
        public static partial void ModerationServiceControllerApproveMemberException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 22_000_005, Level = LogLevel.Error)]
        public static partial void ModerationServiceControllerRejectMemberException(this ILogger logger, Exception exception);
    }
}
