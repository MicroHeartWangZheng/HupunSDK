using System.Collections.Generic;

namespace HupunSDK.Models
{
    public class Product
    {
        /// <summary>
        /// 线上系统商品编号 必填
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// ERP 中的店铺昵称  必填
        /// </summary>
        public string ShopNick { get; set; }

        /// <summary>
        /// 商品标题  必填
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 单价  必填
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 库存  必填
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 商品地址  必填
        /// </summary>
        public string ItemURL { get; set; }

        /// <summary>
        /// 图片地址  必填
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// 状态,0：已删除，1：在售，2：待售，仓库中
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 创建时间，毫秒级时间戳，如1421585369113
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 最新修改时间，毫秒级时间戳，如1421585369113
        /// </summary>
        public long ModifyTime { get; set; }


        public List<Sku> Skus { get; set; }
    }
}
