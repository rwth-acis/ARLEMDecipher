using ARLEMDecipher.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Sensors
{
    public class VirtualSensor : IWorkplaceItem
    {
        [JsonProperty("id")]
        public int InternalID { get; set; }

        [JsonProperty("id_name")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }
    }
}
