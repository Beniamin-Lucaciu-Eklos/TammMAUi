using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Terranova.CrossPlatform.Mobile.App;
using Terranova.CrossPlatform.Mobile.Core.Events;
using Terranova.CrossPlatform.Sample.App;

namespace Terranova.CrossPlatform.Sample.Maui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override async void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        
        AppPermissionsManager.Instance.CurrentActivity = this;
        AppPlatformService.Instance.CurrentActvity = this;
        
        await AppPlatformService.Instance.InitializeAsync(TrnAndroidPermissionsManager.Instance);
        
        await TrnToastEvent.ResolveAndSubscribeAsync(message =>
        {
            var appContext = ApplicationContext;
            if (appContext is not null)
            {
                Toast.MakeText(appContext, message, ToastLength.Short)?.Show();
            }
        });
    }
    
    public override void OnRequestPermissionsResult(int requestCode, string[] permissions,
        [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
        try
        {
            TrnAndroidPermissionsManager.Instance.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        catch (Exception ex)
        {
            _ = ex;
            throw;
            //TrnLogger.Instance.WriteError(ex);
        }
    }
}