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
        Type_Ar_RefundBill_Entry,
        Type_Ar_RefundBill_SrcEntry,
        Type_Ar_RefundBill_PayEntry,
        Type_Ar_RefundBill_BillRefundPayEntry,
        Type_Ar_RefundBill_RefundBillReceiveEntry>
        where Type_Ar_RefundBill_Entry : Ar_RefundBill_Entry
        where Type_Ar_RefundBill_SrcEntry : Ar_RefundBill_SrcEntry
        where Type_Ar_RefundBill_PayEntry : Ar_RefundBill_PayEntry
        where Type_Ar_RefundBill_BillRefundPayEntry : Ar_RefundBill_BillRefundPayEntry
        where Type_Ar_RefundBill_RefundBillReceiveEntry : Ar_RefundBill_RefundBillReceiveEntry
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
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDATE { get; set; } = DateTime.Now;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCONTACTUNITTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDepartment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINIT { get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSETTLERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRECTUNITTYPE { get; set; }
        /// <summary>
        /// 收款单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FRECTUNIT { get; set; }
        /// <summary>
        /// 币别(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCURRENCYID { get; set; } = new FNumberProperty("PRE001");//人民币
        /// <summary>
        /// 结算组织
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEORGID { get; set; }
        /// <summary>
        /// 销售组织
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCancelStatus { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FScanPoint { get; set; }
        /// <summary>
        /// 付款组织
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISSAMEORG { get; set; }
        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLECUR { get; set; } = new FNumberProperty("PRE001");//人民币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISB2C { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSOURCESYSTEM { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FBookingDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FWBSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISCARRYRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEMAINBOOKID { get; set; }
        /// <summary>
        /// 退款单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_RefundBill_Entry> FREFUNDBILLENTRY { get; set; }
        /// <summary>
        /// 退款单源单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_RefundBill_SrcEntry> FREFUNDBILLSRCENTRY { get; set; }
        /// <summary>
        /// 应付票据明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_RefundBill_PayEntry> FREFUNDBILLPAYENTRY { get; set; }
        /// <summary>
        /// 应收票据背书
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_RefundBill_BillRefundPayEntry> FBillRefundPayEntry { get; set; }
        /// <summary>
        /// 应收票据退票
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_RefundBill_RefundBillReceiveEntry> FREFUNDBILLRECEIVENTRY { get; set; }
    }

    public class Ar_RefundSaveInputDtp : Ar_RefundBillSaveInputDto<
        Ar_RefundBill_Entry,
        Ar_RefundBill_SrcEntry,
        Ar_RefundBill_PayEntry,
        Ar_RefundBill_BillRefundPayEntry,
        Ar_RefundBill_RefundBillReceiveEntry>
    { }
}
