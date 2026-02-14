using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Mobile.Core.Commands;
using Terranova.CrossPlatform.Mobile.Core.Data;
using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Sample.Data;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;
using Terranova.CrossPlatform.Sample.Maui.Extensions;

namespace Terranova.CrossPlatform.Sample.Maui.ViewModels;

public class LoginViewModel : AppViewModel<IAppUnitOfWork>
{
    private bool _isAuthenticationKindFormSelected, _isAuthenticationKindActiveDirectorySelected;

    public LoginViewModel(ITrnNavigationService navigationService, IAppUnitOfWorkFactory<IAppUnitOfWork> uowFactory) : base(navigationService, uowFactory)
    {
        LoginCommand = CreateCommandWithErrorValidation(ExecuteLoginAsync);
    }

    protected override void AddRules()
    {
        Rules.Add(new AppValidationMandatoryRule(nameof(UserName),
                    () => !UserName.IsNullOrWhiteSpace()
                            ? new AppValidationResult(TrnValidationStatus.None, null)
                            : new AppValidationResult(TrnValidationStatus.Mandatory, "General_UIMessage_ThisFiedIsRequired")));
        
        Rules.Add(new AppValidationMandatoryRule(nameof(Password),
                    () => !Password.IsNullOrWhiteSpace()
                            ? new AppValidationResult(TrnValidationStatus.None, null)
                            : new AppValidationResult(TrnValidationStatus.Mandatory, "General_UIMessage_ThisFiedIsRequired")));

        }

    public override async void OnAppearing()
    {
        try
        {
            base.OnAppearing();
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            await Navigation.ShowErrorAsync(ex);
        }
    }

    protected override async void OnNavigatedTo(ITrnNavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        try
        {
            using (MaskNavigation())
            {
                await BindAsync();
                Validate();
            }
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            await Navigation.ShowErrorAsync(ex);
        }
    }

    private async Task BindAsync()
    {
        CancellationToken cancellationToken = CancellationToken.None;
        using (MaskChanges())
        {
        
        }
    }
    
    private async Task ExecuteLoginAsync()
    {
        try
        {
            CancellationToken cancellationToken = CancellationToken.None;

            using (MaskNavigation())
            {
                //LOGIN
            }
        }
        catch (Exception ex)
        {
            UnitOfWork.Logger.WriteError(ex);
            await Navigation.ShowErrorAsync(ex);
        }
    }
    
    private string _userName, _password;
    public string UserName
    {
        get => _userName; set => SetProperty(ref _userName, value);
    }

    public string Password
    {
        get => _password; set => SetProperty(ref _password, value);
    }

    public TrnTaskDelegateCommand LoginCommand { get; }
}