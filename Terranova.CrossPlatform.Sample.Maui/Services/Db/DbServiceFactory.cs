namespace Terranova.CrossPlatform.Sample.Services.Db;

public interface IDbServiceFactory
{
    IDbService Create();
}

public class DbServiceFactory : IDbServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public DbServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IDbService Create()
    {
        return _serviceProvider.GetRequiredService<DbService>();
    }
}