using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public class AppLogActivity : TrnActivity
{
    public AppLogActivity(string tag, ITrnLogger logger)
        : base(tag, logger)
    {
    }

    public override TrnActivity Start()
    {
        Logger.WriteEntry(OperationName, AppLogDetail.Start);

        return base.Start();
    }

    public override void Stop()
    {
        Logger.WriteEntry(OperationName, AppLogDetail.Stop);

        base.Stop();
    }

    // public string WriteDownloadActivitiesDetail(TMLogDetail detail,
    //                                             TrnLogEntryResult? result = null,
    //                                             IEnumerable<DbWorkForceActivity> activities = null)
    // {
    //     return Logger.WriteEntry(new TMLogEntry(detail, result, null, activities?.Select(x => x.ExternalId)?.ToList(), TMLogTag.DownloadActivities));
    // }
}
