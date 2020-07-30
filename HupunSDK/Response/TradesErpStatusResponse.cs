using HupunSDK.Models;
using Newtonsoft.Json;

namespace HupunSDK.Response
{
    public class TradesErpStatusResponse : HupunResponse
    {
        [Newtonsoft.Json.JsonIgnore]
        public OrderStatusList OrderStatuses
        {
            get
            {
                return JsonConvert.DeserializeObject<OrderStatusList>(this.Response);
            }
        }
    }
}
