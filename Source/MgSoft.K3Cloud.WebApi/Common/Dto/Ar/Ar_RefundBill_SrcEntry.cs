using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// (收款退款单)退款单源单明细
    /// </summary>
    public class Ar_RefundBill_SrcEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREALREFUNDAMOUNTMB { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPAYPURPOSEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSRCREMARK { get; set; }

    }
}
