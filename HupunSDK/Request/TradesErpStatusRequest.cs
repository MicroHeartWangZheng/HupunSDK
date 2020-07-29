using System.Net.Http;
using HupunSDK.Core;
using HupunSDK.Response;
using Newtonsoft.Json;

namespace HupunSDK.Request
{
    public class TradesErpStatusRequest : BaseRequest<ItemsOpenResponse>
    {
        /// <summary>
        /// 店铺类型，B2C 平台店铺类型：100
        /// </summary>
        [JsonProperty("shop_type")]
        public int ShopType { get; set; }

        /// <summary>
        /// 店铺昵称，必须和订单推送中的店铺昵称相同
        /// </summary>
        [JsonProperty("shop_nick")]
        public string ShopNick { get; set; }

        /// <summary>
        /// 订单号，多个订单以半角逗号相隔，如”123,456”，最多支持200个订单号
        /// </summary>
        [JsonProperty("trade_ids")]
        public string TradeIds { get; set; }

        public override string GetApiName()
        {
            return "/v1/trades/erp/status";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
