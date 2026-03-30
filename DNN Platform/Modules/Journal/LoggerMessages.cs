// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.Journal
{
    using System;

    using Microsoft.Extensions.Logging;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(EventId = 19_000_000, Level = LogLevel.Error)]
        public static partial void ServicesControllerCreateException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_001, Level = LogLevel.Error)]
        public static partial void ServicesControllerDeleteException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_002, Level = LogLevel.Error)]
        public static partial void ServicesControllerSoftDeleteException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_003, Level = LogLevel.Error)]
        public static partial void ServicesControllerPreviewUrlException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_004, Level = LogLevel.Error)]
        public static partial void ServicesControllerGetListForProfileException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_005, Level = LogLevel.Error)]
        public static partial void ServicesControllerLikeException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_006, Level = LogLevel.Error)]
        public static partial void ServicesControllerCommentSaveException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_007, Level = LogLevel.Error)]
        public static partial void ServicesControllerCommentDeleteException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_008, Level = LogLevel.Error)]
        public static partial void ServicesControllerGetSuggestionsException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_100, Level = LogLevel.Error)]
        public static partial void FileUploadControllerUploadFileException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 19_000_200, Level = LogLevel.Error)]
        public static partial void NotificationServicesControllerViewJournalException(this ILogger logger, Exception exception);
    }
}
