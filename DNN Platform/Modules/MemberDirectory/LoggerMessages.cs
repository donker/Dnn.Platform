// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.MemberDirectory
{
    using System;

    using Microsoft.Extensions.Logging;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(EventId = 21_000_000, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerAdvancedSearchException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_001, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerBasicSearchException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_002, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerGetMemberException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_003, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerGetSuggestionsException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_004, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerAcceptFriendException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_005, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerAddFriendException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_006, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerFollowException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_007, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerRemoveFriendException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 21_000_008, Level = LogLevel.Error)]
        public static partial void MemberDirectoryControllerUnfollowException(this ILogger logger, Exception exception);
    }
}
