// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web;

using System;
using System.IO;

using DotNetNuke.Entities.Users;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(EventId = 7_000_000, Message = "{Message}")]
    public static partial void TraceWriterLogMessage(this ILogger logger, LogLevel logLevel, string message);

    [LoggerMessage(7_000_100, LogLevel.Information, "Watcher Activity: {ChangeType}. Path: {FullPath}")]
    public static partial void ShutdownOverloadWatcherActivity(this ILogger logger, WatcherChangeTypes changeType, string fullPath);

    [LoggerMessage(7_000_101, LogLevel.Information, "Watcher Activity: {ChangeType}. New Path: {NewPath}. Old Path: {OldPath}")]
    public static partial void ShutdownOverloadWatcherRenamedActivity(this ILogger logger, WatcherChangeTypes changeType, string newPath, string oldPath);

    [LoggerMessage(7_000_102, LogLevel.Information, "Watcher Activity: N/A. Error:")]
    public static partial void ShutdownOverloadWatcherError(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_000_103, Level = LogLevel.Information)]
    public static partial void ShutdownOverloadInitializeFcnSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(7_000_104, LogLevel.Information, "fileChangesMonitor is null")]
    public static partial void ShutdownOverloadFileChangesMonitorIsNull(this ILogger logger);

    [LoggerMessage(7_000_105, LogLevel.Information, "FCNMode = {fcnMode} (Modes: NotSet/Default=0, Disabled=1, Single=2)")]
    public static partial void ShutdownOverloadFileChangeNotificationMode(this ILogger logger, object fcnMode);

    [LoggerMessage(7_000_106, LogLevel.Trace, "DirMonCompletion count: {Count}")]
    public static partial void ShutdownOverloadDirMonCompletionCount(this ILogger logger, int count);

    [LoggerMessage(7_000_107, LogLevel.Trace, @"Added watcher for: {WatcherPath}/{WatcherFilter}")]
    public static partial void ShutdownOverloadAddedWatcherFor(this ILogger logger, string watcherPath, string watcherFilter);

    [LoggerMessage(7_000_108, LogLevel.Trace, "Error adding our own file monitoring object.")]
    public static partial void ShutdownOverloadErrorAddingOurOwnFileMonitoringObject(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_000_109, Level = LogLevel.Error)]
    public static partial void ShutdownOverloadUnloadAppDomainException(this ILogger logger, Exception exception);

    [LoggerMessage(7_000_200, LogLevel.Information, "Application Starting ({ElapsedSinceAppStart})")]
    public static partial void ApplicationStarting(this ILogger logger, TimeSpan elapsedSinceAppStart);

    [LoggerMessage(7_000_201, LogLevel.Information, "Application Started ({ElapsedSinceAppStart})")]
    public static partial void ApplicationStarted(this ILogger logger, TimeSpan elapsedSinceAppStart);

    [LoggerMessage(7_000_202, LogLevel.Information, "Application Ending")]
    public static partial void ApplicationEnding(this ILogger logger);

    [LoggerMessage(7_000_203, LogLevel.Information, "Application Ended")]
    public static partial void ApplicationEnded(this ILogger logger);

    [LoggerMessage(7_000_204, LogLevel.Trace, "Disposing Lucene")]
    public static partial void ApplicationDisposingLucene(this ILogger logger);

    [LoggerMessage(7_000_205, LogLevel.Trace, "Dumping all Application Errors")]
    public static partial void ApplicationDumpingAllApplicationErrors(this ILogger logger);

    [LoggerMessage(7_000_206, LogLevel.Trace, "End Dumping all Application Errors")]
    public static partial void ApplicationEndDumpingAllApplicationErrors(this ILogger logger);

    [LoggerMessage(EventId = 7_000_207, Level = LogLevel.Error)]
    public static partial void ApplicationLogEndException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_000_208, Level = LogLevel.Error)]
    public static partial void ApplicationStopSchedulerException(this ILogger logger, Exception exception);

    [LoggerMessage(7_000_300, LogLevel.Trace, "Authorization header scheme in the request is not equal to {AuthScheme}")]
    public static partial void ApiTokenControllerAuthorizationHeaderSchemeDoesNotMatchAuthScheme(this ILogger logger, string authScheme);

    [LoggerMessage(7_000_301, LogLevel.Trace, "Missing authorization header value in the request")]
    public static partial void ApiTokenControllerMissingAuthorizationHeaderValue(this ILogger logger);

    [LoggerMessage(7_000_302, LogLevel.Trace, "Token expired")]
    public static partial void ApiTokenControllerTokenExpired(this ILogger logger);

    [LoggerMessage(7_000_303, LogLevel.Trace, "Invalid user")]
    public static partial void ApiTokenControllerInvalidUser(this ILogger logger);

    [LoggerMessage(7_000_304, LogLevel.Trace, "{SchemeType} is not registered/enabled in web.config file")]
    public static partial void ApiTokenControllerSchemeIsNotEnabledInWebConfig(this ILogger logger, string schemeType);

    [LoggerMessage(7_000_400, LogLevel.Trace, "Authenticated using API token {ApiTokenId}")]
    public static partial void ApiTokenAuthMessageHandlerAuthenticatedUsingApiToken(this ILogger logger, int apiTokenId);

    [LoggerMessage(7_000_401, LogLevel.Error, "Unexpected error authenticating API Token.")]
    public static partial void ApiTokenAuthMessageHandlerUnexpectedErrorAuthenticatingApiToken(this ILogger logger, Exception exception);

    [LoggerMessage(7_000_500, LogLevel.Trace, "{AuthScheme}: Validating request vs. SSL mode ({ForceSsl}) failed. ")]
    public static partial void AuthMessageHandlerBaseValidatingRequestVsSslModeFailed(this ILogger logger, string authScheme, bool forceSsl);

    [LoggerMessage(7_000_600, LogLevel.Trace, "Mapping route: {FullRouteName} @ {RouteUrl}")]
    public static partial void ServicesRoutingManagerMappingRoute(this ILogger logger, string fullRouteName, string routeUrl);

    [LoggerMessage(7_000_601, LogLevel.Trace, "Mapping route: {OldRouteName} @ {OldRouteUrl}")]
    public static partial void ServicesRoutingManagerMappingOldRoute(this ILogger logger, string oldRouteName, string oldRouteUrl);

    [LoggerMessage(7_000_602, LogLevel.Trace, "Registered a total of {Count} routes")]
    public static partial void ServicesRoutingManagerRegisteredRoutes(this ILogger logger, int count);

    [LoggerMessage(7_000_603, LogLevel.Trace, "The following handler is disabled {ClassName}")]
    public static partial void ServicesRoutingManagerHandlerIsDisabled(this ILogger logger, string className);

    [LoggerMessage(7_000_604, LogLevel.Trace, "The following handler scheme '{ClassName}' is already added and will be skipped")]
    public static partial void ServicesRoutingManagerHandlerIsAlreadyAdded(this ILogger logger, string className);

    [LoggerMessage(7_000_605, LogLevel.Trace, "Instantiated/Activated instance of {AuthScheme}, class: {ClassFullName}")]
    public static partial void ServicesRoutingManagerHandlerIsActivated(this ILogger logger, string authScheme, string classFullName);

    [LoggerMessage(7_000_606, LogLevel.Error, "{FullTypeName}.RegisterRoutes threw an exception.")]
    public static partial void ServicesRoutingManagerRegisterRoutesThrewAnException(this ILogger logger, Exception exception, string fullTypeName);

    [LoggerMessage(7_000_607, LogLevel.Error, "Unable to create {fullTypeName} while registering service routes.")]
    public static partial void ServicesRoutingManagerUnableToCreateRouteMapper(this ILogger logger, Exception exception, string fullTypeName);

    [LoggerMessage(7_000_608, LogLevel.Error, "Cannot instantiate/activate instance of {ClassName}")]
    public static partial void ServicesRoutingManagerCannotInstantiateInstanceOf(this ILogger logger, Exception exception, string className);

    [LoggerMessage(7_000_700, LogLevel.Warning, "The specified moniker ({Moniker}) is not defined in the system")]
    public static partial void StandardTabAndModuleInfoProviderMonikerIsNotDefined(this ILogger logger, string moniker);

    [LoggerMessage(7_000_800, LogLevel.Warning, "Unable to create thumbnail for {PhysicalPath}")]
    public static partial void DnnFilePickerUnableToCreateThumbnail(this ILogger logger, string physicalPath);

    [LoggerMessage(EventId = 7_000_801, Level = LogLevel.Error)]
    public static partial void DnnFilePickerAddFileException(this ILogger logger, Exception exception);

    [LoggerMessage(7_000_900, LogLevel.Warning, "Unable to get image dimensions for image file")]
    public static partial void FileUploadControllerUnableToGetImageDimensions(this ILogger logger, ArgumentException exception);

    [LoggerMessage(EventId = 7_000_901, Level = LogLevel.Error)]
    public static partial void FileUploadControllerSaveFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_000_902, Level = LogLevel.Error)]
    public static partial void FileUploadControllerUploadFileException(this ILogger logger, Exception exception);

    [LoggerMessage(7_001_000, LogLevel.Warning, "While loading IDnnStartup types, the following assemblies had types that could not be loaded. This is only an issue if these types contain DNN startup logic that could not be loaded:\n{Message}")]
    public static partial void DependencyInjectionInitializeAssembliesCouldNotBeLoaded(this ILogger logger, string message);

    [LoggerMessage(7_001_001, LogLevel.Error, "Unable to configure services for {FullTypeName}, see exception for details")]
    public static partial void DependencyInjectionInitializeUnableToConfigureServicesFor(this ILogger logger, Exception exception, string fullTypeName);

    [LoggerMessage(7_001_001, LogLevel.Error, "Unable to instantiate startup code for {FullTypeName}")]
    public static partial void DependencyInjectionInitializeUnableToInstantiateStartupCodeFor(this ILogger logger, Exception exception, string fullTypeName);

    [LoggerMessage(EventId = 7_001_100, Level = LogLevel.Error)]
    public static partial void BuildUpExtensionsSetValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_200, Level = LogLevel.Error)]
    public static partial void UserFileControllerGetItemsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_300, Level = LogLevel.Error)]
    public static partial void ControlBarControllerParseVisibilityException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_301, Level = LogLevel.Error)]
    public static partial void ControlBarControllerParseSortException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_302, Level = LogLevel.Error)]
    public static partial void ControlBarControllerParseModuleIdException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_303, Level = LogLevel.Error)]
    public static partial void ControlBarControllerParsePageIdException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_304, Level = LogLevel.Error)]
    public static partial void ControlBarControllerAddModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_400, Level = LogLevel.Error)]
    public static partial void EventLogServiceControllerGetLogDetailsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_500, Level = LogLevel.Error)]
    public static partial void MessagingServiceControllerWaitTimeForNextMessageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_501, Level = LogLevel.Error)]
    public static partial void MessagingServiceControllerCreateException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_502, Level = LogLevel.Error)]
    public static partial void MessagingServiceControllerSearchException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_600, Level = LogLevel.Error)]
    public static partial void NotificationsServiceControllerDismissException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_700, Level = LogLevel.Error)]
    public static partial void RelationshipServiceControllerAcceptFriendException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_701, Level = LogLevel.Error)]
    public static partial void RelationshipServiceControllerFollowBackUserRelationshipExistsException(this ILogger logger, UserRelationshipExistsException exception);

    [LoggerMessage(EventId = 7_001_702, Level = LogLevel.Error)]
    public static partial void RelationshipServiceControllerFollowBackGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_800, Level = LogLevel.Error)]
    public static partial void ItemListServiceControllerSearchUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_001_900, Level = LogLevel.Error)]
    public static partial void RibbonBarManagerAddOrUpdateTabException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_002_000, Level = LogLevel.Error)]
    public static partial void DateTimeEditControlDateValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_002_001, Level = LogLevel.Error)]
    public static partial void DateTimeEditControlOldDateValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_003_000, Level = LogLevel.Error)]
    public static partial void DateEditControlDateValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_003_001, Level = LogLevel.Error)]
    public static partial void DateEditControlOldDateValueException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 7_003_100, Level = LogLevel.Error, Message = "Cannot find module ID {ModuleId} (tab ID {TabId}, portal ID {PortalId})")]
    public static partial void ModuleServiceControllerCannotFindModule(this ILogger logger, int moduleId, int tabId, int portalId);
}
