using System;
using Terranova.CrossPlatform.Mobile.Core.Data;

namespace Terranova.CrossPlatform.Sample.Data;

public class AppValidationMandatoryRule : TrnValidationRule
{
    public AppValidationMandatoryRule(string propertyName, Func<bool> rule)
        : this(propertyName, rule, null)
    {
    }

    public AppValidationMandatoryRule(string propertyName, Func<bool> rule, string msg)
        : this(propertyName, () => rule()
            ? new AppValidationResult(TrnValidationStatus.Ok, null)
            : new AppValidationResult(TrnValidationStatus.Mandatory, msg))
    {
    }

    public AppValidationMandatoryRule(string propertyName, Func<bool> rule, string msg, Func<bool> useAsWarning)
        : this(propertyName, () => rule()
            ? new AppValidationResult(TrnValidationStatus.Ok, null)
            : new AppValidationResult(TrnValidationStatus.Mandatory, msg, null, useAsWarning()))
    {
    }

    public AppValidationMandatoryRule(string propertyName, Func<TrnValidationResult> rule)
        : base(propertyName, rule)
    {
    }

    public override string ToString()
    {
        return $"{nameof(AppValidationMandatoryRule)}:{base.ToString()}";
}
}   
