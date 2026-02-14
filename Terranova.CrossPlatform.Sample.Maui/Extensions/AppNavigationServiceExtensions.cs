using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Mobile.MVVM.Navigation;
using Terranova.CrossPlatform.Sample.Maui.Views;

namespace Terranova.CrossPlatform.Sample.Maui.Extensions;

public static class AppNavigationServiceExtensions
{
    public static Task<INavigationResult> NavigateToStartPageAsync(this ITrnNavigationService navigationService)
    {
        string pageName = nameof(MainPage);
        var parameters = BuildNavigationParameters(pageName);
        return navigationService.NavigateAsRootToAsync(pageName, parameters);
    }
    public static Task<INavigationResult> NavigateToSettingsPageAsync(this ITrnNavigationService navigationService)
    {
        string pageName = $"{nameof(SettingsPage)}";
        var parameters = BuildNavigationParameters(pageName);

        return navigationService.NavigateAsync(pageName, parameters);
    }
    
    private static TrnViewParameters BuildNavigationParameters(string name)
    {
        var parameters = new TrnViewParameters { PageName = name };
        return parameters;
    }
}