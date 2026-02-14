
using Terranova.CrossPlatform.Mobile.Core.App;

namespace Terranova.CrossPlatform.Sample.App;

public interface IAppPlatformService : ITrnMobilePlatformService
{
    string InstanceId { get; }
    string ExternalStoragePath { get; }
}