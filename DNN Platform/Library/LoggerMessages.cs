// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke;

using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

using DotNetNuke.Abstractions.Application;
using DotNetNuke.Services.FileSystem;
using DotNetNuke.Services.Log.EventLog;
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

    [LoggerMessage(EventId = 1_800, Level = LogLevel.Debug)]
    public static partial void LogControllerConfigFileNotFound(this ILogger logger, FileNotFoundException exception);

    [LoggerMessage(1_801, LogLevel.Information, "{LogInfo}")]
    public static partial void LogControllerLogInfo(this ILogger logger, LogInfo logInfo);

    [LoggerMessage(EventId = 1_801, Level = LogLevel.Debug)]
    public static partial void LogControllerFailureToWriteToLogFile(this ILogger logger, IOException exception);

    [LoggerMessage(EventId = 1_900, Level = LogLevel.Debug)]
    public static partial void PurgeModuleCachePurgeNotSupportedException(this ILogger logger, NotSupportedException exception);

    [LoggerMessage(EventId = 2_000, Level = LogLevel.Debug)]
    public static partial void PurgeOutputCachePurgeNotSupportedException(this ILogger logger, NotSupportedException exception);

    [LoggerMessage(EventId = 2_100, Level = LogLevel.Debug)]
    public static partial void UserProfilePageHandlerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 2_200, Level = LogLevel.Debug)]
    public static partial void ModuleHostThreadAbortException(this ILogger logger, ThreadAbortException exception);

    [LoggerMessage(EventId = 2_300, Level = LogLevel.Debug)]
    public static partial void CaptchaControlDecryptException(this ILogger logger, ArgumentException exception);

    [LoggerMessage(2_400, LogLevel.Debug, "GetExecutingServerName: {ExecutingServerName}")]
    public static partial void ServerControllerGetExecutingServerName(this ILogger logger, string executingServerName);

    [LoggerMessage(2_401, LogLevel.Debug, "GetServerName: {ServerName}")]
    public static partial void ServerControllerGetServerName(this ILogger logger, string serverName);

    [LoggerMessage(2_500, LogLevel.Information, "Application shutting down. Reason: {Reason}")]
    public static partial void InitializeApplicationShuttingDown(this ILogger logger, string reason);

    [LoggerMessage(2_501, LogLevel.Information, "Application shutting down. Reason: {Reason}\nASP.NET Shutdown Info: {ShutdownMessage}\n{ShutdownStack}")]
    public static partial void InitializeApplicationShuttingDownWithInfo(this ILogger logger, string reason, string shutdownMessage, string shutdownStack);

    [LoggerMessage(2_502, LogLevel.Information, "UnderConstruction page was shown because application needs to be installed, and both the AutoUpgrade and UseWizard AppSettings in web.config are false. Use /install/install.aspx?mode=install to install application. ")]
    public static partial void InitializeUnderConstructionPageShownBecauseInstallationNeeded(this ILogger logger);

    [LoggerMessage(2_503, LogLevel.Information, "UnderConstruction page was shown because application needs to be upgraded, and both the AutoUpgrade and UseInstallWizard AppSettings in web.config are false. Use /install/install.aspx?mode=upgrade to upgrade application. ")]
    public static partial void InitializeUnderConstructionPageShownBecauseUpgradeNeeded(this ILogger logger);

    [LoggerMessage(2_504, LogLevel.Information, "Application Initializing")]
    public static partial void InitializeApplicationInitializing(this ILogger logger);

    [LoggerMessage(2_505, LogLevel.Information, "Application Initialized")]
    public static partial void InitializeApplicationInitialized(this ILogger logger);

    [LoggerMessage(2_506, LogLevel.Trace, "Running Schedule {SchedulerMode}")]
    public static partial void InitializeRunningSchedule(this ILogger logger, SchedulerMode schedulerMode);

    [LoggerMessage(2_507, LogLevel.Trace, "Request {LocalPath}")]
    public static partial void InitializeRequest(this ILogger logger, string localPath);

    [LoggerMessage(2_600, LogLevel.Information, "{RootPath} does not exist. ")]
    public static partial void FileSystemUtilsFolderDoesNotExist(this ILogger logger, string rootPath);

    [LoggerMessage(2_700, LogLevel.Information, "{Message}")]
    public static partial void FolderManagerInvalidFileExtensionException(this ILogger logger, string message);

    [LoggerMessage(2_800, LogLevel.Information, "{Message}")]
    public static partial void InstallLoggerLogInfo(this ILogger logger, string message);

    [LoggerMessage(2_900, LogLevel.Information, "Starting WebServerMonitor")]
    public static partial void WebServerMonitorStartingWebServerMonitor(this ILogger logger);

    [LoggerMessage(2_901, LogLevel.Information, "Starting UpdateCurrentServerActivity")]
    public static partial void WebServerMonitorStartingUpdateCurrentServerActivity(this ILogger logger);

    [LoggerMessage(2_902, LogLevel.Information, "Starting RemoveInActiveServers")]
    public static partial void WebServerMonitorStartingRemoveInActiveServers(this ILogger logger);

    [LoggerMessage(2_903, LogLevel.Information, "Finished RemoveInActiveServers")]
    public static partial void WebServerMonitorFinishedRemoveInActiveServers(this ILogger logger);

    [LoggerMessage(2_904, LogLevel.Information, "Finished UpdateCurrentServerActivity")]
    public static partial void WebServerMonitorFinishedUpdateCurrentServerActivity(this ILogger logger);

    [LoggerMessage(2_905, LogLevel.Information, "Finished WebServerMonitor")]
    public static partial void WebServerMonitorFinishedWebServerMonitor(this ILogger logger);

    [LoggerMessage(3_000, LogLevel.Trace, "Action succeeded - {Description}")]
    public static partial void RetryableActionSucceeded(this ILogger logger, string description);

    [LoggerMessage(3_001, LogLevel.Trace, "Retrying action {RetriesRemaining} - {Description}")]
    public static partial void RetryableActionRetrying(this ILogger logger, int retriesRemaining, string description);

    [LoggerMessage(3_100, LogLevel.Trace, "ModuleIndexer: {Count} search documents found for module [{DesktopModuleName} mid:{ModuleId}]")]
    public static partial void ModuleIndexerSearchDocumentsFoundForModule(this ILogger logger, int count, string desktopModuleName, int moduleId);

    [LoggerMessage(3_101, LogLevel.Trace, "ModuleIndexer: Search document for metaData found for module [{DesktopModuleName} mid:{ModuleId}]")]
    public static partial void ModuleIndexerSearchDocumentForMetadataFoundForModule(this ILogger logger, string desktopModuleName, int moduleId);

    [LoggerMessage(3_200, LogLevel.Trace, "TabIndexer: Search document for metaData added for page [{Title} tid:{TabId}]")]
    public static partial void TabIndexerPageMetadataDocumentAdded(this ILogger logger, string title, int tabId);

    [LoggerMessage(3_300, LogLevel.Trace, "Localizing TabId: {TabId}, TabPath: {TabPath}, Locale: {Locale}")]
    public static partial void TabControllerLocalizingTab(this ILogger logger, int tabId, string tabPath, string locale);

    [LoggerMessage(3_400, LogLevel.Trace, "Adding FcnMode : {ErrorMessage}")]
    public static partial void AddFcnModeStepAddingFcnMode(this ILogger logger, string errorMessage);

    [LoggerMessage(3_500, LogLevel.Trace, "FilePermissionCheck - {Details}")]
    public static partial void FilePermissionCheckStepCheck(this ILogger logger, string details);

    [LoggerMessage(3_600, LogLevel.Trace, "FilePermissionCheck Status - {Status}")]
    public static partial void FilePermissionCheckStepStatus(this ILogger logger, StepStatus status);

    [LoggerMessage(3_700, LogLevel.Trace, "Adding InstallVersion : {ErrorMessage}")]
    public static partial void InstallVersionStepAddingInstallVersion(this ILogger logger, string errorMessage);

    [LoggerMessage(3_800, LogLevel.Trace, "GetUpgradedScripts databaseVersion:{DatabaseVersion} applicationVersion:{ApplicationVersion}")]
    public static partial void UpgradeGetUpgradedScripts(this ILogger logger, Version databaseVersion, Version applicationVersion);

    [LoggerMessage(3_801, LogLevel.Trace, "GetUpgradedScripts including {File}")]
    public static partial void UpgradeGetUpgradedScriptsIncluding(this ILogger logger, string file);

    [LoggerMessage(3_900, LogLevel.Trace, "Getting component for {FullName}")]
    public static partial void ContainerWithServiceProviderFallbackGettingComponent(this ILogger logger, string fullName);

    [LoggerMessage(3_901, LogLevel.Trace, "Got component for {FullName} from container")]
    public static partial void ContainerWithServiceProviderFallbackGotComponentFromContainer(this ILogger logger, string fullName);

    [LoggerMessage(3_902, LogLevel.Trace, "Getting component for {FullName} from service provider")]
    public static partial void ContainerWithServiceProviderFallbackGettingComponentFromServiceProvider(this ILogger logger, string fullName);

    [LoggerMessage(4_000, LogLevel.Trace, "{Details}")]
    public static partial void InstallExtensionsStepInstallingExtensionPackage(this ILogger logger, string details);

    [LoggerMessage(4_100, LogLevel.Trace, "Search: Site Crawler - Starting. Content change start time {LastSuccessfulDateTime}")]
    public static partial void SearchEngineSchedulerStarting(this ILogger logger, DateTime lastSuccessfulDateTime);

    [LoggerMessage(4_101, LogLevel.Trace, "Search: Site Crawler - Indexing Successful")]
    public static partial void SearchEngineSchedulerSuccessful(this ILogger logger);

    [LoggerMessage(4_200, LogLevel.Trace, "Getting application status")]
    public static partial void ApplicationStatusInfoGettingStatus(this ILogger logger);

    [LoggerMessage(4_201, LogLevel.Trace, "result of getting providerpath: {Message}")]
    public static partial void ApplicationStatusInfoResultOfGettingProviderPath(this ILogger logger, string message);

    [LoggerMessage(4_202, LogLevel.Trace, "Application status is {Status}")]
    public static partial void ApplicationStatusInfoStatusIs(this ILogger logger, UpgradeStatus status);

    [LoggerMessage(4_300, LogLevel.Trace, "Executing SQL Script {SQL}")]
    public static partial void SqlDataProviderExecutingSqlScript(this ILogger logger, string sql);

    [LoggerMessage(EventId = 4_400, Level = LogLevel.Warning)]
    public static partial void FileManagerExtractFilesPermissionsNotMet(this ILogger logger, PermissionsNotMetException exception);

    [LoggerMessage(EventId = 4_401, Level = LogLevel.Warning)]
    public static partial void FileManagerExtractFilesNoSpaceAvailable(this ILogger logger, NoSpaceAvailableException exception);

    [LoggerMessage(EventId = 4_402, Level = LogLevel.Warning)]
    public static partial void FileManagerExtractFilesInvalidFileExtension(this ILogger logger, InvalidFileExtensionException exception);
}
