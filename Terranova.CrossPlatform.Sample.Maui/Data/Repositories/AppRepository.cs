using Terranova.CrossPlatform.Core.Abstractions.Repositories;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

namespace Terranova.CrossPlatform.Sample.Data;

public interface IAppRepository : ITrnRepository
{
}

public interface IAppRepository<TUnitOfWork> : ITrnRepository<TUnitOfWork>, IAppRepository
    where TUnitOfWork : class, IAppUnitOfWork
{
}

public abstract class AppRepository<TUnitOfWork> : TrnRepository<TUnitOfWork>, IAppRepository<TUnitOfWork>
    where TUnitOfWork : class, IAppUnitOfWork
{
}