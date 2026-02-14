using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Configuration;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public class AppDiagnosticsOptions : TrnOptions, ITrnAcquireService<AppDiagnosticsOptions>
{
    public AppDiagnosticsOptions()
    {
        LogTags = new TMLogFlagsDictionary();
    }

    public AppDiagnosticsOptions Acquire(AppDiagnosticsOptions other)
    {
        if (other is not null && other != this)
        {
            LogTags = other.LogTags.Clone();
        }

        return this;
    }

    public TMLogFlagsDictionary LogTags { get; set; }
}
