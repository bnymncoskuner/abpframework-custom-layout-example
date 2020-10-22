using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CustomLayouts.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(CustomLayoutsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class CustomLayoutsConsoleApiClientModule : AbpModule
    {
        
    }
}
