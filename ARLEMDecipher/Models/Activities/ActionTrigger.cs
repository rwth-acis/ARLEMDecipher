using ARLEMDecipher.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Activities
{
    public class ActionTrigger
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("mode")]
        public ActionTriggerMode Mode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("remove")]
        public string RemoveSelf { get; set; }

        [JsonProperty("operations")]
        public List<ActionTriggerOperation> Operations { get; set; }
    }
}
