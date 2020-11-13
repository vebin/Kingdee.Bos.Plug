using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MgSoft.K3Cloud.WebApi.Common.Dto.Property
{
    public class FNumberProperty
    {
        public FNumberProperty()
        {
        }

        public FNumberProperty(string fnumber)
        {
            FNumber = fnumber;
        }

        [JsonProperty("FNumber")]
        public string FNumber { get; set; }
    }
}
