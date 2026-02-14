using System.Text.Json;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;
using Terranova.CrossPlatform.Sample.IO;
using Terranova.CrossPlatform.Sample.Maui.Diagnostics;

namespace Terranova.CrossPlatform.Sample.App;

public class AppDiagnosticsOptionsInitializer : ITrnDIInitializeService
{
    public void Initialize(IServiceProvider serviceProvider)
    {
        var optionsSingleton = serviceProvider.GetRequiredService<ITrnOptionsSingleton<AppDiagnosticsOptions>>();
        var options = optionsSingleton.Value;

        var svcFileStorageOptions = serviceProvider.GetRequiredService<IAppFileStorageOptionsService>();
        var pathFileName = Path.Combine(svcFileStorageOptions.LogPath, $"SampleApp.json");
        

        try
        {
            string json = File.ReadAllText(pathFileName);
            var jsonOptions = new JsonSerializerOptions().Default(true).WithPrivateFields();
            jsonOptions.PropertyNameCaseInsensitive = true;
            var fileOptions = json.DeserializeJson<AppDiagnosticsOptions>(jsonOptions);
            options.Acquire(fileOptions);
        }
        catch (Exception ex)
        {
            _ = ex;
            options.LogTags.SetAllFlags();
            options.LogTags.SetFlag(AppLogTag.None, true);
            options.LogTags.SetFlag(AppLogTag.Navigation, false);
            options.LogTags.SetFlag(AppLogTag.Validation, false);
            options.LogTags.SetFlag(AppLogTag.TaskExecution, false);
            options.LogTags.SetFlag(AppLogTag.DeviceBackground, false);
            options.LogTags.SetFlag(AppLogTag.DeviceIO, false);
            options.LogTags.SetFlag(AppLogTag.Binding, false);

            string json = options.SerializeAsJson(new JsonSerializerOptions().WithPrivateFields(), indented: true);
            File.WriteAllText(pathFileName, json);
        }

        optionsSingleton.NotifyChange();
    }
}