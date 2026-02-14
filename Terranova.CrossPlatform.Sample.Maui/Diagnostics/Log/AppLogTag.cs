using Terranova.CrossPlatform.Mobile.Core;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public class AppLogTag : TrnMobileLogTag
{
    public const string None = nameof(None);
    public const string Unhandled = nameof(Unhandled);
    public const string ApplicationStart = nameof(ApplicationStart);
    public const string Binding = nameof(Binding);
    public const string TaskExecution = nameof(TaskExecution);
    public const string DatabaseCheck = nameof(DatabaseCheck);
    public const string SynchronizationWithServer = nameof(SynchronizationWithServer);
    public const string SynchronizationDataArchiveWithServer = nameof(SynchronizationDataArchiveWithServer);
    public const string DeviceSecurityKeys = nameof(DeviceSecurityKeys);

    /// <summary>
    /// Do not include it in the dictionary by default, it is for internal use only
    /// </summary>
    public const string DeviceSecurityKeysClearContent = nameof(DeviceSecurityKeysClearContent);

    public const string ConfigurationCheck = nameof(ConfigurationCheck);
    public const string Login = nameof(Login);
    public const string DeviceActivity = nameof(DeviceActivity);
    public const string DeviceCommFlow = nameof(DeviceCommFlow);
    public const string DeviceIO = nameof(DeviceIO);
    public const string DeviceBackground = nameof(DeviceBackground);
    public const string DeviceHistorical = nameof(DeviceHistorical);
    public const string ThirdParty = nameof(ThirdParty);
    public const string UploadActivities = nameof(UploadActivities);
    public const string DownloadActivities = nameof(DownloadActivities);
    public const string WalkBy = nameof(WalkBy);
    public const string DeviceCommunicationTestWithMdmService = nameof(DeviceCommunicationTestWithMdmService);
}
