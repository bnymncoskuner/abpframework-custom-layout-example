using CustomLayouts.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CustomLayouts.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CustomLayoutsEntityFrameworkCoreDbMigrationsModule),
        typeof(CustomLayoutsApplicationContractsModule)
        )]
    public class CustomLayoutsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
