using ARLEMDecipher.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Triggers
{
    public class Primitive : IWorkplaceItem
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public PrimitiveTypes Type { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("size")]
        public double Size { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }
    }
}
