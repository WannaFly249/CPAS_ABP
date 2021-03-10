using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CPAS2.Data
{
    /* This is used if database provider does't define
     * ICPAS2DbSchemaMigrator implementation.
     */
    public class NullCPAS2DbSchemaMigrator : ICPAS2DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}