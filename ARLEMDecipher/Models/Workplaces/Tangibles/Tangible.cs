using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Tangibles
{
    public class Tangible
    {
        [JsonProperty("place")]
        public List<Place> Places { get; set; }

        [JsonProperty("person")]
        public List<Person> Person { get; set; }

        [JsonProperty("thing")]
        public List<Thing> Thing { get; set; }
    }
}
