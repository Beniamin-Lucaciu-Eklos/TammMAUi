using Terranova.CrossPlatform.Mobile.Core.Data;

namespace Terranova.CrossPlatform.Sample.Data;

public class AppValidationErrorRule : TrnValidationRule
{
    public AppValidationErrorRule(string propertyName, Func<bool> rule)
        : this(propertyName, rule, null)
    {
    }

    public AppValidationErrorRule(string propertyName, Func<bool> rule, string msg)
        : this(propertyName, () => rule()
            ? new AppValidationResult(TrnValidationStatus.Ok, null)
            : new AppValidationResult(TrnValidationStatus.Error, msg))
    {
    }

    public AppValidationErrorRule(string propertyName, Func<bool> rule, string msg, Func<bool> useAsWarning)
        : this(propertyName, () => rule()
            ? new AppValidationResult(TrnValidationStatus.Ok, null)
            : new AppValidationResult(TrnValidationStatus.Error, msg, null, useAsWarning()))
    {
    }

    public AppValidationErrorRule(string propertyName, Func<TrnValidationResult> rule)
        : base(propertyName, rule)
    {
    }
}
