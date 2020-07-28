using HupunSDK.Core;
using HupunSDK.Extend;
using HupunSDK.Models;
using HupunSDK.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace HupunSDK.Request
{
    public class ItemsOpenRequest : HupunRequest<ItemsOpenResponse>
    {
        [JsonProperty("items")]
        public List<Product> Items { get; set; }

        public override string CalcSign(IRequest request)
        {
            var signString = request.GetParameters().CleanupDictionary().ToSortQueryParameters();
        }

        public override string GetApiName()
        {
            return "/items/open";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Post;
        }
    }
}
