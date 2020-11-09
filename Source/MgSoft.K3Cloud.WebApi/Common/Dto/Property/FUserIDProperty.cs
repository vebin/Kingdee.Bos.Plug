using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Property
{
    public class FUserIDProperty
    {
        [JsonProperty("FNumber")]
        public long FUserID { get; set; }
    }
}
