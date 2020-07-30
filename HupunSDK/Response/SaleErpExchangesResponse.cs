using HupunSDK.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HupunSDK.Response
{
    public class SaleErpExchangesResponse : HupunResponse
    {
        [Newtonsoft.Json.JsonIgnore]
        public PageSaleOrder OrderStatuses
        {
            get
            {
                return JsonConvert.DeserializeObject<PageSaleOrder>(this.Response);
            }
        }
    }
}
