using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HupunSDK.Response
{
    public class TradesErpStatusResponse : HupunResponse
    {
        /// <summary>
        /// 订单号，可能为多个，表示系统已合单
        /// </summary>
        [JsonPropertyName("tid")]
        public string TId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonPropertyName("waybill")]
        public string WayBill { get; set; }

        /// <summary>
        /// 系统订单状态，0：订单审核，1:打单配货，2：验货，3：称重，4：待发货，5：财审，8：已发货，9：交易成功，10：交易关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 快递公司编码
        /// </summary>
        [JsonPropertyName("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [JsonPropertyName("express")]
        public string Express { get; set; }

        /// <summary>
        /// 销售税号
        /// </summary>
        [JsonPropertyName("sale_tax_sn")]
        public string SaleTaxSn { get; set; }

        /// <summary>
        /// 发货类型，0：快递；1：EMS；2：平邮；9：卖家承担运费（包邮）；11：虚拟物品；121：自提；122：商家自送（门店配送）
        /// </summary>
        [JsonPropertyName("shippingType")]
        public string shippingType { get; set; }
    }
}
