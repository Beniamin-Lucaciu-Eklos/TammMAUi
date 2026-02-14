using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Core.Abstractions.Data;
using Terranova.CrossPlatform.Core.Abstractions.Tap;
using Terranova.CrossPlatform.Mobile.Core.Navigation;
using Terranova.CrossPlatform.Mobile.Core.UnitsOfWork;
using Terranova.CrossPlatform.Mobile.MVVM.Events;
using Terranova.CrossPlatform.Sample.App;
using Terranova.CrossPlatform.Sample.Data;
using Terranova.CrossPlatform.Sample.IoC;
using Terranova.CrossPlatform.Sample.Services.Db;

namespace Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

public interface IAppUnitOfWork : ITrnMobileUnitOfWork<IAppContext>
{
    IDbService DbService { get; }

    ISecureStorageRepository SecureStorage { get; }

    Task<TrnTaskOutcome<TrnBoolOutcome>> Waiting(ITrnNavigationService navigationService, string title,
        string progressDescription, int secondsDuration);
}

public class AppUnitOfWork : TrnMobileUnitOfWork<IAppContext>, IAppUnitOfWork
{
    private readonly Lazy<IDbService> _svcDb;
    public IDbService DbService => _svcDb.Value;


    private readonly Lazy<ISecureStorageRepository> _repoSecureStorage;
    public ISecureStorageRepository SecureStorage => _repoSecureStorage.Value;

    private readonly Lazy<SubscriptionToken> _appEventSubscriptionToken;


    public AppUnitOfWork(ITMDI<IDbService> svcDb,
        ITMDI<ISecureStorageRepository> repoSecureStorage)
    {
        _svcDb = svcDb.Use(() => this);

        _repoSecureStorage = repoSecureStorage.Use(() => this);

        _appEventSubscriptionToken =
            new Lazy<SubscriptionToken>(() => Context.SubscribeAppEvent(payload => ManageApplicationEvents(payload)));
    }

    private void ManageApplicationEvents(AppEventPayload payload)
    {
    }

    public override void CheckCurrentUserAndAcquireIt(string operatorCode, string token, string operatorId,
        string operatorName)
    {
        //nothing to do here
    }

    public Task<TrnTaskOutcome<TrnBoolOutcome>> Waiting(ITrnNavigationService navigationService, string title,
        string progressDescription, int secondsDuration)
    {
        var outcome =
            navigationService.ShowProgressAsync(new TrnDelayTask(title, progressDescription, secondsDuration, Logger),
                this);
        return outcome;
    }


    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (disposing)
        {
            try
            {
                if (_appEventSubscriptionToken.IsValueCreated)
                {
                    //Context.UnSubscribeAppEvent(_appEventSubscriptionToken.Value);
                }
            }
            catch
            {
                //nothing to do here
            }
        }
    }
}