using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    public class Stk_InStockSaveInputDto<Type_FInStockFin, Type_FInStockEntry>
        where Type_FInStockFin : Stk_InStock_FInStockFin
        where Type_FInStockEntry : Stk_InStock_FInStockEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public virtual FNumberProperty FBillTypeID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public virtual DateTime FDate { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public virtual FNumberProperty FStockOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockDeptId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerGroupId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDemandOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCorrespondOrgId { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaseOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaseDeptId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaserGroupId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaserId { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSupplierId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSupplyId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSupplyAddress { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FChargeId { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public virtual string FOwnerTypeIdHead { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public virtual FNumberProperty FOwnerIdHead { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FUserIDProperty FConfirmerId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FConfirmDate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FScanBox { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCDateOffsetUnit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? FCDateOffsetValue { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FContactNumberProperty FProviderContactID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSplitBillType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Type_FInStockFin FInStockFin { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_FInStockEntry> FInStockEntry { get; set; }
    }

    public class Stk_InStockSaveInputDto : Stk_InStockSaveInputDto<Stk_InStock_FInStockFin, Stk_InStock_FInStockEntry>
    {

    }
}
