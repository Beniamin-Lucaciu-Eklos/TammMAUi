using System.Diagnostics;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.App;
using Terranova.CrossPlatform.Mobile.Core.App;
using Terranova.CrossPlatform.Sample.App;
using Xamarin.Android.Net;
using Activity = Android.App.Activity;

namespace Terranova.CrossPlatform.Sample.Maui;

public class AppPlatformService : IAppPlatformService
{
    private static readonly Lazy<AppPlatformService> _instance =
        new Lazy<AppPlatformService>(() => new AppPlatformService());

    public static AppPlatformService Instance => _instance.Value;

    public Activity CurrentActvity { get; set; }

    private AppPlatformService()
    {
        InstanceId = Guid.NewGuid().ToString("N");
    }

    public TrnAppVersion GetVersion()
    {
        VersionTracking.Track();

        var versionItems = VersionTracking.CurrentVersion.SafeSplit(".");

        var version = new TrnAppVersion
        {
            Major = versionItems.FirstOrDefault().TryParseAsIntInvariant() ?? 0,
            Minor = versionItems.Skip(1).FirstOrDefault().TryParseAsIntInvariant() ?? 0,
            Build = versionItems.Skip(2).FirstOrDefault().TryParseAsIntInvariant() ?? 0,
            Revision = versionItems.Skip(3).FirstOrDefault(),
        };

        return version;
    }

    public HttpMessageHandler RetrieveHttpMessageHandler()
    {
        return new AndroidClientHandler();
    }

    public void Terminate()
    {
        if (CurrentActvity is null)
            return;
        CurrentActvity.Finish();
    }


    public ITrnPermissionsManager PermissionsManager { get; private set; }

    public async Task InitializeAsync(ITrnPermissionsManager permissionsManager)
    {
        try
        {
            PermissionsManager = permissionsManager;

            var permissionsStatus = await TryGrantAppPermissionsAsync();

            if (permissionsStatus != PermissionStatus.Granted)
                throw new TrnUnauthorizeException($"{nameof(PermissionStatus)}: {permissionsStatus}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            throw;
        }
    }

    protected virtual async Task<PermissionStatus> TryGrantAppPermissionsAsync()
    {
        PermissionStatus status;

        try
        {
            status = await PermissionsManager.TryGrantPermissionAsync<Permissions.StorageRead>();
            if (status != PermissionStatus.Granted)
                return status;

            status = await PermissionsManager.TryGrantPermissionAsync<Permissions.StorageWrite>();
            if (status != PermissionStatus.Granted)
                return status;

            status = await PermissionsManager.TryGrantPermissionAsync<Permissions.Phone>();
            if (status != PermissionStatus.Granted)
                return status;

            return status;
        }
        catch (Exception ex)
        {
            _ = ex;
            status = PermissionStatus.Unknown;
        }

        return status;
    }

    public string InstanceId { get; }
    public string ExternalStoragePath => Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
}