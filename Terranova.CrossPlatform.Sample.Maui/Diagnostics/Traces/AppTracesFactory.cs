using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public interface IAppTracesFactory : ITrnTracesFactory
{
}

public class AppTracesFactory : IAppTracesFactory
{
    private static readonly Lazy<AppTracesFactory> _instance = new Lazy<AppTracesFactory>(() => new AppTracesFactory());
    public static AppTracesFactory Instance => _instance.Value;

    public ITrnTraces Build()
    {
        return new AppTraces(new TrnTracesSettings());
    }

    public void ForceReload()
    {
        throw new NotImplementedException();
    }
}