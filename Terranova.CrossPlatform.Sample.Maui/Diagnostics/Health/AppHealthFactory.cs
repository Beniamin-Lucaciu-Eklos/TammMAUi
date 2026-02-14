using System;
using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public interface IAppHealthFactory : ITrnHealthFactory
{
}

public class AppHealthFactory : IAppHealthFactory
{
    private static readonly Lazy<IAppHealthFactory> _instance = new Lazy<IAppHealthFactory>(() => new AppHealthFactory());
    public static IAppHealthFactory Instance => _instance.Value;

    public ITrnHealth Build()
    {
        return new AppHealth(new TrnHealthSettings());
    }

    public void ForceReload()
    {
        throw new NotImplementedException();
    }
}