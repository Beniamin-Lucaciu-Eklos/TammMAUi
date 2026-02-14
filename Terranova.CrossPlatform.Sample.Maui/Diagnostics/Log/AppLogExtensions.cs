
using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Tap;
using Terranova.CrossPlatform.Core.Diagnostics;

namespace Terranova.CrossPlatform.Sample.Maui.Diagnostics;

public enum AppLogTagCategoryKind
{
}

public static class AppLogTagExtensions
{
    //public static ireadonly

    public static ITrnLogMessageBuilder AddTag(this ITrnLogMessageBuilder builder, AppLogTag tag)
    {
        return builder.AddTag(tag.ToString().ToKVPair().ToString());
    }
}

public enum AppLogDetail
{
    Unknown,
    Start,
    Step,
    Stop,
    Request,
    Response,
    Download,
    Upload,
}

public class AppLogEntry : TrnLogEntry
{
    public AppLogEntry()
    {
    }

    public AppLogEntry(AppLogDetail? detail = null, TrnLogEntryResult? result = null,
                        string message = null, object payload = null, params string[] tags)
    {
        Cat = null;
        Det = detail;
        Res = result;
        Msg = message;
        SetPld(payload);
        Tags.AddRange(tags?.Select(x => $"{TrnSeparators.LogTagPrefix}{x}"));
    }

    public new AppLogDetail? Det
    {
        get => base.Det.TryParseAsEnum<AppLogDetail>();
        set => base.Det = value?.ToString();
    }

    public new object Pld { get => base.Pld; set => SetPld(value); }
}

public static class AppLogExtensions
{
    public static string WriteTrace(this ITrnLogger logger, string message, params string[] tags)
    {
        return logger.WriteTrace(b => b.Add(message).AddTags(tags));
    }

    public static string WriteEntry(this ITrnLogger logger, string tag, AppLogDetail? detail, Exception ex, object payload = null)
    {
        return logger.WriteEntry(new AppLogEntry(detail, TrnLogEntryResult.Fail, logger.GetExceptionDetailsMessage(ex), payload, tag));
    }

    public static string WriteEntry(this ITrnLogger logger, string tag, AppLogDetail? detail, TrnLogEntryResult? result = null, string message = null, object payload = null)
    {
        return logger.WriteEntry(new AppLogEntry(detail, result, message, payload, tag));
    }

    public static string WriteEntry<T>(this ITrnLogger logger, string tag, AppLogDetail detail, TrnTaskOutcome<T> taskOutcome, string message = null)
    {
        if (taskOutcome.IsSuccess)
            return logger.WriteEntry(new AppLogEntry(detail, TrnLogEntryResult.Success, message, null, tag));
        else
            return logger.WriteEntry(new AppLogEntry(detail, TrnLogEntryResult.Fail, taskOutcome.Exception?.Message, null, tag));
    }

    public static ITrnActivity Tracing(this ITrnLogger logger, string tag)
    {
        var activity = new AppLogActivity(tag, logger);

        activity.Start();

        return activity;
    }

    public static string Trace<T>(this ITrnActivity activity,
                                    AppLogDetail detail,
                                    TrnTaskOutcome<T> taskOutcome,
                                    string message)
    {
        return WriteEntry(activity.Logger, AppLogTag.None, detail, taskOutcome, message);
    }

    public static string Trace(this ITrnActivity activity, AppLogDetail detail, string message)
    {
        return activity.Logger.WriteEntry(new AppLogEntry(detail, null, message));
    }

    
}