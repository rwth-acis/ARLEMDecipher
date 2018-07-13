using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Serialization;

namespace ARLEMDecipher.Models.Workplaces.Tangibles
{
    [Serializable()]

    public class Tangible
    {
        [XmlArray("places")]
        [XmlArrayItem("palce", typeof(Place))]
        [JsonProperty("place")]
        public List<Place> Places { get; set; }

        [XmlArray("people")]
        [XmlArrayItem("person", typeof(Person))]
        [JsonProperty("person")]
        public List<Person> Person { get; set; }

        [XmlArray("thigns")]
        [XmlArrayItem("thing", typeof(Thing))]
        [JsonProperty("thing")]
        public List<Thing> Thing { get; set; }
    }
}
