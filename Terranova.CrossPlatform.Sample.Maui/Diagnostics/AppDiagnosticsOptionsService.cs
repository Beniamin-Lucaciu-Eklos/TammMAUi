using Microsoft.Extensions.Options;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public interface IAppDiagnosticsSettingsService : ITrnOptionsService<AppDiagnosticsOptions>
{
    public TrnReadonlyFlagsDictionary<string> LogTags { get; }
}

public class AppDiagnosticsOptionsService : TrnOptionsMonitorService<AppDiagnosticsOptions>, IAppDiagnosticsSettingsService
{
    public AppDiagnosticsOptionsService(IOptionsMonitor<AppDiagnosticsOptions> settings)
        : base(settings)
    {
    }

    public TrnReadonlyFlagsDictionary<string> LogTags => Options.LogTags;
}
