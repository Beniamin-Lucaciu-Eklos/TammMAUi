using Microsoft.Extensions.Options;
using Terranova.CrossPlatform.Mobile.Core.IO;

namespace Terranova.CrossPlatform.Sample.IO;

public interface IAppFileStorageOptionsService : ITrnMobileFileStorageOptionsService
{
    new AppFileStorageOptions GetOptions();
}

public class AppFileStorageOptionsService : TrnMobileFileStorageOptionsService<AppFileStorageOptions>, IAppFileStorageOptionsService
{
    public AppFileStorageOptionsService(IOptionsMonitor<AppFileStorageOptions> settings)
        : base(settings)
    {
    }

    
}
