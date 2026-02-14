using Microsoft.Extensions.Options;

using Terranova.CrossPlatform.Core.Abstractions.Configuration;

namespace TammMobile.Core.SoftwareOptions;

public interface IAppSoftwareOptionsService : ITrnOptionsService<AppSoftwareOptions>
{
  
}

public class AppSoftwareOptionsService : TrnOptionsMonitorService<AppSoftwareOptions>, IAppSoftwareOptionsService
{
    public AppSoftwareOptionsService(IOptionsMonitor<AppSoftwareOptions> settings)
        : base(settings)
    {
    }
}
