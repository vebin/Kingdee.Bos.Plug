using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto
{
    public class FContactNumberProperty
    {
        [JsonProperty("FContactNumber")]
        public string FContactNumber { get; set; }
    }
}
