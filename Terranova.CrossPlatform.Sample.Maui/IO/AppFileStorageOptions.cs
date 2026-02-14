using Terranova.CrossPlatform.Mobile.Core.IO;

namespace Terranova.CrossPlatform.Sample.IO;

public class AppFileStorageOptions : TrnMobileFileStorageOptions<AppFileStorageOptions>
{
    public override AppFileStorageOptions Acquire(AppFileStorageOptions other)
    {
        if (other is not null && other != this)
        {
            base.Acquire(other);
            
        }
        return this;
    }
}
