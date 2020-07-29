using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HupunSDK.Models
{
    public class OrderDetail
    {
        /// <summary>
        /// 第三方交易号 必填
        /// </summary>
        [JsonProperty("tradeID")]
        public string TradeId { get; set; }

        /// <summary>
        /// 子交易号 必填
        /// </summary>
        [JsonProperty("orderID")]
        public string OrderID { get; set; }

        /// <summary>
        /// 商品编号 必填
        /// </summary>
        [JsonProperty("itemID")]
        public string ItemID { get; set; }

        /// <summary>
        /// 商品标题，如万里牛 必填
        /// </summary>
        [JsonProperty("itemTitle")]
        public string ItemTitle { get; set; }


        /// <summary>
        /// 规格值，如红色,M
        /// </summary>
        [JsonProperty("skuTitle")]
        public string SkuTitle { get; set; }

        /// <summary>
        /// 明细状态:0：未创建订单；1：等待付款；2：等待发货；3：已完成；4：已关闭；5：等待确认；
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 明细实付
        /// </summary>
        [JsonProperty("payment")]
        public decimal Payment { get; set; }
    }
}
