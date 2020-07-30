using Newtonsoft.Json;
using System.Collections.Generic;

namespace HupunSDK.Response
{
    public class ItemsOpenResponse : HupunResponse
    {
        [JsonIgnore]
        public List<string> ProductIds
        {
            get
            {
                return JsonConvert.DeserializeObject<List<string>>(this.Response);
            }
        }
    }
}
