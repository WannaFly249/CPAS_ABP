using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CPAS2.EntityFrameworkCore
{
    [DependsOn(
        typeof(CPAS2EntityFrameworkCoreModule)
        )]
    public class CPAS2EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CPAS2MigrationsDbContext>();
        }
    }
}
