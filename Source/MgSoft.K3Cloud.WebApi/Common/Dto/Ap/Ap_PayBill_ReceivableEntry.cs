using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// (付款单)应收票据背书
    /// </summary>
    public class Ap_PayBill_ReceivableEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FInnerActId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FReceivebleBillId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPayPurse { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        decimal? FReturnAmount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        decimal? FParAmount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        decimal? FReturnAmountStd { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        decimal? FPARAMOUNTSTD { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBCONTACTUNITTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBCONTACTUNIT { get; set; }


    }
}
