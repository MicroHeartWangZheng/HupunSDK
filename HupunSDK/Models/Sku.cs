namespace HupunSDK.Models
{
    public class Sku
    {
        /// <summary>
        /// B2C 系统规格编号
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// B2C 系统商品编号
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 库存  必填
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 单价  必填
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 创建时间，毫秒级时间戳，如1421585369113
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 最新修改时间，毫秒级时间戳，如1421585369113
        /// </summary>
        public long ModifyTime { get; set; }

        /// <summary>
        /// 图片地址  必填
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// 状态,0：已删除，1：在售，2：待售，仓库中
        /// </summary>
        public int Status { get; set; }
    }
}
