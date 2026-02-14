using Terranova.CrossPlatform.Sample.Maui.UnitsOfWork;

namespace Terranova.CrossPlatform.Sample.Data;

public interface ISecureStorageRepository : IAppRepository<IAppUnitOfWork>
{
    //Task SaveUserToStorageAsync(ITrnMobileUser user);
    //Task<ITrnMobileUser> RecoverLastUserFromStorageAsync();
    //void RemoveLastUserFromStorage();
}

public class SecureStorageRepository : AppRepository<IAppUnitOfWork>, ISecureStorageRepository
{
    //    private const string UserSettingsKey = "UserKey";

    //    public Task SaveUserToStorageAsync(ITrnMobileUser user)
    //    {
    //        return TrnSettingsSecureStorage.SetAsync(UserSettingsKey, user);
    //    }

    //    public Task<ITrnMobileUser> RecoverLastUserFromStorageAsync()
    //    {
    //        return TrnSettingsSecureStorage.GetAsync<ITrnMobileUser>(UserSettingsKey);
    //    }

    //    public void RemoveLastUserFromStorage()
    //    {
    //        TrnSettingsSecureStorage.Remove(UserSettingsKey);
    //    }
}