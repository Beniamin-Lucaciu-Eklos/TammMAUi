using System.Diagnostics;
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public class AppTagTraceFilter : TrnTraceFilter
{
    private readonly TrnFlagsDictionary<string> Tags;
    private readonly Dictionary<string, Func<bool>> PrefixedTags;

    public AppTagTraceFilter(TrnFlagsDictionary<string> tags)
    {
        Tags = tags;
        PrefixedTags = new Dictionary<string, Func<bool>>();
        Tags.Flags.Each(x => PrefixedTags.Add($"{TrnSeparators.LogTagPrefix}{x.Key}", new Func<bool>(() => x.Value)));
    }

    //TMBL App Configuration ShouldTrace
    public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data)
    {
        bool should = false;

        should = eventType == TraceEventType.Critical || eventType == TraceEventType.Error;

        if (!should)
        {
            should = true;

            if (Tags.Enabled)
            {
                string message = data1 as string;

                if (message.IsNullOrWhiteSpace())
                {
                    message = formatOrMessage;
                }

                if (!message.IsNullOrWhiteSpace())
                {
                    var foundTag = PrefixedTags.FirstOrDefault(x => message.Contains(x.Key));

                    if (!foundTag.Key.IsNullOrWhiteSpace())
                    {
                        should = foundTag.Value();
                    }
                    else
                    {
                        should = Tags.GetFlag(AppLogTag.None);
                    }
                }
            }
        }

        return should;
    }
}
