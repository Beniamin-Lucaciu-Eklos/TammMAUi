using Terranova.CrossPlatform.Mobile.MVVM.Events;

namespace Terranova.CrossPlatform.Sample.App;

public class AppEventPayload
{
    public bool RestartRequired { get; set; }
}

public class AppEvent : PubSubEvent<AppEventPayload>
{
}