using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CPAS2.CarPark
{
    public class CarparkService : CPAS2AppService, ICarparkService
    {
        #region Contructor

        public CarparkService()
        {

        }

        #endregion

        #region Public Method

        [HttpGet]
        public async Task<List<CarparkIf>> CheckCarparkAvailability(string dateTime)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(CPAS2Constant.CarparkApiUrl);
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            using var streamReader = new StreamReader(webResponse.GetResponseStream());
            var jsonResult = await streamReader.ReadToEndAsync();
            var result = JsonConvert.DeserializeObject<Carpark>(jsonResult);
            return result?.Items.FirstOrDefault()?.CarparkData.Take(CPAS2Constant.NumberOfLots).ToList();
        }
        #endregion
    }
}
