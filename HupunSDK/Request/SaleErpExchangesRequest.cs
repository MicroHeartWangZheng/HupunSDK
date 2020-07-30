using HupunSDK.Core;
using HupunSDK.Response;
using Newtonsoft.Json;
using System.Net.Http;

namespace HupunSDK.Request
{
    /// <summary>
    /// 查询售后单
    /// </summary>
    public class SaleErpExchangesRequest : BaseRequest<SaleErpExchangesResponse>
    {
        /// <summary>
        /// 店铺类型，B2C 平台：100
        /// </summary>
        [JsonProperty("shop_type")]
        public int ShopType { get; set; }

        ///// <summary>
        ///// ERP 中的店铺昵称  必填
        ///// </summary>
        //[JsonProperty("shop_nick")]
        //public string ShopNick { get; set; }

        /// <summary>
        /// 查询时间类型，1：创建时间；2：结束时间；3：修改时间，默认为修改时间 必填
        /// </summary>
        [JsonProperty("time_type")]
        public int TimeType { get; set; }

        /// <summary>
        /// 开始时间， 格式为yyyy-mm-dd HH:mm:ss, 或者为Long 类型时间戳
        /// </summary>
        [JsonProperty("start")]
        public string Start { get; set; }

        /// <summary>
        /// 结束时间，格式为yyyy-mm-dd HH:mm:ss，或者为Long 类型时间戳
        /// </summary>
        [JsonProperty("end")]
        public string End { get; set; }

        ///// <summary>
        ///// 售后类型: 0: 退货;1:补发;2:换货;3:其他;4:仅退款;
        ///// </summary>
        //[JsonProperty("exchange_type")]
        //public int ExchangeType { get; set; }

        ///// <summary>
        ///// 售后状态：-1:待审核;0:处理中;1:已完成;2:已关闭;3:已拒绝; 4:已取消;
        ///// </summary>
        //[JsonProperty("exchange_status")]
        //public int ExchangeStatus { get; set; }

        /// <summary>
        /// 当前页，默认为第一页 必填
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// 单页条数，默认为50，上线为200
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        public override string GetApiName()
        {
            return "/v1/sale/erp/exchanges";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
