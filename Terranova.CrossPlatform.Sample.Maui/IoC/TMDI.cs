using System.Diagnostics.CodeAnalysis;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

namespace Terranova.CrossPlatform.Sample.IoC;

public interface ITMDI<TDependent> : ITrnDI<TDependent, IAppUnitOfWork>
    where TDependent : ITrnDIDependent<IAppUnitOfWork>
{
}

[ExcludeFromCodeCoverage]
public class TMDI<TDependent> : TrnDI<TDependent, IAppUnitOfWork>, ITMDI<TDependent>
    where TDependent : ITrnDIDependent<IAppUnitOfWork>
{
    public TMDI(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
    }
}