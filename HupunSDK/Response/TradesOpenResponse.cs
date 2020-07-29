using Newtonsoft.Json;
using System.Collections.Generic;

namespace HupunSDK.Response
{
    public class TradesOpenResponse : HupunResponse
    {
        [JsonProperty("response")]
        private string response { get; set; }

        [JsonIgnore]
        public List<string> Response
        {
            get
            {
                return JsonConvert.DeserializeObject<List<string>>(this.response);
            }
        }
    }
}
