using MgSoft.K3Cloud.WebApi.Common.Dto;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock
{
    public class Sal_ReturnStock_FEntity<
        Type_Sal_ReturnStock_FTaxDetailSubEntity, Type_Sal_ReturnStock_FSerialSubEntity>
        where Type_Sal_ReturnStock_FTaxDetailSubEntity : Sal_ReturnStock_FTaxDetailSubEntity
        where Type_Sal_ReturnStock_FSerialSubEntity : Sal_ReturnStock_FSerialSubEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRowType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMapId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMaterialId { get; set; }
        //                "FAuxpropId": {
        //    "FAUXPROPID__FF100002": {
        //        "FNumber": ""
        //                    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FInventoryQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRealQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FParentMatId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FTaxPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsFree { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FTaxCombination { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FEntryTaxRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBOMId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FReturnType { get; set; }
        /// <summary>
        /// 货主类型
        /// </summary>
        public virtual string FOwnerTypeId { get; set; }
        /// <summary>
        /// 货主
        /// </summary>
        public virtual FNumberProperty FOwnerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockId { get; set; }
        public virtual StockLocModel FStocklocId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockstatusId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDeliveryDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FMtoNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FProduceDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FExpiryDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FNote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FDiscountRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPriceDiscount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FExtAuxUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FExtAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FISCONSUMESUM { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSalUnitID { get; set; }
        /// <summary>
        /// 必填
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSalUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSalBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPriceBaseQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FProjectNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FQualifyType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FEOwnerSupplierId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsOverLegalOrg { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FESettleCustomerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSOEntryId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FThirdEntryId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPriceListEntry { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FARNOTJOINQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsReturnCheck { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FETHIRDBILLID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FETHIRDBILLNO { get; set; }
        /// <summary>
        /// 税务明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Sal_ReturnStock_FTaxDetailSubEntity> FTaxDetailSubEntity { get; set; }
        /// <summary>
        /// 序列号子单据体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Sal_ReturnStock_FSerialSubEntity> FSerialSubEntity { get; set; }
    }
    public class Sal_ReturnStock_FEntity : Sal_ReturnStock_FEntity<
        Sal_ReturnStock_FTaxDetailSubEntity, Sal_ReturnStock_FSerialSubEntity>
    {
        
    }
}
