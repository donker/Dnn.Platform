// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.DependencyInjection;

using System.Reflection;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(EventId = 11_000_000, Level = LogLevel.Warning, Message = "Unable to get all types for {AssemblyFullName}, see exception for details\n{Message}")]
    public static partial void SecurityControllerUpdateIpFilterArgumentException(this ILogger logger, ReflectionTypeLoadException exception, string assemblyFullName, string message);
}
