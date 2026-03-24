// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Website
{
    using System.Threading;

    using Microsoft.Extensions.Logging;

    /// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
    internal static partial class LoggerMessages
    {
        [LoggerMessage(EventId = 900_000, Level = LogLevel.Debug)]
        public static partial void SecurityRolesThreadAbortException(this ILogger logger, ThreadAbortException exception);

        [LoggerMessage(EventId = 900_001, Level = LogLevel.Debug)]
        public static partial void ModuleSettingsThreadAbortException(this ILogger logger, ThreadAbortException exception);
    }
}
