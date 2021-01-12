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
        public virtual long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCONTACTUNITTYPE { get; set; }
        /// <summary>
        /// 业务日期(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDATE { get; set; } = DateTime.Now;
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FPAYUNITTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSETTLERATE { get; set; }
        /// <summary>
        /// 付款单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPAYUNIT { get; set; }
        /// <summary>
        /// 币别(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCURRENCYID { get; set; } = new FNumberProperty("PRE001");//人民币
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDepartment { get; set; }
        /// <summary>
        /// 采购组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURCHASEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaseDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaserGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPurchaserId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCancelStatus { get; set; }
        /// <summary>
        /// 付款组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISSAMEORG { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLECUR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEMAINBOOKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FWBSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISCARRYRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FGYSHOPNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FGYCUSTOMERID { get; set; }
        /// <summary>
        /// 退款单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ap_RefundBill_Entry> FREFUNDBILLENTRY { get; set; }
        /// <summary>
        /// 退款单源单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ap_RefundBill_SrcEntry> FRefundBillSrcEntity { get; set; }
        /// <summary>
        /// 应收票据背书
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ap_RefundBill_RecEntry> FRefundBillRecEntry { get; set; }
        /// <summary>
        /// 应收票据明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ap_RefundBill_BillRefundRecEntry> FBILLREFUNDRECENTRY { get; set; }
        /// <summary>
        /// 应付票据退票
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ap_RefundBill_PayableEntry> FREFUNDBILLPAYABLEENTRY { get; set; }

    }
    public class Ap_RefundBillSaveInputDto : Ap_RefundBillSaveInputDto<
        Ap_RefundBill_Entry,
        Ap_RefundBill_SrcEntry,
        Ap_RefundBill_RecEntry,
        Ap_RefundBill_BillRefundRecEntry,
        Ap_RefundBill_PayableEntry>
    { }
}
