using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

namespace Terranova.CrossPlatform.Sample.Maui.ViewModels;

public class MainViewModel :AppViewModel<IAppUnitOfWork>
{
    public MainViewModel(ITrnNavigationService navigationService, IAppUnitOfWorkFactory<IAppUnitOfWork> uowFactory) : base(navigationService, uowFactory)
    {
    }
}