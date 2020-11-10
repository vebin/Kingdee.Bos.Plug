using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// 收款退款单
    /// </summary>
    public class Ar_RefundBillSaveInputDto<
        Type_Ar_Refund_Entry,
        Type_Ar_Refund_SrcEntry,
        Type_Ar_Refund_PayEntry,
        Type_Ar_Refund_BillRefundPayEntry,
        Type_Ar_Refund_RefundBillReceiveEntry>
        where Type_Ar_Refund_Entry : Ar_RefundBill_Entry
        where Type_Ar_Refund_SrcEntry : Ar_RefundBill_SrcEntry
        where Type_Ar_Refund_PayEntry : Ar_RefundBill_PayEntry
        where Type_Ar_Refund_BillRefundPayEntry : Ar_RefundBill_BillRefundPayEntry
        where Type_Ar_Refund_RefundBillReceiveEntry : Ar_RefundBill_RefundBillReceiveEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        /// <summary>
        /// 业务日期(必填)
        /// </summary>
        [JsonRequired]
        public DateTime? FDATE { get; set; } = DateTime.Now;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCONTACTUNITTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDepartment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINIT { get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSETTLERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRECTUNITTYPE { get; set; }
        /// <summary>
        /// 收款单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FRECTUNIT { get; set; }
        /// <summary>
        /// 币别(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCURRENCYID { get; set; } = new FNumberProperty("PRE001");//人民币
        /// <summary>
        /// 结算组织
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLEORGID { get; set; }
        /// <summary>
        /// 销售组织
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSALEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCancelStatus { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FScanPoint { get; set; }
        /// <summary>
        /// 付款组织
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISSAMEORG { get; set; }
        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLECUR { get; set; } = new FNumberProperty("PRE001");//人民币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISB2C { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSOURCESYSTEM { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FBookingDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FWBSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISCARRYRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSETTLEMAINBOOKID { get; set; }
        /// <summary>
        /// 退款单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_RefundBill_Entry> FREFUNDBILLENTRY { get; set; }
        /// <summary>
        /// 退款单源单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_RefundBill_SrcEntry> FREFUNDBILLSRCENTRY { get; set; }
        /// <summary>
        /// 应付票据明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_RefundBill_PayEntry> FREFUNDBILLPAYENTRY { get; set; }
        /// <summary>
        /// 应收票据背书
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_RefundBill_BillRefundPayEntry> FBillRefundPayEntry { get; set; }
        /// <summary>
        /// 应收票据退票
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_RefundBill_RefundBillReceiveEntry> FREFUNDBILLRECEIVENTRY { get; set; }
    }

    public class Ar_RefundSaveInputDtp : Ar_RefundBillSaveInputDto<
        Ar_RefundBill_Entry,
        Ar_RefundBill_SrcEntry,
        Ar_RefundBill_PayEntry,
        Ar_RefundBill_BillRefundPayEntry,
        Ar_RefundBill_RefundBillReceiveEntry>
    { }
}
