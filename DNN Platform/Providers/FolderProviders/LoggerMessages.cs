// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Providers.FolderProviders
{
    using System;

    using Microsoft.Extensions.Logging;
    using Microsoft.WindowsAzure.Storage;

    using LogLevel = Microsoft.Extensions.Logging.LogLevel;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(EventId = 17_000_000, Level = LogLevel.Error)]
        public static partial void SettingsStorageCredentialsException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 17_000_001, Level = LogLevel.Error)]
        public static partial void SettingsCreateContainerStorageException(this ILogger logger, StorageException exception);

        [LoggerMessage(EventId = 17_000_002, Level = LogLevel.Error)]
        public static partial void SettingsCreateContainerGeneralException(this ILogger logger, Exception exception);

        [LoggerMessage(EventId = 17_000_003, Level = LogLevel.Error)]
        public static partial void SettingsLoadContainersStorageException(this ILogger logger, StorageException exception);

        [LoggerMessage(EventId = 17_000_004, Level = LogLevel.Error)]
        public static partial void SettingsLoadContainersGeneralException(this ILogger logger, Exception exception);
    }
}
