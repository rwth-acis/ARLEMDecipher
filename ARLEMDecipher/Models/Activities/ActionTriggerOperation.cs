using ARLEMDecipher.Models.Common;
using ARLEMDecipher.Models.Workplaces;
using ARLEMDecipher.Models.Workplaces.Sensors;
using ARLEMDecipher.Models.Workplaces.Triggers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Activities
{
    public class ActionTriggerOperation
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("is_active")]
        public string IsActivate { get; set; }

        public IWorkplaceItem Entity { get; set; }

        [JsonProperty("predicate")]
        public Predicate Predicate { get; set; }

        [JsonProperty("options")]
        public String Options { get; set; }

        [JsonProperty("sensor")]
        public VirtualSensor Sensor { get; set; }

        [JsonProperty("viewport")]
        public ViewPort ViewPort { get; set; }
    }
}
