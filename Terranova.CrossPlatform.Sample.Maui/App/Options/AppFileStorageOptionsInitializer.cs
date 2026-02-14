using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;
using Terranova.CrossPlatform.Sample.IO;

namespace Terranova.CrossPlatform.Sample.App;

public class AppFileStorageOptionsInitializer : ITrnDIInitializeService
{
    public const string ApplicationFolderName = "SampleApp";

    public void Initialize(IServiceProvider serviceProvider)
    {
        var optionsSingleton = serviceProvider.GetRequiredService<ITrnOptionsSingleton<AppFileStorageOptions>>();
        var options = optionsSingleton.Value;
        var platformService = serviceProvider.GetRequiredService<IAppPlatformService>();
#if ANDROID
        /*Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDocuments).AbsolutePath*/
        options.AppPath = Path.Combine(  Platform.AppContext.GetExternalFilesDir(null).AbsolutePath, ApplicationFolderName);
#else
        options.AppPath = Path.Combine(FileSystem.AppDataDirectory, ApplicationFolderName);
#endif
      
        Directory.CreateDirectory(options.AppPath);

        options.PersistentPath = options.AppPath;

        options.TemporaryPath = Path.Combine(options.AppPath, "Temp");
        Directory.CreateDirectory(options.TemporaryPath);

        options.LogPath = Path.Combine(options.AppPath, ApplicationFolderName, "Log");
        Directory.CreateDirectory(options.LogPath);

      
        options.DatabasePath = Path.Combine(options.AppPath, "Db");
        Directory.CreateDirectory(options.DatabasePath);

        optionsSingleton.NotifyChange();
    }
}