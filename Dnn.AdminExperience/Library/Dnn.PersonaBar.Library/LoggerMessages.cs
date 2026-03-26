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
}
