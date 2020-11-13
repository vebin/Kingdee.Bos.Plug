using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// （销售订单）交货明细
    /// </summary>
    public class Sal_SaleOrder_OrderEntryPlan
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FDetailID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDetailLocId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDetailLocAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FPlanDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTransportLeadTime { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPlanQty { get; set; }
    }
}
