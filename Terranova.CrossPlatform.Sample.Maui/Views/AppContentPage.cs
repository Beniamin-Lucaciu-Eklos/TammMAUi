using Terranova.CrossPlatform.Mobile.Core.Views;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;
using Terranova.CrossPlatform.Sample.Maui.ViewModels;

namespace Terranova.CrossPlatform.Sample.Maui.Views;

public abstract class AppContentPage : TrnContentPage
{
    public AppContentPage():base()
    {
        //OnInitializeComponent();
        //OnCreateControls();
    }

    protected override void OnCreateControls()
    {
        base.OnCreateControls();

        BuildSecondaryActivityToolbar();
    }

    public void BuildSecondaryActivityToolbar()
    {

        AddSettingsToolbarItemIfNeeded();
        AddToolbarItem("Versione", "ShowVersionCommand");
        AddLogoutToolbarItemIfNeeded();
    }

    private void AddSettingsToolbarItemIfNeeded()
    {
        if (this.GetType().Name != nameof(SettingsPage))
        {
            string settingsToolbarItem = "Settings";
            AddToolbarItem(settingsToolbarItem, "NavigateToSettingsCommand");
        }
    }

    private void AddLogoutToolbarItemIfNeeded()
    {
        //TMBL [App2App]
        //var contextFactory = TMApplication.Services.GetRequiredService<ITMContextFactory>();
        //var context = contextFactory.Create();

        //var context = TrnMobileApplication.Current.Services.GetRequiredService<ITMContext>();
        var canLogout = (!UnitOfWork?.Context?.Application?.IsAppToApp ?? false)
                        && (UnitOfWork?.Context?.User?.IsLoggedIn ?? false);

        if (canLogout)
            AddToolbarItem("Logout", "LogoutCommand");
    }

    public void AddToolbarItem(string text, string cmdPath)
    {
        var toolbarItem = new ToolbarItem()
        {
            Text = text,
            Order = ToolbarItemOrder.Secondary,
        };

        toolbarItem.SetBinding(ToolbarItem.CommandProperty, new Binding(cmdPath));
        ToolbarItems.Add(toolbarItem);
    }

    public new IAppViewModel BindingContext
    {
        get => ((IAppViewModel)base.BindingContext);
        set => base.BindingContext = value;
    }

    public new IAppUnitOfWork UnitOfWork => BindingContext?.UnitOfWork as IAppUnitOfWork;

  
}