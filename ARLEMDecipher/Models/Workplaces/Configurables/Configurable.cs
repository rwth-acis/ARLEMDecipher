using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Configurables
{
    public class Configurable
    {
        [JsonProperty("app")]
        public List<App> Apps { get; set; }

        [JsonProperty("device")]
        public List<Device> Devices { get; set; }
    }
}
