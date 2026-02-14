using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Mobile.Core.ViewModels;
using Terranova.CrossPlatform.Sample.Maui.Views;

namespace Terranova.CrossPlatform.Sample.Maui.Extensions;

public static class AppDialogServiceExtensions
{
    public static Task<TrnMessageBoxResult> ShowErrorAsync(this ITrnNavigationService dialog, Exception ex)
    {
        return dialog.ShowErrorAsync("General_Error", ex);
    }

    public static Task<TrnMessageBoxResult> ShowErrorAsync(this ITrnNavigationService dialog, string message)
    {
        return dialog.ShowErrorAsync("General_Error", message);
    }
    
    public static Task<ITrnDialogOutcome> ShowVersionPageAsync(this ITrnNavigationService dialog)
    {
        string pageName = nameof(AppVersionPage);
        var parameters = BuildDialogParameters(pageName);
        return dialog.ShowDialogAsync(pageName, parameters);
    }
    
    private static TrnDialogParameters BuildDialogParameters(string name)
    {
        var parameters = new TrnDialogParameters { PageName = name };
        return parameters;
    }
}