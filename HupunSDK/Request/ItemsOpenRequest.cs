using HupunSDK.Core;
using HupunSDK.Models;
using HupunSDK.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace HupunSDK.Request
{
    public class ItemsOpenRequest : BaseRequest<ItemsOpenResponse>
    {
        [JsonProperty("items")]
        public List<Product> Items { get; set; }

        public override string GetApiName()
        {
            return "/v1/items/open";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Post;
        }
    }
}
