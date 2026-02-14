using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public interface IAppTraces : ITrnTraces
{
}

public class AppTraces : TrnTraces, IAppTraces
{
    public AppTraces(TrnTracesSettings settings)
        : base(settings)
    {
    }
}
