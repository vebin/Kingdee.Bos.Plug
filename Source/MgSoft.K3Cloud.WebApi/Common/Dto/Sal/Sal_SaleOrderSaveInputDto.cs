using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// 销售订单Dto
    /// </summary>
    /// <typeparam name="Type_Sal_SaleOrder_Finance">财务信息</typeparam>
    /// <typeparam name="Type_Sal_SaleOrder_Clause">订单条款</typeparam>
    /// <typeparam name="Type_Sal_SaleOrder_Entry">订单明细</typeparam>
    /// <typeparam name="Type_Sal_SaleOrder_Plan">收款计划</typeparam>
    /// <typeparam name="Type_Sal_SaleOrder_Trace">物流跟踪明细</typeparam>
    public class Sal_SaleOrderSaveInputDto<
        Type_Sal_SaleOrder_Finance,
        Type_Sal_SaleOrder_Clause,
        Type_Sal_SaleOrder_Entry,
        Type_Sal_SaleOrder_Plan,
        Type_Sal_SaleOrder_Trace>
        where Type_Sal_SaleOrder_Finance : Sal_SaleOrder_Finance
        where Type_Sal_SaleOrder_Clause : Sal_SaleOrder_Clause
        where Type_Sal_SaleOrder_Entry : Sal_SaleOrder_Entry
        where Type_Sal_SaleOrder_Plan : Sal_SaleOrder_Plan
        where Type_Sal_SaleOrder_Trace : Sal_SaleOrder_Trace
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
        /// 销售组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSaleOrgId { get; set; }
        /// <summary>
        /// 客户(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FCustId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FHeadDeliveryWay { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FReceiveId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FHEADLOCID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCorrespondOrgId { get; set; }
        /// <summary>
        /// 销售部门(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSaleDeptId { get; set; }
        /// <summary>
        /// 销售组（必填）
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSaleGroupId { get; set; }
        /// <summary>
        /// 销售员(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSalerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiveAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNameProperty FReceiveContact { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FChargeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FNetOrderBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FNetOrderBillId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FOppID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSalePhaseID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FNote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsMobile { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Sal_SaleOrder_Finance FSaleOrderFinance { get; set; }
        /// <summary>
        /// 订单条款
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_SaleOrder_Clause> FSaleOrderClause { get; set; }
        /// <summary>
        /// 订单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_SaleOrder_Entry> FSaleOrderEntry { get; set; }
        /// <summary>
        /// 收款计划
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_SaleOrder_Plan> FSaleOrderPlan { get; set; }
        /// <summary>
        /// 物流跟踪明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_SaleOrder_Trace> FSalOrderTrace { get; set; }
    }
    /// <summary>
    /// 销售订单Dto
    /// </summary>
    public class Sal_SaleOrderSaveInputDto : Sal_SaleOrderSaveInputDto<
        Sal_SaleOrder_Finance,
        Sal_SaleOrder_Clause,
        Sal_SaleOrder_Entry,
        Sal_SaleOrder_Plan,
        Sal_SaleOrder_Trace>
    { }
}
