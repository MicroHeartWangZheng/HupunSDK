using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HupunSDK.Models
{
    public class Order
    {
        /// <summary>
        /// 第三方交易号 必填
        /// </summary>
        [JsonProperty("tradeID")]
        public string TradeId { get; set; }

        /// <summary>
        /// ERP 中的店铺昵称  必填
        /// </summary>
        [JsonProperty("shopNick")]
        public string ShopNick { get; set; }

        /// <summary>
        /// 交易状态:0：未创建交易；1：等待付款；2：等待发货；3：已完成；4：已关闭；5：等待确认；6：已签收
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 交易创建时间，毫秒级时间戳，如1421585369113
        /// </summary>
        [JsonProperty("createTime")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 交易付款时间，毫秒级时间戳，如1421585369113，付款后才会有值，其他状态不传
        /// </summary>
        [JsonProperty("payTime")]
        public long PayTime { get; set; }

        /// <summary>
        /// 交易结束时间，毫秒级时间戳，如1421585369113，结束后才会有值，其他状态不传  否（付款后必填）
        /// </summary>
        [JsonProperty("endTime")]
        public long EndTime { get; set; }

        /// <summary>
        /// 交易修改时间，毫秒级时间戳，如1421585369113，订单每次修改更新该值
        /// </summary>
        [JsonProperty("modifyTime")]
        public long ModifyTime { get; set; }

        /// <summary>
        /// 交易发货时间，毫秒级时间戳，如1421585369113，发货后才会有值，其他状态不传  否（发货后必填）
        /// </summary>
        [JsonProperty("shippingTime")]
        public long ShippingTime { get; set; }

        /// <summary>
        /// 发货类型:0：快递；1：EMS；2：平邮；9：卖家承担运费（包邮）；11：虚拟物品；121：自提；122：商家自送（门店配送）
        /// </summary>
        [JsonProperty("shippingType")]
        public int ShippingType { get; set; }

        /// <summary>
        /// 商品总金额，不含邮费  必填
        /// </summary>
        [JsonProperty("totalFee")]
        public decimal TotalFee { get; set; }

        /// <summary>
        /// 邮费  必填
        /// </summary>
        [JsonProperty("postFee")]
        public decimal PostFee { get; set; }

        /// <summary>
        /// 买家最后实际支付金额  必填
        /// </summary>
        [JsonProperty("payment")]
        public decimal Payment { get; set; }

        /// <summary>
        /// 总的优惠金额  必填
        /// </summary>
        [JsonProperty("discountFee")]
        public decimal DiscountFee { get; set; }

        /// <summary>
        /// 买家  必填
        /// </summary>
        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// 收件人  必填
        /// </summary>
        [JsonProperty("receiverName")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人地址  必填
        /// </summary>
        [JsonProperty("receiverAddress")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收件人手机  必填
        /// </summary>
        [JsonProperty("receiverMobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 退款退货标记，1：退款；0：未退款
        /// </summary>
        [JsonProperty("hasRefund")]
        public int HasRefund { get; set; }

        [JsonProperty("orders")]
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
