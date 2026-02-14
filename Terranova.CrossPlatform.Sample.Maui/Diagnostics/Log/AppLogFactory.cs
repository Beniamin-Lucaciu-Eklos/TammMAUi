using System.Diagnostics; 
using Terranova.CrossPlatform.Core.Diagnostics;
using Terranova.CrossPlatform.Core.Diagnostics.NLog;
using Terranova.CrossPlatform.Sample.IO;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public class AppLogFactory : TrnNLogFactory
{
    public AppLogFactory(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
    }

    public override Lazy<ITrnLogger> Create()
    {
        return base.Create();
    }

    public override Lazy<ITrnLogger> Create(Action<TrnNLogBuilder> build)
    {
        return base.Create(build);
    }

    protected override ITrnLogger OnCreate()
    {
        return base.OnCreate();
    }

    protected override ITrnLogger OnCreate(Action<TrnNLogBuilder> build)
    {
        return base.OnCreate(build);
    }

    protected override ITrnLogger CreateCore(TrnNLogOptions options)
    {
        var svcFileStorageSettings = ServiceProvider.GetRequiredService<IAppFileStorageOptionsService>();
        var svcDiagnosticsSettings = ServiceProvider.GetRequiredService<IAppDiagnosticsSettingsService>();

        var fileName = "SampleApp_${date:format=yyyyMMdd}.log";
        options.PathFileName = Path.Combine(svcFileStorageSettings.LogPath, fileName);

        options.IsDailyArchive = true;

        options.IsTraceEnabled = true;

        var logger = base.CreateCore(options);


        var logTags = svcDiagnosticsSettings.GetOptions().LogTags;

        foreach (TraceListener l in logger.Trace.Listeners)
        {
            l.Filter = new AppTagTraceFilter(logTags);
        }
        return logger;
    }
}
