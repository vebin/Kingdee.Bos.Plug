﻿using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    public class Stk_InStock_FInStockEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FEntryID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRowType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FWWInType { get; set; }

        /// <summary>
        /// 物料编码(必填)
        /// </summary>
        public virtual FNumberProperty FMaterialId { get; set; }

        /// <summary>
        /// 库存单位(必填)
        /// </summary>
        public virtual FNumberProperty FUnitID { get; set; }
        //"FAuxPropId": {
        //    "FAUXPROPID__FF100002": {
        //        "FNumber": ""
        //    }
        //},

        /// <summary>
        /// 基本单位
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBaseUnitID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FParentMatId { get; set; }
        /// <summary>
        /// 实收数量(必填)
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRealQty { get; set; }

        /// <summary>
        /// 计价单位（必填）
        /// </summary>
        public virtual FNumberProperty FPriceUnitID { get; set; }
        /// <summary>
        /// 计价数量(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPriceUnitQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPrice { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FAmount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FTaxCombination { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLot { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FDisPriceQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual StockLocModel FStockLocId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockStatusId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FMtoNo { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FGiveAway { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FNote { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FProduceDate { get; set; }

        /// <summary>
        /// 货主类型（必填）
        /// </summary>
        public virtual string FOWNERTYPEID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FExtAuxUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FExtAuxUnitQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FCheckInComing { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FProjectNo { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsReceiveUpdateStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FInvoicedJoinQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPriceBaseQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSetPriceUnitID { get; set; }

        /// <summary>
        /// 采购单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FRemainInStockUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FBILLINGCLOSE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRemainInStockQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FAPNotJoinQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRemainInStockBaseQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FTaxPrice { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual float? FEntryTaxRate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual float? FDiscountRate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FCostPrice { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBOMId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSupplierLot { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FExpiryDate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FAuxUnitQty { get; set; }

        /// <summary>
        /// 货主（必填）
        /// </summary>
        public virtual FNumberProperty FOWNERID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FPriceDiscount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FConsumeSumQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FBaseConsumeSumQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FBeforeDisPriceQty { get; set; }
        //"FEntryPruCost": [
        //    {
        //        "FDetailID": 0
        //    }
        //],
        //"FTaxDetailSubEntity": [
        //    {
        //        "FDetailID": 0,
        //        "FTaxRate": 0
        //    }
        //],
        //"FSerialSubEntity": [
        //    {
        //        "FDetailID": 0,
        //        "FSerialNo": "",
        //        "FSerialNote": ""
        //    }
        //]
    }
}