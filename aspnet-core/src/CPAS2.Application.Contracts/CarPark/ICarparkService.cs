using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace CPAS2.CarPark
{
    public interface ICarparkService : IApplicationService
    {
        Task<List<CarparkIf>> CheckCarparkAvailability(string dateTime);
    }
}
