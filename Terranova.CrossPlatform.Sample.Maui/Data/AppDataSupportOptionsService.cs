using Terranova.CrossPlatform.Core.Abstractions.Data;

namespace Terranova.CrossPlatform.Sample.Data;

public interface IAppDataSupportOptionsService : ITrnDataSupportOptionsService
{
}

public class AppDataSupportOptionsService : TrnDataSupportOptionsService, IAppDataSupportOptionsService
{
    public const string SqLiteDbSectionKey = "SqLite";

    public AppDataSupportOptionsService(TrnDataSupportOptions options)
        : base(options)
    {
    }
}
