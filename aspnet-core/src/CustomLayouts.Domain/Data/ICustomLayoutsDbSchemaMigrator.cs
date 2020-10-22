using System.Threading.Tasks;

namespace CustomLayouts.Data
{
    public interface ICustomLayoutsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
