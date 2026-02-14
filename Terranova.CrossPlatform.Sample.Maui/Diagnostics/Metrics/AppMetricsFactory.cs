using System.Diagnostics.Metrics;
using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public interface IAppMetricsFactory : ITrnMetricsFactory
{
    new IAppMetrics Build();
}

public class AppMetricsFactory : IAppMetricsFactory
{
    private static readonly Lazy<IAppMetricsFactory> _instance = new Lazy<IAppMetricsFactory>(() => new AppMetricsFactory());
    public static IAppMetricsFactory Instance => _instance.Value;

    public const string ServiceName = "Sample_Metrics";
    public const string ServiceVersion = "1.0";

    protected readonly object _lock = new object();

    protected IAppMetrics _metrics;

    public virtual IAppMetrics Build()
    {
        if (_metrics is null)
        {
            lock (_lock)
            {
                if (_metrics is null)
                {
                    try
                    {
                        var settings = new TrnMetricsSettings
                        {
                            HostId = "ALL",
                            ServiceName = ServiceName,
                            ServiceVersion = ServiceVersion,
                        };

                        _metrics = new AppMetrics(settings, new TrnMetricsProvider(), new Dictionary<string, Meter>(), new Dictionary<string, ITrnMetric>());
                    }
                    catch (Exception ex)
                    {
                        _ = ex;
                        _metrics = null;
                    }
                }
            }
        }

        return _metrics;
    }

    ITrnMetrics ITrnMetricsFactory.Build()
    {
        return Build();
    }

    public virtual void ForceReload()
    {
        lock (_lock)
        {
            _metrics?.Dispose();
            _metrics = null;
        }
    }
}