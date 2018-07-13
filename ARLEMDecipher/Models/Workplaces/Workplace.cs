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
using ARLEMDecipher.Models.Workplaces.Sensors;
using System.Xml.Serialization;

namespace ARLEMDecipher.Models.Workplaces
{
    [Serializable()]
    public class Workplace
    {
        [XmlElement("tangibles")]
        [JsonProperty("tangibles")]
        public Tangible Tangibles { get; set; }

        [XmlElement("configurables")]
        [JsonProperty("configurables")]
        public Configurable Configurables { get; set; }

        [XmlElement("triggers")]
        [JsonProperty("triggers")]
        public Trigger Triggers { get; set; }

        [XmlElement("activities")]
        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }

        [XmlElement("sensors")]
        [JsonProperty("sensors")]
        public List<VirtualSensor> Sensors { get; set; }
    }
}
