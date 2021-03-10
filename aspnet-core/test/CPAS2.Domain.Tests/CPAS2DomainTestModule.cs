using CPAS2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CPAS2
{
    [DependsOn(
        typeof(CPAS2EntityFrameworkCoreTestModule)
        )]
    public class CPAS2DomainTestModule : AbpModule
    {

    }
}