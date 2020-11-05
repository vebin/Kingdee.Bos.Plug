using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    public class Sal_OutStock_FEntity<Type_Sal_OutStock_FTaxDetailSubEntity, Type_Sal_OutStock_FSerialSubEntity>
        where Type_Sal_OutStock_FTaxDetailSubEntity : Sal_OutStock_FTaxDetailSubEntity
        where Type_Sal_OutStock_FSerialSubEntity : Sal_OutStock_FSerialSubEntity
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRowType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCustMatID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMaterialID { get; set; }
        //public virtual    "FAuxPropId": {
        //        "FAUXPROPID__FF100002": {
        //            "FNumber": ""
        //        }
        //    },
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FInventoryQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FParentMatId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FRealQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FDisPriceQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FTaxPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FIsFree { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBomID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOwnerTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FOwnerID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLot { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime FProduceDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime FExpiryDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FTaxCombination { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FEntryTaxRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FExtAuxUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FExtAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockID { get; set; }
        //"FStockLocID": {
        //    "FSTOCKLOCID__FF100001": {
        //        "FNumber": ""
        //    },
        //    "FSTOCKLOCID__FF100002": {
        //        "FNumber": ""
        //    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockStatusID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FQualifyType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FMtoNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FEntrynote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FDiscountRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FPriceDiscount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FActQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSalUnitID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FSALUNITQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FSALBASEQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FPRICEBASEQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FProjectNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FOUTCONTROL { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FRepairQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FIsCreateProDoc { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FEOwnerSupplierId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FIsOverLegalOrg { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FESettleCustomerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPriceListEntry { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FARNOTJOINQTY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FQmEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FConvertEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FSOEntryId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FBeforeDisPriceQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FSignQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FCheckDelivery { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FThirdEntryId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FETHIRDBILLID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FETHIRDBILLNO { get; set; }

        /// <summary>
        /// 税务明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_OutStock_FTaxDetailSubEntity> FTaxDetailSubEntity { get; set; }

        /// <summary>
        /// 序列号子单据体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_OutStock_FSerialSubEntity> FSerialSubEntity { get; set; }

    }
}
