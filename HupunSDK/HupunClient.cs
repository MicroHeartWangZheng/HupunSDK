using HupunSDK.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace HupunSDK
{
    public class HupunClient : BaseClient
    {
        private string TimeStamp;

        public override string GetRequestUri(IRequest request)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("app_id", alipayOptions.AppId);
            dic.Add("method", request.GetApiName());
            dic.Add("charset", alipayOptions.Charset);
            dic.Add("sign_type", "RSA2");
            dic.Add("sign", GetSign(request));
            dic.Add("timestamp", TimeStamp);
            dic.Add("version", "1.0");

            dic.Add("biz_content", JsonConvert.SerializeObject(request.GetParameters().CleanupDictionary(), Formatting.None));

            return alipayOptions.ApiUrl + "?" + dic.ToSortQueryParameters(true);
        }

        public override string GetRequestBody(IRequest request)
        {
            return string.Empty;
        }

        public override string MediaType => "application/x-www-form-urlencoded";
    }
}
