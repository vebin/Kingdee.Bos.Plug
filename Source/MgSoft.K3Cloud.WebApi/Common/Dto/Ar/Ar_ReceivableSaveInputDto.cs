using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// 应收单Dto
    /// </summary>
    public class Ar_ReceivableSaveInputDto<
        Type_Ar_Receivable_SubHeadSupplier,
        Type_Ar_Receivable_SubHeadFinc,
        Type_Ar_Receivable_EntityDetail,
        Type_Ar_Receivable_EntityPlan,
        Type_Ar_Receivable_ArCostEntry>
        where Type_Ar_Receivable_SubHeadSupplier : Ar_Receivable_SubHeadSupplier
        where Type_Ar_Receivable_SubHeadFinc : Ar_Receivable_SubHeadFinc
        where Type_Ar_Receivable_EntityDetail : Ar_Receivable_EntityDetail
        where Type_Ar_Receivable_EntityPlan : Ar_Receivable_EntityPlan
        where Type_Ar_Receivable_ArCostEntry : Ar_Receivable_ArCostEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }
        /// <summary>
        /// 业务日期(必填)
        /// </summary>
        [JsonRequired]
        public virtual DateTime? FDATE { get; set; } = DateTime.Now;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINIT { get; set; }
        /// <summary>
        /// 到期日(必填)
        /// </summary>
        [JsonRequired]
        public virtual DateTime? FENDDATE_H { get; set; }
        /// <summary>
        /// 客户(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FCUSTOMERID { get; set; }
        /// <summary>
        /// 币别(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FCURRENCYID { get; set; } = new FNumberProperty("PRE001");//人民币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPayConditon { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISPRICEEXCLUDETAX { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FACCOUNTSYSTEM { get; set; }
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSETTLEORGID { get; set; }
        /// <summary>
        /// 收款组织
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FPAYORGID { get; set; }
        /// <summary>
        /// 销售组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSALEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISTAX { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCancelStatus { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FAR_Remark { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSetAccountType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISHookMatch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINVOICEARLIER { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FBILLMATCHLOGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FWBOPENQTY { get; set; }
        /// <summary>
        /// 表头客户
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Type_Ar_Receivable_SubHeadSupplier FsubHeadSuppile { get; set; }
        /// <summary>
        /// 表头财务
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Type_Ar_Receivable_SubHeadFinc FsubHeadFinc { get; set; }
        /// <summary>
        /// 明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_Receivable_EntityDetail> FEntityDetail { get; set; }
        /// <summary>
        /// 收款计划
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_Receivable_EntityPlan> FEntityPlan { get; set; }
        /// <summary>
        /// 成本明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_Receivable_ArCostEntry> FARCOSTENTRY { get; set; }
    }
    public class Ar_ReceivableSaveInputDto : Ar_ReceivableSaveInputDto<
        Ar_Receivable_SubHeadSupplier,
        Ar_Receivable_SubHeadFinc,
        Ar_Receivable_EntityDetail,
        Ar_Receivable_EntityPlan,
        Ar_Receivable_ArCostEntry>
    { }
}
