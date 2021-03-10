using System.Threading.Tasks;

namespace CPAS2.Data
{
    public interface ICPAS2DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
