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
    public class Action
    {
        [XmlAttribute("id")]
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [XmlAttribute("id_name")]
        [JsonProperty("id_name")]
        public string ID { get; set; }

        [XmlAttribute("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [XmlAttribute("instructionTitle")]
        [JsonProperty("instructionTitle")]
        public string InstructionTitle { get; set; }

        [XmlAttribute("instructionDescription")]
        [JsonProperty("instructionDescription")]
        public string InstructionDescription { get; set; }

        [XmlElement("author")]
        [JsonProperty("author")]
        public Author Author { get; set; }

        [XmlArray("triggers")]
        [XmlArrayItem("trigger", typeof(ActionTrigger))]
        [JsonProperty("triggers")]
        public List<ActionTrigger> Triggers { get; set; }
    }
}
