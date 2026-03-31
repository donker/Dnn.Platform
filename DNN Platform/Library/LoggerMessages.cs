// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke;

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Web.UI;

using DotNetNuke.Abstractions.Application;
using DotNetNuke.Entities.Tabs.TabVersions.Exceptions;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.FileSystem;
using DotNetNuke.Services.Log.EventLog;
using DotNetNuke.Services.Search.Entities;
using DotNetNuke.Services.Upgrade.Internals.Steps;

using Lucene.Net.Search;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(1_000, LogLevel.Debug, "PortalModuleBase.OnInit Start (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnInitStart(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_001, LogLevel.Debug, "PortalModuleBase.OnInit End (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnInitEnd(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_002, LogLevel.Debug, "PortalModuleBase.OnLoad Start (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnLoadStart(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_003, LogLevel.Debug, "PortalModuleBase.OnLoad End (TabId:{TabId},ModuleId:{ModuleId}): {Type}")]
    public static partial void PortalModuleBaseOnLoadEnd(this ILogger logger, int tabId, int moduleId, Type type);

    [LoggerMessage(1_100, LogLevel.Debug, "{Origin} {Action} (TabId:{TabId},{Message})")]
    public static partial void PageBaseTrace(this ILogger logger, string origin, string action, int tabId, string message);

    [LoggerMessage(1_101, LogLevel.Critical, "An error has occurred while loading page.")]
    public static partial void PageBaseAnErrorHasOccurredWhileLoadingPage(this ILogger logger, Exception exception);

    [LoggerMessage(1_200, LogLevel.Debug, "ScheduleHistoryItem.Succeeded Info (ScheduledTask Start): {FriendlyName}")]
    public static partial void ScheduleHistoryItemSucceededStart(this ILogger logger, string friendlyName);

    [LoggerMessage(1_201, LogLevel.Debug, "ScheduleHistoryItem.Succeeded Info (ScheduledTask End): {FriendlyName}")]
    public static partial void ScheduleHistoryItemSucceededEnd(this ILogger logger, string friendlyName);

    [LoggerMessage(1_202, LogLevel.Trace, "{Notes}")]
    public static partial void ScheduleHistoryItemLogNote(this ILogger logger, string notes);

    [LoggerMessage(EventId = 1300, Level = LogLevel.Debug)]
    public static partial void SchedulerReaderLockRequestTimeout(this ILogger logger, Exception exception);

    [LoggerMessage(1_301, LogLevel.Debug, "loadqueue executingServer: {ExecutingServer}")]
    public static partial void SchedulerLoadQueue(this ILogger logger, string executingServer);

    [LoggerMessage(1_302, LogLevel.Debug, "LoadQueueFromTimer executingServer: {ExecutingServer}")]
    public static partial void SchedulerLoadQueueFromTimer(this ILogger logger, string executingServer);

    [LoggerMessage(1_400, LogLevel.Trace, "Query: {Query}\n{Explanation}")]
    public static partial void LuceneControllerSearchResultExplanation(this ILogger logger, Query query, string explanation);

    [LoggerMessage(1_401, LogLevel.Debug, "Compacting Search Index - started")]
    public static partial void LuceneControllerCompactingSearchIndexStarted(this ILogger logger);

    [LoggerMessage(1_402, LogLevel.Debug, "Compacting Search Index - finished")]
    public static partial void LuceneControllerCompactingSearchIndexFinished(this ILogger logger);

    [LoggerMessage(EventId = 1_403, Level = LogLevel.Error)]
    public static partial void LuceneControllerSearchException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 1_404, Level = LogLevel.Error)]
    public static partial void LuceneControllerGetCustomAnalyzerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 1_405, Level = LogLevel.Error, Message = "Search Index Folder Is Not Available: {Message}, Retry {Retries} time(s).")]
    public static partial void LuceneControllerSearchIndexFolderIsNotAvailable(this ILogger logger, Exception exception, string message, int retries);

    [LoggerMessage(1_500, LogLevel.Debug, "Container.ProcessModule Start (TabId:{TabId},ModuleID: {DesktopModuleId}): Module FriendlyName: '{ModuleFriendlyName}')")]
    public static partial void ContainerProcessModuleStart(this ILogger logger, int tabId, int desktopModuleId, string moduleFriendlyName);

    [LoggerMessage(1_501, LogLevel.Debug, "Container.ProcessModule Info (TabId:{TabId},ModuleID: {DesktopModuleId}): ControlPane.Controls.Add(ModuleHost:{ModuleHostId})")]
    public static partial void ContainerProcessModuleInfo(this ILogger logger, int tabId, int desktopModuleId, string moduleHostId);

    [LoggerMessage(1_502, LogLevel.Debug, "Container.ProcessModule End (TabId:{TabId},ModuleID: {DesktopModuleId}): Module FriendlyName: '{ModuleFriendlyName}')")]
    public static partial void ContainerProcessModuleEnd(this ILogger logger, int tabId, int desktopModuleId, string moduleFriendlyName);

    [LoggerMessage(1_600, LogLevel.Debug, "ModuleControlFactory.LoadModuleControl Start (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadModuleControlStart(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(1_601, LogLevel.Debug, "ModuleControlFactory.LoadModuleControl End (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadModuleControlEnd(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(1_602, LogLevel.Debug, "ModuleControlFactory.LoadSettingsControl Start (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadSettingsControlStart(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(1_603, LogLevel.Debug, "ModuleControlFactory.LoadSettingsControl End (TabId:{TabId},ModuleId:{ModuleId}): ModuleControlSource:{ModuleControlSource}")]
    public static partial void ModuleControlFactoryLoadSettingsControlEnd(this ILogger logger, int tabId, int moduleId, string moduleControlSource);

    [LoggerMessage(EventId = 1_700, Level = LogLevel.Debug)]
    public static partial void DataProviderSqlExceptionFromAddPropertyDefinition(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 1_701, Level = LogLevel.Error)]
    public static partial void DataProviderSqlExceptionFromAddSearchDeletedItems(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 1_702, Level = LogLevel.Error)]
    public static partial void DataProviderSqlExceptionFromDeleteProcessedSearchDeletedItems(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 1_800, Level = LogLevel.Debug)]
    public static partial void LogControllerConfigFileNotFound(this ILogger logger, FileNotFoundException exception);

    [LoggerMessage(1_801, LogLevel.Information, "{LogInfo}")]
    public static partial void LogControllerLogInfo(this ILogger logger, LogInfo logInfo);

    [LoggerMessage(EventId = 1_801, Level = LogLevel.Debug)]
    public static partial void LogControllerFailureToWriteToLogFile(this ILogger logger, IOException exception);

    [LoggerMessage(1_802, LogLevel.Error, "filePath={FilePath}, header={Header}, message={Message}")]
    public static partial void LogControllerRaiseError(this ILogger logger, string filePath, string header, string message);

    [LoggerMessage(EventId = 1_803, Level = LogLevel.Error)]
    public static partial void LogControllerAddLogException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 1_804, Level = LogLevel.Error)]
    public static partial void LogControllerAddLogToFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 1_805, Level = LogLevel.Error, Message = "Unable to retrieve HttpContext.Request, ignoring LogUserName")]
    public static partial void LogControllerUnableToRetrieveRequestIgnoringLogUserName(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 1_900, Level = LogLevel.Debug)]
    public static partial void PurgeModuleCachePurgeNotSupportedException(this ILogger logger, NotSupportedException exception);

    [LoggerMessage(EventId = 2_000, Level = LogLevel.Debug)]
    public static partial void PurgeOutputCachePurgeNotSupportedException(this ILogger logger, NotSupportedException exception);

    [LoggerMessage(EventId = 2_100, Level = LogLevel.Debug)]
    public static partial void UserProfilePageHandlerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_200, Level = LogLevel.Debug)]
    public static partial void ModuleHostThreadAbortException(this ILogger logger, ThreadAbortException exception);

    [LoggerMessage(EventId = 2_201, Level = LogLevel.Error)]
    public static partial void ModuleHostLoadModuleControlException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_300, Level = LogLevel.Debug)]
    public static partial void CaptchaControlDecryptException(this ILogger logger, ArgumentException exception);

    [LoggerMessage(EventId = 2_301, Level = LogLevel.Error)]
    public static partial void CaptchaControlCreateTextException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_302, Level = LogLevel.Error)]
    public static partial void CaptchaControlGetFontException(this ILogger logger, Exception exception);

    [LoggerMessage(2_400, LogLevel.Debug, "GetExecutingServerName: {ExecutingServerName}")]
    public static partial void ServerControllerGetExecutingServerName(this ILogger logger, string executingServerName);

    [LoggerMessage(2_401, LogLevel.Debug, "GetServerName: {ServerName}")]
    public static partial void ServerControllerGetServerName(this ILogger logger, string serverName);

    [LoggerMessage(EventId = 2_402, Level = LogLevel.Error)]
    public static partial void ServerControllerGetServerUrlException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_403, Level = LogLevel.Error)]
    public static partial void ServerControllerGetServerUniqueIdException(this ILogger logger, Exception exception);

    [LoggerMessage(2_500, LogLevel.Information, "Application shutting down. Reason: {Reason}")]
    public static partial void InitializeApplicationShuttingDown(this ILogger logger, string reason);

    [LoggerMessage(EventId = 2_501, Level = LogLevel.Information, Message = "Application shutting down. Reason: {Reason}\nASP.NET Shutdown Info: {ShutdownMessage}\n{ShutdownStack}")]
    public static partial void InitializeApplicationShuttingDownWithInfo(this ILogger logger, string reason, string shutdownMessage, string shutdownStack);

    [LoggerMessage(EventId = 2_502, Level = LogLevel.Information, Message = "UnderConstruction page was shown because application needs to be installed, and both the AutoUpgrade and UseWizard AppSettings in web.config are false. Use /install/install.aspx?mode=install to install application. ")]
    public static partial void InitializeUnderConstructionPageShownBecauseInstallationNeeded(this ILogger logger);

    [LoggerMessage(EventId = 2_503, Level = LogLevel.Information, Message = "UnderConstruction page was shown because application needs to be upgraded, and both the AutoUpgrade and UseInstallWizard AppSettings in web.config are false. Use /install/install.aspx?mode=upgrade to upgrade application. ")]
    public static partial void InitializeUnderConstructionPageShownBecauseUpgradeNeeded(this ILogger logger);

    [LoggerMessage(EventId = 2_504, Level = LogLevel.Information, Message = "Application Initializing")]
    public static partial void InitializeApplicationInitializing(this ILogger logger);

    [LoggerMessage(EventId = 2_505, Level = LogLevel.Information, Message = "Application Initialized")]
    public static partial void InitializeApplicationInitialized(this ILogger logger);

    [LoggerMessage(EventId = 2_506, Level = LogLevel.Trace, Message = "Running Schedule {SchedulerMode}")]
    public static partial void InitializeRunningSchedule(this ILogger logger, SchedulerMode schedulerMode);

    [LoggerMessage(EventId = 2_507, Level = LogLevel.Trace, Message = "Request {LocalPath}")]
    public static partial void InitializeRequest(this ILogger logger, string localPath);

    [LoggerMessage(EventId = 2_508, Level = LogLevel.Error, Message = "UnderConstruction page was shown because we cannot ascertain the application was ever installed, and there is no working database connection. Check database connectivity before continuing. ")]
    public static partial void InitializeUnderConstructionPageShownBecauseNoWorkingDatabaseConnection(this ILogger logger);

    [LoggerMessage(EventId = 2_509, Level = LogLevel.Error, Message = "The connection to the database has failed, the application is not installed yet, and both AutoUpgrade and UseInstallWizard are not set in web.config, a 500 error page will be shown to visitors")]
    public static partial void InitializeConnectionToTheDatabaseHasFailedTheApplicationIsNotInstalledYetA500ErrorPageWillBeShown(this ILogger logger);

    [LoggerMessage(EventId = 2_510, Level = LogLevel.Error, Message = "The connection to the database has failed, however, the application is already completely installed, a 500 error page will be shown to visitors")]
    public static partial void InitializeConnectionToTheDatabaseHasFailedHoweverTheApplicationIsAlreadyCompletelyInstalledA500ErrorPageWillBeShown(this ILogger logger);

    [LoggerMessage(EventId = 2_600, Level = LogLevel.Information, Message = "{RootPath} does not exist. ")]
    public static partial void FileSystemUtilsFolderDoesNotExist(this ILogger logger, string rootPath);

    [LoggerMessage(EventId = 2_601, Level = LogLevel.Error, Message = "Reading from {FilePath} didn't read all data in buffer. Requested to read {BufferLength} bytes, but was read {ReadCount} bytes")]
    public static partial void FileSystemUtilsAddToZipDidNotReadAllDataInBuffer(this ILogger logger, string filePath, long bufferLength, int readCount);

    [LoggerMessage(EventId = 2_602, Level = LogLevel.Error)]
    public static partial void FileSystemUtilsDeleteFileWithWaitException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_603, Level = LogLevel.Error)]
    public static partial void FileSystemUtilsUnzipResourcesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_604, Level = LogLevel.Error)]
    public static partial void FileSystemUtilsDeleteFilesFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_605, Level = LogLevel.Error)]
    public static partial void FileSystemUtilsDeleteFilesFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_605, Level = LogLevel.Error)]
    public static partial void FileSystemUtilsDeleteFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_605, Level = LogLevel.Error)]
    public static partial void FileSystemUtilsDeleteFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_605, Level = LogLevel.Error)]
    public static partial void FileSystemUtilsUnzipException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_700, Level = LogLevel.Information, Message = "{Message}")]
    public static partial void FolderManagerInvalidFileExtensionException(this ILogger logger, string message);

    [LoggerMessage(EventId = 2_701, Level = LogLevel.Error)]
    public static partial void FolderManagerAddFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_702, Level = LogLevel.Error)]
    public static partial void FolderManagerDeleteFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_703, Level = LogLevel.Error)]
    public static partial void FolderManagerGetFileSystemFoldersRecursiveException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_704, Level = LogLevel.Error)]
    public static partial void FolderManagerRemoveOrphanedFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_705, Level = LogLevel.Error)]
    public static partial void FolderManagerAddOrUpdateFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_706, Level = LogLevel.Error)]
    public static partial void FolderManagerSynchronizeFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_707, Level = LogLevel.Error)]
    public static partial void FolderManagerDeleteFolderInternalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_708, Level = LogLevel.Error, Message = "Could not create folder {FolderPath}. EXCEPTION: {Message}")]
    public static partial void FolderManagerCouldNotCreateFolder(this ILogger logger, Exception exception, string folderPath, string message);

    [LoggerMessage(EventId = 2_800, Level = LogLevel.Information, Message = "{Message}")]
    public static partial void InstallLoggerLogInfo(this ILogger logger, string message);

    [LoggerMessage(EventId = 2_801, Level = LogLevel.Warning, Message = "{Message}")]
    public static partial void InstallLoggerLogWarning(this ILogger logger, string message);

    [LoggerMessage(EventId = 2_802, Level = LogLevel.Error, Message = "{Message}")]
    public static partial void InstallLoggerLogFailure(this ILogger logger, string message);

    [LoggerMessage(EventId = 2_900, Level = LogLevel.Information, Message = "Starting WebServerMonitor")]
    public static partial void WebServerMonitorStartingWebServerMonitor(this ILogger logger);

    [LoggerMessage(EventId = 2_901, Level = LogLevel.Information, Message = "Starting UpdateCurrentServerActivity")]
    public static partial void WebServerMonitorStartingUpdateCurrentServerActivity(this ILogger logger);

    [LoggerMessage(EventId = 2_902, Level = LogLevel.Information, Message = "Starting RemoveInActiveServers")]
    public static partial void WebServerMonitorStartingRemoveInActiveServers(this ILogger logger);

    [LoggerMessage(EventId = 2_903, Level = LogLevel.Information, Message = "Finished RemoveInActiveServers")]
    public static partial void WebServerMonitorFinishedRemoveInActiveServers(this ILogger logger);

    [LoggerMessage(EventId = 2_904, Level = LogLevel.Information, Message = "Finished UpdateCurrentServerActivity")]
    public static partial void WebServerMonitorFinishedUpdateCurrentServerActivity(this ILogger logger);

    [LoggerMessage(EventId = 2_905, Level = LogLevel.Information, Message = "Finished WebServerMonitor")]
    public static partial void WebServerMonitorFinishedWebServerMonitor(this ILogger logger);

    [LoggerMessage(EventId = 2_906, Level = LogLevel.Error, Message = "Error in WebServerMonitor: {Message}. {StackTrace}")]
    public static partial void WebServerMonitorErrorInWebServerMonitor(this ILogger logger, Exception exception, string message, string stackTrace);

    [LoggerMessage(EventId = 3_000, Level = LogLevel.Trace, Message = "Action succeeded - {Description}")]
    public static partial void RetryableActionSucceeded(this ILogger logger, string description);

    [LoggerMessage(EventId = 3_001, Level = LogLevel.Trace, Message = "Retrying action {RetriesRemaining} - {Description}")]
    public static partial void RetryableActionRetrying(this ILogger logger, int retriesRemaining, string description);

    [LoggerMessage(EventId = 3_002, Level = LogLevel.Warning, Message = "All retries of action failed - {Description}")]
    public static partial void RetryableActionAllRetriesFailed(this ILogger logger, string description);

    [LoggerMessage(EventId = 3_100, Level = LogLevel.Trace, Message = "ModuleIndexer: {Count} search documents found for module [{DesktopModuleName} mid:{ModuleId}]")]
    public static partial void ModuleIndexerSearchDocumentsFoundForModule(this ILogger logger, int count, string desktopModuleName, int moduleId);

    [LoggerMessage(EventId = 3_101, Level = LogLevel.Trace, Message = "ModuleIndexer: Search document for metaData found for module [{DesktopModuleName} mid:{ModuleId}]")]
    public static partial void ModuleIndexerSearchDocumentForMetadataFoundForModule(this ILogger logger, string desktopModuleName, int moduleId);

    [LoggerMessage(EventId = 3_102, Level = LogLevel.Error)]
    public static partial void ModuleIndexerGetModulesForIndexException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_200, Level = LogLevel.Trace, Message = "TabIndexer: Search document for metaData added for page [{Title} tid:{TabId}]")]
    public static partial void TabIndexerPageMetadataDocumentAdded(this ILogger logger, string title, int tabId);

    [LoggerMessage(EventId = 3_300, Level = LogLevel.Trace, Message = "Localizing TabId: {TabId}, TabPath: {TabPath}, Locale: {Locale}")]
    public static partial void TabControllerLocalizingTab(this ILogger logger, int tabId, string tabPath, string locale);

    [LoggerMessage(EventId = 3_301, Level = LogLevel.Warning, Message = "Invalid tabId {TabId} of portal {PortalId}")]
    public static partial void TabControllerInvalidTabId(this ILogger logger, int tabId, int portalId);

    [LoggerMessage(EventId = 3_301, Level = LogLevel.Warning, Message = "Unable to find tabId {TabId} of portal {PortalId}")]
    public static partial void TabControllerUnableToFindTabId(this ILogger logger, int tabId, int portalId);

    [LoggerMessage(EventId = 3_400, Level = LogLevel.Trace, Message = "Adding FcnMode : {ErrorMessage}")]
    public static partial void AddFcnModeStepAddingFcnMode(this ILogger logger, string errorMessage);

    [LoggerMessage(EventId = 3_500, Level = LogLevel.Trace, Message = "FilePermissionCheck - {Details}")]
    public static partial void FilePermissionCheckStepCheck(this ILogger logger, string details);

    [LoggerMessage(EventId = 3_600, Level = LogLevel.Trace, Message = "FilePermissionCheck Status - {Status}")]
    public static partial void FilePermissionCheckStepStatus(this ILogger logger, StepStatus status);

    [LoggerMessage(EventId = 3_700, Level = LogLevel.Trace, Message = "Adding InstallVersion : {ErrorMessage}")]
    public static partial void InstallVersionStepAddingInstallVersion(this ILogger logger, string errorMessage);

    [LoggerMessage(EventId = 3_800, Level = LogLevel.Trace, Message = "GetUpgradedScripts databaseVersion:{DatabaseVersion} applicationVersion:{ApplicationVersion}")]
    public static partial void UpgradeGetUpgradedScripts(this ILogger logger, Version databaseVersion, Version applicationVersion);

    [LoggerMessage(EventId = 3_801, Level = LogLevel.Trace, Message = "GetUpgradedScripts including {File}")]
    public static partial void UpgradeGetUpgradedScriptsIncluding(this ILogger logger, string file);

    [LoggerMessage(EventId = 3_802, Level = LogLevel.Error)]
    public static partial void UpgradeAddModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_803, Level = LogLevel.Error)]
    public static partial void UpgradeAddPortalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_804, Level = LogLevel.Error)]
    public static partial void UpgradeDeleteFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_805, Level = LogLevel.Error)]
    public static partial void UpgradeExceptionDeletingScriptFileAfterExecution(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_806, Level = LogLevel.Error)]
    public static partial void UpgradeExceptionDeletingPackageFileAfterInstallation(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_807, Level = LogLevel.Error)]
    public static partial void UpgradeExceptionInUpgradeApplication(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_808, Level = LogLevel.Error)]
    public static partial void UpgradeExceptionLoggingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_809, Level = LogLevel.Error, Message = "{Version}")]
    public static partial void UpgradeExceptionDuringVersionSpecificUpgrade(this ILogger logger, Exception exception, Version version);

    [LoggerMessage(EventId = 3_810, Level = LogLevel.Error, Message = "{Version}")]
    public static partial void UpgradeExceptionWritingExceptionLogForVersionSpecificUpgrade(this ILogger logger, Exception exception, Version version);

    [LoggerMessage(EventId = 3_811, Level = LogLevel.Error)]
    public static partial void UpgradeExceptionUpdatingConfig(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_812, Level = LogLevel.Error)]
    public static partial void UpgradeExceptionLoggingExceptionFromUpdatingConfig(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_813, Level = LogLevel.Error)]
    public static partial void UpgradeUpdateNewtonsoftVersionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_814, Level = LogLevel.Error)]
    public static partial void UpgradeCreateExecuteScriptLogException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_815, Level = LogLevel.Error)]
    public static partial void UpgradeCreateMemberRoleProviderLogException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_816, Level = LogLevel.Error)]
    public static partial void UpgradeRemoveGettingStartedPageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_817, Level = LogLevel.Error)]
    public static partial void UpgradeFixFipsComplianceAssemblyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_818, Level = LogLevel.Error)]
    public static partial void UpgradeFindLanguageXmlDocumentException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 3_819, Level = LogLevel.Error, Message = "Error cleanup file {ListFile}")]
    public static partial void UpgradeErrorCleanupFile(this ILogger logger, Exception exception, string listFile);

    [LoggerMessage(EventId = 3_820, Level = LogLevel.Error, Message = "File deletion failed for [Install/{File}]. PLEASE REMOVE THIS MANUALLY.")]
    public static partial void UpgradeFileDeletionFailedFor(this ILogger logger, Exception exception, string file);

    [LoggerMessage(EventId = 3_821, Level = LogLevel.Error, Message = "{LogDescription}")]
    public static partial void UpgradeFailureLog(this ILogger logger, string logDescription);

    [LoggerMessage(EventId = 3_900, Level = LogLevel.Trace, Message = "Getting component for {FullName}")]
    public static partial void ContainerWithServiceProviderFallbackGettingComponent(this ILogger logger, string fullName);

    [LoggerMessage(EventId = 3_901, Level = LogLevel.Trace, Message = "Got component for {FullName} from container")]
    public static partial void ContainerWithServiceProviderFallbackGotComponentFromContainer(this ILogger logger, string fullName);

    [LoggerMessage(EventId = 3_902, Level = LogLevel.Trace, Message = "Getting component for {FullName} from service provider")]
    public static partial void ContainerWithServiceProviderFallbackGettingComponentFromServiceProvider(this ILogger logger, string fullName);

    [LoggerMessage(EventId = 4_000, Level = LogLevel.Trace, Message = "{Details}")]
    public static partial void InstallExtensionsStepInstallingExtensionPackage(this ILogger logger, string details);

    [LoggerMessage(EventId = 4_100, Level = LogLevel.Trace, Message = "Search: Site Crawler - Starting. Content change start time {LastSuccessfulDateTime}")]
    public static partial void SearchEngineSchedulerStarting(this ILogger logger, DateTime lastSuccessfulDateTime);

    [LoggerMessage(EventId = 4_101, Level = LogLevel.Trace, Message = "Search: Site Crawler - Indexing Successful")]
    public static partial void SearchEngineSchedulerSuccessful(this ILogger logger);

    [LoggerMessage(EventId = 4_200, Level = LogLevel.Trace, Message = "Getting application status")]
    public static partial void ApplicationStatusInfoGettingStatus(this ILogger logger);

    [LoggerMessage(EventId = 4_201, Level = LogLevel.Trace, Message = "result of getting providerpath: {Message}")]
    public static partial void ApplicationStatusInfoResultOfGettingProviderPath(this ILogger logger, string message);

    [LoggerMessage(EventId = 4_202, Level = LogLevel.Trace, Message = "Application status is {Status}")]
    public static partial void ApplicationStatusInfoStatusIs(this ILogger logger, UpgradeStatus status);

    [LoggerMessage(EventId = 4_203, Level = LogLevel.Error)]
    public static partial void ApplicationStatusInfoDatabaseVersionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_300, Level = LogLevel.Trace, Message = "Executing SQL Script {SQL}")]
    public static partial void SqlDataProviderExecutingSqlScript(this ILogger logger, string sql);

    [LoggerMessage(EventId = 4_301, Level = LogLevel.Error)]
    public static partial void SqlDataProviderGrantProcedureExecutePermissionException(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 4_302, Level = LogLevel.Error)]
    public static partial void SqlDataProviderGrantFunctionExecutePermissionException(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 4_303, Level = LogLevel.Error)]
    public static partial void SqlDataProviderExecuteScriptException(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 4_304, Level = LogLevel.Error)]
    public static partial void SqlDataProviderExecuteSqlException(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 4_305, Level = LogLevel.Error)]
    public static partial void SqlDataProviderExecuteSqlGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_306, Level = LogLevel.Error)]
    public static partial void SqlDataProviderExecuteUpgradedConnectionQueryException(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 4_400, Level = LogLevel.Warning)]
    public static partial void FileManagerExtractFilesPermissionsNotMet(this ILogger logger, PermissionsNotMetException exception);

    [LoggerMessage(EventId = 4_401, Level = LogLevel.Warning)]
    public static partial void FileManagerExtractFilesNoSpaceAvailable(this ILogger logger, NoSpaceAvailableException exception);

    [LoggerMessage(EventId = 4_402, Level = LogLevel.Warning)]
    public static partial void FileManagerExtractFilesInvalidFileExtension(this ILogger logger, InvalidFileExtensionException exception);

    [LoggerMessage(EventId = 4_403, Level = LogLevel.Error)]
    public static partial void FileManagerAddFileLockedException(this ILogger logger, FileLockedException exception);

    [LoggerMessage(EventId = 4_404, Level = LogLevel.Error)]
    public static partial void FileManagerAddFileGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_405, Level = LogLevel.Error)]
    public static partial void FileManagerCopyFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_406, Level = LogLevel.Error)]
    public static partial void FileManagerFileExistsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_407, Level = LogLevel.Error)]
    public static partial void FileManagerGetFileStreamException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_408, Level = LogLevel.Error)]
    public static partial void FileManagerGetFileUrlException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_409, Level = LogLevel.Error)]
    public static partial void FileManagerRenameFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_410, Level = LogLevel.Error)]
    public static partial void FileManagerSetAttributesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_411, Level = LogLevel.Error)]
    public static partial void FileManagerUpdateSizeAndModificationTimeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_412, Level = LogLevel.Error)]
    public static partial void FileManagerUpdateExtractFilesGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_413, Level = LogLevel.Error)]
    public static partial void FileManagerWriteToStreamException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_414, Level = LogLevel.Error)]
    public static partial void FileManagerWriteStreamException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_415, Level = LogLevel.Error)]
    public static partial void FileManagerDeleteFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_416, Level = LogLevel.Error)]
    public static partial void FileManagerAddFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_417, Level = LogLevel.Error)]
    public static partial void FileManagerRotateFlipImageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_500, Level = LogLevel.Warning, Message = "Unable to load file properties for File ID {FileId}")]
    public static partial void AttachmentControllerUnableToLoadFileProperties(this ILogger logger, int fileId);

    [LoggerMessage(EventId = 4_600, Level = LogLevel.Warning, Message = "Missing localization key. key:{Key} resFileRoot:{ResourceFileRoot} threadCulture:{ThreadCulture} userlan:{UserLanguage}")]
    public static partial void LocalizationProviderMissingLocalizationKey(this ILogger logger, string key, string resourceFileRoot, CultureInfo threadCulture, string userLanguage);

    [LoggerMessage(EventId = 4_601, Level = LogLevel.Error)]
    public static partial void LocalizationProviderGetLocaleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 4_700, Level = LogLevel.Warning, Message = "Unable to find module by module ID. ID:{DesktopModuleId} PortalID:{PortalId}")]
    public static partial void DesktopModuleControllerUnableToFindModuleByModuleId(this ILogger logger, int desktopModuleId, int portalId);

    [LoggerMessage(EventId = 4_701, Level = LogLevel.Warning, Message = "Unable to find module by package ID. ID:{PackageId}")]
    public static partial void DesktopModuleControllerUnableToFindModuleByPackageId(this ILogger logger, int packageId);

    [LoggerMessage(EventId = 4_702, Level = LogLevel.Warning, Message = "Unable to find module by name. Name:{DesktopModuleName} portalId:{PortalId}")]
    public static partial void DesktopModuleControllerUnableToFindModuleByName(this ILogger logger, string desktopModuleName, int portalId);

    [LoggerMessage(EventId = 4_703, Level = LogLevel.Warning, Message = "Unable to find module by friendly name. Name:{FriendlyName}")]
    public static partial void DesktopModuleControllerUnableToFindModuleByFriendlyName(this ILogger logger, string friendlyName);

    [LoggerMessage(EventId = 4_800, Level = LogLevel.Warning, Message = "Indexer not implemented")]
    public static partial void SearchEngineIndexerNotImplemented(this ILogger logger, NotImplementedException exception);

    [LoggerMessage(EventId = 4_900, Level = LogLevel.Warning, Message = "Unable to create type via service provider: {Type}")]
    public static partial void ReflectionUnableToCreateTypeViaServiceProvider(this ILogger logger, InvalidOperationException exception, Type type);

    [LoggerMessage(EventId = 4_901, Level = LogLevel.Error, Message = "{TypeName}")]
    public static partial void ReflectionCreateTypeException(this ILogger logger, Exception exception, string typeName);

    [LoggerMessage(EventId = 5_000, Level = LogLevel.Warning, Message = "Container was null, instantiating SimpleContainer")]
    public static partial void ComponentFactoryInstantiatingSimpleContainer(this ILogger logger);

    [LoggerMessage(EventId = 5_100, Level = LogLevel.Warning, Message = "Icon Not Present on Disk {PhysicalPath}")]
    public static partial void IconControllerIconNotPresentOnDisk(this ILogger logger, string physicalPath);

    [LoggerMessage(EventId = 5_200, Level = LogLevel.Warning, Message = "Current Workflow and Default workflow are not found on NotifyWorkflowAboutChanges")]
    public static partial void TabWorkflowTrackerCurrentWorkflowAndDefaultWorkflowAreNotFoundOnNotifyWorkflowAboutChanges(this ILogger logger);

    [LoggerMessage(EventId = 5_300, Level = LogLevel.Warning, Message = "Disable cache expiration.")]
    public static partial void CachingProviderDisableCacheExpiration(this ILogger logger);

    [LoggerMessage(EventId = 5_301, Level = LogLevel.Warning, Message = "Enable cache expiration.")]
    public static partial void CachingProviderEnableCacheExpiration(this ILogger logger);

    [LoggerMessage(EventId = 5_400, Level = LogLevel.Warning, Message = "{Message}")]
    public static partial void StandardFolderProviderFileStreamIOException(this ILogger logger, IOException exception, string message);

    [LoggerMessage(EventId = 5_401, Level = LogLevel.Error)]
    public static partial void StandardFolderProviderGetFileAttributesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_402, Level = LogLevel.Error)]
    public static partial void StandardFolderProviderGetLastModificationTimeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_403, Level = LogLevel.Error)]
    public static partial void StandardFolderProviderFileStreamGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_500, Level = LogLevel.Warning, Message = "Ignoring invalid cleanup folder path '{Path}' in package '{PackageName}'.")]
    public static partial void CleanupInstallerIgnoringInvalidCleanupFolderPath(this ILogger logger, string path, string packageName);

    [LoggerMessage(EventId = 5_501, Level = LogLevel.Error)]
    public static partial void CleanupInstallerCleanupFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_501, Level = LogLevel.Error)]
    public static partial void CleanupInstallerCleanupFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_600, Level = LogLevel.Error, Message = "Invalid data type {DataTypeId} for profile property {PropertyName}")]
    public static partial void UserProfileInvalidDataType(this ILogger logger, int dataTypeId, string propertyName);

    [LoggerMessage(EventId = 5_700, Level = LogLevel.Error, Message = "Error localizing module, moduleId: {ModuleId}")]
    public static partial void ModuleControllerErrorLocalizingModule(this ILogger logger, Exception exception, int moduleId);

    [LoggerMessage(EventId = 5_701, Level = LogLevel.Error)]
    public static partial void ModuleControllerModuleAlreadyOnThePageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_702, Level = LogLevel.Error)]
    public static partial void ModuleControllerAddContentException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_800, Level = LogLevel.Error, Message = "WebResponse exception: {ResponseContent}")]
    public static partial void OAuthClientBaseWebResponseException(this ILogger logger, WebException exception, string responseContent);

    [LoggerMessage(EventId = 5_900, Level = LogLevel.Error, Message = "FriendlyMessage=\"{FriendlyMessage}\" ctrl=\"{Control}\"")]
    public static partial void ExceptionsProcessModuleLoadException(this ILogger logger, Exception exception, string friendlyMessage, Control control);

    [LoggerMessage(EventId = 5_901, Level = LogLevel.Error)]
    public static partial void ExceptionsGetExceptionInfoReflectionPermissionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_902, Level = LogLevel.Error)]
    public static partial void ExceptionsLogModuleLoadException(this ILogger logger, ModuleLoadException exception);

    [LoggerMessage(EventId = 5_903, Level = LogLevel.Error)]
    public static partial void ExceptionsLogPageLoadException(this ILogger logger, PageLoadException exception);

    [LoggerMessage(EventId = 5_904, Level = LogLevel.Error)]
    public static partial void ExceptionsLogSchedulerException(this ILogger logger, SchedulerException exception);

    [LoggerMessage(EventId = 5_905, Level = LogLevel.Error)]
    public static partial void ExceptionsLogSecurityException(this ILogger logger, SecurityException exception);

    [LoggerMessage(EventId = 5_906, Level = LogLevel.Error)]
    public static partial void ExceptionsLogGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_907, Level = LogLevel.Error)]
    public static partial void ExceptionsProcessSchedulerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_908, Level = LogLevel.Error)]
    public static partial void ExceptionsLogSearchException(this ILogger logger, SearchException exception);

    [LoggerMessage(EventId = 5_909, Level = LogLevel.Error, Message = "{URL}")]
    public static partial void ExceptionsProcessPageLoadExceptionWithUrl(this ILogger logger, Exception exception, string url);

    [LoggerMessage(EventId = 5_910, Level = LogLevel.Error, Message = "{ResourceNotFound}: - {URL}")]
    public static partial void ExceptionsProcessHttpException(this ILogger logger, Exception exception, string resourceNotFound, string url);

    [LoggerMessage(EventId = 5_911, Level = LogLevel.Critical)]
    public static partial void ExceptionsProcessModuleLoadExceptionUnexpectedException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_000, Level = LogLevel.Error, Message = "Error has occurred getting PageUrl for {TabName}")]
    public static partial void CoreSitemapProviderErrorGettingPageUrl(this ILogger logger, Exception exception, string tabName);

    [LoggerMessage(EventId = 6_100, Level = LogLevel.Error, Message = "Search Document error: {SearchDocument}")]
    public static partial void InternalSearchControllerSearchDocumentError(this ILogger logger, Exception exception, SearchDocument searchDocument);

    [LoggerMessage(EventId = 6_200, Level = LogLevel.Error)]
    public static partial void SettingInfoBoolParseException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_201, Level = LogLevel.Error)]
    public static partial void SettingInfoInt32ParseException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_300, Level = LogLevel.Error)]
    public static partial void ProviderInstallerCouldNotLoadProvider(this ILogger logger, ConfigurationErrorsException exception);

    [LoggerMessage(EventId = 6_400, Level = LogLevel.Error)]
    public static partial void UserOnlineControllerUpdateUsersOnlineException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_500, Level = LogLevel.Error)]
    public static partial void GlobalsRedirectException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_501, Level = LogLevel.Error)]
    public static partial void GlobalsGetTotalRecordsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_502, Level = LogLevel.Error)]
    public static partial void GlobalsDateToStringException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_503, Level = LogLevel.Error)]
    public static partial void GlobalsDeserializeHashTableBase64Exception(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_504, Level = LogLevel.Error)]
    public static partial void GlobalsSerializeHashTableBase64Exception(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_600, Level = LogLevel.Error)]
    public static partial void HostControllerGetBooleanException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_700, Level = LogLevel.Error)]
    public static partial void ListInfoCollectionAddException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_701, Level = LogLevel.Error)]
    public static partial void ListInfoCollectionItemIndexException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_702, Level = LogLevel.Error)]
    public static partial void ListInfoCollectionItemKeyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_703, Level = LogLevel.Error)]
    public static partial void ListInfoCollectionItemKeyCacheException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_800, Level = LogLevel.Error)]
    public static partial void ConfigSaveFileIOException(this ILogger logger, IOException exception);

    [LoggerMessage(EventId = 6_801, Level = LogLevel.Error)]
    public static partial void ConfigSaveFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_802, Level = LogLevel.Error)]
    public static partial void ConfigTouchException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_803, Level = LogLevel.Error)]
    public static partial void ConfigUpdateMachineKeyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_804, Level = LogLevel.Error)]
    public static partial void ConfigUpdateValidationKeyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_805, Level = LogLevel.Error)]
    public static partial void ConfigUpdateInstallVersionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_806, Level = LogLevel.Error)]
    public static partial void ConfigAddFcnModeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 6_900, Level = LogLevel.Error)]
    public static partial void GoogleAnalyticsControllerGetConfigFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_000, Level = LogLevel.Error)]
    public static partial void DataCacheItemRemovedCallbackException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_100, Level = LogLevel.Error)]
    public static partial void AnalyticsConfigGetConfigException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_200, Level = LogLevel.Error)]
    public static partial void SkinThumbNailControlCreateThumbnailException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_300, Level = LogLevel.Error)]
    public static partial void TrueFalseEditControlBooleanValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_301, Level = LogLevel.Error)]
    public static partial void TrueFalseEditControlOldBooleanValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_400, Level = LogLevel.Error)]
    public static partial void IntegerEditControlIntegerValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_401, Level = LogLevel.Error)]
    public static partial void IntegerEditControlOldIntegerValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_500, Level = LogLevel.Error)]
    public static partial void DnnListEditControlIntegerValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_501, Level = LogLevel.Error)]
    public static partial void DnnListEditControlOldIntegerValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_600, Level = LogLevel.Error)]
    public static partial void DateEditControlDateValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_601, Level = LogLevel.Error)]
    public static partial void DateEditControlOldDateValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_700, Level = LogLevel.Error)]
    public static partial void SkinFileProcessorLoadXmlFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_800, Level = LogLevel.Error)]
    public static partial void SkinFileLoadXmlFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_900, Level = LogLevel.Error)]
    public static partial void RoleControllerUserAlreadyBelongsToRoleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_000, Level = LogLevel.Error)]
    public static partial void DnnRoleProviderAddUserToRoleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_100, Level = LogLevel.Error)]
    public static partial void SkinControllerExceptionLoggingInstallationEvent(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_200, Level = LogLevel.Error)]
    public static partial void DbLoggingProviderFillLogInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_201, Level = LogLevel.Error)]
    public static partial void DbLoggingProviderWriteLogSqlException(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 8_202, Level = LogLevel.Error)]
    public static partial void DbLoggingProviderWriteLogGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_300, Level = LogLevel.Error)]
    public static partial void PortalTemplateImporterParseTemplateException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_301, Level = LogLevel.Error)]
    public static partial void PortalTemplateImporterGetFolderMappingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_302, Level = LogLevel.Error)]
    public static partial void PortalTemplateImporterAddFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_303, Level = LogLevel.Error, Message = "{Message}")]
    public static partial void PortalTemplateImporterParseFilesInvalidFileExtensionException(this ILogger logger, InvalidFileExtensionException exception, string message);

    [LoggerMessage(EventId = 8_400, Level = LogLevel.Error)]
    public static partial void ProfileControllerCreateThumbnailsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_401, Level = LogLevel.Error)]
    public static partial void ProfileControllerFillPropertyDefinitionInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_500, Level = LogLevel.Error)]
    public static partial void AddModuleRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_600, Level = LogLevel.Error)]
    public static partial void UrlRewriterUtilsLogExceptionInRequest(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_700, Level = LogLevel.Error)]
    public static partial void ModuleInfoFillException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_800, Level = LogLevel.Error)]
    public static partial void TabVersionBuilderConvertToModuleInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_801, Level = LogLevel.Error, Message = "There was a problem making rollback of the module {ModuleId}.")]
    public static partial void TabVersionBuilderProblemMakingRollbackOfTheModule(this ILogger logger, DnnTabVersionException exception, int moduleId);

    [LoggerMessage(EventId = 8_900, Level = LogLevel.Error)]
    public static partial void FileSystemPermissionVerifierFileCreateException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_901, Level = LogLevel.Error)]
    public static partial void FileSystemPermissionVerifierFileDeleteException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_902, Level = LogLevel.Error)]
    public static partial void FileSystemPermissionVerifierFolderCreateException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 8_903, Level = LogLevel.Error)]
    public static partial void FileSystemPermissionVerifierFolderDeleteException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_000, Level = LogLevel.Error)]
    public static partial void FbCachingProviderPurgeDeleteFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_100, Level = LogLevel.Error)]
    public static partial void AuthenticationConfigConstructorException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_200, Level = LogLevel.Error)]
    public static partial void AuthenticationControllerGetAuthenticationTypeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_300, Level = LogLevel.Error)]
    public static partial void UpdateLanguagePackStepExecuteException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_400, Level = LogLevel.Error)]
    public static partial void AspNetMembershipProviderDeleteUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_500, Level = LogLevel.Error)]
    public static partial void SecurityExceptionInitializeProviderVariablesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_600, Level = LogLevel.Error)]
    public static partial void EventMessageProcessorProcessMessageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_700, Level = LogLevel.Error)]
    public static partial void PortalGroupControllerLogEventException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_800, Level = LogLevel.Error)]
    public static partial void PortalControllerCreateChildPortalFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_801, Level = LogLevel.Error)]
    public static partial void PortalControllerGetPortalSettingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_802, Level = LogLevel.Error)]
    public static partial void PortalControllerGetPortalSettingAsBooleanException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_803, Level = LogLevel.Error)]
    public static partial void PortalControllerGetPortalSettingAsIntegerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_804, Level = LogLevel.Error)]
    public static partial void PortalControllerGetPortalSettingAsDoubleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_805, Level = LogLevel.Error)]
    public static partial void PortalControllerGetAdminUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_806, Level = LogLevel.Error)]
    public static partial void PortalControllerCreateAdminUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_807, Level = LogLevel.Error)]
    public static partial void PortalControllerProcessResourceFileExplicitException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_808, Level = LogLevel.Error)]
    public static partial void PortalControllerLogDeletePortalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_809, Level = LogLevel.Error)]
    public static partial void PortalControllerEnableBrowserLanguageInDefaultException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_810, Level = LogLevel.Error)]
    public static partial void PortalControllerDeleteHomeDirectoryException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_811, Level = LogLevel.Error)]
    public static partial void PortalControllerCreateChildPortalFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_812, Level = LogLevel.Error)]
    public static partial void PortalControllerAddDefaultFolderTypesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_813, Level = LogLevel.Error)]
    public static partial void PortalControllerApplyPortalTemplateException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_814, Level = LogLevel.Error)]
    public static partial void PortalControllerCreateDefaultRelationshipsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_815, Level = LogLevel.Error)]
    public static partial void PortalControllerCreateProfanityListException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_816, Level = LogLevel.Error)]
    public static partial void PortalControllerCreateBannedPasswordsListException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_817, Level = LogLevel.Error)]
    public static partial void PortalControllerLogCreatePortalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 9_818, Level = LogLevel.Error, Message = "{Message}")]
    public static partial void PortalControllerEnsureRequiredProvidersForFolderTypesException(this ILogger logger, Exception exception, string message);

    [LoggerMessage(EventId = 9_819, Level = LogLevel.Error, Message = "{Message}: {FolderTypeName}")]
    public static partial void PortalControllerAddFolderMappingException(this ILogger logger, Exception exception, string message, string folderTypeName);

    [LoggerMessage(EventId = 9_820, Level = LogLevel.Error, Message = "Error while parsing: {TemplateFilePath}")]
    public static partial void PortalControllerErrorWhileParsing(this ILogger logger, Exception exception, string templateFilePath);

    [LoggerMessage(EventId = 9_900, Level = LogLevel.Error, Message = "{LogInfo}")]
    public static partial void RewriterConfigurationGetConfigFailed(this ILogger logger, LogInfo logInfo);

    [LoggerMessage(EventId = 10_000, Level = LogLevel.Error)]
    public static partial void BasePortalExceptionExceptionGettingDataProviderType(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_001, Level = LogLevel.Error)]
    public static partial void BasePortalExceptionExceptionGettingStackTrace(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_002, Level = LogLevel.Error)]
    public static partial void BasePortalExceptionExceptionGettingMessage(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_003, Level = LogLevel.Error)]
    public static partial void BasePortalExceptionExceptionGettingSource(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 10_004, Level = LogLevel.Error)]
    public static partial void BasePortalExceptionInitializePrivateVariablesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 11_000, Level = LogLevel.Error)]
    public static partial void SendTokenizedBulkEmailSendMailsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 12_000, Level = LogLevel.Error)]
    public static partial void FolderMappingsConfigControllerLoadConfigException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 13_000, Level = LogLevel.Error)]
    public static partial void LocalizationGetSystemMessageException(this ILogger logger, NullReferenceException exception);

    [LoggerMessage(EventId = 14_000, Level = LogLevel.Error)]
    public static partial void FileServerHandlerHandleFileLinkException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 15_000, Level = LogLevel.Error)]
    public static partial void ProcessGroupDoWorkException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 16_000, Level = LogLevel.Error)]
    public static partial void InstallerBackupStreamInfoFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 16_001, Level = LogLevel.Error)]
    public static partial void InstallerLogInstallEventException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 16_002, Level = LogLevel.Error, Message = "Exception deleting folder {TempInstallFolder} while installing {Name}")]
    public static partial void InstallerExceptionDeletingFolderWhileInstalling(this ILogger logger, Exception exception, string tempInstallFolder, string name);

    [LoggerMessage(EventId = 17_000, Level = LogLevel.Error)]
    public static partial void FileDeletionControllerDeleteFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 18_000, Level = LogLevel.Error)]
    public static partial void ResourceFileInstallerInstallFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 19_000, Level = LogLevel.Error)]
    public static partial void ModulePackageWriterConvertControlTypeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 20_000, Level = LogLevel.Error)]
    public static partial void ModuleResultControllerGetModuleSearchUrlException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 21_000, Level = LogLevel.Error, Message = "Unable to register service routes")]
    public static partial void ServicesRoutingManagerUnableToRegisterServiceRoutes(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 22_000, Level = LogLevel.Error, Message = "{Message}")]
    public static partial void EventHandlersContainerConstructorException(this ILogger logger, Exception exception, string message);

    [LoggerMessage(EventId = 23_000, Level = LogLevel.Error, Message = "Create File Security Checker for '{Extension}' failed.")]
    public static partial void FileSecurityControllerCreateFileSecurityCheckerFailed(this ILogger logger, Exception exception, string extension);

    [LoggerMessage(EventId = 24_000, Level = LogLevel.Error, Message = "Error while parsing: {TemplateFilePath}")]
    public static partial void PortalTemplateInfoErrorWhileParsing(this ILogger logger, Exception exception, string templateFilePath);

    [LoggerMessage(EventId = 25_000, Level = LogLevel.Error, Message = "{ErrorMessage}")]
    public static partial void TabPublishingControllerPermissionsAreNotMetThePageHasNotBeenPublished(this ILogger logger, Entities.Tabs.PermissionsNotMetException exception, string errorMessage);

    [LoggerMessage(EventId = 26_000, Level = LogLevel.Error, Message = "Error loading portal setting: {Key}:{Value} Default value {DefaultValue} was used instead")]
    public static partial void CollectionExtensionsErrorLoadingPortalSettingDefaultUsedInstead(this ILogger logger, string key, object value, object defaultValue);

    [LoggerMessage(EventId = 27_000, Level = LogLevel.Error, Message = "[1] Error executing SQL: {SQL}")]
    public static partial void PetaPocoHelper1ErrorExecutingSql(this ILogger logger, Exception exception, string sql);

    [LoggerMessage(EventId = 27_001, Level = LogLevel.Error, Message = "[2] Error executing SQL: {CommandText}")]
    public static partial void PetaPocoHelper2ErrorExecutingSql(this ILogger logger, Exception exception, string commandText);

    [LoggerMessage(EventId = 27_002, Level = LogLevel.Error, Message = "[3] Error executing SQL: {SQL}")]
    public static partial void PetaPocoHelper3ErrorExecutingSql(this ILogger logger, Exception exception, string sql);

    [LoggerMessage(EventId = 27_003, Level = LogLevel.Error, Message = "[4] Error executing SQL: {SQL}")]
    public static partial void PetaPocoHelper4ErrorExecutingSql(this ILogger logger, Exception exception, string sql);

    [LoggerMessage(EventId = 27_004, Level = LogLevel.Error, Message = "[5] Error executing SQL: {SQL}")]
    public static partial void PetaPocoHelper5ErrorExecutingSql(this ILogger logger, Exception exception, string sql);
}
