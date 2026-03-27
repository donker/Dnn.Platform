// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.PersonaBar;

using System;

using DotNetNuke.Services.Connections;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(EventId = 5_000_000, Level = LogLevel.Information)]
    public static partial void SecurityControllerUpdateIpFilterArgumentException(this ILogger logger, ArgumentException exception);

    [LoggerMessage(EventId = 5_000_100, Level = LogLevel.Warning)]
    public static partial void ConnectorsControllerSaveConnectionConnectorArgumentException(this ILogger logger, ConnectorArgumentException exception);
}
