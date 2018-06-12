using ARLEMDecipher.Models.Common;
using ARLEMDecipher.Models.Workplaces.Triggers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Tangibles
{
    public class Person : IWorkplaceItem
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("mbox")]
        public string MailBox { get; set; }

        [JsonProperty("persona")]
        public string Persona { get; set; }

        [JsonProperty("detectable")]
        public Detectable Detectable { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

    }
}
