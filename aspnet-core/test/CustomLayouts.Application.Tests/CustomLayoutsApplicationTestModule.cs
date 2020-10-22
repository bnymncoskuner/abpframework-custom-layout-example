using Volo.Abp.Modularity;

namespace CustomLayouts
{
    [DependsOn(
        typeof(CustomLayoutsApplicationModule),
        typeof(CustomLayoutsDomainTestModule)
        )]
    public class CustomLayoutsApplicationTestModule : AbpModule
    {

    }
}