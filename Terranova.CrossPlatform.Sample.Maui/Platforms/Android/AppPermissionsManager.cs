using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using Terranova.CrossPlatform.Mobile.Core.App;

namespace Terranova.CrossPlatform.Mobile.App;

public class AppPermissionsManager : TrnPermissionsManager
{
    private static readonly Lazy<AppPermissionsManager> _instance =
        new Lazy<AppPermissionsManager>(() => new AppPermissionsManager());

    private AppPermissionsManager() { }

    public static AppPermissionsManager Instance => _instance.Value;


    private const int StoragePermissionRequestCode = 23;
    public const int FilePickingRequestCode = 3001;
    public const int UnknownSourcesRequestCode = 1979;
    private const int ReadWriteExternalStorageRequestCode = 2230;
    private const int ManageAllFilesRequestCode = 2231;

    private TaskCompletionSource<bool> _requestPermissionsResult;

    public Task<bool> RequestManageUnknownAppSourcesPermissionsAsync()
    {
        _requestPermissionsResult = new TaskCompletionSource<bool>();

        var unknownSources = new Intent(Android.Provider.Settings.ActionManageUnknownAppSources);
        unknownSources.SetData(Android.Net.Uri.Parse($"package:{CurrentActivity.PackageName}"));

        CurrentActivity.StartActivityForResult(unknownSources, UnknownSourcesRequestCode);

        return _requestPermissionsResult.Task;
    }

    public bool HasManageUnknownAppSourcesPermissions()
    {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            return CurrentActivity.PackageManager.CanRequestPackageInstalls();
        else
            return true;
    }

    public Task<bool> RequestForExternalStoragePermissionsAsync()
    {
        _requestPermissionsResult = new TaskCompletionSource<bool>();

        //Android is 11 (R) or above
        if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.R)
        {
            try
            {
                Intent intent = new Intent();
                intent.SetAction(Android.Provider.Settings.ActionManageAppAllFilesAccessPermission);
                intent.AddCategory(Android.Content.Intent.CategoryDefault);
                Android.Net.Uri uri = Android.Net.Uri.FromParts("package", CurrentActivity.PackageName, null);
                intent.SetData(uri);

                CurrentActivity.StartActivityForResult(intent, ManageAllFilesRequestCode);
            }
            catch (Exception ex)
            {
                _ = ex;
                Intent intent = new Intent();
                intent.SetAction(Android.Provider.Settings.ActionManageAppAllFilesAccessPermission);
                CurrentActivity.StartActivityForResult(intent, ManageAllFilesRequestCode);
            }
        }
        else
        {
            //Below android 11
            ActivityCompat.RequestPermissions
            (
                Platform.CurrentActivity, new string[]
                {
                    Android.Manifest.Permission.WriteExternalStorage,
                    Android.Manifest.Permission.ReadExternalStorage
                },
                StoragePermissionRequestCode
            );
        }

        return _requestPermissionsResult.Task;
    }

    public Activity CurrentActivity { get; set; }

    public bool HasExternalStoragePermissions()
    {
        if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.R)
        {
            //Android is 11 (R) or above
            return Android.OS.Environment.IsExternalStorageManager;
        }
        else
        {
            //Below android 11
            var write = ContextCompat.CheckSelfPermission(CurrentActivity,
                Android.Manifest.Permission.WriteExternalStorage);
            var read = ContextCompat.CheckSelfPermission(CurrentActivity,
                Android.Manifest.Permission.ReadExternalStorage);

            return read == Permission.Granted && write == Permission.Granted;
        }
    }

    public void OnRequestPermissionsResult(int requestCode, string[] permissions,
        [GeneratedEnum] Permission[] grantResults)
    {
        Microsoft.Maui.ApplicationModel.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        if (requestCode == StoragePermissionRequestCode)
        {
            _requestPermissionsResult?.TrySetResult(grantResults.Where(g => g == Permission.Granted).Count() ==
                                                    grantResults.Length);
        }
    }

    public void OnActivityResult(int requestCode, Result resultCode, Intent data)
    {
        switch (requestCode)
        {
            case ManageAllFilesRequestCode:
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
                {
                    if (Android.OS.Environment.IsExternalStorageManager)
                    {
                        _requestPermissionsResult?.TrySetResult(true);
                    }
                    else
                    {
                        _requestPermissionsResult?.TrySetResult(false);
                    }
                }

                break;
            }
            case UnknownSourcesRequestCode:
            {
                if (resultCode == Result.Ok)
                    _requestPermissionsResult?.TrySetResult(true);
                else
                    _requestPermissionsResult?.TrySetResult(false);
                break;
            }

            case StoragePermissionRequestCode:
                break;

            default:
                break;
        }
    }
}