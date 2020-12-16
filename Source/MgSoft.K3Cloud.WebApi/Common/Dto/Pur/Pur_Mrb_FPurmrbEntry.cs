using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// (采购退料单)明细信息
    /// </summary>
    public class Pur_Mrb_FPurmrbEntry<
        Type_Pur_Mrb_FEntryPruCost,
        Type_Pur_Mrb_FTaxDetailSubEntity,
        Type_Pur_Mrb_FSerialSubEntity>
        where Type_Pur_Mrb_FEntryPruCost : Pur_Mrb_FEntryPruCost
        where Type_Pur_Mrb_FTaxDetailSubEntity : Pur_Mrb_FTaxDetailSubEntity
        where Type_Pur_Mrb_FSerialSubEntity : Pur_Mrb_FSerialSubEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRowType { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FMATERIALID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FMaterialDesc { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FParentMatId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FProjectNo { get; set; }
        /// <summary>
        /// 库存单位
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FUnitID { get; set; }
        /// <summary>
        /// 实退数量(必填)
        /// </summary>
        [JsonRequired]
        public virtual decimal? FRMREALQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FREPLENISHQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FKEAPAMTQTY { get; set; }
        /// <summary>
        /// 计价单位(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FPRICEUNITID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKID { get; set; }
        /// <summary>
        /// 仓位
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual StockLocModel FSTOCKLOCID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockStatusId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FNOTE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FTaxCombination { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FExtAuxUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FExtAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FREQTRACENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsReceiveUpdateStock { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FInvoicedJoinQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FGiveAway { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPriceBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSetPriceUnitID { get; set; }
        /// <summary>
        /// 采购单位(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FCarryUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FCarryQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FCarryBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPOORDERENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FBILLINGCLOSE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPriceListEntry { get; set; }
        //"FAuxPropID": {
        //    "FAUXPROPID__FF100002": {
        //        "FNumber": ""
        //    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRMMUSTQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBOMID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSupplierLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FProduceDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FEXPIRYDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FAUXUNITQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOWNERTYPEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FOWNERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FENTRYTAXRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FDISCOUNTRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FTAXPRICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPriceDiscount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsStock { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FChargeProjectID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMtoNo { get; set; }
        /// <summary>
        /// 费用明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Pur_Mrb_FEntryPruCost> FEntryPruCost { get; set; }
        /// <summary>
        /// 税务明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Pur_Mrb_FTaxDetailSubEntity> FTaxDetailSubEntity { get; set; }
        /// <summary>
        /// 序列号子单据体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Pur_Mrb_FSerialSubEntity> FSerialSubEntity { get; set; }
    }
    public class Pur_Mrb_FPurmrbEntry : Pur_Mrb_FPurmrbEntry<Pur_Mrb_FEntryPruCost, Pur_Mrb_FTaxDetailSubEntity, Pur_Mrb_FSerialSubEntity>
    {

    }
}
