using System.Runtime.Serialization;
using Terranova.CrossPlatform.Core.Abstractions;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public class TMLogFlagsDictionary : TrnFlagsDictionary<string>, ITrnCloneService<TMLogFlagsDictionary>
{
    public TMLogFlagsDictionary()
        : base(new string[]
        {
            AppLogTag.None,
            AppLogTag.Unhandled,
            AppLogTag.ApplicationStart,
            AppLogTag.Navigation,
            AppLogTag.Validation,
            AppLogTag.Binding,
            AppLogTag.TaskExecution,
            AppLogTag.DatabaseCheck,
            AppLogTag.SynchronizationWithServer,
            AppLogTag.DeviceSecurityKeys,
            AppLogTag.ConfigurationCheck,
            AppLogTag.Login,
            AppLogTag.DeviceActivity,
            AppLogTag.DeviceCommFlow,
            AppLogTag.DeviceIO,
            AppLogTag.DeviceBackground,
            AppLogTag.DeviceHistorical,
            AppLogTag.ThirdParty,
            AppLogTag.UploadActivities,
            AppLogTag.DownloadActivities,
            AppLogTag.WalkBy,
            AppLogTag.DeviceCommunicationTestWithMdmService
        })
    {
    }

    public new TMLogFlagsDictionary Clone()
    {
        var cloned = new TMLogFlagsDictionary();
        cloned.Acquire(this);
        return cloned;
    }
}
