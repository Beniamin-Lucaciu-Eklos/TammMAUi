using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;

namespace Terranova.CrossPlatform.Sample.App;

public class AppOptionsInitializer : ITrnDIInitializeService
{
    public void Initialize(IServiceProvider serviceProvider)
    {
        var options = serviceProvider.GetRequiredService<ITrnOptionsSingleton<AppOptions>>();
        var platformService = serviceProvider.GetRequiredService<IAppPlatformService>();

        options.Value.Name = AppOptions.ApplicationName;
        options.Value.Version = platformService.GetVersion();
        options.Value.InstanceId = platformService.InstanceId;
        options.Value.HostId = Environment.MachineName;
        options.Value.DatabaseVersion = "0";
        options.Value.WebApiTimeout = TimeSpan.FromSeconds(10);

        options.NotifyChange();
    }
}
