using Microsoft.Extensions.Options;
using Terranova.CrossPlatform.Mobile.Core.App;

namespace Terranova.CrossPlatform.Sample.App;

public interface IAppOptionsService : ITrnMobileAppOptionsService
{
    string InstanceId { get; }

    string WebServerAddress { get; }

    string DatabaseVersion { get; }

    DateTime? LastSynchronizationTimestamp { get; }

    string LastLoggedInUserName { get; }
    

    TimeSpan WebApiTimeout { get; }

    string HandHeldId { get; }

    string DeviceId { get; }
    

    new AppOptions GetOptions();
}

public class AppOptionsService : TrnMobileAppOptionsService<AppOptions>, IAppOptionsService
{
    public AppOptionsService(IOptionsMonitor<AppOptions> settings)
        : base(settings)
    {
    }

    public string InstanceId => Options.InstanceId;

    public string WebServerAddress => Options.WebServerAddress;
    

    public string DatabaseVersion => Options.DatabaseVersion;

    public DateTime? LastSynchronizationTimestamp => Options.LastSynchronizationTimestamp;

    public string LastLoggedInUserName => Options.LastLoggedInUserName;
    
    
    public TimeSpan WebApiTimeout => Options.WebApiTimeout;

    public string HandHeldId => Options.HandHeldId;

    public string DeviceId => Options.DeviceId;
    
}
