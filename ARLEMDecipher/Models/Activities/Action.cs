using ARLEMDecipher.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Activities
{
    public class Action
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("id_name")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("instructionTitle")]
        public string InstructionTitle { get; set; }

        [JsonProperty("instructionDescription")]
        public string InstructionDescription { get; set; }

        [JsonProperty("Author")]
        public Author Author { get; set; }

        [JsonProperty("triggers")]
        public List<ActionTrigger> Triggers { get; set; }
    }
}
