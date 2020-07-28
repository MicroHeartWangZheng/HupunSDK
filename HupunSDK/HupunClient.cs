using HupunSDK.Common.Extend;
using HupunSDK.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace HupunSDK
{
    public class HupunClient : BaseClient, IHupunClient
    {
        public HupunClient(HupunConfig hupunConfig)
        {
            this.Config = hupunConfig;
        }

        public override string GetRequestUri(IRequest request)
        {
            return this.Config.ApiUrl + "?" + request.GetParameters().ToSortQueryParameters();
        }

        public override string GetRequestBody(IRequest request)
        {
            return string.Empty;
        }

        public override string MediaType => "application/x-www-form-urlencoded";
    }
}
