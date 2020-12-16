using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sp
{
    public class Sp_PickMtrl_SerialSubEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FDetailID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSerialNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSerialNote { get; set; }
    }
}
