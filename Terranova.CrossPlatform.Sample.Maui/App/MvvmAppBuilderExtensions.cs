using Microsoft.Extensions.DependencyInjection.Extensions;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.App;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;
using Terranova.CrossPlatform.Core.Abstractions.Data;
using Terranova.CrossPlatform.Core.Abstractions.IO;
using Terranova.CrossPlatform.Core.Abstractions.Resources;
using Terranova.CrossPlatform.Core.Data.Sqlite;
using Terranova.CrossPlatform.Core.Diagnostics;
using Terranova.CrossPlatform.Mobile.App;
using Terranova.CrossPlatform.Mobile.Core.App;
using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Mobile.Core.Users;
using Terranova.CrossPlatform.Mobile.MVVM;
using Terranova.CrossPlatform.Mobile.MVVM.Ioc;
using Terranova.CrossPlatform.Mobile.MVVM.Navigation;
using Terranova.CrossPlatform.Sample.Data;
using Terranova.CrossPlatform.Sample.IO;
using Terranova.CrossPlatform.Sample.IoC;
using Terranova.CrossPlatform.Sample.Maui;
using Terranova.CrossPlatform.Sample.Maui.Diagnostics;
using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;
using Terranova.CrossPlatform.Sample.Maui.ViewModels;
using Terranova.CrossPlatform.Sample.Maui.Views;
using Terranova.CrossPlatform.Mobile.MVVM.Popups;

namespace Terranova.CrossPlatform.Sample.App;

internal static class MvvmAppBuilderExtensions
{
    public static void SetupTrnSampleApplication(this MVVMAppBuilder mvvmAppBuilder)
    {
        mvvmAppBuilder.SetupTrnApp();
        mvvmAppBuilder.UseMauiPopups();
        mvvmAppBuilder.ConfigureServices(AddServices);
        mvvmAppBuilder.RegisterTypes(AddTypes);
        mvvmAppBuilder.MauiBuilder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });
        
        mvvmAppBuilder.CreateWindow(async (container, navigation) =>
        {
            var result = await navigation.NavigateAsync("NavigationPage/LoginPage",
                new NavigationParameters()
                {
                    { "IsAppToApp", false }
                });
            var bp = true;
        });
    }

    static void AddTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
        containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
        containerRegistry.RegisterForNavigation<SettingsPage, SettingsViewModel>();
        
        containerRegistry.RegisterDialog<AppVersionPage, AppVersionPageViewModel>();
        
        containerRegistry.Register(typeof(ITMDI<>), typeof(TMDI<>));
    }
    
    static void AddServices(IServiceCollection services)
    {
        services.TryAddTransient<AppLogFactory>();
        services.TryAddTransient<ITrnLogMessageBuilder, TrnLogMessageBuilder>();
        services.TryAddSingleton<ITrnLogger>(sp =>
        {
            var factory = sp.GetRequiredService<AppLogFactory>();
            var logger = factory.Create().Value;
            return logger;
        });
        services.TryAddSingleton<IAppMetricsFactory>(c => AppMetricsFactory.Instance);
        services.TryAddSingleton<IAppTracesFactory>(c => AppTracesFactory.Instance);
        services.TryAddSingleton<IAppHealthFactory>(c => AppHealthFactory.Instance);
        services.AddSingleton<IAppPlatformService>(AppPlatformService.Instance);
        services.AddSingleton(AppPermissionsManager.Instance);
        
        services.TryAddTransient<IAppContextFactory, AppContextFactory>();
        services
            .TryAddTransient<
                ITrnContextFactory<AppDataSupportOptionsBuilder, AppContextSettings, IAppContext, AppContextBuilder>,
                AppContextFactory>();
        services.TryAddSingleton<IAppContext, AppContext>();
        services.TryAddTransient<ITrnNavigationService, TrnNavigationService>();
        services.TryAddTransient(typeof(IAppUnitOfWorkFactory<>), typeof(AppUnitOfWorkFactory<>));
        
        services.TryAddTransient<IAppUnitOfWork, AppUnitOfWork>();
        
        
        services.AddScoped<ITrnUndefinedDataSupport, TrnUndefinedDataSupport>();
        services.AddScoped<ITrnSqliteSupport, TrnSqliteSupport>();
        services.AddSingleton<IAppDataSupportOptionsServiceFactory, AppDataSupportOptionsServiceFactory>();
        services.AddScoped<ITrnDataSupportFactory<AppDataSupportOptionsBuilder>, AppDataSupportFactory>();
        
        
        services.AddOptionsSingleton<AppFileStorageOptions>();
        services.AddSingleton<IAppFileStorageOptionsService, AppFileStorageOptionsService>();
        services.AddSingleton<ITrnFileStorageOptionsService>(sp => sp.GetRequiredService<IAppFileStorageOptionsService>());
        services.TryAddEnumerable(ServiceDescriptor.Transient<ITrnDIInitializeService, AppFileStorageOptionsInitializer>());
        
        
        
        services.AddOptionsSingleton<AppOptions>(); services.TryAddEnumerable(ServiceDescriptor.Transient<ITrnDIInitializeService, AppOptionsInitializer>());
       
        services.AddSingleton<IAppOptionsService, AppOptionsService>();
        services.AddSingleton<ITrnAppOptionsService>(sp => sp.GetRequiredService<IAppOptionsService>());
        services.AddSingleton<ITrnMobileAppOptionsService>(sp => sp.GetRequiredService<IAppOptionsService>());

        
        
        services.AddOptionsSingleton<AppDiagnosticsOptions>();
        services.AddSingleton<IAppDiagnosticsSettingsService, AppDiagnosticsOptionsService>();
        services.TryAddEnumerable(ServiceDescriptor.Transient<ITrnDIInitializeService, AppDiagnosticsOptionsInitializer>());
        
        services.TryAddSingleton<ITrnResourcesService>(sp =>
        {
            var resources = new AppResourcesService();
            var messageBuilder = sp.GetRequiredService<ITrnLogMessageBuilder>();
            resources.Use(() => messageBuilder);

            return resources;
        });

        
        services.TryAddSingleton<ITrnMobileUser>(sp =>
        {
            var user = new TrnMobileUser();
            user.LanguageTag = AppContext.DefaultUserLanguage.ToLanguageTag();
            return user;
        });

    }
}