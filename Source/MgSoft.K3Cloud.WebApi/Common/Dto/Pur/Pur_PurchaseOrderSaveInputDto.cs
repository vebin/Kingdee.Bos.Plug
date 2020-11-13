using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// 采购订单Dto
    /// </summary>
    /// <typeparam name="Type_Pur_PurchaseOrder_Finace">财务信息</typeparam>
    /// <typeparam name="Type_Pru_PurchaseOrder_Clause">订单条款</typeparam>
    /// <typeparam name="Type_Pur_PurchaseOrder_Entry">明细信息</typeparam>
    /// <typeparam name="Type_Pur_PurchaseOrder_Iinstallment">付款计划</typeparam>
    public class Pur_PurchaseOrderSaveInputDto<
        Type_Pur_PurchaseOrder_Finace,
        Type_Pru_PurchaseOrder_Clause,
        Type_Pur_PurchaseOrder_Entry,
        Type_Pur_PurchaseOrder_Iinstallment>
        where Type_Pur_PurchaseOrder_Finace : Pur_PurchaseOrder_Finace
        where Type_Pru_PurchaseOrder_Clause : Pru_PurchaseOrder_Clause
        where Type_Pur_PurchaseOrder_Entry : Pur_PurchaseOrder_Entry
        where Type_Pur_PurchaseOrder_Iinstallment : Pur_PurchaseOrder_Iinstallment
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDate { get; set; }
        /// <summary>
        /// 供应商(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSupplierId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaseOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaseDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaserGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaserId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FProviderId { get; set; }
        //"FProviderContactId ": { "FCONTACTNUMBER": "" },
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FProviderAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FChargeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FConfirmerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FConfirmDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCorrespondOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FProviderContact { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsModificationOperator { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FChangeStatus { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Pur_PurchaseOrder_Finace FPOOrderFinance { get; set; }
        /// <summary>
        /// 订单条款
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Pru_PurchaseOrder_Clause> FPOOrderClause { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Pur_PurchaseOrder_Entry> FPOOrderEntry { get; set; }
        /// <summary>
        /// 付款计划
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Pur_PurchaseOrder_Iinstallment> FIinstallment { get; set; }
    }
    /// <summary>
    /// 采购订单dto
    /// </summary>
    public class Pur_PurchaseOrderSaveInputDto : Pur_PurchaseOrderSaveInputDto<
        Pur_PurchaseOrder_Finace,
        Pru_PurchaseOrder_Clause,
        Pur_PurchaseOrder_Entry,
        Pur_PurchaseOrder_Iinstallment>
    { }
}
