using Volo.Abp.Modularity;

namespace CPAS2
{
    [DependsOn(
        typeof(CPAS2ApplicationModule),
        typeof(CPAS2DomainTestModule)
        )]
    public class CPAS2ApplicationTestModule : AbpModule
    {

    }
}