using HupunSDK.Core;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace HupunSDK.Response
{
    public class HupunResponse: BaseResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
