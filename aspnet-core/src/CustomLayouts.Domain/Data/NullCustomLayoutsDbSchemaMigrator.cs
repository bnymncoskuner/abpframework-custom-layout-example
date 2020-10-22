using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CustomLayouts.Data
{
    /* This is used if database provider does't define
     * ICustomLayoutsDbSchemaMigrator implementation.
     */
    public class NullCustomLayoutsDbSchemaMigrator : ICustomLayoutsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}