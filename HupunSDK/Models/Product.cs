using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HupunSDK.Models
{
    public class Product
    {
        /// <summary>
        /// 线上系统商品编号 必填
        /// </summary>
        [JsonProperty("itemID")]
        public string ItemId { get; set; }

        /// <summary>
        /// ERP 中的店铺昵称  必填
        /// </summary>
        [JsonProperty("shopNick")]
        public string ShopNick { get; set; }

        /// <summary>
        /// 商品标题  必填
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 单价  必填
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// 库存  必填
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 商品地址  必填
        /// </summary>
        [JsonProperty("itemURL")]
        public string ItemURL { get; set; }

        /// <summary>
        /// 图片地址  必填
        /// </summary>
        [JsonProperty("imageURL")]
        public string ImageURL { get; set; }

        /// <summary>
        /// 状态,0：已删除，1：在售，2：待售，仓库中
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 创建时间，毫秒级时间戳，如1421585369113
        /// </summary>
        [JsonProperty("createTime")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 最新修改时间，毫秒级时间戳，如1421585369113
        /// </summary>
        [JsonProperty("modifyTime")]
        public long ModifyTime { get; set; }

        [JsonProperty("skus")]
        public List<Sku> Skus { get; set; } = new List<Sku>();
    }
}
