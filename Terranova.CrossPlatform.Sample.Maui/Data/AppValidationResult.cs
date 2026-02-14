using Terranova.CrossPlatform.Mobile.Core.Data;

namespace Terranova.CrossPlatform.Sample.Data;

public class AppValidationResult : TrnValidationResult
{
    private TrnValidationStatus _status;

    public AppValidationResult()
        : this(TrnValidationStatus.None, null, null, false)
    {
    }

    public AppValidationResult(TrnValidationStatus status, string message)
        : this(status, message, null, false)
    {
    }

    public AppValidationResult(TrnValidationStatus status, string message, string label)
        : this(status, message, label, false)
    {
    }

    public AppValidationResult(TrnValidationStatus status, string message, string label, bool useAsWarning)
    {
        Status = status;
        Message = message;
        Label = label;
        UseAsWarning = useAsWarning;
    }

    public override TrnValidationStatus Status
    {
        get => _status;
        set
        {
            if (_status != value)
            {
                _status = value;
                switch (_status)
                {
                    case TrnValidationStatus.Mandatory:
                        //Localize the message if not already set
                        Message = "General_MessageSelectionMandatory";//.GetClientResource();
                        break;

                    case TrnValidationStatus.Unknown:
                        Message = "Unknown";//.GetClientResource();
                        break;

                    case TrnValidationStatus.Warning:
                        Message = "WARNINGTheValueEnteredIsDifferentFromThatSeenInTheDevice";//.GetClientResource();
                        break;

                    case TrnValidationStatus.Different:
                        break;

                    case TrnValidationStatus.Ok:
                        break;

                    case TrnValidationStatus.Error:
                        break;

                    case TrnValidationStatus.None:
                        return;
                }
            }
        }
    }
}
