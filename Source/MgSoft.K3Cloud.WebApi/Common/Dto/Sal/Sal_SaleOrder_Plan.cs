using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// (销售订单)收款计划
    /// </summary>
    public class Sal_SaleOrder_Plan<Type_Sal_SaleOrder_SaleOrderPlanEntry>
        where Type_Sal_SaleOrder_SaleOrderPlanEntry : Sal_SaleOrder_SaleOrderPlanEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FNeedRecAdvance { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FReceiveType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRecAdvanceRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRecAdvanceAmount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FMustDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRelBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRecAmount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FControlSend { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsOutStockByRecamount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReMark { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPlanMaterialId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? FMaterialSeq { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMaterialRowID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? FOrderEntryId { get; set; }
        /// <summary>
        /// 收款计划子单据体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sal_SaleOrder_SaleOrderPlanEntry> FSaleOrderPlanEntry { get; set; }
    }
    public class Sal_SaleOrder_Plan : Sal_SaleOrder_Plan<Sal_SaleOrder_SaleOrderPlanEntry>
    { }
}
