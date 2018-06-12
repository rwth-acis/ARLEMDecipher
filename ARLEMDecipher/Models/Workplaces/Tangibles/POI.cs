using ARLEMDecipher.Models.Common;
using ARLEMDecipher.Models.Workplaces.Tangibles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces
{
    public class POI : IWorkplaceItem
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("x")]
        public string X { get; set; }

        [JsonProperty("y")]
        public string Y { get; set; }

        [JsonProperty("z")]
        public string Z { get; set; }

    }
}
