using ARLEMDecipher.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARLEMDecipher.Models.Workplaces.Triggers
{
    public class Hazard : IWorkplaceItem
    {
        [JsonProperty("id")]
        public int InertnalID { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        public ViewPort ViewPort { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }
    }
}
