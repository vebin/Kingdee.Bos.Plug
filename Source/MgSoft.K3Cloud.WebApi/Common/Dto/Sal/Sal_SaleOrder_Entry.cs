using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// (销售订单)订单明细
    /// </summary>
    /// <typeparam name="TYpe_Sal_SaleOrder_StockLocalModel">仓位</typeparam>
    /// <typeparam name="Type_Sal_SaleOrder_OrderEntryPlan">交货明细</typeparam>
    /// <typeparam name="Type_Sal_SaleOrder_TaxDetailSubEntity">税务明细</typeparam>
    public class Sal_SaleOrder_Entry<
        TYpe_Sal_SaleOrder_StockLocalModel,
        Type_Sal_SaleOrder_OrderEntryPlan,
        Type_Sal_SaleOrder_TaxDetailSubEntity>
        where TYpe_Sal_SaleOrder_StockLocalModel : Sal_SaleOrder_StockLocalModel
        where Type_Sal_SaleOrder_OrderEntryPlan : Sal_SaleOrder_OrderEntryPlan
        where Type_Sal_SaleOrder_TaxDetailSubEntity : Sal_SaleOrder_TaxDetailSubEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReturnType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRowType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMapId { get; set; }
        /// <summary>
        /// 物料编码(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FMaterialId { get; set; }
        //"FAuxPropId": {
        //    "FAUXPROPID__FF100002": {
        //        "FNumber": ""
        //                    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FParentMatId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FInventoryQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FCurrentInventory { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FAwaitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FAvailableQty { get; set; }
        /// <summary>
        /// 销售数量(必填)
        /// </summary>
        [JsonRequired]
        public decimal? FQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FOldQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurPriceUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTaxPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsFree { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTaxCombination { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEntryTaxRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FProduceDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FExpPeriod { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FExpUnit { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FExpiryDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPriceDiscount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FInStockPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FDiscountRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDeliveryDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSettleOrgIds { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSupplyOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOwnerTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOwnerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FEntryNote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReserveType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPriority { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMtoNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPromotionMatchType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FNetOrderEntryId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPriceBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStockQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStockBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FServiceContext { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOUTLMTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOutLmtUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSOStockId { get; set; }
        /// <summary>
        /// 仓位
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Sal_SaleOrder_StockLocalModel FSOStockLocalId { get; set; }
        public bool? FISMRP { get; set; }
        /// <summary>
        /// 交货明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sal_SaleOrder_OrderEntryPlan> FOrderEntryPlan { get; set; }
        /// <summary>
        /// 税务明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sal_SaleOrder_TaxDetailSubEntity> FTaxDetailSubEntity { get; set; }
    }
    /// <summary>
    /// 订单明细
    /// </summary>
    public class Sal_SaleOrder_Entry : Sal_SaleOrder_Entry<
        Sal_SaleOrder_StockLocalModel,
        Sal_SaleOrder_OrderEntryPlan,
        Sal_SaleOrder_TaxDetailSubEntity>
    { }
}
