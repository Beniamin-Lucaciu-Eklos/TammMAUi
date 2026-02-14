using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Sample.Data;

namespace Terranova.CrossPlatform.Sample.App;

public interface IAppContextFactory : ITrnContextFactory<AppDataSupportOptionsBuilder,
                                                        AppContextSettings,
                                                        IAppContext,
                                                        AppContextBuilder>
{
}

public class AppContextFactory : TrnContextFactory<AppDataSupportOptionsBuilder,
                                                        AppContextSettings,
                                                        IAppContext,
                                                        AppContextBuilder>,
                                IAppContextFactory
{
    public AppContextFactory(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
    }

    protected override AppContextBuilder CreateBuilder()
    {
        var builder = new AppContextBuilder(new AppDataSupportOptionsBuilder(ServiceProvider));
        return builder;
    }
}