using ARLEMDecipher.Models.Common;
using ARLEMDecipher.Models.Workplaces.Sensors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Triggers
{
    public class Detectable : IWorkplaceItem
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("sensor")]
        public VirtualSensor Sensor { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        public Asset Asset { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }
    }
}
