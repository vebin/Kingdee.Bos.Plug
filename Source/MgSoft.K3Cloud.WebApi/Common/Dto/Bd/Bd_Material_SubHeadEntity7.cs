using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_SubHeadEntity7
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSubconUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSubconPriceUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSubBillType { get; set; }
    }
}
