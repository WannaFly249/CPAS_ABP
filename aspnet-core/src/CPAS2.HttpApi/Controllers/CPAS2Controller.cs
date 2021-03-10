using CPAS2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CPAS2.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CPAS2Controller : AbpController
    {
        protected CPAS2Controller()
        {
            LocalizationResource = typeof(CPAS2Resource);
        }
    }
}