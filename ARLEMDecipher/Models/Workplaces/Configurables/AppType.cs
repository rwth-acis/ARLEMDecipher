using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Configurables
{
    public class AppType
    {
        [JsonProperty("id")]
        public int InternalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
