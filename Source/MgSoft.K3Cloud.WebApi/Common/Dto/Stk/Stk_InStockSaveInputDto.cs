using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    /// <summary>
    /// 采购入库单
    /// </summary>
    /// <typeparam name="Type_FInStockFin"></typeparam>
    /// <typeparam name="Type_FInStockEntry"></typeparam>
    public class Stk_InStockSaveInputDto<Type_FInStockFin, Type_FInStockEntry>
        where Type_FInStockFin : Stk_InStock_FInStockFin
        where Type_FInStockEntry : Stk_InStock_FInStockEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID { get; set; }

        /// <summary>
        /// 单据类型(必填)
        /// </summary>
        public virtual FNumberProperty FBillTypeID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }

        /// <summary>
        /// 入库日期(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDate { get; set; }

        /// <summary>
        /// 收料组织(必填)
        /// </summary>
        public virtual FNumberProperty FStockOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockDeptId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerGroupId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerId { get; set; }
        /// <summary>
        /// 需求组织
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDemandOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCorrespondOrgId { get; set; }

        /// <summary>
        /// 采购组织(必填)
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
        /// 供应商(必填)
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
        /// 货主类型(必填)
        /// </summary>
        public virtual string FOwnerTypeIdHead { get; set; }

        /// <summary>
        /// 货主(必填)
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
        /// <summary>
        /// 财务信息
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Type_FInStockFin FInStockFin { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_FInStockEntry> FInStockEntry { get; set; }
    }

    /// <summary>
    /// 采购入库单
    /// </summary>
    public class Stk_InStockSaveInputDto : Stk_InStockSaveInputDto<Stk_InStock_FInStockFin, Stk_InStock_FInStockEntry>
    {

    }
}
