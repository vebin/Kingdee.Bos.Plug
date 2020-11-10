using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// 付款退款单
    /// </summary>
    public class Ap_RefundBillSaveInputDto<
        Type_Ap_RefundBill_Entry,
        Type_Ap_RefundBill_SrcEntry,
        Type_Ap_RefundBill_RecEntry,
        Type_Ap_RefundBill_BillRefundRecEntry,
        Type_Ap_RefundBill_PayableEntry>
        where Type_Ap_RefundBill_Entry : Ap_RefundBill_Entry
        where Type_Ap_RefundBill_SrcEntry : Ap_RefundBill_SrcEntry
        where Type_Ap_RefundBill_RecEntry : Ap_RefundBill_RecEntry
        where Type_Ap_RefundBill_BillRefundRecEntry : Ap_RefundBill_BillRefundRecEntry
        where Type_Ap_RefundBill_PayableEntry : Ap_RefundBill_PayableEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCONTACTUNITTYPE { get; set; }
        /// <summary>
        /// 业务日期(必填)
        /// </summary>
        [JsonRequired]
        public DateTime? FDATE { get; set; } = DateTime.Now;
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPAYUNITTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSETTLERATE { get; set; }
        /// <summary>
        /// 付款单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPAYUNIT { get; set; }
        /// <summary>
        /// 币别(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCURRENCYID { get; set; } = new FNumberProperty("PRE001");//人民币
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDepartment { get; set; }
        /// <summary>
        /// 采购组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPURCHASEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaseDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaserGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaserId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCancelStatus { get; set; }
        /// <summary>
        /// 付款组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISSAMEORG { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSETTLECUR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSETTLEMAINBOOKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FWBSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISCARRYRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FGYSHOPNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FGYCUSTOMERID { get; set; }
        /// <summary>
        /// 退款单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_RefundBill_Entry> FREFUNDBILLENTRY { get; set; }
        /// <summary>
        /// 退款单源单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_RefundBill_SrcEntry> FRefundBillSrcEntity { get; set; }
        /// <summary>
        /// 应收票据背书
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_RefundBill_RecEntry> FRefundBillRecEntry { get; set; }
        /// <summary>
        /// 应收票据明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_RefundBill_BillRefundRecEntry> FBILLREFUNDRECENTRY { get; set; }
        /// <summary>
        /// 应付票据退票
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_RefundBill_PayableEntry> FREFUNDBILLPAYABLEENTRY { get; set; }

    }
    public class Ap_RefundBillSaveInputDto : Ap_RefundBillSaveInputDto<
        Ap_RefundBill_Entry,
        Ap_RefundBill_SrcEntry,
        Ap_RefundBill_RecEntry,
        Ap_RefundBill_BillRefundRecEntry,
        Ap_RefundBill_PayableEntry>
    { }
}
