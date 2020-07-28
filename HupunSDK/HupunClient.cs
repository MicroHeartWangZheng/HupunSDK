using HupunSDK.Common;
using HupunSDK.Common.Extend;
using HupunSDK.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace HupunSDK
{
    public class HupunClient : BaseClient, IHupunClient
    {
        private HupunConfig Config;

        private long TimeStamp;

        public HupunClient(HupunConfig hupunConfig)
        {
            this.Config = hupunConfig;
            TimeStamp = DateTimeHelper.ConvertDateTimeToMillisecond(DateTime.Now);
        }

        public override string GetRequestUri(IRequest request)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("app_key", Config.AppKey);
            dic.Add("format", "json");
            dic.Add("sign", GetSign(request));
            dic.Add("timestamp", TimeStamp);
            return Config.ApiUrl + "?" + dic.ToSortQueryParameters(true);
        }

        public override string GetRequestBody(IRequest request)
        {
            return string.Empty;
        }

        public override string GetSign(IRequest request)
        {
            var dic = request.GetParameters().CleanupDictionary();
            dic.Add("app_key", Config.AppKey);
            dic.Add("format", "json");
            dic.Add("timestamp", TimeStamp);

            var signString = Config.Secret;
            foreach (var para in dic)
            {
                signString += para.Key + para.Value;
            }
            signString += Config.Secret;

            return signString.GetMD5().ToUpper();
        }

        public override string MediaType => "application/x-www-form-urlencoded";
    }
}
