using Terranova.CrossPlatform.Core.Abstractions.UnitsOfWork;
using Terranova.CrossPlatform.Sample.App;
using Terranova.CrossPlatform.Sample.Data;

namespace Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

public class AppUnitOfWorkSettingsBuilder : TrnUnitOfWorkOptionsBuilder<AppDataSupportOptionsBuilder,
                                                                        IAppContext,
                                                                        AppContextSettings,
                                                                        AppContextBuilder,
                                                                        AppUnitOfWorkSettings,
                                                                        AppUnitOfWorkSettingsBuilder>
{
    public AppUnitOfWorkSettingsBuilder(IServiceProvider serviceProvider, AppUnitOfWorkSettings settings = null)
        : base(serviceProvider, settings)
    {
    }

    protected override AppContextBuilder CreateContextBuilder()
    {
        return new AppContextBuilder(new AppDataSupportOptionsBuilder(ServiceProvider));
    }
}