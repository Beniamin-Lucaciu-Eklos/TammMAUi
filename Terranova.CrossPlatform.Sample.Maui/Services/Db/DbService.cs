using TammMobile.Core.Services;

namespace Terranova.CrossPlatform.Sample.Services.Db;

public interface IDbService : IBaseService
{
}

public class DbService : BaseService, IDbService
{
}