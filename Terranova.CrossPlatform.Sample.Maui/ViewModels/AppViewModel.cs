using Terranova.CrossPlatform.Mobile.Core.Commands;
using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Mobile.Core.ViewModels;
using Terranova.CrossPlatform.Sample.Maui.Extensions;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

namespace Terranova.CrossPlatform.Sample.Maui.ViewModels;

public interface IAppViewModel : ITrnViewModel
{
    TrnTaskDelegateCommand LogoutCommand { get; }
    TrnTaskDelegateCommand ShowVersionCommand { get; }
    TrnTaskDelegateCommand NavigateToSettingsCommand { get; }
}

public interface IAppViewModel<TUnitOfWork> : IAppViewModel, ITrnViewModel<TUnitOfWork>
    where TUnitOfWork : IAppUnitOfWork
{
}

public abstract class AppViewModelBase<TUnitOfWork> : TrnViewModel<TUnitOfWork>, IAppViewModel<TUnitOfWork>
    where TUnitOfWork : IAppUnitOfWork
{
    private readonly Lazy<TUnitOfWork> _uow;

    protected AppViewModelBase(ITrnNavigationService navigationService, IAppUnitOfWorkFactory<TUnitOfWork> uowFactory)
        : base(navigationService)
    {
        _uow = uowFactory.Create();

        ShowVersionCommand = new TrnTaskDelegateCommand(ShowVersionAsync);
        LogoutCommand = new TrnTaskDelegateCommand(LogoutAsync).ObservesCanExecute(() => CanLogout);
        NavigateToSettingsCommand = new TrnTaskDelegateCommand(NavigateToSettingsPageAsync)
            .ObservesCanExecute(() => CanNavigateToSettingsPage);
    }

    protected override void OnInitialize(ITrnNavigationParameters parameters)
    {
        base.OnInitialize(parameters);

        CanLogout = !UnitOfWork.Context.Application.IsAppToApp && UnitOfWork.Context.User.IsLoggedIn;
        CanNavigateToSettingsPage = !UnitOfWork.Context.Application.IsAppToApp;
    }

    protected virtual Task OnDeviceContentChangedAsync()
    {
        return Task.CompletedTask;
    }

    protected abstract Task ShowVersionAsync();

    protected abstract Task LogoutAsync();

    protected abstract Task NavigateToSettingsPageAsync();

    private bool _canNavigateToSettingsPage;

    public bool CanNavigateToSettingsPage
    {
        get => _canNavigateToSettingsPage;
        set => SetProperty(ref _canNavigateToSettingsPage, value);
    }


    public TrnTaskDelegateCommand ShowVersionCommand { get; protected set; }

    public TrnTaskDelegateCommand LogoutCommand { get; protected set; }

    public TrnTaskDelegateCommand NavigateToSettingsCommand { get; protected set; }
    
    public override TUnitOfWork UnitOfWork => _uow.Value;

    public override void Destroy()
    {
        base.Destroy();

        UnitOfWork?.Dispose();
    }
}


public abstract class AppViewModel<TUnitOfWork> : AppViewModelBase<TUnitOfWork>
    where TUnitOfWork : IAppUnitOfWork
{
    protected AppViewModel(ITrnNavigationService navigationService, IAppUnitOfWorkFactory<TUnitOfWork> uowFactory)
        : base(navigationService, uowFactory)
    {
    }

    protected override async Task ShowVersionAsync()
    {
        try
        {
            await Navigation.ShowVersionPageAsync();
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            //intentionally not rethrown
        }
    }
    
    protected override async Task NavigateToSettingsPageAsync()
    {
        try
        {
            await Navigation.NavigateToSettingsPageAsync();
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            await Navigation.ShowErrorAsync(ex);
        }
    }


    protected override async Task LogoutAsync()
    {
        try
        {
            await Navigation.NavigateToStartPageAsync();
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            //intentionally not rethrown
        }
    }
    
    
}