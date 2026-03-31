// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.ExportImport;

using System;

using Dnn.ExportImport.Components.Common;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(10_000_000, LogLevel.Trace, "Site Export/Import: Job Finished")]
    public static partial void ExportImportSchedulerJobFinished(this ILogger logger);

    [LoggerMessage(10_000_001, LogLevel.Error, "The Scheduler item stopped because main thread stopped, set schedule into emergency mode so it will start after app restart.")]
    public static partial void ExportImportSchedulerItemStoppedBecauseMainThreadStoppedSetScheduledIntoEmergencyModeSoItWillStartAfterAppRestart(this ILogger logger);

    [LoggerMessage(10_000_100, LogLevel.Error, "Unable to clear {TypeName} while calling CleanupDatabaseIfDirty.")]
    public static partial void ExportImportEngineUnableToClear(this ILogger logger, Exception exception, string typeName);

    [LoggerMessage(10_000_200, LogLevel.Error, "ModuleContent: (Module ID={ModuleId}). {XmlContent}")]
    public static partial void PagesExportServiceModuleContentError(this ILogger logger, Exception exception, int moduleId, string xmlContent);

    [LoggerMessage(EventId = 10_000_201, Level = LogLevel.Error)]
    public static partial void PagesExportServiceImportNewTabModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_000_201, Level = LogLevel.Error)]
    public static partial void PagesExportServiceImportExistingTabModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_000_202, Level = LogLevel.Error)]
    public static partial void PagesExportServiceDeleteTabModuleException(this ILogger logger, ImportException exception);

    [LoggerMessage(EventId = 10_000_203, Level = LogLevel.Error)]
    public static partial void PagesExportServiceExportModulePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_000_204, Level = LogLevel.Error, Message = "Error creating business class type.")]
    public static partial void PagesExportServiceErrorCreatingBusinessClassType(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_000_300, Level = LogLevel.Error)]
    public static partial void PackagesExportServiceInstallPackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_000_301, Level = LogLevel.Error)]
    public static partial void PackagesExportServiceProcessImportModulePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_000_400, Level = LogLevel.Error)]
    public static partial void ThemesExportServiceImportThemeFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_000_500, Level = LogLevel.Error, Message = "Failed to delete the job data. Error:{Message}. It will need to be deleted manually. Folder Path:{FolderPath}")]
    public static partial void BaseControllerFailedToDeleteJobData(this ILogger logger, Exception exception, string message, string folderPath);
}
