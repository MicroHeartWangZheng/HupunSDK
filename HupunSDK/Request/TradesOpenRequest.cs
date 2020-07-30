using HupunSDK.Core;
using HupunSDK.Models;
using HupunSDK.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace HupunSDK.Request
{
    /// <summary>
    /// 推送订单到ERP
    /// </summary>
    public class TradesOpenRequest : BaseRequest<TradesOpenResponse>
    {
        [JsonProperty("trades")]
        public List<Order> Orders { get; set; }

        public override string GetApiName()
        {
            return "/v1/trades/open";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Post;
        }
    }
}
