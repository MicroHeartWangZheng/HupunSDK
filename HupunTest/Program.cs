using HupunSDK.Common.Extend;
using HupunSDK.Models;
using HupunSDK.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HupunSDK.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateProduct();
            CreateOrder();
            GetOrderStatus();
            GetSaleOrders();
        }

        public static void CreateProduct()
        {
            var product = new Product()
            {
                CreateTime = DateTime.Now.ToTimeStamp(),
                ImageURL = "http://blog.csdn.net/MaYang_/article/details/100748276",
                ItemId = "0001",
                ItemURL = "https://www.baidu.com/s?ie=UTF-8&wd=ServiceStack",
                ModifyTime = DateTime.Now.ToTimeStamp(),
                Price = 120m,
                Quantity = 20,
                ShopNick = "供应商C",
                Status = 1,
                Title = "Iphone 11",
            };

            var sku1 = new Sku()
            {
                CreateTime =DateTime.Now.ToTimeStamp(),
                ImageURL = "http://blog.csdn.net/MaYang_/article/details/100748276",
                ItemId = "0001",
                ModifyTime =DateTime.Now.ToTimeStamp(),
                Price = 130m,
                Quantity = 10,
                SkuId = "0001-001",
                Status = 1,
                Attributes = "ORM:2G"
            };
            var sku2 = new Sku()
            {
                CreateTime =DateTime.Now.ToTimeStamp(),
                ImageURL = "http://blog.csdn.net/MaYang_/article/details/100748276",
                ItemId = "0001",
                ModifyTime =DateTime.Now.ToTimeStamp(),
                Price = 140m,
                Quantity = 10,
                SkuId = "0001-002",
                Status = 2,
                Attributes = "ORM:4G"
            };
            product.Skus.Add(sku1);
            product.Skus.Add(sku2);

            var request = new ItemsOpenRequest()
            {
                Items = new List<Product>() { product }
            };

            HupunClient client = new HupunClient(new HupunConfig()
            {
                ApiUrl = "http://114.67.231.99/open/api",
                AppKey = "5Y07TU8",
                Secret = "CC8BC92A4595365AB5172864E1927080"
            });
            var response = client.Execute(request);

            if (response.Success)
                Console.WriteLine($"商品推送成功,线上编号:{JsonConvert.SerializeObject(response.ProductIds)}");
            else
                Console.WriteLine($"商品推送失败");
        }

        public static void CreateOrder()
        {
            var order = new Order()
            {
                Buyer = "111111@qq.com",
                CreateTime = DateTime.Now.ToTimeStamp(),
                DiscountFee = 111m,
                EndTime = DateTime.Now.ToTimeStamp(),
                HasRefund = 0,
                ModifyTime = DateTime.Now.ToTimeStamp(),
                Payment = 1111m,
                PayTime = DateTime.Now.ToTimeStamp(),
                PostFee = 11.3m,
                ReceiverAddress = "浙江省杭州市江干区",
                ReceiverMobile = "17601223799",
                ReceiverName = "小度",
                ShippingTime = DateTime.Now.ToTimeStamp(),
                ShippingType = 1,
                ShopNick = "供应商C",
                Status = 3,
                TotalFee = 1111.6m,
                TradeId = "CF11111111",
            };

            var orderDateil1 = new OrderDetail()
            {
                ImageUrl = "http://blog.csdn.net/MaYang_/article/details/100748276",
                ItemID = "0011",
                ItemTitle = "商品标题1",
                OrderID = "SUB1",
                Payment = 100.3m,
                Price = 10.1m,
                Size = 1,
                SkuTitle = "1kg,小型",
                Status = 3,
                TradeId = "CF11111111"
            };
            var orderDateil2 = new OrderDetail()
            {
                ImageUrl = "http://blog.csdn.net/MaYang_/article/details/100748276",
                ItemID = "0012",
                ItemTitle = "商品标题2",
                OrderID = "SUB2",
                Payment = 200.3m,
                Price = 20.1m,
                Size = 2,
                SkuTitle = "2kg,中型",
                Status = 3,
                TradeId = "CF11111111"
            };

            order.OrderDetails.Add(orderDateil1);
            order.OrderDetails.Add(orderDateil2);

            var request = new TradesOpenRequest()
            {
                Orders = new List<Order>() { order }
            };

            var client = new HupunClient(new HupunConfig()
            {
                ApiUrl = "http://114.67.231.99/open/api",
                AppKey = "5Y07TU8",
                Secret = "CC8BC92A4595365AB5172864E1927080"
            });
            var response = client.Execute(request);

            if (response.Success)
                Console.WriteLine($"订单推送成功");
            else
                Console.WriteLine($"订单推送失败");
        }

        public static void GetOrderStatus()
        {
            var request = new TradesErpStatusRequest()
            {
                ShopNick = "供应商C",
                ShopType = 100,
                TradeIds = "CF123456789"
            };
            var client = new HupunClient(new HupunConfig()
            {
                ApiUrl = "http://114.67.231.99/open/api",
                AppKey = "5Y07TU8",
                Secret = "CC8BC92A4595365AB5172864E1927080"
            });
            var response = client.Execute(request);
            if (response.Success)
                Console.WriteLine($"订单状态:{JsonConvert.SerializeObject(response)}");
            else
                Console.WriteLine($"获取订单状态失败");
            Console.ReadLine();
        }

        public static void GetSaleOrders()
        {
            var request = new SaleErpExchangesRequest()
            {
                ShopType = 100,
                Start = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd HH:mm:ss"),
                End = DateTime.Now.AddDays(30).ToString("yyyy-MM-dd HH:mm:ss"),
                Page = 1,
                Limit = 50,
                TimeType = 1,
            };
            var client = new HupunClient(new HupunConfig()
            {
                ApiUrl = "http://114.67.231.99/open/api",
                AppKey = "5Y07TU8",
                Secret = "CC8BC92A4595365AB5172864E1927080"
            });
            var response = client.Execute(request);
            if (response.Success)
                Console.WriteLine($"订单状态:{JsonConvert.SerializeObject(response)}");
            else
                Console.WriteLine($"获取订单状态失败");
            Console.ReadLine();
        }
    }
}
