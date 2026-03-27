// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.EditBar.UI;

using System;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(13_000_000, LogLevel.Error, "Unable to create {TypeFullName} while getting all edit bar menu items.")]
    public static partial void EditBarControllerUnableToCreateMenuItem(this ILogger logger, Exception exception, string typeFullName);
}
