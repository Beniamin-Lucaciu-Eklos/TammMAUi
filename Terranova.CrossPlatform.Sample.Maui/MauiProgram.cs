using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Terranova.CrossPlatform.Sample.App;

namespace Terranova.CrossPlatform.Sample.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<TrnSampleApplication>()
            .UseMauiCommunityToolkit()
            .UseMVVM(static mvvm =>
            {
                mvvm.SetupTrnSampleApplication();
            });


#if DEBUG
        builder.Logging.AddDebug();
#endif
        
        
        return builder.Build();
    }
}