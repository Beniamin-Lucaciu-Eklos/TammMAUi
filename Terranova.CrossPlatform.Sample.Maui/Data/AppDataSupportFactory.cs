using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Data;
using Terranova.CrossPlatform.Core.Data.Sqlite;

namespace Terranova.CrossPlatform.Sample.Data;

public interface IAppDataSupportFactory : ITrnDataSupportFactory<AppDataSupportOptionsBuilder>
{
}

public class AppDataSupportFactory : TrnDataSupportFactory<AppDataSupportOptionsBuilder>, IAppDataSupportFactory
{
    public AppDataSupportFactory(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
    }

    protected override AppDataSupportOptionsBuilder CreateBuilder()
    {
        return new AppDataSupportOptionsBuilder(ServiceProvider);
    }

    protected override ITrnDataSupport OnCreate()
    {
        var builder = CreateBuilder();

        builder.UseSqLite();

        var options = builder.Build();

        var dataSupport = CreateCore(options);

        return dataSupport;
    }

    protected override ITrnDataSupport CreateCore(TrnDataSupportOptions settings)
    {
        ITrnDataSupport dataSupport;

        switch (settings.DatabaseKind)
        {
            case TrnDatabaseKind.SQLite:
                dataSupport = ServiceProvider.GetRequiredService<ITrnSqliteSupport>();
                break;

            case TrnDatabaseKind.Undefined:
                dataSupport = ServiceProvider.GetRequiredService<ITrnUndefinedDataSupport>();
                break;

            default:
                throw new TrnNotSupportedException($"Unsupported database: {settings.DatabaseKind}");
        }

        var svcDataSupportOptions = new AppDataSupportOptionsService(settings);

        dataSupport.Use(svcDataSupportOptions);

        return dataSupport;
    }
}
