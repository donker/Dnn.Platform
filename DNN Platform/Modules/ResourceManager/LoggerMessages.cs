// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.Modules.ResourceManager
{
    using System;

    using Microsoft.Extensions.Logging;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(4_000_000, LogLevel.Information, "Adding Global Assets host menu item.")]
        public static partial void ResourceManagerControllerAddingGlobalAssetsHostMenuItem(this ILogger logger);

        [LoggerMessage(4_000_001, LogLevel.Information, "Added Global Assets host menu item.")]
        public static partial void ResourceManagerControllerAddedGlobalAssetsHostMenuItem(this ILogger logger);

        [LoggerMessage(4_000_002, LogLevel.Information, "Removing old pages.")]
        public static partial void ResourceManagerControllerRemovingOldPages(this ILogger logger);

        [LoggerMessage(EventId = 4_000_003, Level = LogLevel.Error)]
        public static partial void ResourceManagerControllerUpgradeModuleException(this ILogger logger, Exception exception);
    }
}
