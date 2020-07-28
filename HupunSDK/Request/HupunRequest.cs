using HupunSDK.Core;
using HupunSDK.Response;
using Newtonsoft.Json;

namespace HupunSDK.Request
{
    public abstract class HupunRequest<TResponse> : BaseRequest<TResponse>, IRequest<TResponse> where TResponse : HupunResponse, new()
    {
        [JsonProperty("app_key")]
        public string AppKey { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; } = "json";

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}
