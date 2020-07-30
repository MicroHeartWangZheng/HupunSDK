using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HupunSDK.Models
{

    public class OrderStatusList
    {
        [JsonProperty("statuses")]
        public List<OrderStatus> OrderStatuses { get; set; }
    }


    public class OrderStatus
    {
        /// <summary>
        /// 订单号，可能为多个，表示系统已合单
        /// </summary>
        [JsonProperty("tid")]
        public string TId { get; set; }

        /// <summary>
        /// 万里牛单号
        /// </summary>
        [JsonProperty("tradeNo")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonProperty("waybill")]
        public string WayBill { get; set; }

        /// <summary>
        /// 系统订单状态，0：订单审核，1:打单配货，2：验货，3：称重，4：待发货，5：财审，8：已发货，9：交易成功，10：交易关闭
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 快递公司编码
        /// </summary>
        [JsonProperty("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 快递本地编码
        /// </summary>
        [JsonProperty("express_local")]
        public string ExpressLocal { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [JsonProperty("express")]
        public string Express { get; set; }

        /// <summary>
        /// 销售税号
        /// </summary>
        [JsonProperty("sale_tax_sn")]
        public string SaleTaxSn { get; set; }

        /// <summary>
        /// 发货类型，0：快递；1：EMS；2：平邮；9：卖家承担运费（包邮）；11：虚拟物品；121：自提；122：商家自送（门店配送）
        /// </summary>
        [JsonProperty("shippingType")]
        public string ShippingType { get; set; }

        [JsonProperty("orders")]
        public List<SubOrder> Orders { get; set; }
    }



    public class SubOrder
    {
        [JsonProperty("orderstatus")]
        public string OrderStatus { get; set; }

        [JsonProperty("itemID")]
        public string ItemId { get; set; }

        [JsonProperty("orderID")]
        public string OrderId { get; set; }

        [JsonProperty("skuID")]
        public string SkuId { get; set; }
    }
}
