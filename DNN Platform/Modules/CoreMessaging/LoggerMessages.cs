// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.CoreMessaging
{
    using System;

    using Microsoft.Extensions.Logging;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(EventId = 17_000_000, Level = LogLevel.Error)]
        public static partial void CoreMessagingBusinessControllerUpgradeModuleException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 17_000_100, Level = LogLevel.Error)]
        public static partial void FileUploadControllerUploadFileException(this ILogger logger, Exception exception);
    }
}
