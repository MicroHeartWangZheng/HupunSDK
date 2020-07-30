using HupunSDK.Core;
using Newtonsoft.Json;

namespace HupunSDK.Response
{
    public class HupunResponse : BaseResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }
    }
}
