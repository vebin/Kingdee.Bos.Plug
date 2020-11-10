using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// (付款单)应付票据明细
    /// </summary>
    public class Ap_PayBill_PayableEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FINNERACCOUNTID_B { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBILLID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FUSEDAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FBPPARAMOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPARLEFTAMOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FUSEDAMOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTempOrgId { get; set; }

    }
}
