using Terranova.CrossPlatform.Core.Abstractions;
using Terranova.CrossPlatform.Sample.Data;

namespace Terranova.CrossPlatform.Sample.App;

public class AppContextBuilder : TrnContextBuilder<AppDataSupportOptionsBuilder, IAppContext, AppContextSettings, AppContextBuilder>
{
    public AppContextBuilder(AppDataSupportOptionsBuilder dataSupportSettingsBuilder)
        : base(dataSupportSettingsBuilder)
    {
    }
}
