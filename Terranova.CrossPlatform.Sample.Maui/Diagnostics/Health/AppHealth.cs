using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public interface IAppHealth : ITrnHealth
{
}

public class AppHealth : TrnHealth
{
    public AppHealth(TrnHealthSettings settings)
        : base(settings)
    {
    }
}
