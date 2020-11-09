using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    class Bd_Material_FEntityAuxPty
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FAuxPropertyId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsEnable1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsComControl { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsAffectPrice1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsAffectPlan1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsAffectCost1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsMustInput { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FValueType { get; set; }
    }
}
