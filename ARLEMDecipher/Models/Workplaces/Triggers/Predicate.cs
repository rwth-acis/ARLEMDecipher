using ARLEMDecipher.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Triggers
{
    public class Predicate : IWorkplaceItem
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primitives")]
        public List<Primitive> Primitives { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }
    }
}
