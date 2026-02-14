using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;
using Terranova.CrossPlatform.Core.Abstractions.Data;

namespace TammMobile.Core.SoftwareOptions;

public class AppSoftwareOptions : TrnOptions,
                                    ITrnAcquireService<AppSoftwareOptions>
{
    public AppSoftwareOptions()
    {
    }

    public AppSoftwareOptions Acquire(AppSoftwareOptions other)
    {
        if (other is not null && other != this)
        {

        }

        return this;
    }
}