using HupunSDK.Common;
using HupunSDK.Common.Extend;
using HupunSDK.Core;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;

namespace HupunSDK
{
    public class HupunClient : BaseClient, IHupunClient
    {
        private HupunConfig Config;

        private long TimeStamp;

        public HupunClient(HupunConfig hupunConfig)
        {
            this.Config = hupunConfig;
            
        }

        public override string GetRequestUri(IRequest request)
        {
            this.TimeStamp = DateTime.UtcNow.ToTimeStamp();

            if (request.GetHttpMethod() == HttpMethod.Post)
                return Config.ApiUrl + request.GetApiName();

            var dic = request.GetParameters().CleanupDictionary();
            dic.Add("app_key", Config.AppKey);
            dic.Add("format", "json");
            dic.Add("sign", GetSign(request));
            dic.Add("timestamp", TimeStamp);
            return Config.ApiUrl + request.GetApiName() + "?" + dic.ToSortQueryParameters(true);
        }

        public override string GetRequestBody(IRequest request)
        {
            if (request.GetHttpMethod() == HttpMethod.Get)
                return string.Empty;
            var dic = request.GetParameters().CleanupDictionary();
            dic.Add("app_key", Config.AppKey);
            dic.Add("format", "json");
            dic.Add("sign", GetSign(request));
            dic.Add("timestamp", TimeStamp);
            return dic.ToSortQueryParameters(true);
        }

        public override string GetSign(IRequest request)
        {
            var dic = request.GetParameters().CleanupDictionary();
            dic.Add("app_key", Config.AppKey);
            dic.Add("format", "json");
            dic.Add("timestamp", TimeStamp);

            var orderDic = dic.OrderBy(m => m.Key);
            var signString = Config.Secret;
            foreach (var para in orderDic)
            {
                signString += para.Key + para.Value;
            }
            signString += Config.Secret;
            return signString.GetMD5().ToUpper();
        }

        public override string MediaType => "application/x-www-form-urlencoded";
    }
}
