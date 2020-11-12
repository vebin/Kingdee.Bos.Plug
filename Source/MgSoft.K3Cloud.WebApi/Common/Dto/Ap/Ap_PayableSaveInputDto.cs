using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// 应付单Dto
    /// </summary>
    public class Ap_PayableSaveInputDto<
        Type_Ap_Payable_SubHeadSupplier,
        Type_Ap_Payable_SubHeadFinc,
        Type_Ap_Payable_EntryDetail,
        Type_Ap_Payable_EntityPlan,
        Type_Ap_Payable_RecInvInfo>
        where Type_Ap_Payable_SubHeadSupplier : Ap_Payable_SubHeadSupplier
        where Type_Ap_Payable_SubHeadFinc : Ap_Payable_SubHeadFinc
        where Type_Ap_Payable_EntryDetail : Ap_Payable_EntryDetail
        where Type_Ap_Payable_EntityPlan : Ap_Payable_EntityPlan
        where Type_Ap_Payable_RecInvInfo : Ap_Payable_RecInvInfo
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FENDDATE_H { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDOCUMENTSTATUS { get; set; }
        /// <summary>
        /// 供应商(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSUPPLIERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCURRENCYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPayConditon { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISPRICEEXCLUDETAX { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSourceBillType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISTAX { get; set; }
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLEORGID { get; set; }
        /// <summary>
        /// 付款组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPAYORGID { get; set; }
        /// <summary>
        /// 采购组织
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPURCHASEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSetAccountType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISTAXINCOST { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FAP_Remark { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISHookMatch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FACCOUNTSYSTEM { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASERGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCancelStatus { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISBYIV { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISGENHSADJ { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINVOICEARLIER { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FBILLMATCHLOGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FWBOPENQTY { get; set; }
        /// <summary>
        /// 表头供应商
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Ap_Payable_SubHeadSupplier FsubHeadSuppiler { get; set; }
        /// <summary>
        /// 表头财务
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Ap_Payable_SubHeadFinc FsubHeadFinc { get; set; }
        /// <summary>
        /// 明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_Payable_EntryDetail> FEntityDetail { get; set; }
        /// <summary>
        /// 付款计划
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_Payable_EntityPlan> FEntityPlan { get; set; }
        /// <summary>
        /// Ap_Payable_RecInvInfo
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_Payable_RecInvInfo> FRecInvInfo { get; set; }
    }

    public class Ap_PayableSaveInputDto : Ap_PayableSaveInputDto<
        Ap_Payable_SubHeadSupplier,
        Ap_Payable_SubHeadFinc,
        Ap_Payable_EntryDetail,
        Ap_Payable_EntityPlan,
        Ap_Payable_RecInvInfo>
    { }
}
