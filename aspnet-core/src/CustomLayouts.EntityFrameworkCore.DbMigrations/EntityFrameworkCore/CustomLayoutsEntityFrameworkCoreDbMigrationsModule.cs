using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CustomLayouts.EntityFrameworkCore
{
    [DependsOn(
        typeof(CustomLayoutsEntityFrameworkCoreModule)
        )]
    public class CustomLayoutsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CustomLayoutsMigrationsDbContext>();
        }
    }
}
