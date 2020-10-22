using CustomLayouts.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CustomLayouts
{
    [DependsOn(
        typeof(CustomLayoutsEntityFrameworkCoreTestModule)
        )]
    public class CustomLayoutsDomainTestModule : AbpModule
    {

    }
}