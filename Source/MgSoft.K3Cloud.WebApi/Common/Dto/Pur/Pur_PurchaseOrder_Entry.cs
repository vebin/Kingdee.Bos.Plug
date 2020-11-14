using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// (采购订单)明细信息
    /// </summary>
    public class Pur_PurchaseOrder_Entry<
        Type_Pur_PurchaseOrder_EntryDeliveryPlan, 
        Type_Pur_PurchaseOrder_TaxDetailSubEntity>
        where Type_Pur_PurchaseOrder_EntryDeliveryPlan : Pur_PurchaseOrder_EntryDeliveryPlan
        where Type_Pur_PurchaseOrder_TaxDetailSubEntity : Pur_PurchaseOrder_TaxDetailSubEntity

    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FProductType { get; set; }
        /// <summary>
        /// 物料编码(必填)
        /// </summary>
        [JsonRequired]
        public virtual virtual FNumberProperty FMaterialId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FBomId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FMaterialDesc { get; set; }
        //"FAuxPropId": { "FAUXPROPID__FF100002": { "FNumber": "" }},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FUnitId { get; set; }
        /// <summary>
        /// 采购数量
        /// </summary>
        [JsonRequired]
        public virtual virtual decimal? FQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FPriceUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FPriceUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FPriceBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual DateTime? FDeliveryDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FLocation { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FLocationAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FPrice { get; set; }
        /// <summary>
        /// 采购单价(必填)
        /// </summary>
        [JsonRequired]
        public virtual virtual decimal? FTaxPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FEntryDiscountRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FTaxCombination { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FEntryTaxRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FRequireOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FRequireDeptId { get; set; }
        //"FRequireStaffId": { },
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FReceiveOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FReceiveDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FEntrySettleOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual bool? FGiveAway { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FEntryNote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FSupMatId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FSupMatName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FStockUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FStockQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FStockBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FSupplierLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FProcesser { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual bool? FDeliveryControl { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual bool? FTimeControl { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FDeliveryMaxQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FDeliveryMinQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FDeliveryBeforeDays { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FDeliveryDelayDays { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual DateTime? FDeliveryEarlyDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual DateTime? FDeliveryLastDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FPriceCoefficient { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FEntrySettleModeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FConsumeSumQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FContractNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FReqTraceNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FMtoNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FDEMANDTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual string FDEMANDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FDEMANDBILLENTRYSEQ { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FDEMANDBILLENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FLocationId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual bool? FPlanConfirm { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FSalUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FSalQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FSalJoinQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FBaseSalJoinQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FSetPriceUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FInventoryQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FChargeProjectID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FCentSettleOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FDispSettleOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual int? FGroup { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FDeliveryStockStatus { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FMaxPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FMinPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual bool? FIsStock { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FBaseConsumeSumQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FSalBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FSubOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual FNumberProperty FEntryPayOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual decimal? FPriceDiscount { get; set; }
        /// <summary>
        /// 交货明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual List<Pur_PurchaseOrder_EntryDeliveryPlan> FEntryDeliveryPlan { get; set; }
        /// <summary>
        /// 税务明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual virtual List<Pur_PurchaseOrder_TaxDetailSubEntity> FTaxDetailSubEntity { get; set; }
    }
    /// <summary>
    /// 明细信息
    /// </summary>
    public class Pur_PurchaseOrder_Entry : Pur_PurchaseOrder_Entry<
        Pur_PurchaseOrder_EntryDeliveryPlan,
        Pur_PurchaseOrder_TaxDetailSubEntity>
    { }
}
