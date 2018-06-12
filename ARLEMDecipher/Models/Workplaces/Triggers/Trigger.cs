using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Triggers
{
    public class Trigger
    {
        [JsonProperty("detectable")]
        public List<Detectable> Detectables { get; set; }

        [JsonProperty("hazard")]
        public List<Hazard> Hazards { get; set; }

        [JsonProperty("predicate")]
        public List<Predicate> Predicates { get; set; }

        [JsonProperty("warning")]
        public List<Warning> Warnings { get; set; }
    }
}
