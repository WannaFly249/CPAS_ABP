using System;
using System.Collections.Generic;
using System.Text;
using CPAS2.Localization;
using Volo.Abp.Application.Services;

namespace CPAS2
{
    /* Inherit your application services from this class.
     */
    public abstract class CPAS2AppService : ApplicationService
    {
        protected CPAS2AppService()
        {
            LocalizationResource = typeof(CPAS2Resource);
        }
    }
}
