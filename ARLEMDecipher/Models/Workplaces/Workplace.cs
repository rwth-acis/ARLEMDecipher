using ARLEMDecipher.Models.Workplaces.Configurables;
using ARLEMDecipher.Models.Workplaces.Tangibles;
using ARLEMDecipher.Models.Workplaces.Triggers;
using ARLEMDecipher.Models.Activities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces
{
    public class Workplace
    {
        [JsonProperty("tangibles")]
        public Tangible Tangibles { get; set; }

        [JsonProperty("configurables")]
        public Configurable Configurables { get; set; }

        [JsonProperty("triggers")]
        public Trigger Triggers { get; set; }

        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }
    }
}
