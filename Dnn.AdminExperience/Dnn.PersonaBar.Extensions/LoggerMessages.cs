// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.PersonaBar;

using System;
using System.Data.SqlClient;
using System.IO;
using System.Web.Security;

using Dnn.PersonaBar.Roles.Components.Prompt.Exceptions;

using DotNetNuke.Entities.Users;
using DotNetNuke.Services.Connections;

using Microsoft.Extensions.Logging;

/// <summary>Extension methods for <see cref="ILogger"/> for pre-defined logging messages.</summary>
internal static partial class LoggerMessages
{
    [LoggerMessage(EventId = 5_000_000, Level = LogLevel.Information)]
    public static partial void SecurityControllerUpdateIpFilterArgumentException(this ILogger logger, ArgumentException exception);

    [LoggerMessage(EventId = 5_000_001, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetBasicLoginSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_002, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateBasicLoginSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_003, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetIpFiltersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_004, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetIpFilterException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_005, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateIpFilterException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_006, Level = LogLevel.Error)]
    public static partial void SecurityControllerDeleteIpFilterException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_007, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetMemberSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_008, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateMemberSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_009, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetRegistrationSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_010, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetSslSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_011, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateRegistrationSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_012, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateSslSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_012, Level = LogLevel.Error)]
    public static partial void SecurityControllerSetAllPagesSecureException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_013, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetSecurityBulletinsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_014, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetOtherSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_015, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateOtherSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_015, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetAuditCheckResultsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_016, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetAuditCheckResultException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_017, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetSuperuserActivitiesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_018, Level = LogLevel.Error)]
    public static partial void SecurityControllerSearchFileSystemAndDatabaseException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_019, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetLastModifiedFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_020, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetLastModifiedSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_021, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetApiTokenSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_022, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateApiTokenSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_023, Level = LogLevel.Error)]
    public static partial void SecurityControllerGetCspSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_024, Level = LogLevel.Error)]
    public static partial void SecurityControllerUpdateCspSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_100, Level = LogLevel.Warning)]
    public static partial void ConnectorsControllerSaveConnectionConnectorArgumentException(this ILogger logger, ConnectorArgumentException exception);

    [LoggerMessage(EventId = 5_000_101, Level = LogLevel.Error)]
    public static partial void ConnectorsControllerSaveConnectionGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_102, Level = LogLevel.Error)]
    public static partial void ConnectorsControllerDeleteConnectionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_103, Level = LogLevel.Error)]
    public static partial void ConnectorsControllerGetConnectionLocalizedStringException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_200, Level = LogLevel.Warning, Message = "{Message}")]
    public static partial void LanguagesControllerObsolete(this ILogger logger, string message);

    [LoggerMessage(EventId = 5_000_300, Level = LogLevel.Error)]
    public static partial void LicensingControllerGetProductException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_400, Level = LogLevel.Error)]
    public static partial void SkinPackageEditorSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_500, Level = LogLevel.Error)]
    public static partial void CssEditorControllerGetStyleSheetException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_501, Level = LogLevel.Error)]
    public static partial void CssEditorControllerUpdateStyleSheetException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_502, Level = LogLevel.Error)]
    public static partial void CssEditorControllerRestoreStyleSheetException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_600, Level = LogLevel.Error)]
    public static partial void ConfigConsoleControllerGetConfigFilesListException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_601, Level = LogLevel.Error)]
    public static partial void ConfigConsoleControllerGetConfigFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_602, Level = LogLevel.Error)]
    public static partial void ConfigConsoleControllerValidateConfigFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_603, Level = LogLevel.Error)]
    public static partial void ConfigConsoleControllerUpdateConfigFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_604, Level = LogLevel.Error)]
    public static partial void ConfigConsoleControllerMergeConfigFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_605, Level = LogLevel.Error)]
    public static partial void ConfigConsoleControllerSaveNonConfigFileIOException(this ILogger logger, IOException exception);

    [LoggerMessage(EventId = 5_000_605, Level = LogLevel.Error)]
    public static partial void ConfigConsoleControllerSaveNonConfigFileGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_700, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerGetLogTypesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_701, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerGetLogItemsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_702, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerDeleteLogItemsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_703, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerEmailLogItemsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_704, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerClearLogException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_705, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerGetKeepMostRecentOptionsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_706, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerGetOccurrenceOptionsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_707, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerGetLogSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_708, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerGetLogSettingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_708, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerAddLogSettingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_709, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerUpdateLogSettingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_710, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerDeleteLogSettingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_711, Level = LogLevel.Error)]
    public static partial void AdminLogsControllerGetLatestLogSettingException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_800, Level = LogLevel.Error)]
    public static partial void CommandControllerCmdException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_801, Level = LogLevel.Error)]
    public static partial void CommandControllerTryRunOldCommandException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_802, Level = LogLevel.Error)]
    public static partial void CommandControllerTryRunNewCommandException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_900, Level = LogLevel.Error)]
    public static partial void UpgradesControllerDeleteException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_000_901, Level = LogLevel.Error)]
    public static partial void UpgradesControllerUploadException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_000, Level = LogLevel.Error)]
    public static partial void InstallControllerDeleteTempInstallFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_000, Level = LogLevel.Error)]
    public static partial void InstallControllerDeleteInstallFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_001, Level = LogLevel.Error)]
    public static partial void InstallControllerReadAzureCompatibleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_100, Level = LogLevel.Error)]
    public static partial void SkinObjectPackageEditorSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_200, Level = LogLevel.Error)]
    public static partial void ModulePackageEditorSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_300, Level = LogLevel.Error)]
    public static partial void JsLibraryPackageEditorSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_400, Level = LogLevel.Error)]
    public static partial void ExtensionLanguagePackageEditorSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_500, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetPackageTypesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_501, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetAllPackagesListExceptLangPacksException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_502, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetInstalledPackagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_503, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetAvailablePackagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_504, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetPackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_505, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_506, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetAvailableControlsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_507, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerDeletePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_508, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerInstallPackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_509, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerParsePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_510, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerParsePackageFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_511, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerParseLanguagePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_512, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerInstallAvailablePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_513, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerDownloadPackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_514, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerDownloadLanguagePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_515, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetPackageUsageFilterException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_516, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetPackageUsageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_517, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerCreateExtensionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_518, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetOwnerFoldersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_519, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetModuleFoldersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_520, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetModuleFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_521, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerCreateFolderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_522, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerCreateModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_523, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerGetPackageManifestException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_524, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerCreateManifestException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_525, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerCreateNewManifestException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_526, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerCreatePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_527, Level = LogLevel.Error)]
    public static partial void ExtensionsControllerRefreshPackageFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_600, Level = LogLevel.Error)]
    public static partial void ModulesControllerCopyModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_601, Level = LogLevel.Error)]
    public static partial void ModulesControllerDeleteModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_700, Level = LogLevel.Error)]
    public static partial void AuthSystemPackageEditorSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_800, Level = LogLevel.Error)]
    public static partial void RolesControllerGetRolesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_801, Level = LogLevel.Error)]
    public static partial void RolesControllerSaveRoleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_802, Level = LogLevel.Error)]
    public static partial void RolesControllerGetRoleGroupsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_803, Level = LogLevel.Error)]
    public static partial void RolesControllerSaveRoleGroupException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_804, Level = LogLevel.Error)]
    public static partial void RolesControllerDeleteRoleGroupException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_805, Level = LogLevel.Error)]
    public static partial void RolesControllerGetRoleUsersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_806, Level = LogLevel.Error)]
    public static partial void RolesControllerAddUserToRoleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_807, Level = LogLevel.Error)]
    public static partial void RolesControllerRemoveUserFromRoleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_001_900, Level = LogLevel.Error)]
    public static partial void CoreLanguagePackageEditorSavePackageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_000, Level = LogLevel.Error)]
    public static partial void SeoControllerGetGeneralSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_001, Level = LogLevel.Error)]
    public static partial void SeoControllerUpdateGeneralSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_002, Level = LogLevel.Error)]
    public static partial void SeoControllerGetRegexSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_003, Level = LogLevel.Error)]
    public static partial void SeoControllerUpdateRegexSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_004, Level = LogLevel.Error)]
    public static partial void SeoControllerGetSitemapSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_005, Level = LogLevel.Error)]
    public static partial void SeoControllerCreateVerificationException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_006, Level = LogLevel.Error)]
    public static partial void SeoControllerUpdateSitemapSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_007, Level = LogLevel.Error)]
    public static partial void SeoControllerResetCacheException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_008, Level = LogLevel.Error)]
    public static partial void SeoControllerGetSitemapProvidersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_009, Level = LogLevel.Error)]
    public static partial void SeoControllerUpdateSitemapProviderException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_010, Level = LogLevel.Error)]
    public static partial void SeoControllerGetExtensionUrlProvidersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_011, Level = LogLevel.Error)]
    public static partial void SeoControllerUpdateExtensionUrlProviderStatusException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_012, Level = LogLevel.Error)]
    public static partial void SeoControllerTestUrlException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_013, Level = LogLevel.Error)]
    public static partial void SeoControllerTestUrlRewriteException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_100, Level = LogLevel.Error)]
    public static partial void SystemInfoWebControllerGetWebServerInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_200, Level = LogLevel.Error)]
    public static partial void SystemInfoServersControllerGetServersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_201, Level = LogLevel.Error)]
    public static partial void SystemInfoServersControllerDeleteServerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_202, Level = LogLevel.Error)]
    public static partial void SystemInfoServersControllerEditServerUrlException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_203, Level = LogLevel.Error)]
    public static partial void SystemInfoServersControllerDeleteNonActiveServersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_300, Level = LogLevel.Error)]
    public static partial void SystemInfoDatabaseControllerGetDatabaseServerInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_400, Level = LogLevel.Error)]
    public static partial void SystemInfoApplicationHostControllerGetApplicationInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_500, Level = LogLevel.Error)]
    public static partial void SystemInfoApplicationAdminControllerGetApplicationInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_600, Level = LogLevel.Error)]
    public static partial void SiteGroupsControllerSaveException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_601, Level = LogLevel.Error)]
    public static partial void SiteGroupsControllerDeleteException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_700, Level = LogLevel.Error)]
    public static partial void RecyclebinControllerDeleteModuleForTabException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_700, Level = LogLevel.Error)]
    public static partial void RecyclebinControllerHardDeleteModuleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_800, Level = LogLevel.Error)]
    public static partial void ServerControllerRestartApplicationException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_801, Level = LogLevel.Error)]
    public static partial void ServerControllerClearCacheException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_900, Level = LogLevel.Error)]
    public static partial void ServerSettingsLogsControllerGetLogsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_901, Level = LogLevel.Error)]
    public static partial void ServerSettingsLogsControllerGetLogFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_002_902, Level = LogLevel.Error)]
    public static partial void ServerSettingsLogsControllerGetUpgradeLogFileException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_000, Level = LogLevel.Error)]
    public static partial void ServerSettingsPerformanceControllerGetPerformanceSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_001, Level = LogLevel.Error)]
    public static partial void ServerSettingsPerformanceControllerIncrementPortalVersionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_002, Level = LogLevel.Error)]
    public static partial void ServerSettingsPerformanceControllerIncrementHostVersionException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_003, Level = LogLevel.Error)]
    public static partial void ServerSettingsPerformanceControllerUpdatePerformanceSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_100, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpAdminControllerGetSmtpSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_101, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpAdminControllerUpdateSmtpSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_102, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpAdminControllerSendTestEmailException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_103, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpAdminControllerGetSmtpOAuthProvidersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_200, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpHostControllerGetSmtpSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_201, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpHostControllerUpdateSmtpSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_202, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpHostControllerSendTestEmailException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_203, Level = LogLevel.Error)]
    public static partial void ServerSettingsSmtpHostControllerGetSmtpOAuthProvidersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_300, Level = LogLevel.Error)]
    public static partial void LanguagesControllerGetTabsForTranslationException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_301, Level = LogLevel.Error)]
    public static partial void LanguagesControllerGetRootResourcesFoldersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_302, Level = LogLevel.Error)]
    public static partial void LanguagesControllerGetSubRootResourcesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_303, Level = LogLevel.Error)]
    public static partial void LanguagesControllerGetResxEntriesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_304, Level = LogLevel.Error)]
    public static partial void LanguagesControllerSaveResxEntriesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_305, Level = LogLevel.Error)]
    public static partial void LanguagesControllerEnableLocalizedContentException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_306, Level = LogLevel.Error)]
    public static partial void LanguagesControllerLocalizedContentException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_307, Level = LogLevel.Error)]
    public static partial void LanguagesControllerGetLocalizationProgressException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_308, Level = LogLevel.Error)]
    public static partial void LanguagesControllerDisableLocalizedContentException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_309, Level = LogLevel.Error)]
    public static partial void LanguagesControllerMarkAllPagesTranslatedException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_310, Level = LogLevel.Error)]
    public static partial void LanguagesControllerActivateLanguageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_311, Level = LogLevel.Error)]
    public static partial void LanguagesControllerPublishAllPagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_312, Level = LogLevel.Error)]
    public static partial void LanguagesControllerDeleteLanguagePagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_400, Level = LogLevel.Error)]
    public static partial void SitesControllerGetPortalsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_401, Level = LogLevel.Error)]
    public static partial void SitesControllerCreatePortalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_402, Level = LogLevel.Error)]
    public static partial void SitesControllerDeletePortalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_403, Level = LogLevel.Error)]
    public static partial void SitesControllerExportPortalTemplateException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_404, Level = LogLevel.Error)]
    public static partial void SitesControllerGetPortalLocalesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_405, Level = LogLevel.Error)]
    public static partial void SitesControllerDeleteExpiredPortalsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_406, Level = LogLevel.Error)]
    public static partial void SitesControllerGetPortalTemplatesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_407, Level = LogLevel.Error)]
    public static partial void SitesControllerRequiresQuestionAndAnswerException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_500, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetPortalSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_501, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetCultureListException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_502, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdatePortalSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_503, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetDefaultPagesSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_504, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateDefaultPagesSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_505, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetMessagingSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_506, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateMessagingSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_507, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetProfileSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_508, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateProfileSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_509, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetProfilePropertiesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_510, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetProfilePropertyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_511, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetProfilePropertyLocalizationException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_512, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateProfilePropertyLocalizationException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_513, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerAddProfilePropertyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_514, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateProfilePropertyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_515, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateProfilePropertyOrdersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_516, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerDeleteProfilePropertyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_517, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetUrlMappingSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_518, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateUrlMappingSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_519, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetSiteAliasesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_520, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetSiteAliasException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_521, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerAddSiteAliasException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_522, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateSiteAliasException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_523, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerDeleteSiteAliasException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_524, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerSetPrimarySiteAliasException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_525, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetListInfoException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_526, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateListEntryException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_527, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerDeleteListEntryException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_528, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateListEntryOrdersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_529, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetPrivacySettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_530, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdatePrivacySettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_531, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerResetTermsAgreementException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_532, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetBasicSearchSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_533, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateBasicSearchSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_534, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerCompactSearchIndexException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_535, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerHostSearchReindexException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_536, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerPortalSearchReindexException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_537, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetPortalsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_538, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetSynonymsGroupsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_539, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerAddSynonymsGroupException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_540, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateSynonymsGroupException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_541, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerDeleteSynonymsGroupException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_542, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetIgnoreWordsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_543, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerAddIgnoreWordsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_544, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateIgnoreWordsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_545, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerDeleteIgnoreWordsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_546, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetLanguageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_547, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateLanguageSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_548, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetLanguagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_549, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetLanguageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_550, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetAllLanguagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_551, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerAddLanguageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_552, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateLanguageRolesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_553, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateLanguageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_554, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerVerifyLanguageResourceFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_555, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetModuleListException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_556, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerCreateLanguagePackException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_557, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetTranslatorRolesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_558, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetTranslatorRoleGroupsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_559, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerGetOtherSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_560, Level = LogLevel.Error)]
    public static partial void SiteSettingsControllerUpdateOtherSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_600, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerGetServersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_601, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerGetScheduleItemsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_602, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerGetSchedulerSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_603, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerUpdateSchedulerSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_604, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerGetScheduleItemHistoryException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_605, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerGetScheduleItemException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_606, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerCreateScheduleItemException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_607, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerUpdateScheduleItemException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_608, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerGetScheduleStatusException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_609, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerStartScheduleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_610, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerStopScheduleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_611, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerRunScheduleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_612, Level = LogLevel.Error)]
    public static partial void TaskSchedulerControllerDeleteScheduleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_700, Level = LogLevel.Error)]
    public static partial void ThemesControllerGetCurrentThemeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_701, Level = LogLevel.Error)]
    public static partial void ThemesControllerGetThemesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_702, Level = LogLevel.Error)]
    public static partial void ThemesControllerGetThemeFilesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_703, Level = LogLevel.Error)]
    public static partial void ThemesControllerApplyThemeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_704, Level = LogLevel.Error)]
    public static partial void ThemesControllerApplyDefaultThemeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_705, Level = LogLevel.Error)]
    public static partial void ThemesControllerDeleteThemePackageException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_706, Level = LogLevel.Error)]
    public static partial void ThemesControllerGetEditableTokensException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_707, Level = LogLevel.Error)]
    public static partial void ThemesControllerGetEditableSettingsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_708, Level = LogLevel.Error)]
    public static partial void ThemesControllerGetEditableValuesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_709, Level = LogLevel.Error)]
    public static partial void ThemesControllerUpdateThemeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_710, Level = LogLevel.Error)]
    public static partial void ThemesControllerParseThemeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_711, Level = LogLevel.Error)]
    public static partial void ThemesControllerRestoreThemeException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_800, Level = LogLevel.Error)]
    public static partial void UsersControllerCreateUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_801, Level = LogLevel.Error)]
    public static partial void UsersControllerGetUsersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_802, Level = LogLevel.Error)]
    public static partial void UsersControllerGetUserFiltersException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_803, Level = LogLevel.Error)]
    public static partial void UsersControllerGetUserDetailException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_804, Level = LogLevel.Error)]
    public static partial void UsersControllerChangePasswordInvalidPasswordException(this ILogger logger, InvalidPasswordException exception);

    [LoggerMessage(EventId = 5_003_805, Level = LogLevel.Error)]
    public static partial void UsersControllerChangePasswordGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_806, Level = LogLevel.Error)]
    public static partial void UsersControllerForceChangePasswordException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_807, Level = LogLevel.Error)]
    public static partial void UsersControllerCreateResetTokenArgumentException(this ILogger logger, ArgumentException exception);

    [LoggerMessage(EventId = 5_003_808, Level = LogLevel.Error)]
    public static partial void UsersControllerCreateResetTokenGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_809, Level = LogLevel.Error)]
    public static partial void UsersControllerSendPasswordResetLinkException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_810, Level = LogLevel.Error)]
    public static partial void UsersControllerUpdateAuthorizeStatusException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_811, Level = LogLevel.Error)]
    public static partial void UsersControllerSoftDeleteUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_812, Level = LogLevel.Error)]
    public static partial void UsersControllerHardDeleteUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_813, Level = LogLevel.Error)]
    public static partial void UsersControllerRestoreDeletedUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_814, Level = LogLevel.Error)]
    public static partial void UsersControllerUpdateSuperUserStatusException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_815, Level = LogLevel.Error)]
    public static partial void UsersControllerUpdateUserBasicInfoSqlException(this ILogger logger, SqlException exception);

    [LoggerMessage(EventId = 5_003_816, Level = LogLevel.Error)]
    public static partial void UsersControllerUpdateUserBasicInfoGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_817, Level = LogLevel.Error)]
    public static partial void UsersControllerUnlockUserException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_818, Level = LogLevel.Error)]
    public static partial void UsersControllerGetSuggestRolesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_819, Level = LogLevel.Error)]
    public static partial void UsersControllerGetUserRolesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_820, Level = LogLevel.Error)]
    public static partial void UsersControllerSaveUserRoleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_821, Level = LogLevel.Error)]
    public static partial void UsersControllerRemoveUserRoleException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_900, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerGetVocabulariesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_901, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerCreateVocabularyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_902, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerUpdateVocabularyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_903, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerDeleteVocabularyException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_904, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerGetTermsByVocabularyIdException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_905, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerGetTermException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_906, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerCreateTermException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_907, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerUpdateTermException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_003_908, Level = LogLevel.Error)]
    public static partial void VocabulariesControllerDeleteTermException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_004_000, Level = LogLevel.Error)]
    public static partial void ComponentsSitesControllerCreatePortalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_004_001, Level = LogLevel.Error)]
    public static partial void ComponentsSitesControllerSendMailException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_004_002, Level = LogLevel.Error)]
    public static partial void ComponentsSitesControllerTryDeleteCreatingPortalException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_000, Level = LogLevel.Error)]
    public static partial void ComponentsTaskSchedulerControllerGetScheduleItemsException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_100, Level = LogLevel.Error)]
    public static partial void LanguageControllerTasksLocalizeSitePagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_101, Level = LogLevel.Error)]
    public static partial void LanguageControllerTasksLocalizeLanguagePagesException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_200, Level = LogLevel.Error)]
    public static partial void ComponentsThemesControllerUpdateManifestException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_201, Level = LogLevel.Error)]
    public static partial void ComponentsThemesControllerCreateThumbnailException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_300, Level = LogLevel.Error)]
    public static partial void ComponentsUsersControllerChangePasswordMembershipPasswordException(this ILogger logger, MembershipPasswordException exception);

    [LoggerMessage(EventId = 5_005_301, Level = LogLevel.Error)]
    public static partial void ComponentsUsersControllerChangePasswordInvalidPasswordException(this ILogger logger, InvalidPasswordException exception);

    [LoggerMessage(EventId = 5_005_302, Level = LogLevel.Error)]
    public static partial void ComponentsUsersControllerChangePasswordGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_400, Level = LogLevel.Error)]
    public static partial void ClearLogRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_500, Level = LogLevel.Error)]
    public static partial void ClearCacheRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_600, Level = LogLevel.Error)]
    public static partial void ListCommandsRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_700, Level = LogLevel.Error)]
    public static partial void RestartApplicationRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_800, Level = LogLevel.Error)]
    public static partial void SetRoleRunSetRoleException(this ILogger logger, SetRoleException exception);

    [LoggerMessage(EventId = 5_005_801, Level = LogLevel.Error)]
    public static partial void SetRoleRunGeneralException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_005_900, Level = LogLevel.Error)]
    public static partial void NewRoleRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_006_000, Level = LogLevel.Error)]
    public static partial void ListRolesRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_006_100, Level = LogLevel.Error)]
    public static partial void DeleteRoleRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_006_200, Level = LogLevel.Error)]
    public static partial void SetTaskRunException(this ILogger logger, Exception exception);

    [LoggerMessage(EventId = 5_006_300, Level = LogLevel.Error)]
    public static partial void GetTaskRunException(this ILogger logger, Exception exception);
}
