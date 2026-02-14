using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Resources;
using Terranova.CrossPlatform.Core.Abstractions.Security;
using Terranova.CrossPlatform.Core.Diagnostics;
using Terranova.CrossPlatform.Mobile.Core;
using Terranova.CrossPlatform.Mobile.Core.App;
using Terranova.CrossPlatform.Mobile.Core.Users;
using Terranova.CrossPlatform.Mobile.MVVM.Events;
using Terranova.CrossPlatform.Sample.Maui.Diagnostics;

namespace Terranova.CrossPlatform.Sample.App;

public interface IAppContext : ITrnMobileContext, ITrnClearServiceAsync<IAppContext>
{
    new ITrnMobileApplication Application { get; }
    
    SubscriptionToken SubscribeAppEvent(Action<AppEventPayload> action);

    void UnSubscribeAppEvent(SubscriptionToken subscriptionToken);
    
    void PublishAppEvent(AppEventPayload payload);
}

public class AppContext : TrnMobileContext, IAppContext
{
    public static readonly TrnLanguage DefaultUserLanguage = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName switch
    {
        "it" => TrnLanguage.IT,
        "es"=> TrnLanguage.ES,
        _ => TrnLanguage.EN
    };
    
    public AppContext(ITrnDILazy<ITrnMobileUser> user,
                        ITrnDILazy<ITrnResourcesService> resources,
                        ITrnDILazy<ITrnTextEncryptor> encryptor,
                        IAppMetricsFactory metricsFactory,
                        IAppTracesFactory tracesFactory,
                        IAppHealthFactory healthFactory,
                        ITrnDILazy<IEventAggregator> eventAggregator,
                        ITrnLogger logger,
                        IServiceProvider serviceProvider)
        : base(user, resources, encryptor, metricsFactory, tracesFactory, healthFactory, eventAggregator, logger, serviceProvider)
    {
    }
    
    public async Task<IAppContext> ClearAsync()
    {
        User.Clear();

        User.LanguageTag = DefaultUserLanguage.ToLanguageTag();

        User.LanguageTag.SetAsAppDomainCultures();


        return this;
    }

    public new ITrnMobileApplication Application => (ITrnMobileApplication)base.Application;

    public virtual SubscriptionToken SubscribeAppEvent(Action<AppEventPayload> action)
    {
        return EventAggregator.GetEvent<AppEvent>().Subscribe(action);
    }

    public virtual void UnSubscribeAppEvent(SubscriptionToken subscriptionToken)
    {
        EventAggregator.GetEvent<AppEvent>().Unsubscribe(subscriptionToken);
    }

    public virtual void PublishAppEvent(AppEventPayload payload)
    {
        EventAggregator.GetEvent<AppEvent>().Publish(payload);
    }
}