using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CPAS2
{
    [Dependency(ReplaceServices = true)]
    public class CPAS2BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CPAS2";
    }
}
