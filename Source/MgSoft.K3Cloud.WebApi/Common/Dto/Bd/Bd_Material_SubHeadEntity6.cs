using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_SubHeadEntity6
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FCheckIncoming { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FCheckProduct { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FCheckStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FCheckReturn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FCheckDelivery { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FEnableCyclistQCSTK { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStockCycle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FEnableCyclistQCSTKEW { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? FEWLeadDay { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FIncSampSchemeId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FIncQcSchemeId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FInspectGroupId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FInspectorId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FCheckEntrusted { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FCheckOther { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsFirstInspect { get; set; }
    }
}
