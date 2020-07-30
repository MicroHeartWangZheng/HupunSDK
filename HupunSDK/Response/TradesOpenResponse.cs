using Newtonsoft.Json;
using System.Collections.Generic;

namespace HupunSDK.Response
{
    public class TradesOpenResponse : HupunResponse
    {
        [JsonIgnore]
        public List<string> OrderIds
        {
            get
            {
                return JsonConvert.DeserializeObject<List<string>>(this.Response);
            }
        }
    }
}
