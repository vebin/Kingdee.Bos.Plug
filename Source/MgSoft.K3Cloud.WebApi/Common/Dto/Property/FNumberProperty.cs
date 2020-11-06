using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi.Common.Dto
{
    public class FNumberProperty
    {
        public FNumberProperty()
        {
        }

        public FNumberProperty(string fnumber)
        {
            this.FNumber = fnumber;
        }

        [JsonProperty("FNumber")]
        public string FNumber { get; set; }
    }
}
