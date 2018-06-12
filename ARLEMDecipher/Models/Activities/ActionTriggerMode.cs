using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Activities
{
    public class ActionTriggerMode
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
