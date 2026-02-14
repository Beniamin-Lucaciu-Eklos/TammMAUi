
using Terranova.CrossPlatform.Core.Abstractions.UnitsOfWork;
using Terranova.CrossPlatform.Sample.App;
using Terranova.CrossPlatform.Sample.Data;

namespace Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;


public interface IAppUnitOfWorkFactory<TUnitOfWork> : ITrnUnitOfWorkFactory<AppDataSupportOptionsBuilder,
                                                                            IAppContext,
                                                                            AppContextSettings,
                                                                            AppContextBuilder,
                                                                            AppUnitOfWorkSettings,
                                                                            TUnitOfWork,
                                                                            AppUnitOfWorkSettingsBuilder>
    where TUnitOfWork : IAppUnitOfWork
{
}

public class AppUnitOfWorkFactory<TUnitOfWork> : TrnUnitOfWorkFactory<AppDataSupportOptionsBuilder,
                                                                        IAppContext,
                                                                        AppContextSettings,
                                                                        AppContextBuilder,
                                                                        AppUnitOfWorkSettings,
                                                                        TUnitOfWork,
                                                                        AppUnitOfWorkSettingsBuilder>,
                                                    IAppUnitOfWorkFactory<TUnitOfWork>
    where TUnitOfWork : IAppUnitOfWork
{

    public AppUnitOfWorkFactory(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
    }

    protected override AppUnitOfWorkSettingsBuilder CreateBuilder()
    {
        var builder = new AppUnitOfWorkSettingsBuilder(ServiceProvider);
        return builder;
    }
}
