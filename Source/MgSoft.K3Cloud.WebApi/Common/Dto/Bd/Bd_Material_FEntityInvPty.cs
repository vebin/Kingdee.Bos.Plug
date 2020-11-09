using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_FEntityInvPty
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FInvPtyId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsEnable { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsAffectPrice { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsAffectPlan { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsAffectCost { get; set; }
    }
}
