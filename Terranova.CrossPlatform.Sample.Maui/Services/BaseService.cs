using Terranova.CrossPlatform.Core.Abstractions.Services;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

namespace TammMobile.Core.Services;

public interface IBaseService : ITrnService<IAppUnitOfWork>
{
}

public abstract class BaseService : TrnService<IAppUnitOfWork>, IBaseService
{
}