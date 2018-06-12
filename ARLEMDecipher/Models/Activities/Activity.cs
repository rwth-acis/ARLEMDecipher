using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARLEMDecipher.Models.Common;
using ARLEMDecipher.Models.Workplaces;
using Newtonsoft.Json;

namespace ARLEMDecipher.Models.Activities
{
    public class Activity
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("start")]
        public int StartAction { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }
    }
}
