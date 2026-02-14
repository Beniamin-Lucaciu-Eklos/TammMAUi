using Terranova.CrossPlatform.Core.Abstractions.Data;

namespace Terranova.CrossPlatform.Sample.Data;

public class AppDataSupportOptionsBuilder : TrnDataSupportOptionsBuilder<AppDataSupportOptionsBuilder>
{
    public AppDataSupportOptionsBuilder(IServiceProvider serviceProvider, TrnDataSupportOptions settings = null)
        : base(serviceProvider, settings)
    {
    }

    public AppDataSupportOptionsBuilder UseSqLite()
    {
        var dataSupportsOptionsFactory = ServiceProvider.GetRequiredService<IAppDataSupportOptionsServiceFactory>();

        var svcDataSupportOptions = dataSupportsOptionsFactory[AppDataSupportOptionsService.SqLiteDbSectionKey];
        Use(svcDataSupportOptions().GetOptions());

        return this;
    }
}
