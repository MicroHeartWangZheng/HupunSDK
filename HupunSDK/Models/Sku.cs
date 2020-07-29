using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace HupunSDK.Models
{
    public class Sku
    {
        /// <summary>
        /// B2C 系统规格编号
        /// </summary>
        [JsonProperty("skuID")]
        public string SkuId { get; set; }

        /// <summary>
        /// B2C 系统商品编号
        /// </summary>
        [JsonProperty("itemID")]
        public string ItemId { get; set; }

        /// <summary>
        /// 库存  必填
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 单价  必填
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// 创建时间，毫秒级时间戳，如1421585369113
        /// </summary>
        [JsonProperty("createTime")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 最新修改时间，毫秒级时间戳，如1421585369113
        /// </summary>
        [JsonProperty("modifiyTime")]
        public long ModifyTime { get; set; }

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
        /// 规格： key1:value;key2:value;... 以key:value 的键值形式拼接，必须使用半角符，如颜色:红色;尺码:M
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; set; }
    }
}
