using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    public class Sal_OutStock_FOutStockTrace<Type_Sal_OutStock_FOutStockTraceDetail>
        where Type_Sal_OutStock_FOutStockTraceDetail : Sal_OutStock_FOutStockTraceDetail
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FEntryID { get; set; }
        //"FLogComId": {
        //    "FCODE": ""
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FPhoneNumber { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDelTime { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCarryBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FTraceStatus { get; set; }

        /// <summary>
        /// FOutStockTraceDetail
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_OutStock_FOutStockTraceDetail> FOutStockTraceDetail { get; set; }
    }
}
