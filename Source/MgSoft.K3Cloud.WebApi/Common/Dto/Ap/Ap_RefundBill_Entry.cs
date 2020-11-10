using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// (付款退款单)退款单明细
    /// </summary>
    public class Ap_RefundBill_Entry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        /// <summary>
        /// 结算方式(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLETYPEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURPOSEID { get; set; }
        /// <summary>
        /// 应退金额(必填)
        /// </summary>
        [JsonRequired]
        public decimal? FREFUNDAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREFUNDAMOUNTFOR_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FHANDLINGCHARGEFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FINNERACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITEBANKNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITEBANKACCOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITECCOUNTNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCashAccount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNOTE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCOSTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREFUNDAMOUNT_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FPOSTDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPRICEUNITID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPRICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPURCHASEORDERNUMBER { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FGYSALEORDERNO { get; set; }
    }
}
