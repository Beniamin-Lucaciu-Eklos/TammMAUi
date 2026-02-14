using System.Diagnostics.Metrics;
using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public interface IAppMetrics : ITrnMetrics
{
}

public class AppMetrics : TrnMetrics, IAppMetrics
{
    public AppMetrics(TrnMetricsSettings settings,
                            ITrnMetricsProvider metricsProvider,
                            Dictionary<string, Meter> meters,
                            Dictionary<string, ITrnMetric> metrics)
        : base(settings, metricsProvider, meters, metrics)
    {
    }
}
