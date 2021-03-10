using CPAS2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CPAS2.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CPAS2EntityFrameworkCoreDbMigrationsModule),
        typeof(CPAS2ApplicationContractsModule)
        )]
    public class CPAS2DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
