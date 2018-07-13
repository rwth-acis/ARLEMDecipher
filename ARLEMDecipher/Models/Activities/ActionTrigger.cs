using ARLEMDecipher.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ARLEMDecipher.Models.Activities
{
    [Serializable()]
    public class ActionTrigger
    {
        [XmlAttribute("id")]
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [XmlElement("mode")]
        [JsonProperty("mode")]
        public ActionTriggerMode Mode { get; set; }

        [XmlAttribute("type")]
        [JsonProperty("type")]
        public string Type { get; set; }

        [XmlAttribute("value")]
        [JsonProperty("value")]
        public string Value { get; set; }

        [XmlAttribute("remove")]
        [JsonProperty("remove")]
        public string RemoveSelf { get; set; }

        [XmlArray("operations")]
        [XmlArrayItem("operation", typeof(ActionTriggerOperation))]
        [JsonProperty("operations")]
        public List<ActionTriggerOperation> Operations { get; set; }
    }
}
