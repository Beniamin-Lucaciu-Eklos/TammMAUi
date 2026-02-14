using Terranova.CrossPlatform.Sample.Maui.Extensions;
using Terranova.CrossPlatform.Mobile.Core.Commands;
using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

namespace Terranova.CrossPlatform.Sample.Maui.ViewModels;

public class AppVersionPageViewModel : AppViewModel<IAppUnitOfWork>
{
    public AppVersionPageViewModel(ITrnNavigationService navigationService, IAppUnitOfWorkFactory<IAppUnitOfWork> uowFactory)
        : base(navigationService, uowFactory)
    {
        DialogCanBeCanceled = true;
    }

    protected override void OnInitialize(ITrnNavigationParameters parameters)
    {
        try
        {
            base.OnInitialize(parameters);

            Title = "About";

            Message =  UnitOfWork.Context.Application.Version.FullVersion;
            Copyright =  "2022-2025";
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            throw;
        }
    }

    protected override async void OnNavigatedTo(ITrnNavigationParameters parameters)
    {
        try
        {
            base.OnNavigatedTo(parameters);
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            await Navigation.ShowErrorAsync(ex);
        }
    }

    private string _message;
    public string Message
    {
        get => _message;
        set => SetProperty(ref _message, value);
    }

    private string _copyright;
    public string Copyright
    {
        get => _copyright;
        set => SetProperty(ref _copyright, value);
    }

    public TrnTaskDelegateCommand CloseCommand { get; private set; }
}
