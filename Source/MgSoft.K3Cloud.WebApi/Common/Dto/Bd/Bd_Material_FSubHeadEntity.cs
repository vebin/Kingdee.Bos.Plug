using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_FSubHeadEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsControlSal { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FLowerPercent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FUpPercent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCalculateBase { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal FMaxSalPrice_CMK { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMinSalPrice_CMK { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsAutoRemove { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsMailVirtual { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FIsFreeSend { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPriceType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FLogisticsCount { get; set; }
    }
}
