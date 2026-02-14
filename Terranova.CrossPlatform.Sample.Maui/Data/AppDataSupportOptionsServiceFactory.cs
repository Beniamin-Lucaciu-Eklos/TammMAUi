using Microsoft.Extensions.Options;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;
using Terranova.CrossPlatform.Core.Abstractions.Data;

namespace Terranova.CrossPlatform.Sample.Data;

public interface IAppDataSupportOptionsServiceFactory : ITrnOptionsServiceFactory<IAppDataSupportOptionsService, string, TrnDataSupportOptions>
{
}

public class AppDataSupportOptionsServiceFactory : TrnOptionsServiceFactory<IAppDataSupportOptionsService, string, TrnDataSupportOptions>, IAppDataSupportOptionsServiceFactory
{
    public AppDataSupportOptionsServiceFactory(IServiceProvider serviceProvider)
    {
        var optionsSnaphot = serviceProvider.GetRequiredService<IOptionsSnapshot<TrnDataSupportOptions>>();

        void add(string key) => Factories.Add(key, () => new AppDataSupportOptionsService(optionsSnaphot.Get(key)));

        add(AppDataSupportOptionsService.SqLiteDbSectionKey);
    }
}