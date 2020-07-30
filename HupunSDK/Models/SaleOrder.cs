using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HupunSDK.Models
{

    public class PageSaleOrder
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("exchanges")]
        public List<SaleOrder> SaleOrders { get; set; }
    }

    public class SaleOrder
    {
        /// <summary>
        /// 线上订单号 必填
        /// </summary>
        [JsonProperty("oln_trade_id")]
        public string OlnTradeId { get; set; }

        /// <summary>
        /// 单据编号 必填
        /// </summary>
        [JsonProperty("exchange_no")]
        public string ExchangeNo { get; set; }

        /// <summary>
        /// 售后状态：-1:待审核;0:处理中;1:已完成;2:已关闭;3:已拒绝; 4:已取消; 必填
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 售后类型: 0: 退货;1:补发;2:换货;3:其他;4:仅退款;
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 理由
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 理由详情
        /// </summary>
        [JsonProperty("reason_detail")]
        public string ReasonDetail { get; set; }

        /// <summary>
        /// 理由详情
        /// </summary>
        [JsonProperty("create_time")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 买家
        /// </summary>
        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// 买家退回单号
        /// </summary>
        [JsonProperty("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 快递公司
        /// </summary>
        [JsonProperty("express")]
        public string Express { get; set; }
    }
}
