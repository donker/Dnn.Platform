// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Maintenance;

using System;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(12_000_000, LogLevel.Warning, "Could not determine Telerik dependencies on some assemblies.")]
    public static partial void TelerikUtilsCountNotDetermineTelerikDependenciesOnSomeAssemblies(this ILogger logger, Exception exception);
}
