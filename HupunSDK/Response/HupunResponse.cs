using HupunSDK.Core;
using Newtonsoft.Json;

namespace HupunSDK.Response
{
    public abstract class HupunResponse : BaseResponse
    {
        /// <summary>
        /// 调用是否成功
        /// </summary>
        [JsonProperty("success")]
        public string Success { get; set; }

        /// <summary>
        /// 网关返回码描述
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务返回码，参见具体的API接口文档
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
