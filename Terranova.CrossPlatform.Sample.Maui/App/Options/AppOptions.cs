using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.App;
using Terranova.CrossPlatform.Mobile.Core.App;

namespace Terranova.CrossPlatform.Sample.App;

public class AppOptions : TrnMobileAppOptions,
                                ITrnAcquireService<AppOptions>,
                                ITrnCloneService<AppOptions>
{
    public AppOptions()
    {
        Description = "SampleApp";
        Version = new TrnAppVersion();
    }

    public AppOptions Acquire(AppOptions other)
    {
        if (other is not null && other != this)
        {
            base.Acquire(other);

            InstanceId = other.InstanceId;

            WebServerAddress = other.WebServerAddress;

            DatabaseVersion = other.DatabaseVersion;
            LastSynchronizationTimestamp = other.LastSynchronizationTimestamp;
            LastLoggedInUserName = other.LastLoggedInUserName;
     
            WebApiTimeout = other.WebApiTimeout;
            HandHeldId = other.HandHeldId;
            DeviceId = other.DeviceId;

        }

        return this;
    }

    public override TrnAppOptions Acquire(TrnAppOptions other)
    {
        if (other is not null)
        {
            if (other is AppOptions)
            {
                return Acquire((AppOptions)other);
            }
            else
            {
                base.Acquire(other);
            }
        }

        return this;
    }

    public new AppOptions Clone()
    {
        return new AppOptions().Acquire(this);
    }

    public const string ApplicationName = "SampleApp";

    public string InstanceId { get; set; }

 
    public string WebServerAddress { get; set; }

 

    public string DatabaseVersion { get; set; }

    public DateTime? LastSynchronizationTimestamp { get; set; }

    public string LastLoggedInUserName { get; set; }
    
    
    public string HandHeldId { get; set; }

    public string DeviceId { get; set; }

    public TimeSpan WebApiTimeout { get; set; }
}
