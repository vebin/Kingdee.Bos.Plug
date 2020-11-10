using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
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
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRowType { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        [JsonRequired]
        public FNumberProperty FMATERIALID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMaterialDesc { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FParentMatId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FProjectNo { get; set; }
        /// <summary>
        /// 库存单位
        /// </summary>
        [JsonRequired]
        public FNumberProperty FUnitID { get; set; }
        /// <summary>
        /// 实退数量(必填)
        /// </summary>
        [JsonRequired]
        public decimal? FRMREALQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREPLENISHQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FKEAPAMTQTY { get; set; }
        /// <summary>
        /// 计价单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPRICEUNITID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSTOCKID { get; set; }
        /// <summary>
        /// 仓位
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Pur_Mrb_StrockLocModel FSTOCKLOCID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockStatusId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNOTE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTaxCombination { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FExtAuxUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FExtAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FREQTRACENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsReceiveUpdateStock { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FInvoicedJoinQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FGiveAway { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPriceBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSetPriceUnitID { get; set; }
        /// <summary>
        /// 采购单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCarryUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FCarryQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FCarryBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPOORDERENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FBILLINGCLOSE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPriceListEntry { get; set; }
        //"FAuxPropID": {
        //    "FAUXPROPID__FF100002": {
        //        "FNumber": ""
        //    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRMMUSTQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBOMID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSupplierLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FProduceDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FEXPIRYDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FAUXUNITQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOWNERTYPEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOWNERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FENTRYTAXRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FDISCOUNTRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTAXPRICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPriceDiscount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsStock { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FChargeProjectID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMtoNo { get; set; }
        /// <summary>
        /// 费用明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Pur_Mrb_FEntryPruCost> FEntryPruCost { get; set; }
        /// <summary>
        /// 税务明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Pur_Mrb_FTaxDetailSubEntity> FTaxDetailSubEntity { get; set; }
        /// <summary>
        /// 序列号子单据体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Pur_Mrb_FSerialSubEntity> FSerialSubEntity { get; set; }
    }
    public class Pur_Mrb_FPurmrbEntry : Pur_Mrb_FPurmrbEntry<Pur_Mrb_FEntryPruCost, Pur_Mrb_FTaxDetailSubEntity, Pur_Mrb_FSerialSubEntity>
    {

    }
}
