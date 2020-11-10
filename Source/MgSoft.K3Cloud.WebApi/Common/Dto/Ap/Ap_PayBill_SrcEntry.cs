using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// (付款单)付款单源单明细
    /// </summary>
    public class Ap_PayBill_SrcEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTAXAMOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPAYPURPOSEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSRCCOSTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FEXPENSEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSRCPRICEUNITID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSRCPRICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSRCQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTAXAMOUNTLOC { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPLANPAYAMOUNTLOC { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREALPAYAMOUNTLOC { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSRCREMARK { get; set; }

    }
}
