using TammMobile.Core.SoftwareOptions;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;
using Terranova.CrossPlatform.Mobile.Core.App;
using Terranova.CrossPlatform.Sample.IO;
using Terranova.CrossPlatform.Sample.Maui.Diagnostics;

namespace Terranova.CrossPlatform.Sample.App;

public class TrnSampleApplication : TrnMobileApplication
{
    private readonly Lazy<ITrnConfigurationProvider> _rootProvider;
    private readonly Lazy<IAppOptionsService> _options;
    private readonly Lazy<IAppFileStorageOptionsService> _fileStorageOptions;
    private readonly Lazy<IAppSoftwareOptionsService> _softwareOptions;
    private readonly Lazy<IAppDiagnosticsSettingsService> _diagnosticsOptions;

    
    public TrnSampleApplication(IAppPlatformService platformService,IServiceProvider provider) : base(platformService)
    {
        _rootProvider = new Lazy<ITrnConfigurationProvider>(() => Configuration.GetProvider(AppOptions.ApplicationName));
        _options = new Lazy<IAppOptionsService>(() => Services.GetRequiredService<IAppOptionsService>());
        _fileStorageOptions = new Lazy<IAppFileStorageOptionsService>(() => Services.GetRequiredService<IAppFileStorageOptionsService>());
        _softwareOptions = new Lazy<IAppSoftwareOptionsService>(() => Services.GetRequiredService<IAppSoftwareOptionsService>());
        _diagnosticsOptions = new Lazy<IAppDiagnosticsSettingsService>(() => Services.GetRequiredService<IAppDiagnosticsSettingsService>());
        
        Use(provider);
        
        //Initializes all services that implement ITrnDIInitializeService
        var initServices = Services?.GetServices<ITrnDIInitializeService>();
        if (initServices is not null)
            foreach (var instance in initServices)
                instance.Initialize(Services);
    }
}

