// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.PersonaBar.UI;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(3_000_000, LogLevel.Information, "{LogStart}Removal of assembly:{AssemblyName}")]
    public static partial void BusinessControllerRemovalOfAssembly(this ILogger logger, string logStart, string assemblyName);

    [LoggerMessage(3_000_001, LogLevel.Information, "{AssemblyUnregistered} - {FileName}")]
    public static partial void BusinessControllerAssemblyUnregistered(this ILogger logger, string assemblyUnregistered, string fileName);

    [LoggerMessage(3_000_002, LogLevel.Information, "{AssemblyInUse} - {AssemblyName}")]
    public static partial void BusinessControllerAssemblyInUse(this ILogger logger, string assemblyInUse, string assemblyName);
}
